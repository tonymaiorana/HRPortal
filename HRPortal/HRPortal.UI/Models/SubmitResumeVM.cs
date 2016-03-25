using HRPortal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRPortal.UI.Models
{
    public class SubmitResumeVM
    {
        [Required]
        public Resume Resume { get; set; }

        public List<Position> AvailiblePositions { get; set; }
        public List<Education> Educations { get; set; }
    }
}