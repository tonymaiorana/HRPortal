using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    //are we using enum or????????????
    public class Position
    {
        public string Title { get; set; }
        [Required (ErrorMessage = "Please select the position you are applying for. ")]
        public int PositionID { get; set; }
    }
}
