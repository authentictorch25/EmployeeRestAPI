using System;
using System.Collections.Generic;
using System.Text;

namespace RestApi
{
    public class Employee
    {
        public int id { get; set; }
        public string job { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string region { get; set; }
        public long phoneNumber { get; set; }
        public string email { get; set; }

        public long salary { get; set; }
    }
}
