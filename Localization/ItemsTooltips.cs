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
                for (int i = 0; i < tooltips.Count; i++)
                {
                    ModItem mi = item.ModItem;
                    Mod mo = mi.Mod;
                    
                    if (mo.Name.Equals("Stellamod"))
                    {
                        TooltipLine tl = tooltips[i];
                        tl.Text = tl.Text.Replace("Simple Brooch!", "简易饰符!");
                        tl.Text = tl.Text.Replace("Use with caution...", "谨慎使用...");
                        tl.Text = tl.Text.Replace("May cause disaster", "可能导致灾难性的后果");
                        tl.Text = tl.Text.Replace("Advanced Brooch!", "高级饰符！");
                        tl.Text = tl.Text.Replace("You need an Advanced Brooches Backpack for this!", "你需要高级饰符背包才能让此饰品发挥效果！");
                        tl.Text = tl.Text.Replace("Radiant Brooch!", "辉映饰符！");
                        tl.Text = tl.Text.Replace("I shall arrive with you soon - Gintzia", "马上到你家门口 ——金戈亚");
                        tl.Text = tl.Text.Replace("This'll drive you insane for one minion", "为了一个随从栏位，至于吗？");
                        tl.Text = tl.Text.Replace("A+ Accessory!", "超级棒的饰品！");
                        tl.Text = tl.Text.Replace("You need an Radiant Brooches Backpack for this!", "你需要辉映饰符背包才能让此饰品发挥效果！");
                        tl.Text = tl.Text.Replace("Love you and have fun -Sirestias", "爱你哟，玩的开心！ ——希丝忒莉亚");
                        tl.Text = tl.Text.Replace("Please check out my game Diari!", "有空的话也请去看看我的游戏Diari！");
                        tl.Text = tl.Text.Replace("This mod is in relation to the game", "此mod的剧情与它有联系");
                        tl.Text = tl.Text.Replace("Can be changed to", "可使用宝珠转化为");
                        tl.Text = tl.Text.Replace("(A)Honestly could wipe out many wide varieties of enemies!", "（A）威力强劲，横扫千军！");
                        tl.Text = tl.Text.Replace("(A) Extremely good for targeting! Needs an enemy alive to work!", "敌人无可遁形！前提是要有敌人");
                        tl.Text = tl.Text.Replace("(A+) Strikes enemies with some straight ass star power!", "（A+）引导繁星之力，降下天罚！");
                        tl.Text = tl.Text.Replace("Greatsword Weapon Type", "武器类型：巨剑");
                        tl.Text = tl.Text.Replace("(A) Very High Damage Scaling with frost explosions!", "（A）很高的冰霜爆炸伤害修正！");
                        tl.Text = tl.Text.Replace("(A) Very High Damage Scaling with knives!", "（A）很高的飞刀伤害修正！");
                        tl.Text = tl.Text.Replace("Stein Weapon Type", "武器类型：冲击拳套");
                        tl.Text = tl.Text.Replace("The sorrowing souls within are crying", "聆听那灵魂的哀嚎...");
                        tl.Text = tl.Text.Replace("This weapon is bound by Fenix", "凤涅克丝的力量缠绕于其上");
                        tl.Text = tl.Text.Replace("(S) Explosion damage is out of this world!", "（S）超神的爆炸伤害修正！");
                        tl.Text = tl.Text.Replace("(A) Honestly could wipe out many wide varieties of enemies!", "（A）威力强劲，横扫千军！");
                        tl.Text = tl.Text.Replace("A weapon so powerful, it holds a gravitation pull and can change forms!", "有股力量将周围的一切吸向它...还可以改变形态！");
                        tl.Text = tl.Text.Replace("Right click for a powerful gravitation slam!", "右键释放强力俯冲猛砸地面！");
                        tl.Text = tl.Text.Replace("(S) Use your right click to switch between 4 forms!", "右键在4个形态中切换！");
                        tl.Text = tl.Text.Replace("(S+) Godlike High Damage Scaling with the power of the sun!", "（S+）驾驭烈阳之力，展现神威！");
                        tl.Text = tl.Text.Replace("Multiplication and cloning is the essense of power nyaaa!", "复制，克隆，这正是力量的精华展现喵！！！");
                        tl.Text = tl.Text.Replace("(B) Good Damage scaling with scythe blades!", "（B）不错的镰刃伤害修正！");
                        tl.Text = tl.Text.Replace("Right click to change form, requires a Sewing Kit", "右键变化形态，需要装备织影套件包");
                        tl.Text = tl.Text.Replace("Changed by Sewing Kit, effects may be incorrect...", "形态发生了扭曲转变...");
                        tl.Text = tl.Text.Replace("Safunai Weapon Type", "武器类型：鞭刃");
                        tl.Text = tl.Text.Replace("(C) Medium Damage Scaling wind shots On Hit!", "（C）中等的风之矢伤害修正");
                        tl.Text = tl.Text.Replace("(B) Medium Damage Scaling (Frost balls) On Hit!", "（B）中等的冰霜球伤害修正");
                        tl.Text = tl.Text.Replace("(S) Great Damage scaling with swings!", "（S）极高的挥动伤害修正！");
                        tl.Text = tl.Text.Replace("(A) 3 Weapons in one!", "三武合一，何等便利！");
                        tl.Text = tl.Text.Replace("(A) Use your right click to switch between 3 forms!", "右键在3个形态中切换！");
                        tl.Text = tl.Text.Replace("(D) Low Damage scaling for Skulls on hit", "（D）低的骷髅头的伤害修正");
                        tl.Text = tl.Text.Replace("(B) Great spread on bullets", "（B）子弹较为发散");
                        tl.Text = tl.Text.Replace("Gun Holster Weapon Type", "武器类型：枪套");
                        tl.Text = tl.Text.Replace("Use to equip to your gun holster's right hand!", "左键来将它装备至你的枪套右手！");
                        tl.Text = tl.Text.Replace("You do not have a Gun Holster...", "你并没有枪套...");
                        tl.Text = tl.Text.Replace("Buy one from Delgrim!", "去向戴尔格林买一个吧！");
                        tl.Text = tl.Text.Replace("(A) Great stacking and holding damage, less immunity frames!", "（A）伤害随按住堆砌得更高，且造成无敌帧更少！");
                        tl.Text = tl.Text.Replace("(S) Extreme damage scaling with the love sword!", "（S）极高的爱之剑伤害修正！");
                        tl.Text = tl.Text.Replace("Use to equip to your gun holster's left hand!", "左键来将它装备至你的枪套左手！");
                        tl.Text = tl.Text.Replace("OR right click to equip to your gun holster's right hand!", "或者，右键来将它装备至你的枪套右手！");
                        tl.Text = tl.Text.Replace("Can be in both hands at the same time!", "可以同时存在于枪套的左右手！");
                        tl.Text = tl.Text.Replace("(A) Great Damage scaling for explosions!", "（A）很高的爆炸伤害修正！");
                        tl.Text = tl.Text.Replace("(Special) The farther your cursor is, the faster the axe goes!", "特殊：你的鼠标离你越远，斧子速度越快！");
                        tl.Text = tl.Text.Replace("(D) Low Damage scaling for Explosions on hit", "（D）低的爆炸伤害修正");
                        tl.Text = tl.Text.Replace("Jerry does not like being called names", "杰瑞可不喜欢被别人起外号");
                        tl.Text = tl.Text.Replace("(D) Really low scaling damage", "（D）很低的伤害修正");
                        tl.Text = tl.Text.Replace("(D) Low Damage scaling for flames", "（D）低的火焰伤害修正");
                        tl.Text = tl.Text.Replace("(B) Great spread on with flames", "（B）范围宽广的火焰");

                        //来自武器 七色剑刃
                        tl.Text = tl.Text.Replace("Red - No Effect", "红——朴实无华");
                        tl.Text = tl.Text.Replace("Orange - Explodes", "橙——焰华绽放");
                        tl.Text = tl.Text.Replace("Yellow - Teleports after hitting an enemy", "黄——闪转腾挪");
                        tl.Text = tl.Text.Replace("Green - High damage", "绿——会心一击");
                        tl.Text = tl.Text.Replace("Cyan - Causes several debuffs", "青——钻心剜骨");
                        tl.Text = tl.Text.Replace("Blue - Homing", "蓝——夺命追魂");
                        tl.Text = tl.Text.Replace("Purple - Summons powerful blades upon hitting an enemy", "紫——万剑穿心");


                        tl.Text = tl.Text.Replace("(B) Very good throwing weapon that sticks around!", "（B）非常棒的投掷物，而且会持续存在好一阵子！");
                        tl.Text = tl.Text.Replace("Orb Weapon Type", "武器类型：球体");
                        tl.Text = tl.Text.Replace("Juggler Weapon Type", "武器类型：抛接");
                    }
                }
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
