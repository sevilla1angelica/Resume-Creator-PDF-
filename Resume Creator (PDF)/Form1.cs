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
        public ResumeForm()
        {
            InitializeComponent();
        }


        static void Form1_Load(object sender, EventArgs e)
        {
            var path = @"C:\Users\HP\OneDrive\Desktop\C# Programs\Resume Creator (PDF)\new 1.json";
            var json = JsonConvert.DeserializeObject<data>(File.ReadAllText(path));
        }

        public class data
        {
            public string name { get; set; }
            public string email { get; set; }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }
    }
}