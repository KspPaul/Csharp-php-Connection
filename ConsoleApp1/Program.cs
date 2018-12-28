using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string Data = Web.GetPost("http://paulserv.ddns.net/php/index.php", "UserName", "Paul");
            Console.WriteLine(Data);
            Console.ReadLine();
        }
    }
}
