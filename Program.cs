using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void DelCall(string s);
    class Program
    {
        public static void returnDel(string s) 
        {
            Console.WriteLine("Delegate invoked");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //DelCall d = new DelCall(returnDel);
            //d.Invoke("rakesh");

            DelCall de = rajesh => {  };
            //de.Invoke("ok");
        }
    }
}
