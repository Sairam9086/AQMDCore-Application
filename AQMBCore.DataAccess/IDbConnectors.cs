using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQMDCore.DataAccess
{
    public interface IDbConnectors:IDisposable
    {
        DbConnection GetDbconnection();
      T Get<T>(string query, object parameters = null) where T : class;
    }
}
