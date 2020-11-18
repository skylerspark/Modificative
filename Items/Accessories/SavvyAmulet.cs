using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Modificative.Items.Accessories
{
	public class SavvyAmulet: ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("[c/ff0000:You arent supposed to have this]");
			DisplayName.SetDefault("Savvy Safe Amulet");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
            item.accessory = true;
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
