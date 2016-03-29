using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using HRPortal.Models;

namespace HRPortal.UI.Models
{
    public class ResumeVM
    {
        public Resume newResume { get; set; }
        public List<SelectListItem> AvailablePositions { get; set; }
        public List<SelectListItem> Education { get; set; }

        public ResumeVM(List<Position> availablePositions)
        {
            AvailablePositions = new List<SelectListItem>();
            foreach (Position position in availablePositions)
            {
                SelectListItem jobTitles = new SelectListItem() { Text = position.Title, Value = position.PositionID.ToString() };
                AvailablePositions.Add(jobTitles);
            }

            Education = new List<SelectListItem>();
            foreach (var education in Enum.GetValues(typeof(Education)))
            {
                string fuckADuck = Regex.Replace(education.ToString(), @"(\B[A-Z]|[0-9]+)", " $1");
                SelectListItem educationLevel = new SelectListItem()
                {
                    Text = fuckADuck,
                    Value = education.ToString()
                };
                Education.Add(educationLevel);
            }
        }
    }
}