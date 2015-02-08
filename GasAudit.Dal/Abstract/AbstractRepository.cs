using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasAudit.Dal.Abstract
{
    public abstract class AbstractRepository
    {

        private readonly string _connectionString;

        protected AbstractRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        protected DbContext CreateDbContext()
        {
            return new DbContext(_connectionString);
        }
    }
}
