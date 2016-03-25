using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class Resume :IValidatableObject
    {
        public Person Applicant { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateUpdated { get; set; }
        public Position ApplyingPosition { get; set; }
        //not sure how to validate
        public object ResumeFile { get; set; }
        public int ResumeID { get; set; }
        
        public Education Education { get; set; }
        public JobExperience JobExperience { get; set; }
        //todo: refrences??
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            //not sure what to do here
            return errors;

        }
    }
}
