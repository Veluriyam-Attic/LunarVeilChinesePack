using Stellamod.Items;
using Stellamod.Items.Accessories.Brooches;

namespace LunarVeilChinesePack.Items;

public class ItemTooltipLocalizer : ModSystem
{
    public override void Load()
    {
        Dictionary<string, string> localizations = new()
        {
            { "Simple Brooch!", "简易饰符!" },
            { "Use with caution...", "谨慎使用..." },
            { "May cause disaster", "可能导致灾难性的后果" },
            { "Advanced Brooch!", "高级饰符！" },
            { "You need an Advanced Brooches Backpack for this!", "你需要高级饰符背包才能让此饰品发挥效果！" },
            { "Radiant Brooch!", "辉映饰符！" },
            { "I shall arrive with you soon - Gintzia", "马上到你家门口 ——金戈亚" },
            { "This'll drive you insane for one minion", "为了一个随从栏位，至于吗？" },
            { "A+ Accessory!", "超级棒的饰品！" },
            { "S+ Accessory!", "比超级棒更棒的饰品！" },
            { "You need an Radiant Brooches Backpack for this!", "你需要辉映饰符背包才能让此饰品发挥效果！" },
            { "Love you and have fun -Sirestias", "爱你哟，玩的开心！ ——希丝忒莉亚" },
            { "Please check out my game Diari!", "有空的话也请去看看我的游戏Diari！" },
            { "This mod is in relation to the game", "此mod的剧情与它有联系" },
            { "Can be changed to", "可使用宝珠转化为" },
            { "(A)Honestly could wipe out many wide varieties of enemies!", "（A）威力强劲，横扫千军！" },
            { "(A) Extremely good for targeting! Needs an enemy alive to work!", "敌人无可遁形！前提是要有敌人" },
            { "(A+) Strikes enemies with some straight ass star power!", "（A+）引导繁星之力，降下天罚！" },
            { "Greatsword Weapon Type", "武器类型：巨剑" },
            { "(A) Very High Damage Scaling with frost explosions!", "（A）很高的冰霜爆炸伤害！" },
            { "(A) Very High Damage Scaling with knives!", "（A）很高的飞刀伤害！" },
            { "Stein Weapon Type", "武器类型：冲击拳套" },
            { "The sorrowing souls within are crying", "聆听那灵魂的哀嚎..." },
            { "This weapon is bound by Fenix", "绯琦的力量缠绕于其上" },
            { "(S) Explosion damage is out of this world!", "（S）超神的爆炸伤害！" },
            { "(A) Honestly could wipe out many wide varieties of enemies!", "（A）威力强劲，横扫千军！" },
            { "A weapon so powerful, it holds a gravitation pull and can change forms!", "有股力量将周围的一切吸向它...还可以改变形态！" },
            { "Right click for a powerful gravitation slam!", "右键释放强力俯冲猛砸地面！" },
            { "(S) Use your right click to switch between 4 forms!", "右键在4个形态中切换！" },
            { "(S+) Godlike High Damage Scaling with the power of the sun!", "（S+）驾驭烈阳之力，展现神威！" },
            { "Multiplication and cloning is the essense of power nyaaa!", "复制，克隆，这正是力量的精华展现喵！！！" },
            { "(B) Good Damage scaling with scythe blades!", "（B）不错的镰刃伤害！" },
            { "Right click to change form, requires a Sewing Kit", "右键变化形态，需要装备织影套件包" },
            { "Changed by Sewing Kit, effects may be incorrect...", "形态发生了扭曲转变..." },
            { "Safunai Weapon Type", "武器类型：鞭刃" },
            { "(C) Medium Damage Scaling wind shots On Hit!", "（C）中等的风之矢伤害！" },
            { "(B) Medium Damage Scaling (Frost balls) On Hit!", "（B）中等的冰霜球伤害！" },
            { "(S) Great Damage scaling with swings!", "（S）极高的挥动伤害！" },
            { "(A) 3 Weapons in one!", "三武合一，何等便利！" },
            { "(A) Use your right click to switch between 3 forms!", "右键在3个形态中切换！" },
            { "(D) Low Damage scaling for Skulls on hit", "（D）低的骷髅头的伤害！" },
            { "(B) Great spread on bullets", "（B）子弹较为发散" },
            { "Gun Holster Weapon Type", "武器类型：枪套" },
            { "Use to equip to your gun holster's right hand!", "左键来将它装备至你的枪套右手！" },
            { "You do not have a Gun Holster...", "你并没有枪套..." },
            { "Buy one from Delgrim!", "去向戴尔格林买一个吧！" },
            { "(A) Great stacking and holding damage, less immunity frames!", "（A）伤害随按住堆砌得更高，且造成无敌帧更少！" },
            { "(S) Extreme damage scaling with the love sword!", "（S）极高的爱之剑伤害！" },
            { "Use to equip to your gun holster's left hand!", "左键来将它装备至你的枪套左手！" },
            { "OR right click to equip to your gun holster's right hand!", "或者，右键来将它装备至你的枪套右手！" },
            { "Can be in both hands at the same time!", "可以同时存在于枪套的左右手！" },
            { "(A) Great Damage scaling for explosions!", "（A）很高的爆炸伤害！" },
            { "(Special) The farther your cursor is, the faster the axe goes!", "特殊：你的鼠标离你越远，斧子速度越快！" },
            { "(D) Low Damage scaling for Explosions on hit", "（D）低的爆炸伤害" },
            { "Jerry does not like being called names", "杰瑞可不喜欢被别人起外号" },
            { "(D) Really low scaling damage", "（D）很低的伤害" },
            { "(D) Low Damage scaling for flames", "（D）低的火焰伤害" },
            { "(B) Great spread on with flames", "（B）范围宽广的火焰" },
            { "Red - No Effect", "红——朴实无华" },
            { "Orange - Explodes", "橙——焰华绽放" },
            { "Yellow - Teleports after hitting an enemy", "黄——闪转腾挪" },
            { "Green - High damage", "绿——会心一击" },
            { "Cyan - Causes several debuffs", "青——钻心剜骨" },
            { "Blue - Homing", "蓝——夺命追魂" },
            { "Purple - Summons powerful blades upon hitting an enemy", "紫——万剑穿心" },
            { "(B) Very good throwing weapon that sticks around!", "（B）非常棒的投掷物，而且会持续存在好一阵子！" },
            { "Orb Weapon Type", "武器类型：球体" },
            { "Juggler Weapon Type", "武器类型：抛接" },
            { "Creates flamed explosions for some explosion dusts!", "让某些魔法尘在引燃时产生火焰爆炸！" },
            { "These do not stack!", "和其他魔法尘增效器的效果不能叠加！" },
            { "Use this to put inside of your Xixian flask and when you drink it, the effects of this insource is used!", "召唤我以灌满希克斯瓶，当你饮用它希克斯瓶时，我的效果就会被触发！" },
            { "She'll just love you forever I guess.", "那，就让她永远爱着你吧" },
            { "Put one on as an accessory, eat for temporary effects!", "既可以作为饰品佩戴，也可以吃下去以获得临时效果！" },
            { "(C) Medium Damage Scaling (Fireballs) On Hit!", "（C）击中时产生中等伤害的火球" },
            { "Creates a very good voidal explosion on dust explosions and constants!", "魔法尘引爆时释放强力的虚空爆炸！" },
            { "Use an insource to put something in the flask, then drink it! It acts like an infinite potion!", "先召唤瓶内容物以灌满我，然后左键将我一饮而下！就像一瓶无限使用的药水！" },
            { "(B) Good Damage Scaling (Alcarish Blobs) On Hit!", "（B）击中时产生不错伤害的混溶块" },
            { "(C) Medium Damage Scaling (Stingers) On Hit!", "（C）击中时产生中等伤害的毒刺" },
            { "(B) Medium Damage Scaling (Grail shot) On Hit!", "（B）击中时产生中等伤害的砾金" },
            { "(C) Medium Damage Scaling (spikyballs) On Hit!", "（C）击中时产生中等伤害的刺球" },
        };
                ForceLocalizeSystem.LocalizeDerivedByType(typeof(ModItem), nameof(ModItem.ModifyTooltips), localizations);
        ForceLocalizeSystem.LocalizeByType(typeof(ClassSwapItem), nameof(ModItem.ModifyTooltips), new() {
                    { "Can be changed to", "可使用宝珠转换为" },
                    { "Damage Type Swapped!", "武器职业已被改变！" },
                });
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Items.GlobalItemEdits", nameof(ModItem.ModifyTooltips), new() {
                    { "Lunar Veil: 8% decreased ranged damage", "【穹月天纱】减少8%远程伤害" },
                    { "Lunar Veil: Stealth is MUCH less effective", "【穹月天纱】潜行的收益大大降低" },
                    { "Lunar Veil: 6% decreased ranged damage", "【穹月天纱】减少6%远程伤害" },
                    { "Lunar Veil: 6% decreased ranged critical strike chance", "【穹月天纱】减少6%远程暴击率" },
                    { "Lunar Veil: 4% decreased ranged damage", "【穹月天纱】减少4%远程伤害" },
                    { "Lunar Veil: Damage boosters are 50% less effective", "【穹月天纱】所有伤害增幅效果减少50%" },
                });

        // 应该是测试用物品
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Items.Test.HavocSignaler", nameof(ModItem.ModifyTooltips), new() {
                    { "Use this item to signal Havoc for an attack\nRight click to swap attacks", "使用此物品来控制浩劫龙械的攻击，右键切换攻击模式" },
                    { "Attack: Charge", "攻击模式：冲撞" },
                    { "Attack: Mini Laser", "攻击模式：小型激光" },
                    { "Attack: Big Laser", "攻击模式：大型激光" },
                });
        if (AlwaysFalse())
        {
            // 这一段不会被执行, 只是展示另外一种方式
            // 这种方式更加精准, 但会费力一些
            ForceLocalizeSystem.LocalizeByTypeName(nameof(AmberBroochA), nameof(ModItem.ModifyTooltips), new() {
                            { "Simple Brooch!", "简易饰符!" },
                        });
            ForceLocalizeSystem.LocalizeByTypeName(nameof(AmethystBroochA), nameof(ModItem.ModifyTooltips), new() {
                            { "Simple Brooch!", "简易饰符!" },
                        });
            // 如果不需要特定翻译的话使用整个 localizations 字典也没问题
            ForceLocalizeSystem.LocalizeByTypeName("LittleWand", nameof(ModItem.ModifyTooltips), localizations);
            ForceLocalizeSystem.LocalizeByTypeName(nameof(BonedThrowBroochA), nameof(ModItem.ModifyTooltips), localizations);
            // ...
        }
    }
    static bool AlwaysFalse() => false;
}
//风卷残云! 刮骨疗毒! 大刀阔斧! 涤荡旧弊!
