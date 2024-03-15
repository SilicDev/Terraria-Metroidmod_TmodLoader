using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;

namespace MetroidMod.Content.Tiles.ItemTile.Beam.Hunters
{
	public class JudicatorTile : ItemTile
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Main.tileSpelunker[Type] = true;
			Main.tileOreFinderPriority[Type] = 807;
			LocalizedText name = CreateMapEntryName();
			// name.SetDefault("Judicator");
			AddMapEntry(new Color(255, 126, 255), name);
			DustType = 1;
		}
	}
}
