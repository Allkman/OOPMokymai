using OOPMokymai.P2.Models.Abstract;
using OOPSchool.P2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSchool.P2.Services.Interfaces
{
    public interface IRaceFactory
    {
        RaceBase Build(RaceDTO race);
    }
}
