using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Res_System
{
    public partial class Manual : Form
    {
        public string whereto = "";
        public Manual(string url)
        {
            InitializeComponent();
            whereto = url;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(whereto);
        }

        private void Manual_Load(object sender, EventArgs e)
        {
            if (whereto == "1") whereto = "http://www.ru.ac.za/deanofstudents/documents/wardensinfo";
            if (whereto == "2") whereto = "https://testmealserver.ru.ac.za/ressystem_faq.htm";

            webBrowser1.Url = new Uri(whereto);
        }
    }
}
