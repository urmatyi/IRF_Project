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
        List<Subscription> subList = new List<Subscription>();
        List<Subscription> yoursub = new List<Subscription>();
        public Form1()
        {
            InitializeComponent();

            XmlLoad();

        }

        private void XmlLoad()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("subscriptions.xml");

            XmlNodeList nodeList = xml.SelectNodes("/subscriptions/subscription");
            foreach (XmlNode node in nodeList)
            {
                string name = node["name"].InnerText;
                string type = node["type"].InnerText;
                string price = node["price"].InnerText;
                string subtype = node["subtype"].InnerText;

                var sub = new Subscription();
                subList.Add(sub);

                sub.Name = name;
                sub.Type = type;
                sub.Price = price;
                sub.SubType = subtype;
            }

            dataGridView1.DataSource = subList;
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            
            string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string type = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string price = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string subtype = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            var sub = new Subscription();
            yoursub.Add(sub);
            sub.Name = name;
            sub.Type = type;
            sub.Price = price;
            sub.SubType = subtype;
            
            dataGridView2.DataSource = yoursub;
            
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            var searchedList = subList.Where(s => s.Name.ToLower().Contains(searchText.Text.ToLower()) ||
                                             s.Type.ToLower().Contains(searchText.Text.ToLower())).ToList();
            dataGridView1.DataSource = searchedList;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (removeCombo.SelectedIndex==0)
            {
                dataGridView2.DataSource = null;

                var itemToRemove = yoursub.FirstOrDefault(r => r.Name.ToLower().Contains(removeText.Text.ToLower()));
                yoursub.Remove(itemToRemove);
                dataGridView2.DataSource = yoursub;
            }
            else
            {
                if (removeCombo.SelectedIndex == 1)
                {
                    dataGridView2.DataSource = null;

                    var itemToRemoveList = yoursub.Where(r => r.Type.ToLower().Contains(removeText.Text.ToLower())).ToList();
                    yoursub = yoursub.Except(itemToRemoveList).ToList();
                    dataGridView2.DataSource = yoursub;
                }
                else
                {
                    MessageBox.Show("Please select an item from the Remove by list.");
                }
            }
            
        }
    }
}