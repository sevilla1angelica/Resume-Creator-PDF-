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
        }
    }
}