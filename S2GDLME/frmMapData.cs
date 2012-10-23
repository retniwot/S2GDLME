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
    public partial class frmMapData : Form
    {
        Map map;

        public frmMapData()
        {
            InitializeComponent();
        }

        private void frmMapData_Load(object sender, EventArgs e)
        {

        }

        public void initMap(Map map)
        {
            this.map = map;

            for (int y = 0; y < map.mapArray.GetLength(1); y++)
            {
                for (int x = 0; x < map.mapArray.GetLength(0); x++)
                {
                    txtMapData.Text += Environment.NewLine + "Tile - X: " + map.mapArray[x, y].X + ", Y: " + map.mapArray[x, y].Y + ", ID: " + map.mapArray[x, y].ID;
                }
            }

            for (int i = 0; i < map.objectArray.Count; i++)
            {
                txtMapData.Text += Environment.NewLine + "Object - X: " + map.objectArray[i].X + ", Y: " + map.objectArray[i].Y + ", ID: " + map.objectArray[i].ID;
            }
        }

        private void txtMapData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
