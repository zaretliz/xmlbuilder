using ConsoleApplication7._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.Commands
{
   public class SetCommand :Command
    {
        public SetCommand(Builder.XmlBuilder xmlbuilder,string args, string name)
        {
            treeBuilder = xmlbuilder;
            if (treeBuilder.GetResult().xmlComplete)
                Console.WriteLine("Xml завершен");
            else
                treeBuilder.SetAttr(args, name);
        }
        public override void Execute()
        {
            //    SetAttrObserver(treeBuilder.GetResult().noder.Last().);
            if (treeBuilder.GetResult().notUndoCommand)
                treeBuilder.GetResult().com.Push(this);
        }
    }
}