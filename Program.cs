using System;

  namespace operatorler
 {
     class Program
     {
         static void Main(string[] args)
         {
             

               try
               {
                //int a = int.Parse(null);
               int a = int.Parse("test");
               }
               catch (FormatException ex)
               {
                Console.WriteLine("veri tipi uygun değil.");
                Console.WriteLine(ex);             
              }
              catch(OverflowException ex)
              {
              Console.WriteLine("çok küçük ya da çok büyük değer girdiniz");
              Console.WriteLine(ex);
              }
              finally
              {
                Console.WriteLine("işlem başariyla tamamlandi");

              }
         }
     }
 }