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
            //saveNewApplication();
            new ApplicationListParser().addNewApplicationToList(PathTextBox.Text,ArgumentsTextBox.Text,StartCheckBox.Checked);
            this.Close();
        }

        private void saveNewApplication()
        {


            /*
            XmlReader reader = XmlReader.Create("application_list.xml");
            XmlWriter writer = XmlWriter.Create("application_listopera:speeddial
.xml");
            
            reader.MoveToContent();
            reader.Read();

            writer.WriteStartElement("applications");
            writer.WriteAttributeString("path", PathTextBox.Text);
            writer.WriteAttributeString("arguments", ArgumentsTextBox.Text);
            if (StartCheckBox.Checked == true)
            {
                writer.WriteAttributeString("default_start", "yes");
            }
            else
            {
                writer.WriteAttributeString("default_start", "no");
            }
            writer.WriteEndElement();
            */
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
