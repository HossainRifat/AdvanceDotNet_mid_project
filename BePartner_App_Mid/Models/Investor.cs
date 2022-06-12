﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BePartner_App_Mid.Models
{
    public class Investor
    {
        [Required(ErrorMessage = "Name required")]
        [RegularExpression("^[A-Za-z ]*$", ErrorMessage ="Invalid Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Name required")]
        [RegularExpression("^[A-Za-z ]*$", ErrorMessage = "Invalid Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of birth required")]
        [CustomValidation.CustomValid]
        public string Dob { get; set; }

        [Required(ErrorMessage = "Address required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone required")]
        [RegularExpression("[0]{1}[1]{1}[7,9,6,5,3]{1}[0-9]{8}", ErrorMessage ="Invalid Number")]
        public string Phone { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Invalid Email")]
        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "NID required")]
        [RegularExpression("^([0-9]{10}|[0-9]{13})$",ErrorMessage ="Invalid NID Number")]
        public string Nid { get; set; }


        [Required(ErrorMessage = "Organization name required")]
        [StringLength(100,MinimumLength =3,ErrorMessage ="Invalid! Full name required")]
        public string OrgName { get; set; }

        [Required(ErrorMessage = "Established date required")]
        public int OrgEstablished { get; set; }

        [Required(ErrorMessage = "Organization location required")]
        [StringLength(5000, MinimumLength = 5, ErrorMessage = "Invalid! Full address required")]
        public string OrgLocation { get; set; }

        [Required(ErrorMessage = "Organization email required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Invalid emial")]
        public string OrgEmail { get; set; }

        [Required(ErrorMessage = "Organization phone required")]
        [RegularExpression("[0]{1}[1]{1}[7,9,6,5,3]{1}[0-9]{8}", ErrorMessage = "Invalid Phone")]
        public string OrgPhone { get; set; }

        [Required(ErrorMessage = "Organization license required")]
        [RegularExpression("[0-9]{5,15}",ErrorMessage ="Invalid license number")]
        public string OrgLicense  { get; set; }

        [Required(ErrorMessage = "TIN required")]
        [RegularExpression("[0-9]{5,15}", ErrorMessage = "Invalid TIN")]
        public string Tin { get; set; }

        [Required(ErrorMessage = "Organization site required")]
        [RegularExpression("(http|http(s)?://)?([\\w-]+\\.)+[\\w-]+[.com|.in|.org]+(\\[\\?%&=]*)?", ErrorMessage ="Invalid site")]
        public string OrgSite { get; set; }

        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password required")]
        public string ConfirmPassword { get; set; }

    }
}