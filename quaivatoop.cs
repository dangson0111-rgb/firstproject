using System;
using System.Collections.Generic;

namespace codethuanC_
{
    public class QuaiVat
    {
        private string tenqv;
        private int mau;
        public QuaiVat(string tenqv, int mau)
        {
            this.tenqv = tenqv;
            this.mau = mau;
        }
        public string Tenqv
        {
            get { return tenqv; }
            set { tenqv = value; }
        }
        public int Mau
        {
            get { return mau; }
            set { mau = value; }
        }
        public static void Main2()
        {
            Console.Write("Hãy nhập ID của chú linh với cú pháp là Q + số bất kỳ: ");
            string ID = Console.ReadLine();

            Dictionary<string, QuaiVat> Chulinh = new Dictionary<string, QuaiVat>(StringComparer.OrdinalIgnoreCase)
            {
        { "Q01", new QuaiVat("Mahito", 100) },
        { "Q02", new QuaiVat("Jogo", 90) },
        { "Q03", new QuaiVat("Sukuna", 500) },
        { "Q04", new QuaiVat("Hanami", 60) }
               };

            if (Chulinh.ContainsKey(ID))
            {
                QuaiVat qv = Chulinh[ID];
                Console.WriteLine($"Chú Linh tồn tại: {qv.Tenqv} - Máu: {qv.Mau}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy Chú Linh!");
            }
        }

    }
}

