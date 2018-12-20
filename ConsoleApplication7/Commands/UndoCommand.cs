using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ConsoleApplication7.Commands
{
  public  class UndoCommand : Command
    {
        public UndoCommand(Builder.XmlBuilder xmlbuilder)
        {
            treeBuilder = xmlbuilder;
        }
        public override void Execute()
        {
            if (treeBuilder.GetResult().com.Count != 0)
            {
                treeBuilder.GetResult().notUndoCommand = false;
                if (treeBuilder.GetResult().com.Peek().GetType() == typeof(SaveCommand))
                {
                    int numberString = 0;
                    string[] Text = File.ReadAllLines(file);
                    for (int i = 0; i < Text.Length; i++)
                    {
                        if (Text[i] == ("<" + treeBuilder.GetResult().name + ">"))
                        {

                            numberString = i;
                        }
                    }
                    File.Delete(file);
                    for (int i = 0; i < numberString; i++)
                    {
                        File.AppendAllText("data.txt", Text[i] + "\n");
                    }

                    treeBuilder.GetResult().notUndoCommand = true;

                }
                else
                    treeBuilder.GetResult().notUndoCommand = true;
            }

        }
    }
}

