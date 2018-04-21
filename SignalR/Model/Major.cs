using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR.Model
{
    public class Major
    {
        public Guid MajorID { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
    }
}