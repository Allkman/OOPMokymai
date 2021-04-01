using OOPSchool.P2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSchool.P2.InitialData
{
    public static class RaceInitialData
    {
        public static List<RaceDTO> DataSeed => new List<RaceDTO>
        {
            new RaceDTO(1, "Blane", "Thomson", 1, "Human"),
            new RaceDTO(1, "Blane", "Thomson", 1, "Human"),
            new RaceDTO(1, "Blane", "Thomson", 0, "Kree"),
            new RaceDTO(1, "Blane", "Thomson", 1, "Kree"),
            new RaceDTO(1, "Blane", "Thomson", 1, "Artificial"),
            new RaceDTO(1, "Blane", "Thomson", 1, "Artificial"),
        };
    }
}
