using Business.Concrete;
using Entities.Concrete;

namespace Workaraound
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Engin";
            person.LastName = "Demiroğ";
            person.DateOfBirthYear = 1985;
            person.NationalIdentity = 12345678910;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);

        }

    }
}