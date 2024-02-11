using Businiess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businiess.Concrete
{ 
    public class PharmacyManager:ISupplierService
    {
    private IApplicantService _applicantService;

    public PharmacyManager(IApplicantService applicantService) //Constructer : Oluşturucu // New yazıldığında çalışır
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager();
            PharmacyManager pharmacyManager = new PharmacyManager(new PersonManager()); // OR 
                                                                                        //PttManager pttManager = new PttManager(new ForeignManager());
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi ");

            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske Verilemedi");
            }
        }
    }
}
