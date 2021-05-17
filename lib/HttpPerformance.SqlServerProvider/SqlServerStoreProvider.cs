 
using httpPerformance.lib;
using HttpPerformance.SqlServerProvider.Entities;
using HttpPerformance.SqlServerProvider.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpPerformance.SqlServerProvider
{
    public class SqlServerStoreProvider : IDataStore
    {
        private readonly string _connectionString;
        private string _tableName = "RequestLog";
     //   private static readonly IMapper _mapper;
        static SqlServerStoreProvider()
        {
            //var config = new MapperConfiguration(cf =>
            //{
            //    cf.CreateMap<RequestLog, RequestLogEntity>()
            //        .ForMember(dest => dest.Timestamp, opt => opt.MapFrom(d => DateTime.Now));
            //});

            //_mapper = config.CreateMapper();

        }
        public SqlServerStoreProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlServerStoreProvider TableName(string tableName)
        {
            _tableName = tableName;
            return this;
        }

        private SqlServerDataContext GetDbContext()
        {
            var context = new SqlServerDataContext(_connectionString, _tableName);
            context.Database.EnsureCreated();
            return context;
        }

        public void Save(httpPerformanceModel model)
        {
            using (var context = GetDbContext())
            {
                //var log = _mapper.Map<httpPerformance>(model);
                //context.RequestLogs.Add(log);
                //context.SaveChanges();
            }

        }

        public async Task SaveAsync(httpPerformanceModel model)
        {
            using (var context = GetDbContext())
            {
                //var log = _mapper.Map<httpPerformance>(model);
                //await context.RequestLogs.AddAsync(log);
                //await context.SaveChangesAsync();
            }

        }
    }
}
