using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.IO;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfDocument = PdfSharp.Pdf.PdfDocument;
using PdfPage = PdfSharp.Pdf.PdfPage;

namespace Resume_Creator__PDF_
{
    public partial class ResumeForm : Form
    {
        public ResumeForm()
        {
            InitializeComponent();
            string file = @"C:\Users\HP\OneDrive\Desktop\C# Programs\Resume Creator (PDF)\Resume1.json";
            string JsonInfo = File.ReadAllText(file);

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            string str = File.ReadAllText(@"C:\Users\HP\OneDrive\Desktop\C# Programs\Resume Creator (PDF)\Resume1.json");

            var Resume = JsonConvert.DeserializeObject<Resume>(str);

            string profilesummary_1 = Resume.ProfileSummary_1;
            string profilesummary_2 = Resume.ProfileSummary_2;
            string profilesummary_3 = Resume.ProfileSummary_3;
            string profilesummary_4 = Resume.ProfileSummary_4;
            string profilesummary_5 = Resume.ProfileSummary_5;
            string profilesummary_6 = Resume.ProfileSummary_6;
            string firstname = Resume.FirstName;
            string middleinitial = Resume.MiddleInitial;
            string lastname = Resume.LastName;
            string email = Resume.Email;
            string address = Resume.CompleteAddress;
            string zipcode = Resume.ZipCode;
            string contactnumber = Resume.ContactNumber;
            string skill1 = Resume.Skill1;
            string skill2 = Resume.Skill2;
            string skill3 = Resume.Skill3;
            string skill4 = Resume.Skill4;
            string skill5 = Resume.Skill5;
            string college = Resume.College;
            string collegestatus = Resume.CollegeStatus;
            string seniorhighschool = Resume.SeniorHighSchool;
            string seniorhighstatus = Resume.SeniorHighStatus;
            string juniorhighschool = Resume.JuniorHighSchool;
            string juniorhighstatus = Resume.juniorhighstatus;
            string coursework1 = Resume.Coursework1;
            string coursework2 = Resume.Coursework2;
            string coursework3 = Resume.Coursework3;

            lblProfileSummary_1.Text = profilesummary_1;
            lblProfileSummary_2.Text = profilesummary_2;
            lblProfileSummary_3.Text = profilesummary_3;
            lblProfileSummary_4.Text = profilesummary_4;
            lblProfileSummary_5.Text = profilesummary_5;
            lblProfileSummary_6.Text = profilesummary_6;
            lblFirstname.Text = firstname;
            lblMiddleInitial.Text = middleinitial;
            lblLastname.Text = lastname;
            lblProfileSummary_1.Text = firstname;
            lblProfileSummary_2.Text = middleinitial;
            lblProfileSummary_3.Text = lastname;
            lblEmail.Text = email;
            lblAddress.Text = address;
            lblZipCode.Text = zipcode;
            lblContact.Text = contactnumber;
            lblSkill1.Text = skill1;
            lblSkill2.Text = skill2;
            lblSkill3.Text = skill3;
            lblSkill4.Text = skill4;
            lblSkill5.Text = skill5;
            lblCollege.Text = college;
            lblCollegeStatus.Text = collegestatus;
            lblSeniorHigh.Text = seniorhighschool;
            lblSeniorHighStatus.Text = seniorhighstatus;
            lblJuniorHigh.Text = juniorhighschool;
            lblJuniorHighStatus.Text = juniorhighstatus;
            lblCoursework1.Text = coursework1;
            lblCoursework2.Text = coursework2;
            lblCoursework3.Text = coursework3;
        }

        public class Resume
        {
            public string ProfileSummary_1 { get; set; }
            public string ProfileSummary_2 { get; set; }
            public string ProfileSummary_3 { get; set; }
            public string ProfileSummary_4 { get; set; }
            public string ProfileSummary_5 { get; set; }
            public string ProfileSummary_6 { get; set; }
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
            public string SeniorHighStatus { get; set; }
            public string JuniorHighSchool { get; set; }
            public string juniorhighstatus { get; set; }
            public string Coursework1 { get; set; }
            public string Coursework2 { get; set; }
            public string Coursework3 { get; set; }
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            string file = File.ReadAllText(@"C:\Users\HP\OneDrive\Desktop\C# Programs\Resume Creator (PDF)\Resume1.json");

            var Resume = JsonConvert.DeserializeObject<Resume>(file);

