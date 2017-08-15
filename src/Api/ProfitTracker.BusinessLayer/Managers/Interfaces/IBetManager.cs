using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfitTracker.Model.Entities;

namespace ProfitTracker.BusinessLayer.Managers.Interfaces
{
    public interface IBetManager
    {IEnumerable<Bet> GetAllBets();
    }
}
