using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using S2DGL;
using System.IO;

namespace S2GDLME
{
    public partial class frmMain : Form
    {
      

        //tile selected
        int tileSelected;

        
        bool tileMode;
        bool unitMode;

        int mapLayer = 0;

        public frmMain()
        {
            InitializeComponent();

           
        }

        private void picTiles_Click(object sender, EventArgs e)
        {

            //wheres the mapContorl start
            int xOffset = picTiles.Location.X;
            int yOffset = picTiles.Location.Y;

            int panelxOffset = panelTiles.Location.X;
            int panelyOffset = panelTiles.Location.Y;
           

            //find mouse position to map position

            Point mousePosition = Cursor.Position;
            mousePosition = PointToClient(mousePosition);

            mousePosition.X -= (xOffset + panelxOffset);
            mousePosition.Y -= (yOffset + panelyOffset);

            Point mapPosition = new Point(mousePosition.X / 32, mousePosition.Y / 32);

            //this.mapControl.map.mapArray[mapPosition.X, mapPosition.Y] = 5;

            Console.WriteLine(mousePosition + ", offset: {X: " + xOffset  +", Y: " + yOffset + "}" + ", TileSet: " + mapPosition + ", ID: " + mapControl.map.getTileIndexAt(mapPosition.X, mapPosition.Y));

            //sick 1 now find the tile your on and copy it to picTileSelected
            picTileSelected.Image = mapControl.map.TextureToImage(mapControl.map.get32TileAt(mapPosition.X, mapPosition.Y));

            //pass it to global var
            tileSelected = mapControl.map.getTileIndexAt(mapPosition.X, mapPosition.Y);

            //save the id of the object
            lblTileID.Text = "" + mapControl.map.getTileIndexAt(mapPosition.X, mapPosition.Y);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            picTiles.Image = mapControl.map.TextureToImage(mapControl.spriteSheet);
            picObjects.Image = mapControl.map.TextureToImage(mapControl.objectSheet);
            //picUnits.Image = mapControl.map.TextureToImage(mapControl.unitSheet);
            //fix size to tilesheet
            picTiles.Size = new Size(mapControl.spriteSheet.Width, mapControl.spriteSheet.Height);

            panelTiles.AutoScroll = true;

            tileMode = true;
            

          
           

        }
        private void mapControl_MouseClick(object sender, MouseEventArgs e)
        {
            
                //wheres the mapContorl start
                int xOffset = mapControl.Location.X;
                int yOffset = mapControl.Location.Y;

                //find mouse position to map position

                Point mousePosition = Cursor.Position;
                mousePosition = PointToClient(mousePosition);

                mousePosition.X -= xOffset;
                mousePosition.Y -= yOffset;

                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                //Point mapPosition = new Point(mousePosition.X / 32, mousePosition.Y / 32);
                if (tileMode)
                {
                    if (mapLayer == 0)
                    {
                        this.mapControl.map.mapArray[(mousePosition.X + mapControl.map.cameraX) / 32, (mousePosition.Y + mapControl.map.cameraY) / 32].ID = tileSelected;
                        this.mapControl.map.mapArray[(mousePosition.X + mapControl.map.cameraX) / 32, (mousePosition.Y + mapControl.map.cameraY) / 32].updateTile();
                    }
                    else if (mapLayer == 1)
                    {
                        mousePosition.X += 32;
                        mousePosition.Y += 32;
                        //this.mapControl.map.mapArrayLayer1[(mousePosition.X + mapControl.map.cameraX) / 32, (mousePosition.Y + mapControl.map.cameraY) / 32].ID = tileSelected;
                        //this.mapControl.map.mapArrayLayer1[(mousePosition.X + mapControl.map.cameraX) / 32, (mousePosition.Y + mapControl.map.cameraY) / 32].updateTile();
                    }
                }
                else
                {
                    int x = (mousePosition.X + mapControl.map.cameraX) / 32;
                    int y = (mousePosition.Y + mapControl.map.cameraY) / 32;

                    this.mapControl.map.addObject(new MapObject(x, y, int.Parse(lblObjectID.Text)));
                    /* if(mapControl.map.isObjectSpaceFree(x, y)) //THIS MESSED UP CAUSE OF WALLS THAT NEED TO OVERLAP ON ONE TILE
                     {

                     Console.WriteLine("object placed");
                     this.mapControl.map.addObject(new MapObject(x, y, int.Parse(lblObjectID.Text)));
                     }
                     else
                     {
                         Console.WriteLine("object already exists at " + x + "," + y);
                         Console.WriteLine("object not placed");
                     }*/
                }
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //where you clickin
                int x = (mousePosition.X + mapControl.map.cameraX) / 32;
                int y = (mousePosition.Y + mapControl.map.cameraY) / 32;

                mapControl.map.removeObjectAt(x, y);
            }
        }


