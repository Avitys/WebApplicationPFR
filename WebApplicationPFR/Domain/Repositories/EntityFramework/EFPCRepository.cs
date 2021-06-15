using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationPFR.Domain.Entities;
using WebApplicationPFR.Domain.Repositories.Abstract;

namespace WebApplicationPFR.Domain.Repositories.EntityFramework
{
    public class EFPCRepository : IPCRepositories
    {
        private readonly AppDbContext context;
        public EFPCRepository(AppDbContext context)
        {
            this.context = context;
        }
        
        public PC GetPCById(Guid id)
        {
            return context.PC.FirstOrDefault(x => x.Id == id);
        }

        public PC GetPCBymon(string pc)
        {
            return context.PC.FirstOrDefault(x => x.pc == pc);
        }
        public PC GetPCBymon_ser(string pc_ser)
        {
            return context.PC.FirstOrDefault(x => x.pc_ser == pc_ser);
        }
        public PC GetPCBymon_inv(string pc_inv)
        {
            return context.PC.FirstOrDefault(x => x.pc_inv == pc_inv);
        }

        IQueryable<PC> IPCRepositories.GetPC()
        {
            throw new NotImplementedException();
        }

        PC IPCRepositories.GetPCById(Guid id)
        {
            throw new NotImplementedException();
        }

        void IPCRepositories.SavePC(PC entity)
        {
            throw new NotImplementedException();
        }

        void IPCRepositories.DeletePC(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
