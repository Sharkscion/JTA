
using System.Collections.Generic;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    /// <summary>
    /// The view model for the purchase order document page
    /// </summary>
    public class POAddDocumentPageVM : AddDocumentPageVM, IObserver
    {
        private AutoCompleteComboBoxSubjectVM mCbxSupplier;
        private AutoCompleteComboBoxObserverVM mCbxAddress;
        private AutoCompleteComboBoxSubjectVM mCbxTerms;

        private TextEntryVM mTxtPurchaseDescription;
        private TextEntryVM mTxtNote;
        private TextEntryVM mTxtSSI;

        private TextIconEntryVM mTxtIssuedBy;

        private DatePickerVM mDateIssued;

        public POAddDocumentPageVM()
        {
            Row1PageFields = new List<object>();
            Row2Col1PageFields = new List<object>();
            Row2Col2PageFields = new List<object>();
            IsDocumentNumberEditable = false;
            DocumentTitle = "PO#";
            TitlePage = "Add a Purchase Order";
            BackPageLinkLabel = "Back to purchase order list";
        }

        public override ICommand AddCommand()
        {
            throw new System.NotImplementedException();
        }

        public override ICommand CancelCommand()
        {
            throw new System.NotImplementedException();
        }

        public override void ConstructPageFields()
        {
            mTxtNote = new TextEntryVM()
            {
                Label = "Note"
            };

            mTxtPurchaseDescription = new TextEntryVM()
            {
                Label = "Purchase Description"
            };

            mTxtIssuedBy = new TextIconEntryVM()
            {
                Icon = IconType.IssuedBy,
                Label = "User that is Logged in"
            };

            mCbxTerms = new AutoCompleteComboBoxSubjectVM()
            {
                Label = "*Terms"
            };

            mCbxAddress = new AutoCompleteComboBoxObserverVM()
            {
                Label = "Address"
            };

            mDateIssued = new DatePickerVM()
            {
                Label = "*Date Issued",
            };
            
            var dateReqRule = new RequiredRule("Please enter a date issued.");
            dateReqRule.Register(this);
            mDateIssued.AddRule(dateReqRule);


            var SSIReqRule = new RequiredRule("Please enter the supplier's sales invoice.");
            SSIReqRule.Register(this);

            mTxtSSI = new TextEntryVM() {
                Label = "*Supplier SI#"
            };
            mTxtSSI.AddRule(SSIReqRule);

           

            var cbxSupplierReqRule = new RequiredRule("Please select a supplier.");
            cbxSupplierReqRule.Register(this);

            mCbxSupplier = new AutoCompleteComboBoxSubjectVM()
            {
                Label = "*Supplier",
                //populate list
                //Items
            };
            mCbxSupplier.AddRule(cbxSupplierReqRule);
            mCbxSupplier.Register(mCbxAddress);            

            var quad1 = new List<object>
            {
                {mCbxSupplier },
                {mCbxAddress },
                {mTxtPurchaseDescription }
            };


            var quad2row1 = new List<object>
            {
                {mDateIssued },
                {mCbxTerms }
            };

            var quad2 = new List<object>
            {
                {quad2row1 },
                {mTxtIssuedBy },
                {mTxtNote}
            };

            Row1PageFields.Add(mTxtSSI);
            Row2Col1PageFields.Add(quad1);
            Row2Col2PageFields.Add(quad2);

        }

        public void Update(object value = null)
        {
            HasError = (bool)value;
        }
    }
}
