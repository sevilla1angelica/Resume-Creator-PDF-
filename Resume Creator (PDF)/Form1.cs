using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text.Json;
using System.IO;
using System.Collections.ObjectModel;
using System.Linq;

namespace Resume_Creator__PDF_
{
    public partial class ResumeForm : Form
    {
        string file = @"C:\Users\HP\OneDrive\Desktop\C# Programs\Resume Creator (PDF)\Resume1.json";
        public ResumeForm()
        {
            InitializeComponent();
            string file = @"C:\Users\HP\OneDrive\Desktop\C# Programs\Resume Creator (PDF)\Resume1.json";
            string JsonInfo = File.ReadAllText(file);

        }

        public class Resume
        {
            public string FirstName { get; set; }
            public string MiddleInitial { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string CompleteAddress { get; set; }
            public string ZipCode { get; set; }
            public string ContactNumber { get; set; }
            public string Skill1 { get; set; }
            public string Skill2 { get; set; }
            public string Skill3 { get; set; }
            public string Skill4 { get; set; }
            public string Skill5 { get; set; }
            public string College { get; set; }
            public string CollegeStatus { get; set; }
            public string SeniorHighScgool { get; set; }
            public string SeniorHighSchoolStatus { get; set; }
            public string JuniorHighSchool { get; set; }
            public string JuniorHighSchoolStatus { get; set; }
            public string Coursework1 { get; set; }
            public string Coursework2 { get; set; }
            public string Coursework3 { get; set; }
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
        }
    }
}