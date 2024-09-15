namespace LunarVeilChinesePack.Items;

public class ArmorSetLocalizer : ModSystem {
    public override void Load() {
        ForceLocalizeSystem.LocalizeDerivedByType(typeof(ModItem), nameof(ModItem.UpdateArmorSet), new() {
            { "Stand still to emit a toxic aura!", "站立不动以散发出有毒的气息!" }, // AcidHelm, AcidMask, AcidRobe, AcidVisor
            { "\n+1 max minions" +
                "\nThe stars of Illuria protect you!", "\n+1 随从栏\n星树之地的明星会护佑着你!" }, // AlcaliteMask
            { "You are a true mage..." +
                "\nGain the effects of a mana flower, magic cuffs, and retrieve magic stars from afar " +
                "\nMana costs are reduced by 70% and increased magic regeneration", "你是真正的法师...\n获得魔力花、星力手环并收集远处的星星!\n减少70%的魔力消耗并提升魔力再生速度" }, // AlsisMask
            { "3, 2, 1 .. Smile! Act like you're on stage will ya :p" +
                "\nEvery little while you'll get a countdown, and when you hear Zero," +
                "\nyour crit is 100% and damage output is doubled! " +
                "\nSmall bits of paint left in your tracks." +
                "\nCrit chance and armor penetration increased by 20!", "3，2，1..大声笑出来！像你在舞台上表演一样！:p\n每隔一小段时间进行一次倒计时，当你听到“Zero“时\n你将必定暴击，伤害加倍！\n在你走过的地方留下印记\n暴击率和护甲穿透提高20%" }, // ArtisanMask
            { "Stars orbit around you\nHit an enemy 5 times to rain down a gigantic star upon them!", "一颗璀璨的明星在围绕着你运动！\n每攻击五次敌人明星将会从他们上方坠落!" }, // AstrasilkHead
            { "Increases life regen by a great amount!" +
                "\nMove faster and enemies that hit you take damage back! ", "大量增加生命再生速度！\n更快的移速并且攻击你的敌人会受到伤害！" }, // CelestiaMoonHelmet
            { "Increases life regen by a great amount!" +
                "\nMove faster and gain the effects of magic cuffs! ", "大量增加生命再生速度！\n更快的移速并获得魔法手铐的效果." }, // CelestiaMoonMask
            { "This armor is really scuffed..." +
                "\nGives the ability of a molten quiver!" +
                "\n-Stuck at 400 max HP, but 20% increased damage for Rangers", "这个盔甲已经磨损了...\n给予熔火箭袋的效果\n增加20%远程伤害但是生命值上限为400" }, // DaedenMask
            { "Increases life regen by decent amount!" +
                "\nEnemies become lovestruck when you are hit, or when you hit them!" +
                "\nThis weakens, burns and confuses, slows and does exponential damage " +
                "\nSpirit balls come from a portal on your armor and attack enemies " +
                "\nNo fall Damage " +
                "\nPick up hearts from afar!", "大量增加生命再生速度!\n当你被击中或者击中敌人时，敌人将坠入爱河\n造成虚弱，灼烧，困惑，减速并且伤害递增\n会有魂球从你盔甲上的传送门出来并攻击敌人\n免疫掉落伤害\n从更远处拾取爱心！" }, // DaediaMask
            { "Enemies are less likely to target you!" +
                "\nBlades of Cinder and Rhamenthal will fight alongside you" +
                "\nEvery few seconds you'll gain a major increase to Melee Damage" +
                "\nAn upgraded Govheil set essentially. ", "敌怪不太可能以你为目标\n烬火之刃和雷曼索织魔将会与你并肩作战！\n每过几秒会大幅度提高你的近战伤害\n升级后的歌维赫套装." }, // DucanblitzCap
            { "+1 Max Minions\n+45 Max Life \nHit enemies have a rare chance to be assaulted by angelic power!", "+1召唤栏\n+45最大生命值\n击中敌人有小概率进行一次天使力量的攻击!" }, // ElagentHead
            { "Grants immunity to knockback!\n" +
                "When you take a hit, gain a temporary attack speed boost based on the amount of damage you took!", "免疫击退\n受伤时根据你收到的伤害短暂性增加攻击速度！" }, // EldritchianHood
            { "Increases life regen by decent amount!" +
                "\nThe armor makes a flowery circle that heals players in it for a large amount!" +
                "\nTurns all your wooden arrows into flower arrows! Which when hitting a target, " +
                "\nsplits into little golden shots that hit back! ", "大量增加什么再生速度!\n召唤出一个花圈并治疗玩家\n将你射出的所有木箭变为花箭\n当击中目标时投射小金弹来回击!" }, // FlowerHat
            { "Summons a forest bow to fight for you!", "召唤一个森之弓为你而战！" }, // ForestCoreHead
            { "Grants immunity to knockback!\n" +
                "+2 Summons", "免疫击退\n+2召唤栏" }, // GarbageMask
            { "Enemies are less likely to target you!" +
                "\nGovheil blades will come to defend you!" +
                "\nEvery few seconds you'll gain a major increase to Magic and Summon damage" +
                "\n+2 Summons!", "敌人不太可能以你为目标\n歌维赫之刃将会保护你\n每过几秒会大幅提高你的魔法和召唤伤害\n+2召唤栏" }, // GovheilHelmet
            { "Enemies are less likely to target you!" +
                "\nMagical Govheil bows will come to your aid!!" +
                "\nEvery few seconds you'll gain a major increase to Magic and Summon damage" +
                "\n+2 Summons!", "敌人不太可能以你为目标\n歌维赫魔能弓将会帮助你\n每过几秒会大幅提高你魔法和召唤伤害\n+2召唤栏" }, // GovheilMask
            { "2 Gintze Guards come to fight for you" +
                 "\n+1 Summons!", "召唤两个玄铁护卫来给你而战\n+1召唤栏" }, // HeavyMetalHead, GintzeMask
            { "Increases life regen by a big amount!" +
                "\nReduced Healing Flask cooldown" +
                "\nDOES NOT STACK with philosophers stone", "大量增加生命再生速度\n减少治疗药水的冷却时间\n不要与点金石一起使用" }, // HuntrianHelmet
            { "Enemies are less likely to target you!", "敌人不大可能以你为目标" }, // IllurianCrestmask
            { "Allows you to walk on water", "允许你在水上行走" }, // IllurianWarriorHelm
            { "Increases life regen by a great amount!" +
                "\nMove faster and go along with the watery winds." +
                "\nSummons in watery dragons to come and swirl around your character." +
                "\nThese dragons emit a great becoming amongst the lost dynasty and give 50 Health." +
                "\nThis aura also lessens enemy damage by 10% and damages enemies." +
                "\nEnemies are less likely to target you!", "大量增加什么再生速度\n增加移动速度，与水流和迅风同行\n召唤水龙来围绕你盘旋\n这些龙散发出倾颓的王朝中的巨大能量，并给予50点生命值\n这种光环将会使敌人的伤害降低10%\n敌人不太可能以你为目标！" }, // JianxinMask
            { "Increases life regen by an enormous amount!" +
                "\nEnemies become lovestruck when you are hit, or when you hit them!" +
                "\nThis weakens, burns and confuses, slows and does exponential damage ", "大量增加生命再生速度!\n当你被击中或者击中敌人时，敌人将坠入爱河\n造成虚弱，灼烧，困惑，减速并且伤害递增" }, // LovestruckMask
            { "Increases life regen" +
                "\nTake 10% Less damage", "增加生命再生速度\n减少10%伤害" }, // MardenthMask
            { "Increases summon damage by 16%"+
                "\n+2 Max Sentries" +
                "\nYour attacks have a chance to cleave out a part of the enemy's soul" +
                "\nCollect these to gain a stacking increase to your whip speed and summon damage!" +
                "\nTaking damage resets the stack", "增加16%召唤伤害\n+2哨兵栏\n你的攻击可以收割敌人的部分灵魂\n收集这些将会增加你的挥鞭速度和召唤伤害\n当你受到伤害时会重置此效果" }, // MiracleHead
            { "Increases life regen by a great amount!" +
                "\nMove faster and have less aggro and less enemies spawn around you!", "大量增加生命再生速度\n攻击更快！伤害更少！敌人更少！" }, // ScissorianMask
            { "Summons a turret over your head to shoot a laser at nearby enemies!\n8% increased magic and summon damage", "在头顶上召唤一个炮塔并发射激光\n+8%魔法和召唤伤害" }, // ScrappyHead
            { "Become greatly empowered for a short time when low on health!\nJust one last breath...", "生命值很少时将会获得巨大的力量\n回光返照？" }, // ShadeWraithHead
            { "Immunity to fall damage!", "免疫摔落伤害" }, // StoniaHat
            { "You build up magical crit chance over time!\n" +
                "+20 Max Life", "魔法暴击率逐步提高\n+20最大生命值" }, // TerricHead
            { "Increases life regen" +
                "\nAnyone that touches you gets an ATD (Astolfo Transmitted Disease)", "增加生命再生速度\n使所有触碰你的人罹患阿斯托弗传染病" }, // AstolfoMask
            { "Auto gain the abilities of Magic cuffs and Mana Flower!" +
                "\nEnemies will be attacked by your power of music!" +
                "\nEvery few seconds you'll gain a major increase to Magic and Ranged damage!", "获得魔法手铐和魔力花的效果\n敌人会被你的乐之力攻击！\n几秒钟后，将大幅增加你的魔法和远程伤害！" }, // VerlHat
            { "Auto gain the abilities of a Magic Quiver and +5% Ranged damage" +
                "\nEnemies will be attacked by your power of music!" +
                "\nEvery few seconds you'll gain a major increase to Ranged and Magic damage!", "获得魔法箭袋的效果并增加5%远程伤害\n敌人会被你的乐之力攻击！\n几秒钟后将会大幅度增加你的远程和魔法伤害" }, // VerlMask
            { "Gain the accessory effects of desert boots!" +
                "\nAutomatically run at fast speeds without boots! " +
                "\n +3 Defense!", "获得沙丘行者靴的效果\n无需靴子即可自动高速行走！\n+3防御力" }, // VextinMask
            { "I am wind in a million" +
                "\n30% Increased throwing attack speed!" +
                "\nHighly increased throwing weapon knowckback", "“夫物芸芸，各复归其根.”PS：zjm看完这个PS记得删了，这个句话出自老子第13章\n增加30%投掷伤害" }, // WindmillionHat
            { "Up to three icicles surround you to protect you from attacks!", "冰锥会出现在你身边保护你，最多三只" }, // WinterbornHead
            { "Truly a giver of society! The witches respect you :P" +
                "\nGain the effects of a mana flower, magic cuffs" +
                "\nExtreme mana regeneration" +
                "\nMana costs are reduced by 50%" +
                "\nFlowery Rhythm!", "你是真正的社会贡献者！女巫会尊重你！\n获得魔力花和魔法手铐的效果\n极高的魔力再生速度\n魔力消耗减少50%\n花之律！" }, // WitchenHat
            { "Gain the accessory effects of desert boots!" +
                "\nAutomatically run at fast speeds without boots! " +
                "\n +5 Defense!"+
                "\nGain the effects if Forbidden armor!" +
                "\nArrows are heated up with the effects of a molten quiver!", "获得沙丘行者靴的效果\n无需靴子即可高速行走\n+5防御力\n获得禁忌盔甲的效果\n拥有熔火箭袋的效果，将木箭点燃" }, // XexterianHat
        });
    }
}
