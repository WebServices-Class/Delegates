using System;
using System.Collections.Generic;
using DelegateDemo.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate string data2string();//a delegate to activate different data to string converters on various objects
    class Program
    {

        private Random r;

        /// <summary>
        /// This program demonstrates the usage of delegates.
        /// We create different objects that use methods to accomplish things while maintaining the same
        /// signature.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program dlg = new Program();
            dlg.go();//running the program from a non static environment to avoid use of global static members
        }

        public void go()//non static entry point to the program.
        {
            int shapename = 0;
            string dataname;
            r = new Random();
            List<object> things = new List<object>();
            int length = r.Next(4);
            for (int i = 0; i < length+3; i++)
            {
                if(r.Next(2)==0)
                {
                    things.Add(new Ball("red", r.Next(20)));
                }
                else
                {
                    things.Add(new Pyramid("blue", r.Next(20), r.Next(20)));
                }
            }
            Console.WriteLine(string.Format("what shape number to investigate? (1-{0})",things.Count));
            shapename = int.Parse(Console.ReadLine())-1;
            while (shapename<things.Count)
            {
                Console.WriteLine("what data number (1-3) to investigate?");
                dataname = (Console.ReadLine());
                switch (dataname)
                {
                    case "1":
                        if (things[shapename].GetType() == typeof(Ball))
                            UseDelegate(new data2string((things[shapename] as Ball).Color));
                        else
                            UseDelegate(new data2string((things[shapename] as Pyramid).Color));
                        break;
                    case "2":
                        if (things[shapename].GetType() == typeof(Ball))
                            UseDelegate(new data2string((things[shapename] as Ball).Volume));
                        else
                            UseDelegate(new data2string((things[shapename] as Pyramid).Volume));
                        break;
                    case "3":
                        if (things[shapename].GetType() == typeof(Ball))
                            UseDelegate(new data2string((things[shapename] as Ball).Status));
                        else
                            UseDelegate(new data2string((things[shapename] as Pyramid).Status));
                        break;
                    default:
                        break;
                }
                Console.WriteLine(string.Format("what shape number to investigate? (1-{0})", things.Count));
                shapename = int.Parse(Console.ReadLine())-1;
            }
        }

        private void UseDelegate(data2string that)
        {
            Console.WriteLine(that());
        }
    }
}
