using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializingInterfaces.Interfaces
{
    public interface IPersonalDataContainer
    {
        string Name { get; set; }
        string SurName { get; set; }
        string FullName { get; }
        DateTime BirthDate { get; set; }
        byte Age { get; }
    }
}
