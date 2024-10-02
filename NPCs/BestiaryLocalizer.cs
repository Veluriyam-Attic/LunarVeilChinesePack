namespace LunarVeilChinesePack.NPCs;

public class BestiaryLocalizer : ModSystem
{
    public override void Load()
    {
        ForceLocalizeSystem.LocalizeDerivedByType(typeof(ModNPC), nameof(ModNPC.SetBestiary), new() {
            #region Bosses

            { "Powerful skulls sent by skeletron to roam the darkness for the next pray", "由骷髅王统领的小型骷髅头，在黑暗中寻找下一名受害者." }, // AbysmLunatic, ShadowWraith

            { "A scarecrow reanimated by the passion of wandering flames", "一只稻草人，被漂浪火焰中的热情唤醒." }, // Azurerin, Caeva, SolarPortal, GintziaHand
            
            { "One who followed power, exchanging their freedom for a taste of a singularity. Trapped forever guarding whats left of the Govheil.", "力量的追随者，甘愿献出自己的生命与自由成为奇点的容器，作为守卫被永世封印于歌维赫的残骸中." }, // DaedusR
            { "The aspiring forgotten puppet", "渴求力量的石偶" }, // DaedusR
            { "A small singularity granted to Daedus in exchange for where he lives and protects for.", "一颗小型奇点，便换来了他的永世忠诚守护" }, // SolarSingularity

            { "A crystal which holds the power of summoning one of the three deities", "一颗水晶，具有唤醒天纱三神之一的力量." }, // BloodCyst, DreadMonolith, GraveShard
            { "One of the three powerful cosmic deities that has been tainted by devilish intent", "天纱三神之一，其力量被不洁意图污染." }, // DreadMire
            { "Traded her singularity in turn for more dreadful power, ridden of anxiety and all things dreadful", "她主动放弃了自己的奇点，换来了这令人恐惧的魔法，将不安与惊惶散步整个大陆." }, // DreadMireR
            { "Cozmire- Dreadmire Veil??", "天寰——等等，绛渊恶巫？" }, // DreadMireR
            // 这个字符哪来的? 我不知道. 反正它不是乱码, 原文就长这样
            { "Powerful skulls tainted by devilish intent (dreadmire must誺e got bored with this one)", "强力的骷髅仆从，被邪恶力量侵蚀." }, // DreadSurvent
            { "The heart of the beast brought on by devilish intent\r\n(How the hell does that thing fit inside her chest?)", "惊惧力量之心\r\n（她的胸膛里怎么装得下这么个东西？？？）" }, // DreadMiresHeart
            
            { "A mystical veil user who took accountability to chain up Sigfried", "禁锢了齐格飞的神秘人物" }, // EreshkigalIdle
            { "Ereshkigal the Lover", "痴恋者厄莉什基迦勒" }, // EreshkigalIdle
            
            { "Searching for a lover, this particular Queen lacks anyone she can socialize with as she tries to gain power of the void to kill Sigfried for revenge, so much power yet so lonely.", "这名皇后几乎封闭了自我，在积蓄力量对齐格飞发起复仇的途中她舍弃了几乎其他一切.强大而孤独." }, // Fenix
            { "Fenix the Vengeful", "逐仇者，绯琦" }, // Fenix
            
            { "This person isn't the real gothivia, where is she?", "这不是真的歌瑟梵.她在哪？" }, // Gothiviab
            { "I guess she knows you destroyed her singularity inside Daedus, oops", "看来她已经知道你摧毁了代达斯和那颗奇点.哎呦." }, // Gothiviabb
            { "A loving little pet of the sun goddess Gothivia", "歌瑟梵的小宠物." }, // Rek
            { "A part of gothivia's largest creations", "歌瑟梵最宏伟的造物的一部分." }, // Train1, Train2
            
            { "You sense a strange godly prescence coming from Gothivia", "你从歌瑟梵身上感受到一股...神圣的气息." }, // GothiviaIdle
            { "Start to something bad", "一件恶事的开端" }, // StartGoth, StartIrradia
            { "A special snake from the Cinderspark that was atop it's food chain and took a liking to Gothivia. Eventually it became her guardian.", "烬火之地的一条盘龙，端坐食物链顶端.对歌瑟梵有特别的好感，甚至成了她的贴身护卫." }, // RekSnake
            { "Rek, The Sun Serpent", "炽阳盘龙 莱克" }, // RekSnake
            
            { "A abomination housing the eggs for what seems to be a mechanical bird, born from the acid and a creation of Gia.", "一个扭曲的造物.其中装着一颗卵，看上去是机械制成的.吉娅结合了酸蚀之地的作品." }, // IrradiatedNest
            { "Irradiated Nest", "辐射巢穴" }, // IrradiatedNest 
            
            { "The most committed protector of the Govhiel. She just wishes to see her friend's and village again.", "歌维赫堡最忠实最固执的守护者.她仅有的愿望是再次见到她的亲人与家园." }, // Irradia
            { "Irradia N Havoc", "伊瑞蒂安与浩劫龙械" }, // Irradia
            { "A suspicious person at the bottom of the Govheil Castle", "歌维赫堡深处的神秘人物" }, // IrradiaIdle
            
            { "A scarecrow reanimated by the passion of wandering flames, exploring out of the veil.", "一只稻草人，被漂浪火焰中的热情唤醒.在天纱之外的凡尘中游荡." }, // Jack
            
            { "Niivi, The First Dragon", "太初祖龙，尼伊维" }, // Niivi
            
            { "A poisonous slime mutated from normal green slimes", "曾经是一只普通的绿史莱姆，在酸蚀之地变异成了此毒物." }, // LazerOrb, SingularityOrb, SupernovaOrb, DreadFireCircle
            { "A powerful gift that was given to Cozmire, yet was stolen away by Fenix to seal away Verlia.", "天寰神巫获赠的宝物，被绯琦盗走后用于封印薇莉娅." }, // SingularityFragment
            { "Singularity Fragment", "破碎奇点" }, // SingularityFragment
            
            { "Destruction is what these bring, Fenix may of purchased some things off the black market, destroy these immediately...", "毁灭是此物唯一的用途.绯琦可能是在黑市买到的它们，见到它一定要悉数摧毁." }, // STARBOMBER
            { "STARBOMBER", "星爆者" }, // STARBOMBER
            
            { "A beloved magical stone guardian, protected the natural life and would petrify anyone who disturbs it.", "一具倍受喜爱的魔力石偶，保卫着自然生灵，擅闯者统统被其化作顽石." }, // StarrVeriplant
            
            { "Former flyer and born where all big birds were born, in the cinderspark.", "曾经的空中猛将，与所有巨鸟一样，出生于烬火之地." }, // SunStalker
            { "SunStalker, the Last Talon", "风沙遗爪，猎日游隼" }, // SunStalker
            
            { "A powerful gift from Lumi V. to her trusted sisters.", "天纱琉明给予她姐妹的礼物." }, // SupernovaFragment
            { "Supernova Fragment", "破碎超新星" }, // SupernovaFragment
            
            { "Someone who was consumed by their dark magic, even more so than Fenix would bother with.", "一个被黑暗魔法吞噬的人，甚至比绯琦还要走火入魔." }, // Sylia
            { "Sylia, Merena's Sister.", "赛莉亚，梅瑞娜的妹妹" }, // Sylia
            { "A strange rift to void, disturbing it may yield catastrophic results...", "一个怪异的虚空裂缝，扰动它可能会产生灾难性的后果......" }, // UnderworldRift
            
            { "Clone of a powerful sexy goddess :)", "一个强力存在的克隆体:)" }, // CloneV, DeathVerlia, StarteV
            
            { "???", "???" }, // GothiviaIdle, IrradiaIdle

            #endregion

            { "Burining with passion I guess.", "我想是在燃烧着自己的芳华吧." }, // BlazingSerpentHead
            { "They guard what is theirs!", "他们捍卫着属于他们自己的东西." }, // BlazingSerpentHead
            { "The most adorable goodest spicy child. Do not dare be mean to him!", "最可爱最好的小家伙！不要对它们那么残忍！" }, // SandWalker, SnowWalker
            { "He's evil yet so weak. This fellow betrayed Gothivia during their war against Fenix and his part of the army joined the other side for power.", "他很邪恶，但又是个纸老虎.这家伙在与绯琦的战争中背叛了歌瑟梵，他的军队加入了另一方去争夺权力." }, // CommanderGintzia
            { "Commander Gintzia, the betrayer", "变节者，金戈亚指挥官" }, // CommanderGintzia, GintziaHand
            { "A Captain of Gothivia's ranks, be careful", "歌瑟梵麾下的队长！需谨慎应对" }, // GintzeCaptain
            { "A Captain of Gofria's ranks, be careful", "歌瑟梵麾下的士兵！需谨慎应对" }, // GintzeSolider
            { "Lowest of the Gintze but can wipe you out fast! They need food too yknow :(", "最低等的玄铁士兵，但仍然致命！他们也需要吃饭的呀 :(" }, // Gintzling
            { "The highest form of worshippers of Gothivia corrupted and risen from the grounds of the fallen Govheil Castle", "在不复往日的歌维赫堡，昔日歌瑟梵最虔诚的崇拜者在腐疫的驱使下，再次起身为其而战." }, // Tulacrowe
            { "A lowly civilian who bought old parts from Irradia before being contaminated. They now seek revenge after having their minds altered by the acid.", "一位在被污染之前常常从伊瑞蒂安购买旧零件的卑微平民。酸蚀腐化了他的心智，促使着他寻求报复." }, // IrravheilSprayer
            { "Guardians who are ready to die for Gothivia?", "心甘情愿为歌瑟梵献出生命的守卫" }, // GovheilGuardian
            { "The last protectors of the govheil, and they are pretty formidable...", "歌维赫堡最后的保护者，他们不容小觑..." }, // GovheilProtector
            { "A respected sorcerer from Sigfried's old rein", "一名来自齐格飞时代受人尊敬的魔法师" }, // IllurianMage
            { "Extremely powerful jellyfish that has been aflicted by the gild in the morrow, very dangerour", "一只异常强大的水母，受幽曦的力量影响后变得更加危险." }, // MorrowedJellyFish
            { "Even the weakest, most poor among the warriors in the morrow are still decent foes..", "即使是幽曦战士中最弱小、最贫穷的人，仍然是可怕的敌人." }, // TribalPeasant
            { "A much richer form of the trible worshippers", "部族崇拜者中的佼佼者" }, // TribalPriest
            { "The slime kings Royal heir, it will take his place opon death...", "史莱姆王室的继承者，在史莱姆王退位后将由它来接替王位..." }, // RoyalSlime
            { "A slime formed of pure darkness conjured by powerful beasts", "由纯粹黑暗凝聚成的凝胶状生命体，由某个强大的怪物召唤而来." }, // ShadeSlime
            { "A strange lady, she seems to overflow with magical energy!", "一名奇怪的女士.她身上的魔力几乎满溢..." }, // LonelySorceress
            { "Lonely Feeble Sorceress", "孤独可怜的魔法少女." }, // LonelySorceress
            { "An old rusted cog with some magical abilities", "一个生锈的齿轮，或许有一些神奇的能力." }, // Rustwork
        });
    }
}
