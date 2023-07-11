using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Rahmat Fauzi Abu Bakar", 19);
            person1.InfoPerson();

            Console.WriteLine("================================");

            Karyawan karyawan1 = new Karyawan("BH08234", "Sekertaris", "Fauzi", 19);
            karyawan1.InfoKaryawan("BH08234", "Sekertaris");
            karyawan1.InfoPerson();


            Console.ReadKey();
        }
    }
}
