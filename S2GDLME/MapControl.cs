#region File Description
//-----------------------------------------------------------------------------
// SpinningTriangleControl.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Drawing;
using System.IO;
using System;
#endregion

namespace S2GDLME
{
    using gdiColor = System.Drawing.Color;
    using xnaColor = Microsoft.Xna.Framework.Color;

    /// <summary>
    /// Example control inherits from GraphicsDeviceControl, which allows it to
    /// render using a GraphicsDevice. This control shows how to draw animating
    /// 3D graphics inside a WinForms application. It hooks the Application.Idle
    /// event, using this to invalidate the control, which will cause the animation
    /// to constantly redraw.
    /// </summary>
    public class MapControl : GraphicsDeviceControl
    {
        
  
       
        Stopwatch timer;

        SpriteBatch spriteBatch;

        //custom
        public Texture2D spriteSheet;
        public Texture2D objectSheet;
        public Texture2D unitSheet;

        public Map map;

        /// <summary>
        /// Initializes the control.
        /// </summary>
        protected override void Initialize()
        {
            //init spritebatch
            spriteBatch = new SpriteBatch(GraphicsDevice);

            
            try
            {
                using (FileStream fileStream = new FileStream(Application.StartupPath + @"\tiles.png", FileMode.Open))
                {
                    spriteSheet = Texture2D.FromStream(GraphicsDevice, fileStream);
                   
                }

                using (FileStream fileStream = new FileStream(Application.StartupPath + @"\objects.png", FileMode.Open))
                {
                     objectSheet = Texture2D.FromStream(GraphicsDevice, fileStream);
                }

       
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }


           

            // Start the animation timer.
            timer = Stopwatch.StartNew();

            
            // Hook the idle event to constantly redraw our animation.
            Application.Idle += delegate { Invalidate(); };

            TextureManager.init(GraphicsDevice, spriteSheet, objectSheet, unitSheet);
            map = new Map(this, 100, 100, "startMap");
        }


        /// <summary>
        /// Draws the control.
        /// </summary>
        protected override void Draw()
        {
            GraphicsDevice.Clear(xnaColor.Black);

            spriteBatch.Begin();

            if (map != null)
            {
    map.draw(spriteBatch);
            }
            
            spriteBatch.End();
        }
    }
}
