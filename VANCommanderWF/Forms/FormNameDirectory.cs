using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VANCommanderWF.Forms
{
    public partial class FormNameDirectory : Form
    {

        Bll bll = new Bll();
        public FormNameDirectory(string path1, string path2, ListBox listBox1, ListBox listBox2)
        {
            InitializeComponent();
            Path1 = path1;
            Path2 = path2;
            ListBox1 = listBox1;
            ListBox2 = listBox2;
        }

        public string Path1 { get; set; }
        public string Path2 { get; set; }
        public ListBox ListBox1 { get; set; }
        public ListBox ListBox2 { get; set; }

        private void btn_nameDirectory_Click(object sender, EventArgs e)
        {
            new Bll().CreateDirectory(Path1, txb_nameDirectory.Text.Trim());
            Close();
        }

        private void FormNameDirectory_FormClosed(object sender, FormClosedEventArgs e)
        {
            bll.GetAllFolderAndFiles(ListBox1, Path1);
            bll.GetAllFolderAndFiles(ListBox2, Path2);
        }
    }
}
