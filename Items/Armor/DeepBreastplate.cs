using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Modificative.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class DeepBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("[c/ff0000:M][c/ff1400:o][c/ff2800:d][c/ff3c00:i][c/ff5000:f][c/ff6400:i][c/ff7800:c][c/ff8c00:a][c/ffa000:t][c/ffb400:i][c/ffc800:v][c/ffdc00:e]");
			DisplayName.SetDefault("Deep Chestplate of Codius");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 900;
			item.rare = 13;
			item.expert = true;
			item.defense = 130;
		}

		public override void UpdateEquip(Player player) {
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[24] = true;
			player.lavaImmune = true;
            player.fireWalk = true;
		}
	}
}