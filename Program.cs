using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71DersPolymorphism
{
    class Program
    {
        //Polymorphism: Birden fazla formun olusma durumu
        class Sekil
        {
            public virtual void SekilCiz() // Virtual: Sanal
            {
                Console.WriteLine("Sekil ciziliyor...");
            }
        }
        class Dikdortgen : Sekil
        {
            //override: Gecersiz kilmak
            public override void SekilCiz() //override kullanarak base siniftaki metotu gecersiz kildik ve kendi metotumuzu olusturduk...
            {
                //base.SekilCiz();  (Base siniftaki ayni metotu cagirir...)
                Console.WriteLine("Dikdortgen ciziliyor...");
            }
        }
        static void Main(string[] args)
        {
            Dikdortgen d1 = new Dikdortgen();
            d1.SekilCiz();
        }
    }
}
