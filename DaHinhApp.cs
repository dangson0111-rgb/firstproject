using System;
using System.Collections.Generic;
using System.Linq;

namespace codethuanC_
{
    public class Product
    {
        // Field thật sự để lưu dữ liệu
        private int id;
        private string name;
        private double price;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product()
        {
            this.ID = 0;
            this.Name = "NO name";
            this.Price = 0;
        }

        public Product(int ID, string Name, double Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
        }

        public void ApplyDiscount(double percent)
        {
            if (percent > 0 && percent <= 100 && Price > 0)
            {
                Price -= (Price * percent / 100);
            }
        }

        public void ApplyPrice(double giasp, bool cohang)
        {
            if (cohang && giasp > 0 && giasp <= Price)
            {
                Price -= giasp;
            }
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
        }
    }

    public class Monitor : Product
    {
        private string Paneltype;
        private string Size;   // sửa thành string cho đúng input

        public Monitor(int ID, string Name, double Price, string PanelType, string Size)
            : base(ID, Name, Price)
        {
            this.Paneltype = PanelType;
            this.Size = Size;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Paneltype: {Paneltype}, Size: {Size}");
            Console.WriteLine("-----------------------");
        }
    }

    public class AudioDevice : Product
    {
        private string Power;
        private bool Connect;

        public AudioDevice(int ID, string Name, double Price, string Power, bool Connect)
            : base(ID, Name, Price)
        {
            this.Power = Power;
            this.Connect = Connect;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Cong suat: {Power}, Ketnoi: {Connect}");
            Console.WriteLine("-----------------------");
        }
    }

    public class StoreManager
    {
        List<Product> ListSp = new List<Product>();

        public void AddProduct(Product Sanpham)
        {
            ListSp.Add(Sanpham);
        }

        public void ShowAll()
        {
            foreach (Product Sanpham in ListSp)
            {
                Sanpham.Display();  // Đa hình
            }
        }

        public Product SearchProduct(int id)
        {
            return ListSp.Find(p => p.ID == id);
        }

        public List<Product> SearchProduct(string name)
        {
            return ListSp.FindAll(p => p.Name.ToLower().Contains(name.ToLower()));
        }

        class Program
        {
            static void Main(string[] args)
            {
                StoreManager s = new StoreManager();
                int choice;

                do
                {
                    Console.WriteLine("\n===== MENU =====");
                    Console.WriteLine("1. Thêm Monitor");
                    Console.WriteLine("2. Thêm Audio Device");
                    Console.WriteLine("3. Hiển thị tất cả sản phẩm");
                    Console.WriteLine("4. Tìm sản phẩm theo tên");
                    Console.WriteLine("5. Áp dụng giảm giá");
                    Console.WriteLine("0. Thoát");
                    Console.Write("Chọn: ");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("ID: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Price: ");
                            double price = double.Parse(Console.ReadLine());
                            Console.Write("Panel Type: ");
                            string panel = Console.ReadLine();
                            Console.Write("Size: ");
                            string size = Console.ReadLine();

                            s.AddProduct(new Monitor(id, name, price, panel, size));
                            break;

                        case 2:
                            Console.Write("ID: ");
                            id = int.Parse(Console.ReadLine());
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                            Console.Write("Price: ");
                            price = double.Parse(Console.ReadLine());
                            Console.Write("Power: ");
                            string power = Console.ReadLine();
                            Console.Write("Connect (true/false): ");
                            bool connect = bool.Parse(Console.ReadLine());

                            s.AddProduct(new AudioDevice(id, name, price, power, connect));
                            break;

                        case 3:
                            s.ShowAll();
                            break;

                        case 4:
                            Console.Write("Nhập tên cần tìm: ");
                            string keyword = Console.ReadLine();
                            var result = s.SearchProduct(keyword);
                            foreach (var item in result)
                            {
                                item.Display();
                            }
                            break;

                        case 5:
                            Console.Write("Nhập ID sản phẩm: ");
                            id = int.Parse(Console.ReadLine());
                            var sp = s.SearchProduct(id);

                            if (sp != null)
                            {
                                Console.WriteLine("1. Giảm theo %");
                                Console.WriteLine("2. Giảm theo số tiền");
                                int chon = int.Parse(Console.ReadLine());

                                if (chon == 1)
                                {
                                    Console.Write("Nhập %: ");
                                    double percent = double.Parse(Console.ReadLine());
                                    sp.ApplyDiscount(percent);
                                }
                                else
                                {
                                    Console.Write("Nhập số tiền: ");
                                    double giam = double.Parse(Console.ReadLine());
                                    sp.ApplyPrice(giam, true);
                                }
                            }
                            break;
                    }

                } while (choice != 0);
            }
        }
    }
}
