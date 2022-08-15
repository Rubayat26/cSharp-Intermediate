
using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);


            //cookie.Expiry = DateTime.Now;
            Console.WriteLine(cookie.Expiry); //If we dont assign any value to the Expiry,
                                              //it will give us the default DateTime 
        }
    }
}
