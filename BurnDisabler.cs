using System;
using Terraria.ModLoader;

namespace BurnDisabler
{
    class BurnDisabler : Mod
	{
        internal static BurnDisabler Instance;
        /*internal bool AALoaded;
        internal bool FargoSoulsLoaded;
        internal bool SinsLoaded;*/
        public BurnDisabler()
        {
            Instance = this;
        }
        public override void Unload()
        {
            Instance = null;
        }
        /*public override void PostSetupContent()
        {
            try
            {
                AALoaded = ModLoader.GetMod("AAMod") != null;
                FargoSoulsLoaded = ModLoader.GetMod("FargowiltasSouls") != null;
                SinsLoaded = ModLoader.GetMod("SinsMod") != null;
            }
            catch (Exception error)
            {
                throw new Exception("BurnDisabler: PostSetupContent Error: " + error.StackTrace + error.Message);
            }
        }*/
    }
}