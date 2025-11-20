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
            if (ModContent.GetInstance<Config.Config>().rarityBalance && source is IEntitySource_WithStatsFromItem itemSource)
            {
                if (itemSource.Item.rare >= ItemRarityID.LightRed)
                {
                    projectile.ApplyStatsFromSource(source);
                }
            }
        }
    }
}
