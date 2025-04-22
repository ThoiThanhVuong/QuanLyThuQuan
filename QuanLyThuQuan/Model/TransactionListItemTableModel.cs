using System.ComponentModel;

namespace QuanLyThuQuan.Model
{
    // JUST TEMP DTO FOR GENE TABLE ON TRANSACTION INFORMATION
    public class TransactionListItemTableModel : INotifyPropertyChanged
    {
        public string productName { get; set; }
        public int amount { get; set; }

        public TransactionListItemTableModel() { }

        public TransactionListItemTableModel(string productName, int amount)
        {
            this.productName = productName;
            this.amount = amount;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
