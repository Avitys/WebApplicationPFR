using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplicationPFR.Domain;
using WebApplicationPFR.Domain.Entities;
using WebApplicationPFR.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFMonitorsRepository : IMonitorsRepositories
    {
        private readonly AppDbContext context;
        public EFMonitorsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Monitors> GetMonitors()
        {
            return context.Monitors;
        }

        public Monitors GetMonitorsById(Guid id)
        {
            return context.Monitors.FirstOrDefault(x => x.Id == id);
        }

        public Monitors GetMonitorsBymon(string mon)
        {
            return context.Monitors.FirstOrDefault(x => x.mon == mon);
        }
        public Monitors GetMonitorsBymon_ser(string mon_ser)
        {
            return context.Monitors.FirstOrDefault(x => x.mon_ser == mon_ser);
        }
        public Monitors GetMonitorsBymon_inv(string mon_inv)
        {
            return context.Monitors.FirstOrDefault(x => x.mon_inv == mon_inv);
        }

        public void SaveMonitors(Monitors entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteMonitors(Guid id)
        {
            context.Monitors.Remove(new Monitors() { Id = id });
            context.SaveChanges();
        }
    }
}
