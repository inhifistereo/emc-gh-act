using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMC.Helpers
{
    public class GetHostName
    {
        public String hostname = System.Net.Dns.GetHostName();
    }
}
