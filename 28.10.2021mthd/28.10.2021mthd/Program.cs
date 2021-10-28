using System;

namespace _28._10._2021mthd
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Verilmis string deyerini ters sekilde qaytaran metod. Misalcun metodu cagirib "salam" yazisi gondersek geriya "malas" yazisi qayitmalidir
            string word = TersSoz("Hello");
            Console.WriteLine(word);

            //2. Verilmis string deyerinde olan sozlerin sayini qaytaran metod.metoda istenilen formada string gonderildikde icerideki sozlerin sayi qayitmalidir, misalcun "   salam   sag  ol   " deyeri gondersek bele geriye 3 qaytarmalidir.
            int say = Words("Salam Baku Hello Mello");
            Console.WriteLine(say);

            //3. Verilmis string deyerinde verilmis char-in indexlerinden ibaret array qaytaran metod.Misalcun metodu cagirib "salam" string deyeri ve 'a' char deyeri gondersem geriye icinde 1 ve 3 deyerleri olan array qayitmalidir
            //string str = "salam";
            //char ch = 'a';

            //int yoxla = Arr(str, ch);

            //Console.WriteLine(yoxla);


        }


        static string TersSoz(string soz)
        {
            string terssoz="";

            for(int i = soz.Length - 1; i >= 0; i--)
            {
                terssoz += soz[i]; 
                
            }
            return terssoz;
        }

        static int Words(string word)
        {

            char space = ' ';
            int counter =0;

            for(int i = 0; i < word.Length; i++)
            {
                if (space == word[i])
                {
                    counter++;
                }
   
            }
            return counter;

        }

        static int[] Arr(string text,char chr)     // Sehvlik var ...
        {

            int[] Arr = { };
            for (int i = 0; i < text.Length; i++)
            {


                if (text[i] == chr)
                {

                    return Arr;


                }

            }
            
            
    
            

        }
    }
}
