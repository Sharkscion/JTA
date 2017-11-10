
namespace JTA.JTASystem.Core
{
    public class POPageVMFactory : IDocumentPageVMFactory
    {
        public AddDocumentPageVM CreateAddDocumentPageVM()
        {
           return new POAddDocumentPageVM();
        }

        public EditDocumentPageVM CreateEditDocumentPageVM()
        {
            throw new System.NotImplementedException();
        }

        public ViewDocumentPageVM CreateViewDocumentPageVM()
        {
            throw new System.NotImplementedException();
        }
    }
}
