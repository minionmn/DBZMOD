﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DBZMOD.Items.Consumables.TestItems
{
    public sealed class SSJRTestItem : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.consumable = false;
            item.maxStack = 1;
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.value = 0;
            item.expert = true;
            item.potion = false;
            item.noUseGraphic = true;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SSJG Test Item");
            Tooltip.SetDefault("Manually activates the ssjr transformation cutscene and unlocks it.");
        }


        public override bool UseItem(Player player)
        {
            MyPlayer modPlayer = player.GetModPlayer<MyPlayer>();
            UI.TransformationMenu.SelectedTransformation = modPlayer.TransformationDefinitionManager.SSJRDefinition;

            modPlayer.TransformationDefinitionManager.SSJRDefinition.Unlock(player);
            return true;

        }
    }
}
