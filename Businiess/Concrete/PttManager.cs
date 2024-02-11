using Businiess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businiess.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService  applicantService) //Constructer : Oluşturucu // New yazıldığında çalışır
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager();
            PttManager pttManager = new PttManager(new PersonManager()); // OR 
            //PttManager pttManager = new PttManager(new PersonManager());

            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi ");

            }
            else
            {
                Console.WriteLine("Maske Verilemedi");
            }
        }
    }
}
