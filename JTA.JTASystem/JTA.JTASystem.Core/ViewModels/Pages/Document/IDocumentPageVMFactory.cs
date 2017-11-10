

namespace JTA.JTASystem.Core
{
    public interface IDocumentPageVMFactory
    {
        AddDocumentPageVM CreateAddDocumentPageVM();
        EditDocumentPageVM CreateEditDocumentPageVM();
        ViewDocumentPageVM CreateViewDocumentPageVM();
    }
}
