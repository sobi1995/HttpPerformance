using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace httpPerformance.lib
{
  public  class httpPerformanceModel
    {
        public TimeSpan Elapsed { get; set; }
        public string ElapsedMilliseconds { get; set; }
        public string ElapsedTicks { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }

    }
}
