using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7._3
{
    public class Tree
    {
        public bool xmlComplete = false;
        public bool nodeWasCreated = false;
        public bool notUndoCommand = true;
        public List<Observer.IObserver> obss;
        public Stack<Commands.Command> com;
        public Stack<Node> nodes;
        public string name;
        public string attribute;
    }

}

