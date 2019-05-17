using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new PPP
            {
                name = "ck"
            };
            var str = JsonConvert.SerializeObject(p);
            Console.WriteLine(str);
            Console.WriteLine("Hello world");
        }
    }
    class PPP
    {
        public string name { get; set; }
    }
}
