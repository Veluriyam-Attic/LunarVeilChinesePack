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
                "\nMove faster and enemies that hit you take damage back! ", "大量增加生命再生速度！\n￥￥￥￥待补全￥￥￥￥" }, // CelestiaMoonHelmet
            { "Increases life regen by a great amount!" +
                "\nMove faster and gain the effects of magic cuffs! ", "大量增加生命再生速度！\n" }, // CelestiaMoonMask
            { "This armor is really scuffed..." +
                "\nGives the ability of a molten quiver!" +
                "\n-Stuck at 400 max HP, but 20% increased damage for Rangers", "填入汉化文本" }, // DaedenMask
            { "Increases life regen by decent amount!" +
                "\nEnemies become lovestruck when you are hit, or when you hit them!" +
                "\nThis weakens, burns and confuses, slows and does exponential damage " +
                "\nSpirit balls come from a portal on your armor and attack enemies " +
                "\nNo fall Damage " +
                "\nPick up hearts from afar!", "填入汉化文本" }, // DaediaMask
            { "Enemies are less likely to target you!" +
                "\nBlades of Cinder and Rhamenthal will fight alongside you" +
                "\nEvery few seconds you'll gain a major increase to Melee Damage" +
                "\nAn upgraded Govheil set essentially. ", "填入汉化文本" }, // DucanblitzCap
            { "+1 Max Minions\n+45 Max Life \nHit enemies have a rare chance to be assaulted by angelic power!", "填入汉化文本" }, // ElagentHead
            { "Grants immunity to knockback!\n" +
                "When you take a hit, gain a temporary attack speed boost based on the amount of damage you took!", "填入汉化文本" }, // EldritchianHood
            { "Increases life regen by decent amount!" +
                "\nThe armor makes a flowery circle that heals players in it for a large amount!" +
                "\nTurns all your wooden arrows into flower arrows! Which when hitting a target, " +
                "\nsplits into little golden shots that hit back! ", "填入汉化文本" }, // FlowerHat
            { "Summons a forest bow to fight for you!", "填入汉化文本" }, // ForestCoreHead
            { "Grants immunity to knockback!\n" +
                "+2 Summons", "填入汉化文本" }, // GarbageMask
            { "Enemies are less likely to target you!" +
                "\nGovheil blades will come to defend you!" +
                "\nEvery few seconds you'll gain a major increase to Magic and Summon damage" +
                "\n+2 Summons!", "填入汉化文本" }, // GovheilHelmet
            { "Enemies are less likely to target you!" +
                "\nMagical Govheil bows will come to your aid!!" +
                "\nEvery few seconds you'll gain a major increase to Magic and Summon damage" +
                "\n+2 Summons!", "填入汉化文本" }, // GovheilMask
            { "2 Gintze Guards come to fight for you" +
                 "\n+1 Summons!", "填入汉化文本" }, // HeavyMetalHead, GintzeMask
            { "Increases life regen by a big amount!" +
                "\nReduced Healing Flask cooldown" +
                "\nDOES NOT STACK with philosophers stone", "填入汉化文本" }, // HuntrianHelmet
            { "Enemies are less likely to target you!", "填入汉化文本" }, // IllurianCrestmask
            { "Allows you to walk on water", "填入汉化文本" }, // IllurianWarriorHelm
            { "Increases life regen by a great amount!" +
                "\nMove faster and go along with the watery winds." +
                "\nSummons in watery dragons to come and swirl around your character." +
                "\nThese dragons emit a great becoming amongst the lost dynasty and give 50 Health." +
                "\nThis aura also lessens enemy damage by 10% and damages enemies." +
                "\nEnemies are less likely to target you!", "填入汉化文本" }, // JianxinMask
            { "Increases life regen by an enormous amount!" +
                "\nEnemies become lovestruck when you are hit, or when you hit them!" +
                "\nThis weakens, burns and confuses, slows and does exponential damage ", "填入汉化文本" }, // LovestruckMask
            { "Increases life regen" +
                "\nTake 10% Less damage", "填入汉化文本" }, // MardenthMask
            { "Increases summon damage by 16%"+
                "\n+2 Max Sentries" +
                "\nYour attacks have a chance to cleave out a part of the enemy's soul" +
                "\nCollect these to gain a stacking increase to your whip speed and summon damage!" +
                "\nTaking damage resets the stack", "填入汉化文本" }, // MiracleHead
            { "Increases life regen by a great amount!" +
                "\nMove faster and have less aggro and less enemies spawn around you!", "填入汉化文本" }, // ScissorianMask
            { "Summons a turret over your head to shoot a laser at nearby enemies!\n8% increased magic and summon damage", "填入汉化文本" }, // ScrappyHead
            { "Become greatly empowered for a short time when low on health!\nJust one last breath...", "填入汉化文本" }, // ShadeWraithHead
            { "Immunity to fall damage!", "填入汉化文本" }, // StoniaHat
            { "You build up magical crit chance over time!\n" +
                "+20 Max Life", "填入汉化文本" }, // TerricHead
            { "Increases life regen" +
                "\nAnyone that touches you gets an ATD (Astolfo Transmitted Disease)", "填入汉化文本" }, // AstolfoMask
            { "Auto gain the abilities of Magic cuffs and Mana Flower!" +
                "\nEnemies will be attacked by your power of music!" +
                "\nEvery few seconds you'll gain a major increase to Magic and Ranged damage!", "填入汉化文本" }, // VerlHat
            { "Auto gain the abilities of a Magic Quiver and +5% Ranged damage" +
                "\nEnemies will be attacked by your power of music!" +
                "\nEvery few seconds you'll gain a major increase to Ranged and Magic damage!", "填入汉化文本" }, // VerlMask
            { "Gain the accessory effects of desert boots!" +
                "\nAutomatically run at fast speeds without boots! " +
                "\n +3 Defense!", "填入汉化文本" }, // VextinMask
            { "I am wind in a million" +
                "\n30% Increased throwing attack speed!" +
                "\nHighly increased throwing weapon knowckback", "填入汉化文本" }, // WindmillionHat
            { "Up to three icicles surround you to protect you from attacks!", "填入汉化文本" }, // WinterbornHead
            { "Truly a giver of society! The witches respect you :P" +
                "\nGain the effects of a mana flower, magic cuffs" +
                "\nExtreme mana regeneration" +
                "\nMana costs are reduced by 50%" +
                "\nFlowery Rhythm!", "填入汉化文本" }, // WitchenHat
            { "Gain the accessory effects of desert boots!" +
                "\nAutomatically run at fast speeds without boots! " +
                "\n +5 Defense!"+
                "\nGain the effects if Forbidden armor!" +
                "\nArrows are heated up with the effects of a molten quiver!", "填入汉化文本" }, // XexterianHat
        });
    }
}
