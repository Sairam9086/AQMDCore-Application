using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Dynamic;
using System.Data.Common;
using Dapper;


namespace AQMBCore.DataAccess
{
    public class DbConnectors
    {
        private readonly IConfiguration _dbContext;
        private string _config;
        public DbConnectors() {

            _dbContext = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();

            _config = _dbContext.GetConnectionString("AQMDConnections");

        }
        public IDbConnection Creatconnection()
        {
            return new SqlConnection(_config);
        }
        string Sanitize(string sqlString) => sqlString.Replace(Environment.NewLine, " ");
        public T Get<T>(string query, object parameters = null) where T : class
        {
             using(var db= Creatconnection())
            {
                var res = db.QuerySingleOrDefault<T>(Sanitize(query), parameters);
                return res;
            }
        }

        //public int Update<T>(string query, object parameters = null) where T : class
        //{
        //    using (var db = CreateConnection())
        //    {
        //        var rowsAffected = db.Execute(Sanitize(query), parameters);
        //        return rowsAffected;
        //    }
        //}
        //public int Update(string storedProcedureName, object parameters = null, commandType: CommandType.StoredProcedure) where T : class
        //{
        //    using (var db = Creatconnection())
        //    {
        //        db.Open();
        //        var rowsAffected = db.Execute(storedProcedureName, parameters);
        //        return rowsAffected;
        //    }
        //}
        //public int Update(string sql, object parameters = null, commandType: CommandType.StoredProcedure)
        //{
        //    using (var db = Creatconnection())
        //    {
        //        db.Open();
        //        var rowsAffected = db.Execute(sql, parameters );
        //        return rowsAffected;
        //    }
        //}
        public int Update(string sql, object parameters = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using (var db = Creatconnection())
            {
                db.Open();
                var rowsAffected = db.Execute(Sanitize(sql), parameters);
                return rowsAffected;
            }
        }

    }

}
