using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDatabase
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hoşgeldiniz");
            try
            {
                DataAccess da = new DataAccess("personel.csv");
                Console.WriteLine("1->Veri sayısını getir");
                Console.WriteLine("2->İsme göre arama yap");
                Console.WriteLine("3->Departmana göre arama yap");
                Console.WriteLine("4->Telefona göre arama yap");
                Console.WriteLine("5->Hesap Bitiş Tarihine göre arama yap");
                Console.WriteLine("6->Kullanıcı adına göre arama yap");
                Console.WriteLine("7->Kullanıcı adı ve İsime göre arama yap");
                string secim = Console.ReadLine();
                List<Personel> data = new List<Personel>();
                switch (secim)
                {
                    case "1":
                        int result = da.loadData();
                        Console.WriteLine("Veri sayısı :" + result);
                        break;
                    case "2":
                        Console.WriteLine("Personelin adını giriniz :");
                        string ad = Console.ReadLine();
                        Console.WriteLine("Personelin soyadını giriniz :");
                        string soyad = Console.ReadLine();
                        data = da.findByName(ad, soyad);
                        if (data.Count > 0)
                        {
                            foreach (Personel p in data)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Kayıt bulunamadı");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Departmanı giriniz :");
                        string departman = Console.ReadLine();
                        data = da.findByDepartment(departman);
                        if (data.Count > 0)
                        {
                            foreach (Personel p in data)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Kayıt bulunamadı");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Telefonu giriniz :");
                        string tel = Console.ReadLine();
                        data = da.findByTelephoneNumber(tel);
                        if (data.Count > 0)
                        {
                            foreach (Personel p in data)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Kayıt bulunamadı");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Başlangıç Tarihini giriniz (örnek : 2015-12-31): ");
                        string start = Console.ReadLine();
                        Console.WriteLine("Bitiş Tarihini giriniz (örnek : 2015-12-31): ");
                        string end = Console.ReadLine();
                        DateTime startDate = da.convertDateTime(start);
                        DateTime endDate = da.convertDateTime(end);

                        data = da.findByEndDate(startDate, endDate);
                        if (data.Count > 0)
                        {
                            foreach (Personel p in data)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Kayıt bulunamadı");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Kullanıcı adını giriniz :");
                        string kullanici = Console.ReadLine();
                        data = da.findByUsername(kullanici);
                        if (data.Count > 0)
                        {
                            foreach (Personel p in data)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Kayıt bulunamadı");
                        }
                        break;
                    case "7":
                        Console.WriteLine("Kulanıcı adını giriniz :");
                        string ka = Console.ReadLine();
                        Console.WriteLine("Personelin adını giriniz :");
                        string pa = Console.ReadLine();
                        data = da.findByUserNameAndFirstName(ka, pa);
                        if (data.Count > 0)
                        {
                            foreach (Personel p in data)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Kayıt bulunamadı");
                        }
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata!");
            }

            Console.ReadKey();
        }
    }
}
