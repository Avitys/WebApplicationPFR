using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationPFR.Domain.Entities;
using WebApplicationPFR.Domain.Repositories.Abstract;

namespace WebApplicationPFR.Domain.Repositories.EntityFramework
{
    public class EFPrintersRepository : IPrintersRepositories
    {
        private readonly AppDbContext context;
        public EFPrintersRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Printers GetPrintersById(Guid id)
        {
            return context.Printers.FirstOrDefault(x => x.Id == id);
        }

        public Printers GetPrintersByPrinters(string printer)
        {
            return context.Printers.FirstOrDefault(x => x.printer == printer);
        }
        public Printers GetPrintersByPrinter_ser(string printer_ser)
        {
            return context.Printers.FirstOrDefault(x => x.printer_ser == printer_ser);
        }
        public Printers GetPCByprinters_inv(string printer_inv)
        {
            return context.Printers.FirstOrDefault(x => x.printer_inv == printer_inv);
        }

        public IQueryable<Printers> GetPrinters()
        {
            throw new NotImplementedException();
        }
        public void SavePrinters(Printers entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeletePrinters(Guid id)
        {
            context.Printers.Remove(new Printers() { Id = id });
            context.SaveChanges();
        }
    }
}
