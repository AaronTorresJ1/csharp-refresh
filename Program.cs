using System;

namespace csharp_refresh
{
    class Program
    {
        static void Main(string[] args)
        {
            //TYPE CONVERSION       
            // Implicit Type Conversion - byte is 1 byte. int is 4 bytes. - no memory loss
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            
            //Explicit Type Conversion - Casting
            //maximum you can store in a byte is 255
            int x = 1;
            byte c = (byte) x;
            Console.WriteLine(c);


            // Try - Catch Exception Demo
            try
            {
                // convert the string str to boolean.
                string str = "true";
                bool a = Convert.ToBoolean(str);
                Console.WriteLine(a);

            }
            catch (System.Exception)
            {
                
                Console.WriteLine("The number could not be converted to a byte");
                
            }
            

        }
    }
}
