﻿using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        //encapsulation
        public void ApplyForMask(Person person)
        {


        }

        public List<Person> GetList()
        {

            return null;
        }

        public async Task<bool> CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);


            return client.TCKimlikNoDogrulaAsync(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear).GetAwaiter().GetResult().Body.TCKimlikNoDogrulaResult;
        }
    }
}
