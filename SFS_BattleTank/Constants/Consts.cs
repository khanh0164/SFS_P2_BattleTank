﻿
namespace SFS_BattleTank.Constants
{
    public static class Consts
    {
        // button
        public static readonly byte MOUSEBUTTON_LEFT = 1;
        public static readonly byte MOUSEBUTTON_RIGHT = 2;
        public static readonly byte MOUSEBUTTON_MIDDLE = 3;
        // game settings
        public static int VIEWPORT_WIDTH = 800;
        public static int VIEWPORT_HEIGHT = 600;
        public static float VIEWPORT_SCALE_RATE_WIDTH = 1;
        public static float VIEWPORT_SCALE_RATE_HEIGHT = 1;
        // config path
        public static readonly string SMARTFOX_CONFIG = @"../../../../sfs_config.xml";
        // game scene's name
        public static readonly string SCENE_PLAY = "playScene";
        public static readonly string SCENE_LOGIN = "loginScene";
        public static readonly string SCENE_MENU = "menuScene";
        // client proterties
        public static readonly string X = "x";
        public static readonly string Y = "y";
        public static readonly string VX = "vx";
        public static readonly string VY = "vy";
        public static readonly string XDIR = "xdir";
        public static readonly string YDIR = "ydir";
        public static readonly string ROTATION = "rotation";
        public static readonly string GO_ID = "objectid";
        // data properties
        public static readonly string X_ARRAY = "xarray";
        public static readonly string Y_ARRAY = "yarray";
        public static readonly string R_ARRAY = "rarray";
        public static readonly string ID_ARRAY = "idarray";
        // essental
        public static readonly string ES_TANK = "tank";
        public static readonly string ES_BULLET = "bullet";
        public static readonly string ES_ITEM_HP = "itemhp";
        public static readonly string ES_ITEM_POWER_UP = "itempowerup";
        public static readonly string ES_TILE_WATER = "tilewater";
        public static readonly string ES_TILE_WOOD_BOX = "tilewoodbox";
        public static readonly string ES_TILE_TREE = "tiletree";
        // request from server
        public static readonly string CMD_ADD = "add";
        public static readonly string CMD_REMOVE = "remove";
        public static readonly string CMD_UPDATE_DATA = "updatedata";
        // request from client
        public static readonly string CRQ_MOVE = "move";
        public static readonly string CRQ_FIRE = "fire";
        // extension path
        public static readonly string EXTS_ZONE = "ZoneExtension.jar";
        public static readonly string EXTS_ROOM = "RoomExtension.jar";
        public static readonly string EXTS_ZONE_MAINCLASS = "MainClassZoneExtension.java";
        public static readonly string EXTS_ROOM_MAINCLASS = "MainClassRoomExtension.java";
        // controller's name
        public static readonly string CTRL_TANK = "tankcontroller";
        public static readonly string CTRL_BULLET = "bulletcontroller";
        public static readonly string CTRL_ITEM = "itemcontroller";
        // type
        public static readonly string TYPE = "type";
        public static readonly string TYPE_TANK = "tanktype";
        public static readonly string TYPE_BULLET = "bullettype";
        public static readonly string TYPE_PAR_EXPLOSION = "explosionpar";
        public static readonly string TYPE_PAR_FIRE = "firepar";
        public static readonly string TYPE_ITEM = "itemtype";
        public static readonly string TYPE_KIND_OF_ITEM = "kindofitem";
        // game ui type
        public static readonly string UI_INPUT_FIELD = "inputField";
        public static readonly string UI_BUTTON = "button";
        public static readonly string UI_DISPLAY_FIELD = "displayField";        
        // ui cmd
        public static readonly string UI_CMD_INVERSE_USE_BACKGROUND = "inverseUseBackground";
        public static readonly string UI_CMD_CHANGE_TO_LOGIN_BUTTON = "changeToLoginButton";
        public static readonly string UI_CMD_CHANGE_TO_EXIT_BUTTON = "changeToExitButton";
        public static readonly string UI_CMD_CHANGE_TO_SOLO_BUTTON = "changeToSoloButton";
        public static readonly string UI_CMD_CHANGE_TO_CUSTUME_BATTLE_BUTTON = "changeToCustumeBattleButton";
        public static readonly string UI_CMD_DISABLE = "disable";
        public static readonly string UI_CMD_ENABLE = "enable";
        // ui background
        public static readonly string UIS_ID = @"ID";
        public static readonly string UIS_PASS = "";
        public static readonly string UIS_INPUT_FIELD = "textInput";
        public static readonly string UIS_EXIT_BUTTON = @"icon\exit";
        public static readonly string UIS_MENU_BUTTON = "menuBT";
        public static readonly string UIS_SOLO_BUTTON = "SoloButton";
        public static readonly string UIS_CUSTUME_BATTLE_BUTTON = "CustumeBattle";
        public static readonly string UIS_SOUND_ENABLE_BUTTON = @"icon\sound_enable";
        public static readonly string UIS_SOUND_DISABLE_BUTTON = @"icon\sound_disable";
        // item sprite
        public static readonly string ITS_HP = @"item\hp";
        public static readonly string ITS_POWER_UP = @"item\powerup";
        // behavior
        public static readonly string BHVR = "behavior";
        public static readonly string BHVR_ITEM_COUNT_DOWN = "countdown";
        // response
       

    }
}
