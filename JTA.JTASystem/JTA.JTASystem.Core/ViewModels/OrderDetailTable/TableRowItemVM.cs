
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    public class TableRowItemVM : BaseTableRowVM
    {
        public ObservableCollection<DiscountItemVM> DiscountItems { get; set; }

        public List<Product> Products { get; set; }

        public List<ProductVariant> ProductVariants { get; set; }

        public List<Unit> Units { get; set; }

        public OrderDetail OrderDetail { get; set; }

        public ICommand RemoveDiscountCommand { get; set; }

        public ICommand AddDiscountCommand { get; set; }

        public ICommand ValueChangedCommand { get; set; }

        public bool CanBeRemoved { get; set; } = false;

        public TableRowItemVM()
        {
            RemoveDiscountCommand = new RelayParameterizedCommand(item => RemoveDiscount((DiscountItemVM)item));
            AddDiscountCommand = new RelayParameterizedCommand(item => AddDiscount((DiscountItemVM)item));

            DiscountItems = new ObservableCollection<DiscountItemVM>()
            {
                new DiscountItemVM()
                {
                    NewDiscountValue = 0,
                    OldDiscountValue = 0,
                    IsLastItem = true,
                }
            };
        }

        #region Command methods

        public void AddDiscount(DiscountItemVM item)
        {
            if (DiscountItems.Count > 1)
            {
                var discountItem = DiscountItems.Last();
                discountItem.IsLastItem = false;
            }

            item.IsLastItem = true;
            item.mDiscountEntered += (object source, DiscountEventArgs args) =>
            {
                switch (args.Operation)
                {
                    case RateOperation.Add:
                        if (args.OldDiscountValue != args.NewDiscountValue)
                        {
                            OrderDetail.SubAmount = RateOperationCalculator.RevertAddedRate(OrderDetail.SubAmount, args.OldDiscountValue);
                            OrderDetail.SubAmount = RateOperationCalculator.ApplyAddRate(OrderDetail.SubAmount, args.NewDiscountValue);

                        }; break;

                    case RateOperation.Less:
                        if (args.OldDiscountValue != args.NewDiscountValue)
                        {
                            OrderDetail.SubAmount = RateOperationCalculator.RevertDiscountRate(OrderDetail.SubAmount, args.OldDiscountValue);
                            OrderDetail.SubAmount = RateOperationCalculator.ApplyDiscountRate(OrderDetail.SubAmount, args.NewDiscountValue);

                        }; break;
                };
            };

            DiscountItems.Add(item);
        }

        public void RemoveDiscount(DiscountItemVM item)
        {
            if (DiscountItems.Count > 1)
            {
                var discountItem = DiscountItems.Last();
                discountItem.IsLastItem = true;
            }

            item.mDiscountEntered += (object source, DiscountEventArgs args) =>
            {
                switch (args.Operation)
                {
                    case RateOperation.Add:
                            OrderDetail.SubAmount = RateOperationCalculator.RevertAddedRate(OrderDetail.SubAmount, args.OldDiscountValue);
                            break;

                    case RateOperation.Less:
                            OrderDetail.SubAmount = RateOperationCalculator.RevertDiscountRate(OrderDetail.SubAmount, args.OldDiscountValue);
                            break;
                };
            };

            DiscountItems.Remove(item);
        }

        #endregion

    }
}
