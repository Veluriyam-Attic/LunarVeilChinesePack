global using LunarVeilChinesePack.Systems;
global using System;
global using System.Collections.Generic;
global using Terraria;
global using Terraria.ModLoader;

namespace LunarVeilChinesePack;

public class LunarVeilChinesePack : Mod
{
    public static string Tooltips_string(string old,string newst)
    {
        old = old.Replace(old,newst);
        return old;
    }
    public class LunarVeilCN : ModSystem
    {
        public override void PostSetupContent()
        {
            if (
                    ModLoader.HasMod("LunarVeilCN")
               )
                Utils.ShowFancyErrorMessage("[c/ff0000:请关闭LunarVeil（穹月天纱mod）个人汉化]\n[c/ff0000:此汉化不全且长时间不更新，不适配新版本穹月天纱]\n[c/ff0000:以及同时使用多个汉化会造成命名混乱]", 1);
        }
    }
}
