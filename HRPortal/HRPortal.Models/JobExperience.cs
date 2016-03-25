using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class JobExperience :IValidatableObject
    {
        public string Company { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        //what if they still work there???

        public Address Address { get; set; }
        public Person PreviousManager { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (DateTime.Now > StartDate)
            {
                errors.Add(new ValidationResult("Please enter a valid start date", new[] { "StartDate" }));
            }
            if (EndDate < StartDate)
            {
                errors.Add(new ValidationResult("How did you end your job before you started it?", new[] { "EndDate" }));
            }
            return errors;
        }
    }
}
