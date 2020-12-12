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
using beadando_h8slmb.Entities;

namespace beadando_h8slmb
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchList.Clear();
            if (searchText.Text  != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("subscriptions.xml");

                foreach (XmlNode node in doc.DocumentElement)
                {
                    

                    
                    if (node.FirstChild.InnerText.ToLower().Contains(searchText.Text))
                    {
                        foreach (XmlNode searchedchild in node.ChildNodes)
                        {
                            searchList.Items.Add(searchedchild.InnerText);
                        }
                        searchList.Items.Add("");
                    }
                    else
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            string childText = child.InnerText.ToLower();
                            if (childText.Contains(searchText.Text.ToLower()))
                            {
                                foreach (XmlNode searchedchild in node.ChildNodes)
                                {
                                    searchList.Items.Add(searchedchild.InnerText);
                                }
                                searchList.Items.Add("");
                            }
                        }
                    }
                    
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("subscriptions.xml");

            try
            {
                foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].InnerText;
                

                    if (searchList.SelectedItems[0].ToString().ToLower().Contains(name.ToLower()))
                    {
                        addedList.Items.Add(name);
                    }
                              
            }

            }
            catch
            {
                MessageBox.Show("Please select a subscription!");
            }
            searchList.SelectedItems.Clear();
        }
    }
}