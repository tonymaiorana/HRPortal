using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class Address :IValidatableObject
    {
        
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrEmpty(Street))
            {
                errors.Add(new ValidationResult("Please enter a valid street number and name", new[] { "Street" }));
            }
            if (string.IsNullOrEmpty(City))
            {
                errors.Add(new ValidationResult("Please enter a valid City", new[] { "City" }));
            }
            
            if (string.IsNullOrEmpty(State))
            {
                errors.Add(new ValidationResult("Please Enter a valid State", new[] { "State" }));
            }

            if (string.IsNullOrEmpty(ZipCode))
            {
                errors.Add(new ValidationResult("Please enter a valid zip code", new []{"ZipCode"}));
            }

            return errors;
        }
    }
}
