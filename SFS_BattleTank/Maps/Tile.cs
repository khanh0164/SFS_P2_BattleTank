﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SFS_BattleTank.Bases;
using SFS_BattleTank.Constants;

namespace SFS_BattleTank.Maps
{
    public class Tile : GameObject
    {
        protected Texture2D _sprite;
        protected string _spritePath;
        protected int _size;

        public Tile(float x,float y,int size,int essental)
            :base(x,y,"")
        {
            _size = size;
            if(essental == 1)
            {
                _spritePath = @"map\tree";
                _essental = Consts.ES_TILE_TREE;
            }
            if (essental == 2)
            {
                _spritePath = @"map\empty";
                _essental = "";
            }
        }
        public override void LoadContents(ContentManager contents)
        {
            _sprite = contents.Load<Texture2D>(_spritePath);
            base.LoadContents(contents);
        }
        public override void Draw(SpriteBatch sp)
        {
            if(_sprite != null)
            {
                sp.Draw(_sprite,
                    new Rectangle((int)_position.X, (int)_position.Y, _size, _size),
                    Color.White);
            }
            base.Draw(sp);
        }
        public int GetSize()
        {
            return _size;
        }
        
    }
}
