using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
   public class Person :IValidatableObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }


       public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
       {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrEmpty(FirstName))
            {
                errors.Add(new ValidationResult("Please enter a valid first name", new[] { "FirstName" }));
            }
            if (string.IsNullOrEmpty(LastName))
            {
                errors.Add(new ValidationResult("Please enter a valid last name", new[] { "FirstName" }));
            }
            if (string.IsNullOrEmpty(PhoneNumber))
            {
                errors.Add(new ValidationResult("Please Enter a valid phone number in the format of (###)###-####", new []{"PhoneNumber"}));
            }

            if (DateTime.Now < Birthday)
            {
                errors.Add(new ValidationResult("Please enter a valid Birthday", new[] { "Birthday" }));
            }

           if (string.IsNullOrEmpty(Email))
           {
               errors.Add(new ValidationResult("Please enter a valid E-Mail (ex: billybob@gmail.com)", new[] {"Email"} ));
           }
           return errors;

       }
    }
}
