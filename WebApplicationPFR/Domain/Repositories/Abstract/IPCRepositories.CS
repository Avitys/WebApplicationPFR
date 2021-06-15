using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationPFR.Domain.Entities;

namespace WebApplicationPFR.Domain.Repositories.Abstract
{
    public interface IPCRepositories
    {
        IQueryable<PC> GetPC();
        PC GetPCById(Guid id);
        void SavePC(PC entity);
        void DeletePC(Guid id);
    }
}
