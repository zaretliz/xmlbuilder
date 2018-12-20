using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.Observer
{
    public interface IObservable
    {
        void RegisterObserver(IObserver obs);
        void RemoveObserver(IObserver obs);
        void SetNodeObserver(string name);
        void SetAttrObserver(string name, string attribute);
    }
}