        private void picTiles_MouseEnter(object sender, EventArgs e)
        {
            //what tile are you on

        }

        private void frmMain_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
          
            if(e.KeyCode == Keys.D)
            {
                if((mapControl.map.cameraX + mapControl.map.drawBufferX) >= (mapControl.map.width))
                //if (mapControl.map.cameraX >= ((mapControl.map.width) - mapControl.map.drawBufferX) * 32)
                {
                    mapControl.map.cameraX = (((mapControl.map.width - mapControl.map.drawBufferX) - 1) * 32);
                }
                mapControl.map.cameraX += 32;
            }
            else if (e.KeyCode == Keys.A)
            {
                
                if (mapControl.map.cameraX <= 32)
                {
                    mapControl.map.cameraX = 32;
                }
                mapControl.map.cameraX -= 32;
            }
            else if (e.KeyCode == Keys.W)
            {
                if (mapControl.map.cameraY <= 32)
                {
                    mapControl.map.cameraY = 32;
                }
                mapControl.map.cameraY -= 32;
            }
            else if (e.KeyCode == Keys.S)
            {
                if (mapControl.map.cameraY >= ((mapControl.map.height) - mapControl.map.drawBufferY) * 32)
                {
                    mapControl.map.cameraY = (((mapControl.map.height - mapControl.map.drawBufferY) - 1) * 32);
                }
                mapControl.map.cameraY += 32;
            }
            else if (e.KeyCode == Keys.Space)
            {
                Console.WriteLine("Adding light");
                mapControl.map.mapLights.Add(new MapLight(10, 10));
            }

