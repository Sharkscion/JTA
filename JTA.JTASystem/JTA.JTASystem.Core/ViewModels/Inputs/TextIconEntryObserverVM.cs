namespace JTA.JTASystem.Core
{
    public class TextIconEntryObserverVM : TextIconEntryVM, IObserver
    {
        public void Update(object subject = null) => Label = (string)subject;
    }
}
