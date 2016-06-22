﻿using SharpDX;
using SharpDX.Toolkit;
using SharpDX.Toolkit.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder._2D
{
    public class Unit2D
    {
        Texture2D texture;
        public Rectangle rectangle;
        public int locationX;
        public int locationY;
        public static Texture2D getTexture(string entity, Game game)
        {

            switch (entity)
            {
                case "player": return game.Content.Load<Texture2D>("player");
                case "grass": return game.Content.Load<Texture2D>("terraincell");
                case "enemy": return game.Content.Load<Texture2D>("enemy");


                default: return null;

            }

        }
        public Unit2D(string entity, Game game)
        {
            texture = getTexture(entity, game);
            

        }
        public bool isColided(Unit2D player, Unit2D enemy)
        {

            if (player.rectangle.Intersects(enemy.rectangle))
            {
                return true;
            }
            else return false;


        }
        public void update()
        {

            

        }
        public void draw(SpriteBatch spritebatch)
        {
            
            rectangle = new Rectangle(locationX, locationY, 32, 32);
            spritebatch.Draw(texture, rectangle, Color.White);
        }
    }
}
