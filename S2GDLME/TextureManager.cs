using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace S2GDLME
{
    //pass a spritesheet to this and let it index the textures into their respective sizes
    //32x32
    //64x64 *later
    //128x128 *later

    public static class TextureManager
    {
        public static Texture2D spriteSheet;
        public static Texture2D objectSheet;
        public static Texture2D unitSheet;

      

        public const int TILE_WIDTH = 32;
        public const int TILE_HEIGHT = 32;

        static GraphicsDevice graphics;

        public static void init(GraphicsDevice Graphics, Texture2D spritesheet, Texture2D objectsheet, Texture2D unitsheet)
        {
          
            spriteSheet = spritesheet;
            objectSheet = objectsheet;
            //unitSheet = unitsheet;

            graphics = Graphics;
        }

        //use rectangle positional drawing instead of transferring texture2d between textures
       /* public static Texture2D getTileById(int index)
        {
            Texture2D returnTex;

            Rectangle sourceRectangle;
            int tileY = index / (spriteSheet.Width / 32);
            int tileX = index % (spriteSheet.Width / 32);

            sourceRectangle = new Rectangle(tileX * 32, tileY * 32, 32, 32);
            returnTex = new Texture2D(graphics, sourceRectangle.Width, sourceRectangle.Height);

            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            spriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            returnTex.SetData(data);

            return returnTex;
        }*/

        public static Rectangle getTileById(int index)
        {

            Rectangle sourceRectangle;
            int tileY = index / (spriteSheet.Width / 32);
            int tileX = index % (spriteSheet.Width / 32);

            sourceRectangle = new Rectangle(tileX * 32, tileY * 32, 32, 32);

            return sourceRectangle;
        }
        public static Texture2D getObject(int index)
        {
            Texture2D returnTex;

            Rectangle sourceRectangle;
            int tileY = index / (objectSheet.Width / 32);
            int tileX = index % (objectSheet.Width / 32);

            sourceRectangle = new Rectangle(tileX * 32, tileY * 32, 32, 32);
            returnTex = new Texture2D(graphics, sourceRectangle.Width, sourceRectangle.Height);

            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            objectSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            returnTex.SetData(data);

            return returnTex;
        }


        public static Texture2D get32TileAt(int x, int y)
        {
            Texture2D returnTex;

            int tileX = x;
            int tileY = y;

            Rectangle sourceRectangle = new Rectangle(tileX * 32, tileY * 32, 32, 32);
            returnTex = new Texture2D(graphics, sourceRectangle.Width, sourceRectangle.Height);

            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            spriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            returnTex.SetData(data);

            return returnTex;
        }

        public static int getTileIndexAt(int x, int y)
        {
            int index;



            //index = y * (mapControl.spriteSheet.Width / 32);
            index = x % (spriteSheet.Width / 32) + (y * (spriteSheet.Width / 32));

            return index;
        }

        public static int getObjectIndexAt(int x, int y)
        {
            int index;



            //index = y * (mapControl.spriteSheet.Width / 32);
            index = x % (objectSheet.Width / 32) + (y * (objectSheet.Width / 32));

            return index;
        }

        public static Texture2D getObjectAt(int x, int y)
        {
            Texture2D returnTex;

            int tileX = x;
            int tileY = y;

            Rectangle sourceRectangle = new Rectangle(tileX * 32, tileY * 32, 32, 32);
            returnTex = new Texture2D(graphics, sourceRectangle.Width, sourceRectangle.Height);

            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            objectSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            returnTex.SetData(data);

            return returnTex;
        }
    }
}
