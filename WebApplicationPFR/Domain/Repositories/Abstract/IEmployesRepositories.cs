using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationPFR.Domain.Entities;

namespace WebApplicationPFR.Domain.Repositories.Abstract
{
    public interface IEmployesRepositories
    {
        //выпорка полей
        IQueryable<Employes> GetEmployes();

        Employes GetEmployesById(Guid id);
        //Employes GetEmployesByCodeWord(string codeWord);
        void SaveEmployes(Employes entity);
        void DeleteEmployes(Guid id);
        //object GetEmployesByCodeWord(Guid id);
    }
}
