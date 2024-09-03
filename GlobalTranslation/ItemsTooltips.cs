using System.Collections.Generic;
using System.Text;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace LunarVeilChinesePack.Localization
{
    public class ItemsTooltips : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            try
            {
                for (int i = 0; i < tooltips.Count; i++)
                {
                    ModItem mi = item.ModItem;
                    Mod mo = mi.Mod;
                    
                    if (mo.Name.Equals("Stellamod"))
                    {
                        TooltipLine tl = tooltips[i];
                        tl.Text = tl.Text.Replace("Simple Brooch!", "简易饰符!");
                        tl.Text = tl.Text.Replace("Use with caution...", "填入汉化文本");
                        tl.Text = tl.Text.Replace("May cause disaster", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Advanced Brooch!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("You need an Advanced Brooches Backpack for this!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Radiant Brooch!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("I shall arrive with you soon - Gintzia", "填入汉化文本");
                        tl.Text = tl.Text.Replace("This'll drive you insane for one minion", "填入汉化文本");
                        tl.Text = tl.Text.Replace("A+ Accessory!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("You need an Radiant Brooches Backpack for this!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Love you and have fun -Sirestias", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Please check out my game Diari!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("This mod is in relation to the game", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Can be changed to", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(A)Honestly could wipe out many wide varieties of enemies!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(A) Extremely good for targeting! Needs an enemy alive to work!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(A+) Strikes enemies with some straight ass star power!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Greatsword Weapon Type", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(A) Very High Damage Scaling with frost explosions!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(A) Very High Damage Scaling with knives!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Stein Weapon Type", "填入汉化文本");
                        tl.Text = tl.Text.Replace("The sorrowing souls within are crying", "填入汉化文本");
                        tl.Text = tl.Text.Replace("This weapon is bound by Fenix", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(S) Explosion damage is out of this world!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(A) Honestly could wipe out many wide varieties of enemies!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("A weapon so powerful, it holds a gravitation pull and can change forms!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Right click for a powerful gravitation slam!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(S) Use your right click to switch between 4 forms!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(S+) Godlike High Damage Scaling with the power of the sun!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Multiplication and cloning is the essense of power nyaaa!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(B) Good Damage scaling with scythe blades!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Right click to change form, requires a Sewing Kit", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Changed by Sewing Kit, effects may be incorrect...", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Safunai Weapon Type", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(C) Medium Damage Scaling wind shots On Hit!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(B) Medium Damage Scaling (Frost balls) On Hit!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(S) Great Damage scaling with swings!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(A) 3 Weapons in one!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(A) Use your right click to switch between 3 forms!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(D) Low Damage scaling for Skulls on hit", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(B) Great spread on bullets", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Gun Holster Weapon Type", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Use to equip to your gun holster's right hand!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("You do not have a Gun Holster...", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Buy one from Delgrim!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(A) Great stacking and holding damage, less immunity frames!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(S) Extreme damage scaling with the love sword!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Use to equip to your gun holster's left hand!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("OR right click to equip to your gun holster's right hand!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Can be in both hands at the same time!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(A) Great Damage scaling for explosions!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(Special) The farther your cursor is, the faster the axe goes!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(D) Low Damage scaling for Explosions on hit", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Jerry does not like being called names", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(D) Really low scaling damage", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(D) Low Damage scaling for flames", "填入汉化文本");
                        tl.Text = tl.Text.Replace("(B) Great spread on with flames", "填入汉化文本");

                        //来自武器 七色剑刃
                        tl.Text = tl.Text.Replace("Red - No Effect", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Orange - Explodes", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Yellow - Teleports after hitting an enemy", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Green - High damage", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Cyan - Causes several debuffs", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Blue - Homing", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Purple - Summons powerful blades upon hitting an enemy", "填入汉化文本");


                        tl.Text = tl.Text.Replace("(B) Very good throwing weapon that sticks around!", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Orb Weapon Type", "填入汉化文本");
                        tl.Text = tl.Text.Replace("Juggler Weapon Type", "填入汉化文本");
                    }
                }
            }
            catch { };
            //foreach (TooltipLine tooltip in tooltips)
            //{
            //    //用一个字符串替换一个字符串
            //    //StringBuilder sb = new StringBuilder(tooltip.Text);

                

            //    //tooltip.Text = sb.ToString();
            //    //tooltip.Text = Regex.Replace(tooltip.Text,"?" + tooltip.Text +"?",sb.ToString());
                
                
            //}
            base.ModifyTooltips(item, tooltips);
        }
    }
    
}
