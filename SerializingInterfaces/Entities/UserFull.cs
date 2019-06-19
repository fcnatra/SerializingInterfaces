using SerializingInterfaces.Interfaces;
using System;
using System.Collections.Generic;

namespace SerializingInterfaces.Entities
{
    public class UserFull : IUserFull
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public string FullName => $"{Name} {SurName}";

        public DateTime BirthDate { get; set; }

        public byte Age => (byte)(DateTime.Now.Subtract(BirthDate).TotalDays / 365);

        public string Interest { get; set; }
        public IEnumerable<InterestInfo> Interests { get; set; }
    }
}
