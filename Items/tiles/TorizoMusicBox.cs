using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MetroidMod.Items.tiles
{
	public class TorizoMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Torizo - 'Cave Dweller' Ridley Remix)");
			Tooltip.SetDefault("Remix by Prophetik");
		}
		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("TorizoMusicBox");
			item.width = 24;
			item.height = 32;
			item.rare = 8;
			item.value = 1000;
			item.accessory = true;
		}
	}
}
