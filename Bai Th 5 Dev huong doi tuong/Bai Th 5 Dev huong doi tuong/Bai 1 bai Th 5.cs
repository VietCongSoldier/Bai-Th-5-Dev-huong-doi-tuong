using System;

namespace Bai_Th_5_Dev_huong_doi_tuong
{
    class TienDien
    {
        private string tenchuho, diachi;
        private int sodienthangtruoc, sodienthangnay;
        public TienDien()
        {
            tenchuho = "Viet";
            diachi = "Trung Hoa";
            sodienthangtruoc = 0;
            sodienthangnay = 10;
        }
        public TienDien(string tenchuho, string diachi, int sodienthangtruoc, int sodienthangnay)
        {
            this.tenchuho = tenchuho;
            this.diachi = diachi;
            this.sodienthangtruoc = sodienthangtruoc;
            this.sodienthangnay = sodienthangnay;
        }
        public void Nhap()
        {
            Console.Write("Nhap ten chu ho:"); tenchuho = Console.ReadLine();
            Console.Write("Nhap dia chi:  "); diachi = Console.ReadLine();
            Console.Write("Nhap so dien thang truoc:"); sodienthangtruoc = int.Parse(Console.ReadLine());
            Console.Write("Nhap so dien thang nay:"); sodienthangnay = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("{0}\t{1}\t{2}", tenchuho, diachi, sodiendadung);
        }
        public int sodiendadung
        {
            get
            {
                return sodienthangnay - sodienthangtruoc;
            }
        }
        public int Tinhtiendien()
        {
            return sodiendadung * 500;
        }

    }
    class Tiendienmoi : TienDien
    {
        private int dinhmuc;
        public Tiendienmoi() : base()
        {
            dinhmuc = 50;
        }
        public Tiendienmoi(string tenchuho, string diachi, int sodienthangtruoc, int sodienthangnay, int dinhmuc) : base(tenchuho, diachi, sodienthangtruoc, sodienthangnay)
        {
            this.dinhmuc = dinhmuc;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap he so dinh muc: "); dinhmuc = int.Parse(Console.ReadLine());

        }
        public new int Tinhtiendien()
        {
            if (sodiendadung < dinhmuc) return sodiendadung * 500;
            else return sodiendadung * 600;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tiendienmoi t = new Tiendienmoi();
            t.Nhap();
            t.Hien();
            Console.WriteLine("Tiendien={0}", t.Tinhtiendien());
            Console.ReadKey();
        }
    }
}
