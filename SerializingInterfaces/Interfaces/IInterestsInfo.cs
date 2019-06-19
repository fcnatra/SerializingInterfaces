using SerializingInterfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializingInterfaces.Interfaces
{
    public interface IInterestsInfo
    {
        string Interest { get; set; }
        IEnumerable<InterestInfo> Interests { get; set; }
    }
}
