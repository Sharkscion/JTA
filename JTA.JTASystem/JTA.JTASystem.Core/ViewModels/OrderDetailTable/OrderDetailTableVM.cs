using System.Collections.ObjectModel;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    public class OrderDetailTableVM: BaseVM
    {
        public ObservableCollection<BaseTableRowVM> TableRows { get; set; }

        public decimal TotalAmount { get; set; } = 0;

        public bool IsInEditMode { get; set; } = false;

        public ICommand SelectAllCommand { get; set; }

        public ICommand AddRowCommand { get; set; }

        public ICommand RemoveRowCommand { get; set; }

        

        public OrderDetailTableVM()
        {
            TableRows = new ObservableCollection<BaseTableRowVM>();
            AddRowCommand = new RelayCommand(AddRow);
            RemoveRowCommand = new RelayParameterizedCommand(i => RemoveRow(i));
            SelectAllCommand = new RelayCommand(SelectAllItems);
        }

        public void RemoveRow(object i)
        {
            TableRows.Remove((TableRowItemVM)i);
        }

        public void AddRow()
        {
            var newRow = new TableRowItemVM()
            {
                OrderDetail = new OrderDetail(),
                CanBeRemoved = true,
            };

            TableRows.Add(newRow);
        }

        public void SelectAllItems()
        {
            foreach (var row in TableRows)
              row.IsSelected = true;          
        }     

        public void Update(object subject)
        {
            TotalAmount = 0;
            foreach (var row in TableRows)
                if (row is TableRowItemVM)
                    TotalAmount += ((TableRowItemVM)row).OrderDetail.SubAmount;
        }

        //public ICommand ReturnCommand { get; set; }
        //public void ReturnItems()
        //{
        //    foreach (var row in TableRows)
        //        if (row is TableRowItemVM && row.IsSelected)
        //            ((TableRowItemVM)row).OrderDetail.Status = Status.OrderStatus.Returned;
        //}

        //public void CancelItems()
        //{
        //    foreach (var row in TableRows)
        //        if (row is TableRowItemVM && row.IsSelected)
        //            ((TableRowItemVM)row).OrderDetail.Status = Status.OrderStatus.Canceled;
        //}
    }
}
