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
        public FormNameDirectory(string path)
        {
            InitializeComponent();
            this.Path = path;
        }

        public string Path { get; set; }

        private void btn_nameDirectory_Click(object sender, EventArgs e)
        {
            new Bll().CreateDirectory(Path, txb_nameDirectory.Text);
            Close();
        }
    }
}
