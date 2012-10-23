using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2GDLME
{
    public class MapTile
    {
        public int X;
        public int Y;
        public int ID;
        public Microsoft.Xna.Framework.Graphics.Texture2D texture;
        public Microsoft.Xna.Framework.Rectangle rect;

        public MapTile(int X, int Y, int ID)
        {
            this.X = X;
            this.Y = Y;
            this.ID = ID;
            this.rect = TextureManager.getTileById(ID);
        }

        public void updateTile()
        {
            //this.texture = TextureManager.getTileById(ID);
            this.rect = TextureManager.getTileById(ID);
        }

    }
}
