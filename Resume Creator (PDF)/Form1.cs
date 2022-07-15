using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text.Json;
using System.IO;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json.Serialization;

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
            public string SeniorHighSchool { get; set; }
            public string SeniorHighSchoolStatus { get; set; }
            public string JuniorHighSchool { get; set; }
            public string JuniorHighSchoolStatus { get; set; }
            public string Coursework1 { get; set; }
            public string Coursework2 { get; set; }
            public string Coursework3 { get; set; }
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            string file = "Resume1.json";
            string JsonFile;
            using (var reader = new StreamReader(file))
            {
                JsonFile = reader.ReadToEnd();
            }
            var Resume = JsonConvert.DeserializeObject<Resume>(JsonFile);

            string FirstName = Resume.FirstName;
            string MiddleName = Resume.MiddleInitial;
            string Surname = Resume.LastName;
            string Email = Resume.Email;
            string Address = Resume.CompleteAddress;
            string Zipcode = Resume.ZipCode;
            string ContactNumber = Resume.ContactNumber;
            string Skill1 = Resume.Skill1;
            string Skill2 = Resume.Skill2;
            string Skill3 = Resume.Skill3;
            string Skill4 = Resume.Skill4;
            string Skill5 = Resume.Skill5;
            string College = Resume.College;
            string CollegeStatus = Resume.CollegeStatus;
            string SeniorHighSchool = Resume.SeniorHighSchool;
            string SeniorHighSchoolStatus = Resume.SeniorHighSchoolStatus;
            string JuniorHighSchool = Resume.JuniorHighSchool;
            string JuniorHighSchoolStatus = Resume.JuniorHighSchoolStatus;
            string Coursework1 = Resume.Coursework1;
            string Coursework2 = Resume.Coursework2;
            string Coursework3 = Resume.Coursework3;
        }
    }
}