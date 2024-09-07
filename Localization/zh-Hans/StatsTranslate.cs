using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace UNPCCPh.GlobalTranslation
{
    public class StatsTranslate : ModSystem
    {
        public override void Load()
        {
            On_ChatManager.ParseMessage += Translate;            
        }
        public override void Unload()
        {
            On_ChatManager.ParseMessage -= Translate;
        }       
        private static List<TextSnippet> Translate(On_ChatManager.orig_ParseMessage orig, string text,Color baseColor)
        {
            //炼金术师
            text = text.Replace("Cycle Shop", "切换商店");
            text = text.Replace("I could've saved more people with my potions...", "我本可以用我的药水救更多的人...");
            text = text.Replace("Salute to the dead, but not forgotten.", "向死者致敬，不要忘记他们！");
            text = text.Replace("I made a brand new potion to make you enjoy the party more.", "我做了一种全新的药水，能让你更享受聚会。");
            text = text.Replace("Catastrophic Faliure", "");
            text = text.Replace("The Alchemist grows various herbs to make potions for you to buy. Spending much time with plants taught him to be calm and insightful.", "炼金术士种植各种草药，制作药水供你购买。花很多时间在植物上让他拥有了极强的镇静和洞察力。");
            text = text.Replace("MagicalMerchantGore1", "魔法商人1");
            text = text.Replace("MagicalMerchantGore2", "魔法商人2");
            text = text.Replace("MagicalMerchantGore3", "魔法商人3");
            text = text.Replace("MagicalMerchantGore4", "魔法商人4");
            text = text.Replace("Shop(Ingredients)", "草药");
            text = text.Replace("Shop(Battle Potions)", "战斗类药水");
            text = text.Replace("Shop(Utility Potions)", "实用药水");
            text = text.Replace("Shop(Boss/Event)", "Boss音乐盒");
            return orig.Invoke(text, baseColor);
        }       
    }
}
