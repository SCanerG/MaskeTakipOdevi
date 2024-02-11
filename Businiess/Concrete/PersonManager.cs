using Businiess.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businiess.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client =new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);


            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;

            //if (person.NationalIdentity!=0)
            //{
            //    //mernis kontrolü
            //    return true;

            //}
            //else
            //{
            //    return false;
            //}
        }

        public List<Person> Getlist()
        {
            throw new NotImplementedException();
        }
    }
}
