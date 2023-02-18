using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnotation.Models
{
    public class Employee
    {
        [DisplayName("Id")]
        [Required (ErrorMessage="Id is medatory")]
        public int EmpoyeeId { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is medatory")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="Name should be in between 5 and 20")]
        public string EmpoyeeName { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is medatory")]
        [Range(20,60,ErrorMessage =("Age should be in the range of 20 and 60"))]
        public int? EmpoyeeAge { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Id is medatory")]
        public string EmpoyeeGender { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is medatory")]
        [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$",ErrorMessage =("Invalid Email"))]
        public string EmpoyeeEmail { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage =("Password is mendetory"))]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$",ErrorMessage =("Invalid password"))]
        [DataType(DataType.Password)]
        public string EmpPassword { get; set; }

        [DisplayName("CondirmPassword")]
        [Required(ErrorMessage = ("Password is mendetory"))]
        [Compare("EmpPassword",ErrorMessage =("Password is not matched"))]

        [DataType(DataType.Password)]
        public string EmpConfirmPassword { get; set; }

        [DisplayName("organization")]
        [ReadOnly(true)]
        public string EmpOrganization { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = ("Address is mendetory"))]
        [DataType(DataType.MultilineText)]
        public string EmpAddress { get; set; }


        [DisplayName("JoiningDate")]
        [Required(ErrorMessage = ("Date is mendetory"))]
        [DataType(DataType.Date)]
        public string EmpJoiningData { get; set; }



        [DisplayName("JoiningTime")]
        [Required(ErrorMessage = ("Time is mendetory"))]
        [DataType(DataType.Time)]
        public string EmpJoiningTime { get; set; }
    }
}