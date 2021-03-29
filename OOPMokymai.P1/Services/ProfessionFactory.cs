using OOPMokymai.P1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMokymai.P1.Services
{
    public class ProfessionFactory
    {
        public Profession BuildEngineer()
        {
            return new Profession(2, "Engineer", "Inžinierius");
        }
        public Profession BuildPharmacist()
        {
            return new Profession(2, "Pharmacist", "Vaistininkas");
        }
    }
}
