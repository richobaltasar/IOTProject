using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebIOT.Models
{
    public class DashboardModel
    {
        public MqqtModel MqqtPanel { get; set; }

        public ErrorViewModel Error { get; set; }
    }
    public class MqqtModel
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string Topic { get; set; }
    }
}
