using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wow.Core.Models;

namespace Wow.Core.Interfaces
{
   public interface IUserRepository
    {
        User GetPlayerById(Guid id);
        void SavePlayer(User player);
    }
}
