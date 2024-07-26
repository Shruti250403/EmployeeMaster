﻿using System;
using System.ComponentModel.DataAnnotations;
using CivicaEmployeeMaster.Models; // Assuming this namespace is correct

namespace CivicaEmployeeMaster.Dtos
{
    public class UpdateEmployeeDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Department ID is required")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Employee email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
        public string EmployeeEmail { get; set; }


        [Required(ErrorMessage = "First name is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name must only contain alphabetic characters")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First name must be between 3 and 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last name must only contain alphabetic characters")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last name must be between 3 and 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Gender must be a single character")]
        [RegularExpression(@"^[MF]$", ErrorMessage = "Gender must be 'M' or 'F'")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Basic salary is required")]
        public decimal BasicSalary { get; set; }

        [Required(ErrorMessage = "Allowance is required")]
        public decimal Allowance { get; set; }

        [Required(ErrorMessage = "Date of joining is required")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format")]
        public DateTime DateOfJoining { get; set; }
    }
}