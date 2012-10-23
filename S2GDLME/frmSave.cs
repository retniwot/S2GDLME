using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace S2GDLME
{
    public partial class frmSave : Form
    {
        frmMain main;

        public frmSave()
        {
            InitializeComponent();
        }

        private void frmSave_Load(object sender, EventArgs e)
        {
            
        }

        public void init(frmMain main)
        {
            this.main = main;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            main.saveMap(txtName.Text);
            this.Hide();
        }
    }
}
