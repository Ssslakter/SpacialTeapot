using SubworldLibrary;
using System.Diagnostics;
using Terraria;
using SpacialTeapot;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpacialTeapot.Items
{
    public class Teleporter : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a modded item.");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.value = 100;
            Item.rare = ItemRarityID.Blue;
            Item.useTurn = true;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            // Set other Item.X values here
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
        public override bool? UseItem(Player player)
        {
            if (SubworldSystem.IsActive<MySub>())
            {
                //SubworldSystem.Exit();
            }
            else
            {
                SubworldSystem.Enter<MySub>();
            }

            return false;
        }
    }
}