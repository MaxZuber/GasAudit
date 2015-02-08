using GasAudit.Dal.Abstract;
using GasAudit.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasAudit.Dal.Concrete
{
    public class GasTrendsRepository : AbstractRepository, IGasTrendsRepository
    {

        public GasTrendsRepository(string connectionString) : base(connectionString) { }


        public List<tblGasTrends> GetAll()
        {
            List<tblGasTrends> trends;

            using (DbContext context = this.CreateDbContext())
            {
                trends = context.Set<tblGasTrends>().ToList();  //отримуємо всі тренди з таблиці
            }

            return trends;
        }

        public void Insert(tblGasTrends gasTrends)
        {
            using (DbContext context = this.CreateDbContext())
            {
                context.Set<tblGasTrends>().Add(gasTrends);     //записуємо тренди в таблицю
                context.SaveChanges();                          //відправляємо зміни до бази даних
            }
        }
    }
}
