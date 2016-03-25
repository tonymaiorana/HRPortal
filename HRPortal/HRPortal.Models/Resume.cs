using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class Resume //todo: :IValidatableObject
    {
        public Person Applicant { get; set; }
        //[DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        //[DataType(DataType.Date)]
        public DateTime DateUpdated { get; set; }
        public Position ApplyingPosition { get; set; }
        public object ResumeFile { get; set; }
        public int ResumeID { get; set; }
        public Education Education { get; set; }
        public JobExperience JobExperience { get; set; }
        //todo: refrences??
    }
}
