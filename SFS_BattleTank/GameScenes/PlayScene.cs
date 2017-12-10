﻿

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SFS_BattleTank.Bases;
using SFS_BattleTank.Constants;
using SFS_BattleTank.GameObjCtrl;
using SFS_BattleTank.InputControl;
using SFS_BattleTank.Managers;
using SFS_BattleTank.UI;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using System.Collections.Generic;

namespace SFS_BattleTank.GameScenes
{
    public class PlayScene : Scene
    {
        protected ParticleManager _parManager;
        public PlayScene(ContentManager contents)
            : base(Consts.SCENE_PLAY, contents)
        {
        }

        public override bool Init()
        {
            _parManager = new ParticleManager();
            _network.AddController(Consts.CTRL_TANK, new TankController(_contents));
            _network.AddController(Consts.CTRL_BULLET, new BulletController(_contents));
            return base.Init();
        }
        public override bool LoadContents()
        {
            _parManager.LoadContents(_contents);
            return base.LoadContents();
        }
        public override void Shutdown()
        {
            base.Shutdown();
        }
        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
        }
        public override void Draw(SpriteBatch sp)
        {
            DrawObj(sp);
            _parManager.Draw(sp);
            base.Draw(sp);
        }

        protected void DrawObj(SpriteBatch sp)
        {
            Dictionary<string, Controller> controllers = Game1.network.GetControllers();
            foreach (Controller i in controllers.Values)
            {
                Dictionary<int, GameObject> obj = i.GetAllGameObject();
                foreach (GameObject ii in obj.Values)
                {
                    ii.Draw(sp);
                }
            }           
        }
    }
}
