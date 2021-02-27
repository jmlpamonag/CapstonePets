using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapstonePets.Models
{
    public class OwnerModel
    {
        [Display(Name = "First Name")]
        public string strFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string strLastName { get; set; }

        [Display(Name = "Address")]
        public string strAddress { get; set; }

        [Display(Name = "State")]
        public int intStateID { get; set; }

        [Display(Name = "City")]
        public string strCity { get; set; }

        [Display(Name = "Zip")]
        public string strZip { get; set; }

        [Display(Name = "Email Address")]
        public string strEmail { get; set; }

        [Display(Name = "Gender")]
        public int intGenderID { get; set; }

        [Display(Name = "Phone Number")]
        public string strPhoneNumber { get; set; }

        [Display(Name = "Second Owner Name")]
        public string strSecondaryOwnerName { get; set; }

        [Display(Name = "Second Owner Phone Number")]
        public string strSecondaryOwnerPhoneNumber { get; set; }

        [Display(Name = "Second Owner Email Address")]
        public string strSecondaryOwnerEmailAddress { get; set; }

        [Display(Name = "Notes")]
        public string strNotes { get; set; }
    }
}