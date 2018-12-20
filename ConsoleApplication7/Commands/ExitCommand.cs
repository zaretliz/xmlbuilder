using ConsoleApplication7._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication7.Commands
{
   public class ExitCommand :Command
    {
        public ExitCommand()
        {
        }

        public override void Execute()
        {
            File.Delete(file);
            System.Threading.Thread.CurrentThread.Abort();
        }
    }
}
