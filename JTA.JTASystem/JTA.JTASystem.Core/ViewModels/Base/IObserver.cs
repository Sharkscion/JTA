using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JTA.JTASystem.Core
{
    public interface IObserver
    {
        void Update(object subject = null);
    }
}
