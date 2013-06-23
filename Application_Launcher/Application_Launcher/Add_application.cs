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

namespace Application_Launcher
{
    public partial class Add_application : Form
    {
        public Add_application()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            new ApplicationListParser().addNewApplicationToList(PathTextBox.Text,ArgumentsTextBox.Text,StartCheckBox.Checked);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_application_Load(object sender, EventArgs e)
        {
            this.Icon = Application_Launcher.Properties.Resources.Franksouza183_Fs_Apps_aptana;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectFile = new OpenFileDialog();
            selectFile.ShowDialog();
            PathTextBox.Text = selectFile.FileName;
        }
    }
}
