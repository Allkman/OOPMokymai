using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSchool.P2.Services
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
