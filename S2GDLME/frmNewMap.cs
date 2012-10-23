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
    public partial class frmNewMap : Form
    {


        frmMain main;
        public frmNewMap()
        {
            InitializeComponent();
        }

        private void btnNewMap_Click(object sender, EventArgs e)
        {
            int width;
            int height;
            width = int.Parse(txtWidth.Text);
            height = int.Parse(txtHeight.Text);

            main.createNewMap(width, height);
            this.Hide();

        }

        public void init(frmMain main)
        {
            this.main = main;
        }

        
    }
}
