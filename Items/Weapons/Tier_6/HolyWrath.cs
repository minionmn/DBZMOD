﻿using DBZMOD.Extensions;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DBZMOD.Items.Weapons.Tier_6
{
	public class HolyWrath : KiItem
	{
		public override void SetDefaults()
		{
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shoot = mod.ProjectileType("HolyWrathBall");
            item.shootSpeed = 6f;
            item.damage = 200;
            item.knockBack = 12f;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.useAnimation = 400;
            item.useTime = 400;
            item.width = 40;
            item.channel = true;
            item.noUseGraphic = true;
            item.height = 40;
            item.autoReuse = false;
            if (!Main.dedServ)
            {
                item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/SpiritBombFire").WithPitchVariance(.3f);

            }
            item.value = 155000;
            item.rare = 8;
            kiDrain = 500;
            weaponType = "Massive Blast";
        }

	    public override void SetStaticDefaults()
		{
		    DisplayName.SetDefault("Holy Wrath");
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentSolar, 24);
            recipe.AddIngredient(null, "Supernova", 1);
            recipe.AddTile(null, "KaiTable");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool CanUseItem(Player player)
        {
            if (player.whoAmI != Main.myPlayer)
                return true;
            var modPlayer = player.GetModPlayer<MyPlayer>();
            //var inUse = modPlayer.isMassiveBlastInUse;
            var inUse = player.IsMassiveBlastInUse();
            // DebugHelper.Log(string.Format("Player is trying to use {0} and Massive Blast In Use? {1}", DisplayName, inUse));
            return !inUse;
        }
    }
}
