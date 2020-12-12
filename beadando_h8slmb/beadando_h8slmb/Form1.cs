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
        //BindingList<Subscription> Subscriptions = new BindingList<Subscription>();
        List<Subscription> subList = new List<Subscription>();

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
            
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            var searchedList = subList.Where(p => p.Name.ToLower().Contains(searchText.Text) ||
                                             p.Type.ToLower().Contains(searchText.Text)).ToList();
            dataGridView1.DataSource = searchedList;
        }
    }
}