using System;

namespace LatihanInteger2
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka = 0;

            Console.WriteLine("Masukan angka");
            string inputan = Console.ReadLine();

            int.TryParse(inputan, out angka);

            //angka = angka < angka;
            
            for (int i = 0; i < angka; i++)
            {
                Console.WriteLine("angka= " + i + ", kuadrat=" + Math.Pow(i, 2));
            }

            // Mahasiswa budi = new Mahasiswa();
            // Mahasiswa iwan = new Mahasiswa();
            // Mahasiswa wati = new Mahasiswa();
            // Mahasiswa Badu = new Mahasiswa();
            // budi.menulis();
            // Console.WriteLine(Badu.membaca());
            // Badu.bernafas();

            // DutaKampus widya = new DutaKampus();
            // Console.WriteLine(widya.membaca());
            // widya.mempromosikan();

            Desa desa = new Desa();
            desa.namaDesa();
            desa.namaKecamatan();
            desa.namaKabupaten();
        }
    }
}
