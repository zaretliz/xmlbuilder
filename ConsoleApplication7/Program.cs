using ConsoleApplication7._3;
using ConsoleApplication7.Builder;
using ConsoleApplication7.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
         static void Main(string[] args)
        {
            var xmlBuilder = new Builder.XmlBuilder();
            var concreteObserver = new Observer.ConcreteObserver(xmlBuilder);
            Console.WriteLine("Доступные комманды: add, set, save, print, printlog, undo, exit");
            while (true)
            {
                string userString = Console.ReadLine();
                string[] arg = userString.Split(' ');
                var command = Commands.Command.Create(xmlBuilder, arg[0], arg.Length > 1 ? arg[1] : null,arg.Length > 2 ? arg[2] :null);
                if (command != null)
                    command.Execute();
                if (command != null)
                   xmlBuilder = command.treeBuilder;
                else
                    Console.WriteLine("Попробуйте ещё раз");

            }
        }  
    }
}
