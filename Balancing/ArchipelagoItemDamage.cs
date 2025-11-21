using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.UI;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.DataStructures;
using SeldomArchipelago.Players;

namespace SeldomArchipelago.Balancing
{
    class ItemDamage : GlobalItem
    {
        public override void ModifyWeaponDamage(Item item, Player player, ref StatModifier damage)
        {
            if (ModContent.GetInstance<Config.Config>().rarityBalance && item.rare >= ItemRarityID.LightRed)
            {
                damage *= 0.2f;
            }
        }
    }
    class SummonDamage : GlobalProjectile  // As ModifyWeaponDamage does not apply to summons/sentries
    {
        public override void OnSpawn(Projectile projectile, IEntitySource source)
        {
            if (ModContent.GetInstance<Config.Config>().rarityBalance && source is IEntitySource_WithStatsFromItem { Player: var player, Item: var item})
            {
                if (item.rare >= ItemRarityID.LightRed)
                {
                    ArchipelagoPlayer APplayer = player.GetModPlayer<ArchipelagoPlayer>();
                    APplayer.summonMultiplier = 0.2f;
                    Main.NewText("I'm very angry.");
                }
            }
        }
        public override void ModifyHitNPC(Projectile projectile, NPC target, ref NPC.HitModifiers modifiers)
        {
            if (projectile.IsMinionOrSentryRelated)
            {
                projectile.TryGetOwner(out var owner);
                if (owner != null)
                {
                    ArchipelagoPlayer APplayer = owner.GetModPlayer<ArchipelagoPlayer>();
                    projectile.damage = (int)(projectile.damage * APplayer.summonMultiplier);
                }
            }
        }
    }
}
