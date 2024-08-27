using System.Collections.Generic;
using System.Text;
using Terraria;
using Terraria.ModLoader;

namespace LunarVeilChinesePack.Localization
{
    public class ItemsTooltips : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltip in tooltips)
            {
                //用一个字符串替换一个字符串
                StringBuilder sb = new StringBuilder(tooltip.Text);
                sb.Replace("Simple Brooch!", "简易饰符!");


                tooltip.Text = sb.ToString();
                //tooltip.Text = Regex.Replace(tooltip.Text,"?" + tooltip.Text +"?",sb.ToString());
                
                
            }
            base.ModifyTooltips(item, tooltips);
        }
    }
}
