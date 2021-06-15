using System;
using System.Linq;
using WebApplicationPFR.Domain;
using WebApplicationPFR.Domain.Entities;
using WebApplicationPFR.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFEmployesRepository : IEmployesRepositories

    {
        private readonly AppDbContext context;
        public EFEmployesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Employes> GetServiceItems()
        {
            return context.Employes;
        }
        public Employes GetEmployesById(Guid id)
        {
            return context.Employes.FirstOrDefault(x => x.Id == id);
        }
        public Employes GetEmployesByOtdel(string otdel)
        {
            return context.Employes.FirstOrDefault(x => x.otdel == otdel);
        }
        public Employes GetEmployesByRoom(int room)
        {
            return context.Employes.FirstOrDefault(x => x.Room == room);
        }
        public Employes GetEmployesByFIO(string fio)
        {
            return context.Employes.FirstOrDefault(x => x.FIO == fio);
        }
        public Employes GetEmployesByMon(string mon)
        {
            return context.Employes.FirstOrDefault(x => x.mon == mon);
        }
        public Employes GetEmployesByPC(string pc)
        {
            return context.Employes.FirstOrDefault(x => x.pc == pc);
        }
        public Employes GetEmployesByPrinter(string printer)
        {
            return context.Employes.FirstOrDefault(x => x.printer == printer);
        }

        public void DeleteEmployes(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Employes> GetEmployes()
        {
            throw new NotImplementedException();
        }

        public void SaveEmployes(Employes entity)
        {
            throw new NotImplementedException();
        }

        public Employes GetEmployesByCodeWord(string codeWord)
        {
            throw new NotImplementedException();
        }

        public object GetEmployesByCodeWord(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

