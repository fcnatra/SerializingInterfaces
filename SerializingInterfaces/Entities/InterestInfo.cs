using System.Collections.Generic;
using SerializingInterfaces.Interfaces;

namespace SerializingInterfaces.Entities
{
    public class InterestInfo : IInterestsInfo
    {
        public InterestInfo() { }

        public InterestInfo(string interest)
        {
            this.Interest = interest;
        }

        public string Interest { get; set; }
        public IEnumerable<InterestInfo> Interests { get; set; }
    }
}
