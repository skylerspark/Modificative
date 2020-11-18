using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Modificative.Items
{
	public class DeepSword: ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("[c/ff0000:M][c/ff1400:o][c/ff2800:d][c/ff3c00:i][c/ff5000:f][c/ff6400:i][c/ff7800:c][c/ff8c00:a][c/ffa000:t][c/ffb400:i][c/ffc800:v][c/ffdc00:e]");
			DisplayName.SetDefault("Deep Sword of Codius");
		}

		public override void SetDefaults() {
			item.knockBack = 5;
			item.damage = 2147483647;
			item.melee = true;
			item.width = 52;
			item.height = 52;
			item.scale = 3f;
			item.useTime = 0;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.useTurn = true;
			item.autoReuse = true;
			item.rare = 13;
			item.expert = true;
			item.value = Item.buyPrice(gold: 0);
			item.UseSound = SoundID.Item1;
		}

		/* public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.OnFire, 60);
		} */
	}
}
