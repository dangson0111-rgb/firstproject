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
            Console.WriteLine("Nhập vào giá trị USD bạn muốn chuyển sang tiền việt");
            int USD = int.Parse(Console.ReadLine());
            int VND = USD * 23;
            Console.WriteLine("giá trị của {0} USD quy sang tiền việt là {1} nghìn đồng",USD,VND);
        }
    }
}
