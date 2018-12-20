using ConsoleApplication7._3;
using ConsoleApplication7.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.Commands
{
    public abstract class Command
    {
        public Builder.XmlBuilder treeBuilder = new Builder.XmlBuilder();
        public abstract void Execute();
        protected Builder.NodeBuilder nodeBuilder;
        protected string file = "data.txt";
        public Command() {}
        public static Command Create(Builder.XmlBuilder xmlbuilder,string args, string parameters, string name)
        {
            switch (args)
            {
                case "add":
                    return
                       new AddCommand(xmlbuilder,parameters);
                case "set":
                    return
                        new SetCommand(xmlbuilder,parameters,name);
                case "save":
                    return
                        new SaveCommand(xmlbuilder);
                case "print":
                    return
                        new PrintCommand(xmlbuilder);
                case "printlog":
                    return
                        new PrintLogCommand(xmlbuilder);
                case "exit":
                    return
                        new ExitCommand();
                case "undo":
                    return 
                        new UndoCommand(xmlbuilder);
                default:
                    return null;
            }
        }
       
    }

}
