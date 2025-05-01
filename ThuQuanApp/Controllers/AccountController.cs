using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using ThuQuanApp.Models;

namespace ThưQuánSV.Controllers
{
    public class AccountController : Controller
    {
        private readonly DBConnect _connection;

        public AccountController(DBConnect _connection)
        {
            this._connection = _connection;
        }



        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password, bool remember)
        {
            // Xử lý đăng nhập ở đây
            MemberModel? member = _connection.Members.FirstOrDefault(user => user.Username.Equals(username) && user.Password.Equals(password));
            if (member == null)
            {
                ViewBag.ErrorUserNameOrPassword = "Sai tên đăng nhập hoặc mật khẩu!";
                return View("Login");
            }

            if (member.UserType.ToLower().Equals("librarian"))
            {
                ViewBag.ErrorPermission = "Tài khoản không có quyền đăng nhập ở đây!";
                return View("Login");
            }

            HttpContext.Session.SetString("username", member.Username);
            TempData["username"] = member.Username;

            if (!remember)
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, member.MemberID.ToString()),
                    new Claim(ClaimTypes.Name, member.Username)
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                AuthenticationProperties authentication = new AuthenticationProperties
                {
                    IsPersistent = !remember
                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, authentication);
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Register(string fullname, string student_id, string email,
                                     string phone, string password, string confirm_password,
                                     bool terms)
        {
            // Xử lý đăng ký ở đây
            return RedirectToAction("Login");
        }

        public IActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string recoveryIdentifier, string newPassword)
        {
            MemberModel? member = _connection.Members.FirstOrDefault(user => user.Email.Equals(recoveryIdentifier) || user.PhoneNumber.Equals(recoveryIdentifier));

            if (member == null)
                ViewBag.ForgotPasswordError = "Sai email hoặc số điện thoại!";
            else
            {
                ViewBag.AllowChangePassword = true;
                ViewBag.RecoveryIdentifier = recoveryIdentifier;
            }

            if (newPassword != null && member != null)
            {
                member.Password = newPassword;

                try
                {
                    await _connection.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Update done!";
                    return RedirectToAction("Login");
                }
                catch (Exception ex)
                {
                    ViewBag.UpdatePasswordError = "Error update password!";
                    ViewBag.AllowChangePassword = true;
                    ViewBag.KeepOverlayOpen = true;
                    ViewBag.EnteredIdentifier = recoveryIdentifier;
                    Debug.WriteLine(ex.StackTrace);
                }
            }

            ViewBag.KeepOverlayOpen = true;
            return View("Login");
        }

        [HttpGet]
        public IActionResult ResetForm()
        {
            ViewBag.AllowChangePassword = null;
            ViewBag.ForgotPasswordError = null;
            return View("Login");
        }
    }
}