using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_islemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //test için 14 değer
            //liste.Add("hakan");
            //liste.Add("dogan");
            //liste.Add("faruk");
            //liste.Add("emre");
            //liste.Add("emrah");
            //liste.Add("tolga");
            //liste.Add("ömer");
            //liste.Add("hasan");
            //liste.Add("cengiz");
            //liste.Add("kadir");
            //liste.Add("hüsnü");
            //liste.Add("abdullah");
            //liste.Add("kaan");
            //liste.Add("burak");
            string userValue, valueUserWants = "", combination = "";

            do
            {
                Console.WriteLine("Diziye eleman eklemek için (a + boşluk + gireceğinz değer) kombinasyonunu kullanabilirsiniz. ");
                Console.WriteLine("Diziden eleman silmek için (r + boşluk + sileceğiniz değer) kombinasyonunu kullanabilirsiniz.");
                Console.WriteLine("Dizideki elemanları listelemek için (w + boşluk) kombinasyonunu kullanabilirsiniz.");
                Console.WriteLine("Uygulamadan çıkmak için (exit) yazınız");
                Console.WriteLine();
                Console.Write("Yapmak istedğiniz işlem için gerekli kombinasyonu yazın : ");
                userValue = Console.ReadLine();
                if (userValue.Length < 2)
                {


                    Console.WriteLine("Geçerli bir değer girişi yapmadınız !!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();

                }
                else
                {
                    valueUserWants = userValue.Substring(2);
                    combination = userValue.Substring(0, 2);
                }
                bool degerkontrolu = list.Contains(valueUserWants);


                if (userValue != "exit")
                {
                    switch (combination)
                    {

                        case "a ":
                            if (list.Count <= 15)
                            {
                                if (degerkontrolu)
                                {
                                    Console.WriteLine("HATA !!!!!!");
                                    Console.WriteLine("Girdiğiniz değer zaten var..");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                }
                                else if (valueUserWants == "")
                                {
                                    Console.WriteLine("Değer girişi yapmadığınız için ekleme işlemi başarısız..");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                }
                                else
                                {
                                    list.Add(valueUserWants);
                                    Console.Write("Ekleme işlemi başarılı.");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Girdiğiniz veri değeri capasiteyi aştı.");
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                            break;
                        case "w ":
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.WriteLine("{0} - {1}", i, list[i]);
                            }
                            Console.WriteLine("İşlem ekranına dönmek için bir tuşa basın");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case "r ":
                            if (degerkontrolu)
                            {
                                list.Remove(valueUserWants);
                                Console.Write("Silme işlemi başarılı.");
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("HATA !!!!!!");
                                Console.WriteLine("Silmek istediğiniz değer bulunamadı lütfen tekrar deneyin");
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                            break;
                        default:
                            Console.WriteLine("Girdiğiniz değer hatalı!!");
                            Console.WriteLine("Lütfen uyarıları gözden geçirip tekrar deneyin");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            break;

                    }
                }

            } while (userValue != "exit");
        }
    }
}
