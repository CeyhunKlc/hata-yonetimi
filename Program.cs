   using System;

   namespace hata_yonetimi
  {

      class program
      {

        static void Main(string[] args)
         {
            try
            {
                Console.WriteLine("Bir sayi giriniz:");
              int sayi = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("girmiş olduğunuz sayi:"+sayi);
            }
             
              catch(Exception ex)
            { 
                //Console.WriteLine("hata:"+ex.Message.ToString());
            }
            //finaly
            // {
            //    Console.write("işlem tamamlandı.");
            // }  

            try
             {
                //int a= int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-20000000000");
             
            
             }
            catch (ArgumentNullException ex)
            {
               Console.WriteLine("boş değer giriniz");
               Console.WriteLine(ex); 
            }  
            catch(FormatException ex)
            { 
              Console.WriteLine("veri tipi uygun değil");
               Console.WriteLine(ex);       
            }
            catch(OverflowException ex)
            { 
             Console.WriteLine("çok küçük ya da çok büyük bir değer girdiniz");
               Console.WriteLine(ex);   
            } 
            finally{
            Console.WriteLine("işlem başarıyla tamamlandı.");
            }     
          
         }     

     } 
      
 }    








