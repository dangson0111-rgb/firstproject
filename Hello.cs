using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codethuanC_
{
    internal class bt
    {
        static void Main(string[] args)
        {
           
            Console.OutputEncoding=Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào tên của bạn");
            string YourName = Console.ReadLine();
            Console.WriteLine("Tên bạn là "+ YourName);
        }
    }
}
