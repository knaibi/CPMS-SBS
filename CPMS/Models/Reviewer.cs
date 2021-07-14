﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

//Setup for reviewer class, all the data to set up a reviewer and their data
namespace CPMS.Models
{
    public partial class Reviewer
    {
        public Reviewer()
        {
            Review = new HashSet<Review>();
        }

        [Key]
        [Column("ReviewerID")]
        [Required]
        public int ReviewerId { get; set; }


        [Required]
        public bool Active { get; set; }


        [Required]
        [StringLength(50)]
        [RegularExpression("[A-Za-z]+")]//letters only
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [StringLength(1)]
        [Display(Name = "MI")]
        [RegularExpression("[A-Za-z]+")]//letters only
        public string MiddleInitial { get; set; }


        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        [RegularExpression("[A-Za-z]+")]//letters only
        public string LastName { get; set; }


        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-z0-9\s]*$")]//letters, numbers and space
        public string Affiliation { get; set; }


        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-z0-9\s]*$")]//letters, numbers and space
        public string Department { get; set; }


        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z0-9\s-.]*$")]//letters, space, numbers, and dash
        public string Address { get; set; }


        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-z\s]*$")]//letters and space
        public string City { get; set; }


        [Required]
        [StringLength(2)]
        [RegularExpression("[A-Za-z]+")]//letters only
        public string State { get; set; }


        [Required]
        [StringLength(10)]
        [RegularExpression(@"^[0-9-]*$")]//numbers and dashes only
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }


        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[0-9-()]*$")]//numbers ,dashes, parentheses
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }


        [Required]
        [StringLength(5)]
        public string Password { get; set; }

        public bool AnalysisOfAlgorithms { get; set; }


        public bool Applications { get; set; }


        public bool Architecture { get; set; }


        [Display(Name = "Artifical Intelligence")]
        public bool ArtificialIntelligence { get; set; }


        [Display(Name = "Computer Engineering")]
        public bool ComputerEngineering { get; set; }


        public bool Curriculum { get; set; }


        [Display(Name = "Data Structures")]
        public bool DataStructures { get; set; }


        public bool Databases { get; set; }


        [Display(Name = "Distanced Learning")]
        public bool DistancedLearning { get; set; }


        [Display(Name = "Distributed Systems")]
        public bool DistributedSystems { get; set; }


        [Display(Name = "Ethical Societal Issues")]
        public bool EthicalSocietalIssues { get; set; }


        [Display(Name = "First Year Computing")]
        public bool FirstYearComputing { get; set; }


        [Display(Name = "Gender Issues")]
        public bool GenderIssues { get; set; }


        [Display(Name = "Grant Writing")]
        public bool GrantWriting { get; set; }


        [Display(Name = "Graphics Image Processing")]
        public bool GraphicsImageProcessing { get; set; }


        [Display(Name = "Human Computer Interaction")]
        public bool HumanComputerInteraction { get; set; }


        [Display(Name = "Labortatory Environments")]
        public bool LaboratoryEnvironments { get; set; }


        public bool Literacy { get; set; }

        [Display(Name = "Mathmetics In Computing")]
        public bool MathematicsInComputing { get; set; }


        public bool Multimedia { get; set; }


        [Display(Name = "Networking Data Communications")]
        public bool NetworkingDataCommunications { get; set; }


        [Display(Name = "Non-Major Courses")]
        public bool NonMajorCourses { get; set; }


        [Display(Name = "Object Oriented Issues")]
        public bool ObjectOrientedIssues { get; set; }


        [Display(Name = "Operating Systems")]
        public bool OperatingSystems { get; set; }


        [Display(Name = "Parallel Processing")]
        public bool ParallelProcessing { get; set; }


        public bool Pedagogy { get; set; }


        [Display(Name = "Programming Languages")]
        public bool ProgrammingLanguages { get; set; }


        public bool Research { get; set; }


        public bool Security { get; set; }


        [Display(Name = "Software Engineering")]
        public bool SoftwareEngineering { get; set; }


        [Display(Name = "Systems Analysis Design")]
        public bool SystemsAnalysisAndDesign { get; set; }


        [Display(Name = "Using Technology in The Classroom")]
        public bool UsingTechnologyInTheClassroom { get; set; }


        [Display(Name = "Web And Internet Programming")]
        public bool WebAndInternetProgramming { get; set; }


        public bool Other { get; set; }


        [Display(Name = "Other Description")]
        [StringLength(50)]
        public string OtherDescription { get; set; }


        [Display(Name = "Reviews Acknowledged")]
        public bool ReviewsAcknowledged { get; set; }


        [InverseProperty("Reviewer")]
        public virtual ICollection<Review> Review { get; set; }
    }
}
