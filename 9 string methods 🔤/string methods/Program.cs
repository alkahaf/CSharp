using System;

namespace stringMethods
{
    class Program {
        static void Main(string[] args) {

            String fullName = "Alkahaf Mukadam";
            String phoneNumber = "91-1234567890";

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            //phoneNumber =  phoneNumber.Replace("-", "");
            //Console.WriteLine(phoneNumber);

            //String userName = fullName.Insert(0,"Mr.");
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length);

            String firstName = fullName.Substring(0,7);
            Console.WriteLine(firstName);


            Console.ReadKey();
        }
    }

}
