using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationPFR.Domain.Entities;

namespace WebApplicationPFR.Domain.Repositories.Abstract
{
    public interface IPrintersRepositories
    {
        IQueryable<Printers> GetPrinters();
        Printers GetPrintersById(Guid id);
        void SavePrinters(Printers entity);
        void DeletePrinters(Guid id);
    }
}
