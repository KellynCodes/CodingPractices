using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BenzaoSessionOne.CodingPractices
{
      
        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Location { get; set; }
            public char Gender { get; set; }
            //TO DO APP
            internal static void GoodPractice(User user)
            {
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Age);
            Console.WriteLine(user.Gender);
            Console.WriteLine(user.Location);
            }

        internal static void BadPractice(string name, int age, string location, char gender)
        {
            string Un = name;
            int a = age;
            string lct = location;
            char G = gender;
            Console.WriteLine(Un);
            Console.WriteLine(a);
            Console.WriteLine(lct);
            Console.WriteLine(G);
        }
    }
}
