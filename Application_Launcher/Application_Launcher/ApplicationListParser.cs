using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace Application_Launcher
{
    class ApplicationListParser
    {
        private string applicationListFilePath="application_list.xml";
        public IEnumerable<ListViewItem> getUpdatedApplicationList()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(applicationListFilePath);
            foreach (XmlNode node in xdoc.SelectNodes("applications/application"))
            {
                string[] row = { "", node.Attributes.Item(0).Value, node.Attributes.Item(1).Value,node.Attributes.Item(3).Value };
                ListViewItem it = new ListViewItem(row);
                if (node.Attributes.Item(2).Value == "yes")
                {
                    it.Checked = true;
                }
                yield return it;
            }
        }
        public void createNewApplicationList(){
            var initialList = XmlWriter.Create(applicationListFilePath);
            initialList.WriteStartDocument();
            initialList.WriteStartElement("applications");
            initialList.WriteEndElement();
            initialList.WriteEndDocument();
            initialList.Close();
        }

        public void addNewApplicationToList(string path, string arguments, bool start)
        {           
            var applicationListFile = new XmlDocument();
            try
            {
                applicationListFile.Load(applicationListFilePath);
            }
            catch
            {
                createNewApplicationList();
                applicationListFile.Load(applicationListFilePath);
            }
            finally
            {
                var node = applicationListFile.CreateElement("application");
                node.SetAttribute("path", path);
                node.SetAttribute("arguments", arguments);
                if (start == false) { node.SetAttribute("default_start", "no"); }
                else if (start == true) { node.SetAttribute("default_start", "yes"); }
                node.SetAttribute("id", System.DateTime.Now.ToString());
                applicationListFile.DocumentElement.AppendChild(node);
                applicationListFile.Save(applicationListFilePath);
            }
        }
        public void deleteApplicationFromList(string id)
        {
            var applicationListFile = new XmlDocument();
            applicationListFile.Load(applicationListFilePath);
            var node = applicationListFile.SelectSingleNode("//application[@id='" + id + "']");
            node.ParentNode.RemoveChild(node);
            applicationListFile.Save(applicationListFilePath);
        }

        public void changeStartDefault(string id)
        {
            var applicationListFile = new XmlDocument();
            applicationListFile.Load(applicationListFilePath);
            var node = applicationListFile.SelectSingleNode("//application[@id='" + id + "']");
            if (node.Attributes[2].Value == "no") { node.Attributes[2].Value = "yes"; }
            else { node.Attributes[2].Value = "no"; }
            applicationListFile.Save(applicationListFilePath);
        }
    }
}