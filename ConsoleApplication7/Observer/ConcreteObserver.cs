using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7.Observer
{
    class ConcreteObserver: IObserver
    {
        string file = "data.txt";
        public ConcreteObserver(Builder.XmlBuilder xmlbuilder)
        {
            xmlbuilder.RegisterObserver(this);
        }
        public void SetNode(string name)
        {
            File.AppendAllText(file, "<" + name + ">\n");
        }
        public void SetAttr(string name, string attribute)
        {
            int numberString = 0;
            string[] Text = File.ReadAllLines(file);
            File.Delete(file);
            for(int i=0; i<Text.Length;i++)
            {
                if(Text[i] == ("<"+ name + ">"))
                {
                    numberString = i;
                }
            }
            for(int i=0; i<=numberString;i++)
            {
                File.AppendAllText("data.txt", Text[i] + "\n");
            }
            File.AppendAllText("data.txt", attribute + "\n");
            for (int i=numberString+1; i<Text.Length;i++)
            {
                File.AppendAllText("data.txt", Text[i] + "\n");
            }
        }
        public void SaveNode(string name)
        {
            File.AppendAllText("data.txt", "</" + name + ">\n");
        }
    }
}