            lblMap.Text = "Map: [Camera: " + (mapControl.map.cameraX /32) + ", " + (mapControl.map.cameraY /32 ) + "] - [Dimensions: " + mapControl.map.width + ", " + mapControl.map.height + "]" + " - [Tiles: " + "MaxTiles: " + (mapControl.map.width  * mapControl.map.height) + "]";
        }

        private void menuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnToggle_Click(object sender, EventArgs e)
        {

            if (tileMode == true)
            {
                //objectMode = true;
                lblMode.Text = "Object Mode";
                tileMode = false;
                picTiles.Visible = false;
                picObjects.Visible = true;
            }
            else
            {
                //tileMode = true;
                lblMode.Text = "Tile Mode";
                tileMode = true;
                picTiles.Visible = true;
                picObjects.Visible = false;
            }
            //mapControl.map.addObject(new MapObject(10, 10, 1));
        }

        private void picObjects_Click(object sender, EventArgs e)
        {

            //wheres the mapContorl start
            int xOffset = picTiles.Location.X;
            int yOffset = picTiles.Location.Y;

            int panelxOffset = panelTiles.Location.X;
            int panelyOffset = panelTiles.Location.Y;


            //find mouse position to map position

            Point mousePosition = Cursor.Position;
            mousePosition = PointToClient(mousePosition);

            mousePosition.X -= (xOffset + panelxOffset);
            mousePosition.Y -= (yOffset + panelyOffset);

            Point mapPosition = new Point(mousePosition.X / 32, mousePosition.Y / 32);

            //this.mapControl.map.mapArray[mapPosition.X, mapPosition.Y] = 5;

            Console.WriteLine(mousePosition + ", offset: {X: " + xOffset + ", Y: " + yOffset + "}" + ", TileSet: " + mapPosition + ", ID: " + mapControl.map.getTileIndexAt(mapPosition.X, mapPosition.Y));

            //sick 1 now find the tile your on and copy it to picTileSelected
            picObjectSelected.Image = mapControl.map.TextureToImage(mapControl.map.getObjectAt(mapPosition.X, mapPosition.Y));

            //pass it to global var
            tileSelected = mapControl.map.getTileIndexAt(mapPosition.X, mapPosition.Y);

            //save the id of the object
            lblObjectID.Text = "" + mapControl.map.getObjectIndexAt(mapPosition.X, mapPosition.Y);
        }

        private void viewMapDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMapData mapData = new frmMapData();

            mapData.Show();
            mapData.initMap(this.mapControl.map);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void createNewMap(string name, int width, int height)
        {

            mapControl.map = null;
            mapControl.map = new Map(mapControl, width, height, name);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewMap newMapForm = new frmNewMap();

            newMapForm.Show();
            newMapForm.init(this);

            
        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }

        private void mapControl_Click(object sender, EventArgs e)
        {

        }

        public void saveMap(String name)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string mapPath = path + "\\maps\\";
