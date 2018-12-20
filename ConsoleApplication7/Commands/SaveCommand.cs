using ConsoleApplication7._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.Commands
{
    public class SaveCommand : Command
    {
        public SaveCommand(Builder.XmlBuilder xmlbuilder)
        {
            treeBuilder = xmlbuilder;
        }
        public override void Execute()
        {
            treeBuilder.Save();
            if (treeBuilder.GetResult().notUndoCommand)
                treeBuilder.GetResult().com.Push(this);
        }
    }
}
