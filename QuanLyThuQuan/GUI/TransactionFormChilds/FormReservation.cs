using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormReservation : Form
    {
        public FormReservation()
        {
            InitializeComponent();
            LoadAllReservation(ReservationStatus.Pending);
        }

        // NOTE: FOR OTHER LOGICS
        private void SetDefaultForTable()
        {
            dgvReservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservation.AllowUserToAddRows = false;
        }
        // NOTE: GET AND SET VALUES FOR DATA GRID VIEW
        private void LoadAllReservation(ReservationStatus status)
        {
            TempDataReservationBUS temp = new TempDataReservationBUS();
            temp.LoadLocal();
            List<TempDataReservationModel> list = temp.FilterByProduct(status);
            ClearTable(dgvReservation);
            dgvReservation.DataSource = null;
            dgvReservation.DataSource = list;
            CreateColumn(dgvReservation, "More", "...", "detail");
            CreateColumn(dgvReservation, "Submit", "submit", "submit");
            dgvReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservation.ReadOnly = true;
            dgvReservation.DefaultCellStyle.ForeColor = Color.Blue;
            //List<string> colList = new List<string> { "StartTime", "EndTime" };
            //ResizeSpecificCols(colList, dgvReservation, DataGridViewAutoSizeColumnMode.AllCells);
        }

        // NOTE: reservation Detail
        private void LoadReservationDetail(string reservationID)
        {
            TempDataItemReservationBUS temp = new TempDataItemReservationBUS();
            List<TempDataItemReservationModel> list = temp.getByReservationID(reservationID);
            ClearTable(dgvDetailReservation);
            dgvDetailReservation.DataSource = null;
            dgvDetailReservation.DataSource = list;
            dgvDetailReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetailReservation.ReadOnly = true;
            dgvDetailReservation.DefaultCellStyle.ForeColor = Color.Blue;
        }

        private void ClearTable(DataGridView dgv)
        {
            if (dgv == null) return;
            dgv.DataSource = null;
            dgv.Columns.Clear();
            dgv.Rows.Clear();
        }

        // Resize columns
        private void ResizeSpecificCols(List<string> colList, DataGridView dgv, DataGridViewAutoSizeColumnMode mode)
        {
            IEnumerator<string> list = colList.GetEnumerator();
            while (list.MoveNext())
                dgv.Columns[list.Current].AutoSizeMode = mode;
        }

        // NOTE: SUBMIT RESERVATION AND CHANGE IT TO TRANSACTION
        private void SubmitReservation(TempDataReservationModel reservation)
        {
            TempDataItemReservationBUS temp = new TempDataItemReservationBUS();
            List<TempDataItemReservationModel> list = temp.getByReservationID(reservation.reservationID.ToString());
            reservation.status = ReservationStatus.Confirmed;
            new TempDataReservationBUS().Update(reservation);
        }



        // NOTE: FOR VALIDATION
        private bool IsCancelledOrConfirmed(DataGridViewCell cell)
        {
            if (string.IsNullOrEmpty(cell.Value.ToString()))
                return false;
            else if (cell.Value.ToString().Equals(ReservationStatus.Confirmed.ToString()) || cell.Value.ToString().Equals(ReservationStatus.Confirmed.ToString()))
                return true;
            return false;
        }


        // NOTE: FOR EVENT

        private void btnExitChildPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReservation.Columns[e.ColumnIndex].Name.Equals("colMoreOptions"))
                LoadReservationDetail(dgvReservation.Rows[e.RowIndex].Cells["ReservationID"].Value.ToString());
            if (dgvReservation.Columns[e.ColumnIndex].Name.Equals("colSubmitOptions"))
                SubmitReservation(dgvReservation.Rows[e.RowIndex].DataBoundItem as TempDataReservationModel);

        }

        // NOTE: CREATE COL MORE FOR TABLES
        private void CreateColumn(DataGridView dgv, string colName, string colContentText, string colHeaderText)
        {
            if (!dgv.Columns.Contains(colName))
            {
                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "col" + colName + "Options";
                column.HeaderText = colHeaderText;
                column.Text = colContentText;
                column.UseColumnTextForButtonValue = true;
                column.Width = 10;
                dgv.Columns.Add(column);
            }
        }
    }
}
