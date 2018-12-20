
using ConsoleApplication7._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication7.Commands
{
    public class AddCommand :Command
    {
        public AddCommand(Builder.XmlBuilder xmlbuilder,string args)
        {
            treeBuilder = xmlbuilder;
            nodeBuilder = new ConsoleApplication7.Builder.NodeBuilder().SetNode(args);
            treeBuilder.GetResult().name = args;
        }
        public override void Execute()
        {

            if (treeBuilder.GetResult().xmlComplete)
                Console.WriteLine("Xml завершен");
            else
            {
                treeBuilder.AddNode(nodeBuilder.GetResult());
            }
            if (treeBuilder.GetResult().notUndoCommand)
                treeBuilder.GetResult().com.Push(this);

        }

    }
}
