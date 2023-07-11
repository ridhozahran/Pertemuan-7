using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public class Person
    {
        //field
        string name;
        int age;

        //constructor
        public Person(string n, int a)
        {
            this.name = n;
            this.age = a;
        }

        //properties
        public string Name;


        public int Age;


        //fungsi/method
        public void InfoPerson()
        {
            Console.WriteLine("Nama saya {0} dan umur saya {1} tahun", name, age);
        }
    }

    //class turunan
    public class Karyawan : Person
    {

        //properties
        public string karyawanid;
        public string subject;

        //constructor
        public Karyawan(string kid, string sbj, string n, int a) : base(n, a)
        {
            karyawanid = kid;
            subject = sbj;

        }

        //ovefride
        public void InfoKaryawan(string kid, string sbj)
        {

            Console.WriteLine("Dengan ID {0} dan saya sebagai {1}", kid, sbj);
        }

        public void InfoPerson(string name, int age)
        {

            Console.WriteLine("Nama saya {0} dan umur saya {1} tahun", name, age);
        }

    }
}
