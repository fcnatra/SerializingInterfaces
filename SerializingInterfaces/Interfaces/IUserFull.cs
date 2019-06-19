using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializingInterfaces.Interfaces
{
    public interface IUserFull : IUserInfo, IPersonalDataContainer, IInterestsInfo
    {
    }
}
