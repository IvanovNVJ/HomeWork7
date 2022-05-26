using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public struct Worker
    {
        public uint ID;
        public DateTime DateAndTimeOfAdded;
        public string FullName;
        public uint Age;
        public uint Height;
        public DateTime DateOfBirth;
        public string PlaceOfBirth;

        public Worker(uint ID, DateTime DateAndTimeOfAdded, string FullName, uint Age, uint Height, DateTime DateOfBirth, string PlaceOfBirth)
        {
            this.ID = ID;
            this.DateAndTimeOfAdded = DateAndTimeOfAdded;
            this.FullName = FullName;
            this.Age = Age;
            this.Height = Height;
            this.DateOfBirth = DateOfBirth;
            this.PlaceOfBirth = PlaceOfBirth;
        }
    }
}
