


using Business.Concrete;
using Entities.Concrete;


namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Mustafa";
            person1.LastName = "Birinci";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 123;

            static void SelamVer(Person person)
            {
                Console.WriteLine("Merhaba" + person.FirstName + person.LastName);
            }

            SelamVer(person1);

            static int ToplamaIslemi(int sayi1, int sayi2)
            {
                int sonuc = sayi1 + sayi2;
                Console.WriteLine("Toplam: " + sonuc.ToString());
                return sonuc;
            }

            ToplamaIslemi(40, 30);
        }
    }
}