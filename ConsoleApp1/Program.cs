using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WebApiHelper pp = new WebApiHelper("http://47.93.50.106:5000");

            var result = WebApiHelper.GetData("/api/Table");
            Console.WriteLine(result.Result);
            Console.Read();
        }
    }
}