#warning changename
            StreamWriter writer = new StreamWriter(mapPath + name + ".dat");
            writer.WriteLine("[Header]");
            writer.WriteLine(mapControl.map.name + ":" + mapControl.map.width + ":" + mapControl.map.height);
            writer.WriteLine("[/Header]");
            writer.WriteLine("[Tiles]");

            for (int y = 0; y < mapControl.map.mapArray.GetLength(1); y++)
            {
                for (int x = 0; x < mapControl.map.mapArray.GetLength(0); x++)
                {
                    writer.WriteLine("" + mapControl.map.mapArray[x, y].X + ":" + mapControl.map.mapArray[x, y].Y + ":" + mapControl.map.mapArray[x, y].ID);
                }
            }

            writer.WriteLine("[/Tiles]");

            writer.WriteLine("[Objects]");
            for (int i = 0; i < mapControl.map.objectArray.Count; i++)
            {
                writer.WriteLine("" + mapControl.map.objectArray[i].X + ":" + mapControl.map.objectArray[i].Y + ":" + mapControl.map.objectArray[i].ID);
            }
            writer.WriteLine("[/Objects]");

            writer.WriteLine("[Lights]");
            for (int i = 0; i < mapControl.map.mapLights.Count; i++)
            {
                writer.WriteLine("" + mapControl.map.mapLights[i].X + ":" + mapControl.map.mapLights[i].Y);
            }
            writer.WriteLine("[/Lights]");
            writer.Close();



        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatusText.Text = "Loading...";

            fileDialog.Filter = "Data Files (.dat)|*.dat|All Files (*.*)|*.*";

            fileDialog.InitialDirectory = Application.StartupPath + "\\Maps\\";
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                string file = fileDialog.FileName;

                string mapname = "";
                int mapwidth = 0;
                int mapheight = 0;

                bool readingHeader = false;
                bool readingTiles = false;
                bool readingObjects = false;
                bool readingLights = false;

                MapTile[,] mapArray = new MapTile[0, 0];
                List<MapObject> mapObjects = new List<MapObject>();
                List<MapLight> mapLights = new List<MapLight>();
                //init maparray here


                try
                {

                    StreamReader reader = new StreamReader(file);
                    while (!reader.EndOfStream)
                    {

                        string line = reader.ReadLine();
                        Console.WriteLine(line);

                        if (line == "[Header]")
                        {
                            readingHeader = true;
                        }

                        if (readingHeader)
                        {
                            if (line != "[Header]" && line != "[/Header]") //ignore start and end 
                            {

                                String[] unparsedLine = line.Split(':');
                                mapname = unparsedLine[0];
                                mapwidth = int.Parse(unparsedLine[1]);
                                mapheight = int.Parse(unparsedLine[2]);

                            }

                            if (line == "[/Header]")
                            {
                                readingHeader = false;
                                break;

                            }

                        }
                    }
                    mapArray = new MapTile[mapwidth, mapheight];
                    reader.Close();


                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    StreamReader reader = new StreamReader(file);
                    while (!reader.EndOfStream)
                    {


                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                        if (line == "[Tiles]")
                        {
                            readingTiles = true;
                        }

                        if (readingTiles)
                        {
                            if (line != "[Tiles]" && line != "[/Tiles]") //ignore start and end 
                            {
                                //parse em
                                //3 parts x, ,y id
                                int X;
                                int Y;
                                int ID;

                                string[] unparsedLine = line.Split(':');
                                X = int.Parse(unparsedLine[0]);
                                Y = int.Parse(unparsedLine[1]);
                                ID = int.Parse(unparsedLine[2]);

                                MapTile tempTile = new MapTile(X, Y, ID);
                                mapArray[X, Y] = tempTile;
                            }
                        }

                        if (line == "[/Tiles]")
                        {
                            readingTiles = false;
                        }

                        if (line == "[Objects]")
                        {
                            readingObjects = true;
                        }

                        if (readingObjects)
                        {
                            if (line != "[Objects]" && line != "[/Objects]") //ignore start and end 
                            {
                                //3 parts x, ,y id
                                int X;
                                int Y;
                                int ID;
                                //Console.WriteLine(line);
                                string[] unparsedLine = line.Split(':');
                                X = int.Parse(unparsedLine[0]);
                                Y = int.Parse(unparsedLine[1]);
                                ID = int.Parse(unparsedLine[2]);

                                MapObject tempObject = new MapObject(X, Y, ID);
                                mapObjects.Add(tempObject);
                            }
                        }

                        if (line == "[/Objects]")
                        {
                            readingObjects = false;
                        }

                        if (line == "[Lights]")
                        {
                            readingLights = true;


                        }

                        if (readingLights)
                        {
                            if (line != "[Lights]" && line != "[/Lights]")
                            {
                                string[] unparsedLine = line.Split(':');
                                int X = int.Parse(unparsedLine[0]);
                                int Y = int.Parse(unparsedLine[1]);
                            }  
                        }

                        if (line == "[/Lights]")
                        {
                            readingLights = false;
                        }

                        
                        this.mapControl.map = null;
                        this.mapControl.map = new Map(mapControl, mapwidth, mapheight, mapname);
                        this.mapControl.map.setMapArray(mapArray);
                        this.mapControl.map.setMapObjects(mapObjects);
                        this.mapControl.map.setMapLights(mapLights);
                    }
                    reader.Close();
                }
                catch (IOException exc)
                {
                }
            }
            //Console.WriteLine(result); // <-- For debugging use only.
            lblStatusText.Text = "Done.";
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveMap(mapControl.map.name);
            //frmSave saveForm = new frmSave();
            //saveForm.init(this);
            //saveForm.Show();
        }

        private void statusMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < mapControl.map.mapArray.GetLength(1); y++)
            {
                for (int x = 0; x < mapControl.map.mapArray.GetLength(0); x++)
                {
                    mapControl.map.mapArray[x, y].ID = tileSelected;
                    mapControl.map.mapArray[x, y].updateTile();
                }

            }
            //this.mapControl.map.mapArray[(mousePosition.X + mapControl.map.cameraX) / 32, (mousePosition.Y + mapControl.map.cameraY) / 32].ID = tileSelected;
        }







      
    }
}
