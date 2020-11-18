using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Modificative.Items.Weapons
{
	public class DeepSword: ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("From the Bowels of Eternity");
			DisplayName.SetDefault("Deepest Deep Sword");
		}

		public override void SetDefaults() {
			item.knockBack = 2147483647;
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
