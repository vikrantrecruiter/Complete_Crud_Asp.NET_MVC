using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompleteCrud_ASP.NET_MVC.Models
{
    public class CandidateDbModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="The field is required.")]
        [Display(Name ="Name")]
        [MaxLength(50,ErrorMessage ="The word should be less then 50.")]
        public string CandidateName { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "Mobile")]
        [MaxLength(50, ErrorMessage = "The word should be less then 10.")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "Email")]
        [MaxLength(50, ErrorMessage = "The word should be less then 50.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "Gender")]
        [MaxLength(50, ErrorMessage = "The word should be less then 10.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "Python")]
        public bool Python { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "Java")]
        public bool Java { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "Date of birth")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "Country")]
        public int Country { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "State")]
        public int State { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "City")]
        public int City { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="The field is required.")]
        public string Photo { get; set; }

        public string Skills { get; set; }
    }
}