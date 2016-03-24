using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class Resume
    {
        public Person Applicant { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Position ApplyingPosition { get; set; }
        public object ResumeFile { get; set; }
        public int ResumeID { get; set; }
        public Education Education { get; set; }
    }
}
