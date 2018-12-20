using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConsoleApplication7._3;

namespace ConsoleApplication7.Builder
{
   public class XmlBuilder: Observer.IObservable
    {
        private _3.Tree tree;

        public XmlBuilder()
        {
            this.tree = new _3.Tree();
            tree.obss = new List<Observer.IObserver>();
            tree.nodes = new Stack<_3.Node>();
            tree.com = new Stack<Commands.Command>();

        }

        public XmlBuilder AddNode(_3.Node name)
        {
            tree.nodes.Push(name);
            SetNodeObserver(name.name);
            tree.nodeWasCreated = true;
            return this;
        }

        public XmlBuilder SetAttr(string name, string arg)
        {
            var myNode = tree.nodes.Where(x => x.name == name).FirstOrDefault();
            if (myNode != null)
            {
                myNode.attributes.Add(arg);
                SetAttrObserver(name, arg);
            }
            return this;
        }

        public void Save()
        {
            foreach (Observer.IObserver obs in tree.obss)
            {
                if (tree.nodes.Count >= 1)
                {
                    obs.SaveNode(tree.nodes.Pop().name);
                    if (tree.nodes.Count == 0)
                        tree.xmlComplete = true;
                }
                else
                {
                    if (tree.nodeWasCreated)
                    {
                        Console.WriteLine("Xml завершен");
                        tree.xmlComplete = true;
                    }
                    else
                        Console.WriteLine("Xml не создан");
                }
            }
        }

        public void RegisterObserver(Observer.IObserver obs)
        {
            tree.obss.Add(obs);
        }

        public void RemoveObserver(Observer.IObserver obs)
        {
            var myObserver = tree.obss.Where(x => x == obs).FirstOrDefault();
            if (myObserver != null)
            {
                tree.obss.Remove(myObserver);
            }
        }

        public void SetNodeObserver(string name)
        {
            foreach (Observer.IObserver obs in tree.obss)
            {
                obs.SetNode(name);
            }
        }

        public void SetAttrObserver(string name, string attribute)
        {
            foreach (Observer.IObserver obs in tree.obss)
            {
                obs.SetAttr(name,attribute);
            }
        }

        public _3.Tree GetResult()
        {
            return this.tree;
        }

    }
}
