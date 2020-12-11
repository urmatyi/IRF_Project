using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace beadando_h8slmb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            searchList.Clear();
            if (searchText.Text  != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("subscriptions.xml");

                foreach (XmlNode node in doc.DocumentElement)
                {
                    string name = node.Attributes[0].InnerText;
                    if (name == searchText.Text)
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            searchList.Items.Add(child.InnerText);
                        }
                    }
                }
            }
        }
    }
}