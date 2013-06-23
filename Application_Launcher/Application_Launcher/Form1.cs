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
            applicationList.ItemChecked -= applicationList_ItemChecked;
            applicationList.View = View.Details;
            applicationList.CheckBoxes = true;
            applicationList.AllowColumnReorder = true;
            applicationList.GridLines = true;
            applicationList.FullRowSelect = true;
            applicationList.Clear();
            applicationList.Columns.Add("Start");
            applicationList.Columns.Add("Path");
            applicationList.Columns.Add("Arguments");
            applicationList.Columns.Add("Added");
       
            foreach (ListViewItem item in new ApplicationListParser().getUpdatedApplicationList())
            {
                applicationList.Items.Add(item);
            }
            applicationList.ItemChecked += applicationList_ItemChecked;
        }

        private void createNewApplicationList()
        {
            PopulateApplicationList();
        }

        private void applicationList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            new ApplicationListParser().changeStartDefault(applicationList.Items[e.Item.Index].SubItems[3].Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            startApplications();
            button4.Enabled = false;
            timer1.Start();
        }

        private void startApplications()
        {
            foreach (ListViewItem li in applicationList.Items){
                if (li.Checked == true)
                {
                    Process.Start(li.SubItems[1].Text);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button4.Enabled = true;
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (new Add_application().ShowDialog() == DialogResult.OK)
            {
                PopulateApplicationList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                new ApplicationListParser().deleteApplicationFromList(applicationList.SelectedItems[0].SubItems[3].Text);
                PopulateApplicationList();
            }
            catch { showTip("Please select an item to remove"); }
            
        }

        private void tipTimer_Tick(object sender, EventArgs e)
        {
            label1.Hide();
            tipTimer.Stop();
        }
        private void showTip(string tip)
        {
            label1.Text = tip;
            label1.Show();
            tipTimer.Start();
        }

        private void aboutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AboutBox1().Show();
        }
    }
}