            string profilesummary_1 = Resume.ProfileSummary_1;
            string profilesummary_2 = Resume.ProfileSummary_2;
            string profilesummary_3 = Resume.ProfileSummary_3;
            string profilesummary_4 = Resume.ProfileSummary_4;
            string profilesummary_5 = Resume.ProfileSummary_5;
            string profilesummary_6 = Resume.ProfileSummary_6;
            string firstname = Resume.FirstName;
            string middleinitial = Resume.MiddleInitial;
            string lastname = Resume.LastName;
            string email = Resume.Email;
            string address = Resume.CompleteAddress;
            string zipcode = Resume.ZipCode;
            string contactnumber = Resume.ContactNumber;
            string skill1 = Resume.Skill1;
            string skill2 = Resume.Skill2;
            string skill3 = Resume.Skill3;
            string skill4 = Resume.Skill4;
            string skill5 = Resume.Skill5;
            string college = Resume.College;
            string collegestatus = Resume.CollegeStatus;
            string seniorhighschool = Resume.SeniorHighSchool;
            string seniorhighschoolstatus = Resume.SeniorHighStatus;
            string juniorhighschool = Resume.JuniorHighSchool;
            string juniorhighstatus = Resume.juniorhighstatus;
            string coursework1 = Resume.Coursework1;
            string coursework2 = Resume.Coursework2;
            string coursework3 = Resume.Coursework3;


            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "PDF File|*.pdf" })
            {
                saveFile.InitialDirectory = @"C:\Users\HP\OneDrive\Desktop\C# Programs\Resume Creator (PDF)";
                saveFile.FileName = lastname + " " + firstname + ".pdf";



                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = "Resume";
                    PdfPage page = pdf.AddPage();

                    XGraphics graphics =XGraphics.FromPdfPage(page);

                    XFont bigfont = new XFont("Century Gothic", 14, XFontStyle.Bold);
                    XFont smallfont = new XFont("Century Gothic", 12, XFontStyle.Italic);
                    XFont namefont = new XFont("Century Gothic", 18, XFontStyle.Bold);
                    XFont headfont = new XFont("Century Gothic", 30, XFontStyle.Bold);

                    XPen pen = new XPen(XColors.Black, 20);
                    XPen lineforleft = new XPen(XColors.Black, 1); ;
                    XPen lineforright = new XPen(XColors.Black, 1); ;

                    graphics.DrawRoundedRectangle(XBrushes.Gray, 0, 0, page.Width.Point, page.Height.Point, 0, 0);
                    graphics.DrawRectangle(pen, 0, 0, page.Width.Point, page.Height.Point);

                    graphics.DrawString("RESUME", headfont, XBrushes.Black, new XRect(0, 50, page.Width.Point - 20, page.Height.Point - 80),XStringFormat.TopCenter);

                    int marginleft = 25;
                    int initialleft = 125;
                    int marginright = 390;
                    int initialright = 100;

                    string png = @"C:\Users\HP\OneDrive\Desktop\C# Programs\Resume Creator (PDF)\ID_resume.png";
                    XImage image = XImage.FromFile(png);
                    graphics.DrawImage(image, 385, 120, 175, 175);

                    graphics.DrawString(firstname, namefont, XBrushes.Black, new XRect(marginleft, initialleft + 1, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(middleinitial, namefont, XBrushes.Black, new XRect(marginleft, initialleft + 15, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(lastname, namefont, XBrushes.Black, new XRect(marginleft, initialleft + 30, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);

                    graphics.DrawRectangle(lineforleft, marginleft, initialleft + 65, 160, 1);

                    graphics.DrawString("Email :" + email, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 80, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString("Contact Number : " + contactnumber, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 95, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString("Address : " + address, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 110, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString("Zip Code : " + zipcode, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 125, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);

                    graphics.DrawRectangle(lineforleft, marginleft, initialleft + 160, 300, 1);

                    graphics.DrawString("Profile Summary", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 185, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawRectangle(lineforleft, marginleft, initialleft + 201, 116, 1);
                    graphics.DrawString(profilesummary_1, smallfont, XBrushes.Black, new XRect(marginleft - 25, initialleft + 210, page.Width.Point, page.Height.Point), XStringFormat.TopCenter);
                    graphics.DrawString(profilesummary_2, smallfont, XBrushes.Black, new XRect(marginleft - 25, initialleft + 225, page.Width.Point, page.Height.Point), XStringFormat.TopCenter);
                    graphics.DrawString(profilesummary_3, smallfont, XBrushes.Black, new XRect(marginleft - 25, initialleft + 240, page.Width.Point, page.Height.Point), XStringFormat.TopCenter);
                    graphics.DrawString(profilesummary_4, smallfont, XBrushes.Black, new XRect(marginleft - 25, initialleft + 255, page.Width.Point, page.Height.Point), XStringFormat.TopCenter);
                    graphics.DrawString(profilesummary_5, smallfont, XBrushes.Black, new XRect(marginleft - 25, initialleft + 270, page.Width.Point, page.Height.Point), XStringFormat.TopCenter);
                    graphics.DrawString(profilesummary_6, smallfont, XBrushes.Black, new XRect(marginleft - 25, initialleft + 285, page.Width.Point, page.Height.Point), XStringFormat.TopCenter);

                    graphics.DrawString("Education Background : ", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 315, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawRectangle(lineforleft, marginleft, initialleft + 330, 160, 1);
                    graphics.DrawString("College : ", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 340, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(college, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 355, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(collegestatus, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 370, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString("Senior High School : ", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 390, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(seniorhighschool, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 405, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(seniorhighschoolstatus, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 420, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString("Junior High School : ", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 440, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(juniorhighschool, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 455, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(juniorhighstatus, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 470, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);

                    graphics.DrawString("Skills : ", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 513, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawRectangle(lineforleft, marginleft, initialleft + 529, 45, 1);
                    graphics.DrawString(skill1, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 540, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(skill2, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 555, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(skill3, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 570, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(skill4, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 585, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(skill5, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 600, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);

                    graphics.DrawString("Coursework Related : ", bigfont, XBrushes.Black, new XRect(marginright, initialright + 340, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawRectangle(lineforright, marginright, initialright + 354, 130, 1);
                    graphics.DrawString(coursework1, smallfont, XBrushes.Black, new XRect(marginright, initialright + 360, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(coursework2, smallfont, XBrushes.Black, new XRect(marginright, initialright + 375, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(coursework3, smallfont, XBrushes.Black, new XRect(marginright, initialright + 390, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);

                    pdf.Save(saveFile.FileName);
                    MessageBox.Show("You have generated your JSON File to PDF. Please do proceed to the folder. Thank you! ","It's a success!");
                }
            }
        }
    }
}
