using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationPFR.Domain.Entities;

namespace WebApplicationPFR.Domain.Repositories.Abstract
{
    public interface IMonitorsRepositories
    {
        IQueryable<Monitors> GetMonitors();
        Monitors GetMonitorsById(Guid id);
        void SaveMonitors(Monitors entity);
        void DeleteMonitors(Guid id);
        

    }
}
