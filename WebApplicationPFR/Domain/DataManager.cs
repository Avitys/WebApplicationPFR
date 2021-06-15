using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationPFR.Domain.Repositories.Abstract;

namespace WebApplicationPFR.Domain
{
    public class DataManager
    {
        public IEmployesRepositories Employes { get; set; }
        public IMonitorsRepositories Monitors { get; set; }
        public IPCRepositories PC { get; set; }
        public IPrintersRepositories Printers { get; set; }

        public DataManager(IEmployesRepositories employesRepositories, IMonitorsRepositories monitorsRepositories, IPCRepositories pCRepositories, IPrintersRepositories printersRepositories)
        {
            Employes = employesRepositories;
            Monitors = monitorsRepositories;
            PC = pCRepositories;
            Printers = printersRepositories;
        }
    }
}
