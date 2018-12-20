using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication7._3;

namespace ConsoleApplication7.Builder
{
   public class NodeBuilder
    {
        public _3.Node node;
        public NodeBuilder()
        {
            this.node = new _3.Node();
            node.attributes = new List<string>();
        }
        public NodeBuilder SetNode(string name)
        {
            node.name = name;
            return this;
        }
        public NodeBuilder AddAttr(string attribute)
        {
            node.attributes.Add(attribute);
            return this;
        }
        public _3.Node GetResult()
        {
            return this.node;
        }
    }
}
