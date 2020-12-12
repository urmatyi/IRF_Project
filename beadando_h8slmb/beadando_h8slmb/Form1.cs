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

        List<Subscription> newitem = new List<Subscription>();

        private void addButton_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;

            string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string type = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string price = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string subtype = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            var sub = new Subscription();
            newitem.Add(sub);
            sub.Name = name;
            sub.Type = type;
            sub.Price = price;
            sub.SubType = subtype;
            
            dataGridView2.DataSource = newitem;
            
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            var searchedList = subList.Where(s => s.Name.ToLower().Contains(searchText.Text.ToLower()) ||
                                             s.Type.ToLower().Contains(searchText.Text.ToLower())).ToList();
            dataGridView1.DataSource = searchedList;
        }
    }
}