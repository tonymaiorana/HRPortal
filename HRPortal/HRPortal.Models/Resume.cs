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
        public Resume()
        {
            this.ApplyingPosition = new Position();
            this.Applicant = new Person();
            this.JobExperience = new JobExperience();
        }
        public Person Applicant { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public Position ApplyingPosition { get; set; }
        //not sure how to validate
        public object ResumeFile { get; set; }
        public int ResumeID { get; set; }

        [Required (ErrorMessage = "How Smart are you?")]
        public Education Education { get; set; }
        public JobExperience JobExperience { get; set; }
        //todo: refrences??

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            //if (ApplyingPosition isVal)
            return null;
        }
    }
}