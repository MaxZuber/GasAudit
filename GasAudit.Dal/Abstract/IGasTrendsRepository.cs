using GasAudit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasAudit.Dal.Abstract
{
    public interface IGasTrendsRepository
    {
        List<tblGasTrends> GetAll();
        void Insert(tblGasTrends gasTrends);

    }
}
