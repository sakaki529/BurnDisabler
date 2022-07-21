using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BurnDisabler
{
    class BurnDisablerItem : GlobalItem
    {
        private bool canBurn = true;
        public override bool InstancePerEntity => true;
        public override void SetDefaults(Item item)
        {
            int GoblinDoll = 0;
            int AbomDoll = 0;
            int AnglerDoll = 0;
            /*if (BurnDisabler.Instance.AALoaded)
            {
                GoblinDoll = ModLoader.GetMod("AAMod").ItemType("GoblinDoll");
            }
            if (BurnDisabler.Instance.FargoSoulsLoaded)
            {
                AbomDoll = ModLoader.GetMod("FargowiltasSouls").ItemType("AbominationnVoodooDoll");
            }
            if (BurnDisabler.Instance.SinsLoaded)
            {
                AnglerDoll = ModLoader.GetMod("SinsMod").ItemType("AnglerVoodooDoll");
            }*/
            if (item.rare <= ItemRarityID.White && item.type != ItemID.GuideVoodooDoll && item.rare != -11 && item.rare != -12 && item.type != GoblinDoll && item.type != AnglerDoll && item.type != AbomDoll)
            {
                canBurn = false;
                item.rare = ItemRarityID.Blue;
            }
        }
    }
}