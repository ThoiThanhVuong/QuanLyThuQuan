﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuQuanWebForm
{
    public partial class _Default : Page
    {
        public bool IsUserLogin { get { return Session["UserID"] != null; } }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}