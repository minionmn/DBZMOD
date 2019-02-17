﻿using Leveled;
using Leveled.NPCs;
using Leveled.Players;

namespace DBZMOD
{
    internal class LeveledSupport
    {
        public static void Initialize()
        {
            NPCStats.temporaryStrVarHooks.Add(typeof(KiProjectile), player => (int) player.Spirit.Total);
        }

        public static void PlayerPreUpdateMovement(MyPlayer player)
        {
            LeveledPlayer leveledPlayer = player.player.GetModPlayer<LeveledPlayer>();

            player.kiDamage *= LeveledMain.DamageMultiplier((int) leveledPlayer.Spirit.Total, leveledPlayer.Level);
        }
    }
}