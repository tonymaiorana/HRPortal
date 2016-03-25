using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class JobExperience //todo: :IValidatableObject
    {
        public string Company { get; set; }
        //[DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        //[DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public Address Address { get; set; }
        public Person PreviousManager { get; set; }
    }
}
