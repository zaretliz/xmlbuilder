using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.Observer
{
     public interface IObserver
    {
        void SetNode(string name);
        void SetAttr(string name, string attribute);
        void SaveNode(string name);
    }
}
