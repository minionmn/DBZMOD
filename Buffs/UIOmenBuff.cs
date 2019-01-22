﻿using Terraria;

namespace DBZMOD.Buffs
{
    public class UIOmenBuff : TransBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Ultra Instinct -Sign-");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            damageMulti = 2f;
            speedMulti = 7f;
            kiDrainRate = 10;
            kiDrainBuffMulti = 1f;
            Description.SetDefault("The secret technique of the gods. Grants the ability to dodge any attack.");
        }
    }
}

