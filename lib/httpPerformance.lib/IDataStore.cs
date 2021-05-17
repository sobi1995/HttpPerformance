using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace httpPerformance.lib
{
    public interface IDataStore
    {
        void Save(httpPerformanceModel model);
        Task SaveAsync(httpPerformanceModel model);
    }
}
