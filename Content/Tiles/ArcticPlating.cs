﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MetroidMod.Content.Tiles
{
	public class ArcticPlating : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			DustType = 87;
			MinPick = 65;
			HitSound = SoundID.Tink;
			ItemDrop = ModContent.ItemType<Items.Tiles.ArcticPlating>();

			AddMapEntry(new Color(140, 189, 189));
		}
	}
}
