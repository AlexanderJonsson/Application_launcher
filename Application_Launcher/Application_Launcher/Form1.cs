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
using System.Diagnostics;

namespace Application_Launcher
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestXML();
        }

        private static void TestXML()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@"C:\Users\alex\Dropbox\Public\Programmering\Application_launcher\Application_Launcher\Application_Launcher\application_list.xml");
            foreach (XmlNode node in xdoc.SelectNodes("applications/application"))
            {
                MessageBox.Show(node.Attributes.Item(0).Value + "\n" + node.Attributes.Item(1).Value + "\n" + node.Attributes.Item(2).Value);
            }
        }

        private void test2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateApplicationList();
        }

        private void PopulateApplicationList()
        {
            applicationList.View = View.Details;
            applicationList.CheckBoxes = true;
            applicationList.AllowColumnReorder = true;
            applicationList.GridLines = true;
            applicationList.FullRowSelect = true;
            applicationList.Clear();
            applicationList.Columns.Add("Start");
            applicationList.Columns.Add("Path");
            applicationList.Columns.Add("Arguments");

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@"C:\Users\alex\Dropbox\Public\Programmering\Application_launcher\Application_Launcher\Application_Launcher\application_list.xml");
            foreach (XmlNode node in xdoc.SelectNodes("applications/application"))
            {
                string[] row = {"", node.Attributes.Item(0).Value, node.Attributes.Item(1).Value };
                ListViewItem it = new ListViewItem(row);
                //applicationList.Items.Add("").SubItems.AddRange(row);
                if (node.Attributes.Item(2).Value == "yes")
                {
                    it.Checked = true;
                }
                applicationList.Items.Add(it);           
            }
        }

        private void applicationList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            label1.Text = applicationList.SelectedItems[0].SubItems[1].Text;
            label1.Text = e.Item.Selected.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            startApplications();
        }

        private void startApplications()
        {
            foreach (ListViewItem li in applicationList.Items){
                if (li.Checked == true)
                {
                    Process.Start(li.SubItems[1].Text);
                }
            }
            //Process.Start
        }
    }
}
