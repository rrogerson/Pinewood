using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RacingDigital.Models;

namespace RacingDigital.Services.Interfaces
{
    public interface IRacesService
    {
        public IEnumerable<RaceResult> GetRaces();
        //public void AddCustomer(Race customer);

    }
}
