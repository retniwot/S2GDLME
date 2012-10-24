using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.IO;

namespace S2GDLME
{
    public class Map
    {
        public string name;

        public MapTile[,] mapArray;
        public List<MapLight> mapLights;

        public List<MapObject> objectArray;

        public int width;
        public int height;

         MapControl mapControl;

         public int cameraX;
         public int cameraY;

         public int drawBufferX = 31;
         public int drawBufferY = 31;

         
        public Map(MapControl mapControl, int width, int height, string name)
         {
            this.mapControl = mapControl;

            

            this.name = name;
            this.width = width;
            this.height = height;
            this.mapArray = new MapTile[width, height];
            //this.mapArrayLayer1 = new MapTile[width, height];

            this.objectArray = new List<MapObject>();
            this.mapLights = new List<MapLight>();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    mapArray[x, y] = new MapTile(x, y, 1);
                  //  mapArrayLayer1[x, y] = new MapTile(x, y, 0);
                }
            }
       
           
        }

        public void draw(SpriteBatch sp)
        {
            for (int y = cameraY /32; y < ((cameraY /32)  + drawBufferY); y++)
            {
                for (int x = cameraX /32; x < ((cameraX /32) + drawBufferX); x++)
                {
                    //sp.Draw(mapArray[x, y].texture, new Vector2((x * 32) - cameraX, (y *32) - cameraY), Color.White);
                   
                    sp.Draw(TextureManager.spriteSheet, new Rectangle(((x * 32) - cameraX), ((y * 32) - cameraY),32,32), mapArray[x,y].rect,Color.White);
                   //sp.Draw(TextureManager.spriteSheet, new Rectangle(((x * 32) - cameraX) - 32, ((y * 32) - cameraY) - 32, 32, 32), mapArrayLayer1[x, y].rect, Color.White);
                }
            }

            for (int i = 0; i < this.objectArray.Count; i++)
            {
                sp.Draw(getObject(objectArray[i].ID), new Vector2((objectArray[i].X * 32) - cameraX, (objectArray[i].Y * 32) - cameraY), Color.White);
            }
        }

        public void setMapArray(MapTile[,] mapArray)
        {
            this.mapArray = mapArray;
        }

        public void setMapLights(List<MapLight> mapLights)
        {
            this.mapLights = mapLights;
        }
        public void setMapObjects(List<MapObject> mapObjects)
        {
            this.objectArray = mapObjects;
        }
        public void addObject(MapObject i)
        {
            this.objectArray.Add(i);
        }

        public Texture2D get32Tile(int index)
        {
            Texture2D returnTex;

            Rectangle sourceRectangle;
            int tileY = index / (mapControl.spriteSheet.Width / 32);
            int tileX = index % (mapControl.spriteSheet.Width / 32);

            sourceRectangle = new Rectangle(tileX * 32, tileY * 32, 32, 32);
            returnTex = new Texture2D(mapControl.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);

            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            mapControl.spriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            returnTex.SetData(data);

            return returnTex;
        }

        public Texture2D getObject(int index)
        {
            Texture2D returnTex;

            Rectangle sourceRectangle;
            int tileY = index / (mapControl.objectSheet.Width / 32);
            int tileX = index % (mapControl.objectSheet.Width / 32);

            sourceRectangle = new Rectangle(tileX * 32, tileY * 32, 32, 32);
            returnTex = new Texture2D(mapControl.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);

            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            mapControl.objectSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            returnTex.SetData(data);

            return returnTex;
        }

        public Texture2D get32TileAt(int x, int y)
        {
            Texture2D returnTex;

            int tileX = x;
            int tileY = y;

            Rectangle sourceRectangle = new Rectangle(tileX * 32, tileY * 32, 32, 32);
            returnTex = new Texture2D(mapControl.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);

            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            mapControl.spriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            returnTex.SetData(data);

            return returnTex;
        }

        public Texture2D getObjectAt(int x, int y)
        {
            Texture2D returnTex;

            int tileX = x;
            int tileY = y;

            Rectangle sourceRectangle = new Rectangle(tileX * 32, tileY * 32, 32, 32);
            returnTex = new Texture2D(mapControl.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);

            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            mapControl.objectSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            returnTex.SetData(data);

            return returnTex;
        }

        public int getTileIndexAt(int x, int y)
        {
            int index;



            //index = y * (mapControl.spriteSheet.Width / 32);
            index = x % (mapControl.spriteSheet.Width / 32) + (y * (mapControl.spriteSheet.Width /32)) ;

            return index;
        }

        public int getObjectIndexAt(int x, int y)
        {
            int index;



            //index = y * (mapControl.spriteSheet.Width / 32);
            index = x % (mapControl.objectSheet.Width / 32) + (y * (mapControl.objectSheet.Width / 32));

            return index;
        }

        public void removeObjectAt(int x, int y)
        {
            for (int i = 0; i < objectArray.Count; i++)
            {
                if (objectArray[i].X == x && objectArray[i].Y == y)
                {
                    objectArray.Remove(objectArray[i]);
                }
            }
        }
        public bool isObjectSpaceFree(int x, int y)
        {
            bool nothing = true;

            for (int i = 0; i < objectArray.Count; i++)
            {
                if (objectArray[i].X == x && objectArray[i].Y == y)
                {
                    Console.WriteLine("match found @ " + i + ", x: " + x + ", y: " + y);
                    nothing = false;
                }

            }

            return nothing;
            
        }

        public System.Drawing.Image TextureToImage(Texture2D texture)
        {
            if (texture == null)
            {
                return null;
            }

            //Memory stream to store the bitmap data.
            MemoryStream ms = new MemoryStream();

            //Save the texture to the stream.
            texture.SaveAsPng(ms, texture.Width, texture.Height);

            //Seek the beginning of the stream.
            ms.Seek(0, SeekOrigin.Begin);

            //Create an image from a stream.
            System.Drawing.Image bmp2 = System.Drawing.Bitmap.FromStream(ms);

            //Close the stream, we nolonger need it.
            ms.Close();
            ms = null;
            return bmp2;
        }
    }
}
