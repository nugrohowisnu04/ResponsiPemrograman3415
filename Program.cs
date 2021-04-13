using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3415
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan paijo = new Karyawan();
            Karyawan jono = new Karyawan();

            paijo.Nik = 12345166;
            paijo.Nama = "nugroho";
            paijo.GajiBulanan = 3000000;

            jono.Nik = 098765543;
            jono.Nama = "Wisnu";
            jono.GajiBulanan = 2000000;

            Console.WriteLine("Nik Nama                    Gaji Bulanan");
            Console.WriteLine("-------------------------------------------");
            paijo.gajiawal();
            jono.gajiawal();

            Console.WriteLine("\nAlhamdulillah dapat kenaikan gaji 10%\n\n");

            Console.WriteLine("Nik Nama                    Gaji Bulanan");
            Console.WriteLine("-------------------------------------------");
            paijo.gajiakhir();
            jono.gajiakhir();

            Console.ReadKey();
        }
    }
}