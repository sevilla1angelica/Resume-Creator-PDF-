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

            lblFirstname.Text = firstname;
            lblMiddleInitial.Text = middleinitial;
            lblLastname.Text = lastname;
            Firstnamelbl.Text = firstname;
            MiddleInitiallbl.Text = middleinitial;
            LastNamelbl.Text = lastname;
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
                    int initialleft = 150;
                    int marginright = 390;
                    int initialright = 100;

                    string png = @"C:\Users\HP\OneDrive\Desktop\C# Programs\Resume Creator (PDF)\ID_resume.png";
                    XImage image = XImage.FromFile(png);
                    graphics.DrawImage(image, 385, 120, 175, 175);

                    graphics.DrawString(firstname, namefont, XBrushes.Black, new XRect(marginleft, initialleft + 1, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(middleinitial, namefont, XBrushes.Black, new XRect(marginleft, initialleft + 15, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(lastname, namefont, XBrushes.Black, new XRect(marginleft, initialleft + 30, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);

                    graphics.DrawRectangle(lineforleft, marginleft, initialleft + 65, 160, 1);

                    graphics.DrawString("Email :" + email, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 70, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString("Contact Number : " + contactnumber, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 85, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString("Address : " + address, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 100, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString("Zip Code : " + zipcode, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 115, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);

                    graphics.DrawString("Education Background : ", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 155, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawRectangle(lineforleft, marginleft, initialleft + 170, 160, 1);
                    graphics.DrawString("College : ", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 175, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(college, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 190, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(collegestatus, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 205, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString("Senior High School : ", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 225, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(seniorhighschool, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 240, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(seniorhighschoolstatus, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 255, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString("Junior High School : ", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 275, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(juniorhighschool, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 290, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(juniorhighstatus, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 305, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);

                    graphics.DrawString("Skills : ", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 335, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawRectangle(lineforleft, marginleft, initialleft + 350, 160, 1);
                    graphics.DrawString(skill1, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 355, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(skill2, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 370, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(skill3, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 385, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(skill4, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 400, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(skill5, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 415, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);

                    graphics.DrawString("Coursework Related : ", bigfont, XBrushes.Black, new XRect(marginright, initialright + 205, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawRectangle(lineforright, marginright, initialright + 220, 130, 1);
                    graphics.DrawString(coursework1, smallfont, XBrushes.Black, new XRect(marginright, initialright + 230, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(coursework2, smallfont, XBrushes.Black, new XRect(marginright, initialright + 245, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);
                    graphics.DrawString(coursework3, smallfont, XBrushes.Black, new XRect(marginright, initialright + 260, page.Width.Point, page.Height.Point), XStringFormat.TopLeft);

                    pdf.Save(saveFile.FileName);
                    MessageBox.Show("You have generated your JSON File to PDF. Please do proceed to the folder. Thank you! ","It's a success!");
                }
            }
        }
    }
}
