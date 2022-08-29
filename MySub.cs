using System.Collections.Generic;
using Terraria;
using SubworldLibrary;
using Terraria.GameContent.Generation;
using Terraria.WorldBuilding;
using Terraria.ID;

namespace SpacialTeapot
{
    internal class MySub : Subworld
    {
        public override int Width => Main.maxTilesX;

        public override int Height => Main.maxTilesY;

        public override List<GenPass> Tasks => new List<GenPass>()
        {
           new PassLegacy("Brbr Pass",(progress,cfg)=>{
            progress.Message = "Spawning test bricks";
            WorldGen.TileRunner(Main.spawnTileX, Main.spawnTileY,10, 10, TileID.Dirt,addTile:true);
           })
        };
    }

}
