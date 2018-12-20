using ConsoleApplication7._3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.Commands
{
    public class PrintLogCommand : Command
    {
        public PrintLogCommand(Builder.XmlBuilder xmlbuilder)
        {
            treeBuilder = xmlbuilder;
        }
        public override void Execute()
        {
            if (treeBuilder.GetResult().xmlComplete)
            {
                if (File.Exists(file))
                {
                    string[] readText = File.ReadAllLines(file);
                    foreach (string s in readText)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else
            {
                if (treeBuilder.GetResult().nodeWasCreated)
                    while (treeBuilder.GetResult().nodes.Count != 0)
                        treeBuilder.Save();
                if (File.Exists(file))
                {
                    string[] readText = File.ReadAllLines(file);
                    foreach (string s in readText)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                    Console.WriteLine("Xml файл не создан");
            }
        }
    }
}