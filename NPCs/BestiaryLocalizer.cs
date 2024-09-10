namespace LunarVeilChinesePack.NPCs;

public class BestiaryLocalizer : ModSystem {
    public override void Load() {
        ForceLocalizeSystem.LocalizeDerivedByType(typeof(ModNPC), nameof(ModNPC.SetBestiary), new() {
            #region Bosses

            { "Powerful skulls sent by skeletron to roam the darkness for the next pray", "填入汉化文本" }, // AbysmLunatic

            { "A scarecrow reanimated by the passion of wandering flames", "填入汉化文本" }, // Azurerin
            
            { "A scarecrow reanimated by the passion of wandering flames", "填入汉化文本" }, // Caeva
            
            { "One who followed power, exchanging their freedom for a taste of a singularity. Trapped forever guarding whats left of the Govheil.", "填入汉化文本" }, // DaedusR
            { "The aspiring forgotten puppet", "填入汉化文本" }, // DaedusR
            { "A scarecrow reanimated by the passion of wandering flames", "填入汉化文本" }, // SolarPortal
            { "A small singularity granted to Daedus in exchange for where he lives and protects for.", "填入汉化文本" }, // SolarSingularity

            { "A crystal which holds the power of summoning one of the three deities", "填入汉化文本" }, // BloodCyst
            { "A poisonous slime mutated from normal green slimes", "填入汉化文本" }, // DreadFireCircle
            { "One of the three powerful cosmic deities that has been tainted by devilish intent", "填入汉化文本" }, // DreadMire
            { "Traded her singularity in turn for more dreadful power, ridden of anxiety and all things dreadful", "填入汉化文本" }, // DreadMireR
            { "Cozmire- Dreadmire Veil??", "填入汉化文本" }, // DreadMireR
            // 这个字符哪来的? 我不知道. 反正它不是乱码, 原文就长这样
            { "Powerful skulls tainted by devilish intent (dreadmire must誺e got bored with this one)", "填入汉化文本" }, // DreadSurvent
            { "The heart of the beast brought on by devilish intent\r\n(How the hell does that thing fit inside her chest?)", "填入汉化文本" }, // DreadMiresHeart
            { "A crystal which holds the power of summoning one of the three deities", "填入汉化文本" }, // DreadMonolith
            
            { "A mystical veil user who took accountability to chain up Sigfried", "填入汉化文本" }, // EreshkigalIdle
            { "Ereshkigal the Lover", "填入汉化文本" }, // EreshkigalIdle
            
            { "Searching for a lover, this particular Queen lacks anyone she can socialize with as she tries to gain power of the void to kill Sigfried for revenge, so much power yet so lonely.", "填入汉化文本" }, // Fenix
            { "Fenix the Vengeful", "填入汉化文本" }, // Fenix
            
            { "This person isn't the real gothivia, where is she?", "填入汉化文本" }, // Gothiviab
            { "I guess she knows you destroyed her singularity inside Daedus, oops", "填入汉化文本" }, // Gothiviabb
            { "A loving little pet of the sun goddess Gothivia", "填入汉化文本" }, // Rek
            { "A part of gothivia's largest creations", "填入汉化文本" }, // Train1, Train2
            
            { "You sense a strange godly prescence coming from Gothivia", "填入汉化文本" }, // GothiviaIdle
            { "Start to something bad", "填入汉化文本" }, // StartGoth
            { "A special snake from the Cinderspark that was atop it's food chain and took a liking to Gothivia. Eventually it became her guardian.", "填入汉化文本" }, // RekSnake
            { "Rek, The Sun Serpent", "填入汉化文本" }, // RekSnake
            
            { "A abomination housing the eggs for what seems to be a mechanical bird, born from the acid and a creation of Gia.", "一个扭曲的造物.其中装着一颗卵，看上去是机械制成的.吉娅结合了酸蚀之地的作品." }, // IrradiatedNest
            { "Irradiated Nest", "辐射巢穴" }, // IrradiatedNest 
            
            { "The most committed protector of the Govhiel. She just wishes to see her friend's and village again.", "填入汉化文本" }, // Irradia
            { "Irradia N Havoc", "填入汉化文本" }, // Irradia
            { "Start to something bad", "填入汉化文本" }, // StartIrradia
            { "A suspicious person at the bottom of the Govheil Castle", "填入汉化文本" }, // IrradiaIdle
            
            { "A scarecrow reanimated by the passion of wandering flames, exploring out of the veil.", "填入汉化文本" }, // Jack
            
            { "Niivi, The First Dragon", "填入汉化文本" }, // Niivi
            
            { "A poisonous slime mutated from normal green slimes", "填入汉化文本" }, // LazerOrb
            { "A powerful gift that was given to Cozmire, yet was stolen away by Fenix to seal away Verlia.", "填入汉化文本" }, // SingularityFragment
            { "Singularity Fragment", "填入汉化文本" }, // SingularityFragment
            { "A poisonous slime mutated from normal green slimes", "填入汉化文本" }, // SingularityOrb
            
            { "Destruction is what these bring, Fenix may of purchased some things off the black market, destroy these immediately...", "填入汉化文本" }, // STARBOMBER
            { "STARBOMBER", "填入汉化文本" }, // STARBOMBER
            
            { "A beloved magical stone guardian, protected the natural life and would petrify anyone who disturbs it.", "一具倍受喜爱的魔力石偶，保卫着自然生灵，擅闯者统统被其化作顽石." }, // StarrVeriplant
            
            { "Former flyer and born where all big birds were born, in the cinderspark.", "填入汉化文本" }, // SunStalker
            { "SunStalker, the Last Talon", "填入汉化文本" }, // SunStalker
            
            { "A powerful gift from Lumi V. to her trusted sisters.", "填入汉化文本" }, // SupernovaFragment
            { "Supernova Fragment", "填入汉化文本" }, // SupernovaFragment
            { "A poisonous slime mutated from normal green slimes", "填入汉化文本" }, // SupernovaOrb
            
            { "Someone who was consumed by their dark magic, even more so than Fenix would bother with.", "填入汉化文本" }, // Sylia
            { "Sylia, Merena's Sister.", "填入汉化文本" }, // Sylia
            { "A strange rift to void, disturbing it may yield catastrophic results...", "填入汉化文本" }, // UnderworldRift
            
            { "Clone of a powerful sexy goddess :)", "填入汉化文本" }, // CloneV, DeathVerlia, StarteV
            
            { "???", "???" }, // GothiviaIdle, IrradiaIdle

            #endregion

            { "Burining with passion I guess.", "填入汉化文本" }, // BlazingSerpentHead
            { "They guard what is theirs!", "填入汉化文本" }, // BlazingSerpentHead
            { "The most adorable goodest spicy child. Do not dare be mean to him!", "填入汉化文本" }, // SandWalker, SnowWalker
            { "He's evil yet so weak. This fellow betrayed Gothivia during their war against Fenix and his part of the army joined the other side for power.", "填入汉化文本" }, // CommanderGintzia
            { "Commander Gintzia, the betrayer", "填入汉化文本" }, // CommanderGintzia
            { "A scarecrow reanimated by the passion of wandering flames", "填入汉化文本" }, // GintziaHand
            { "Commander Gintzia, the betrayer", "填入汉化文本" }, // GintziaHand
            { "A Captain of Gothivia's ranks, be careful", "填入汉化文本" }, // GintzeCaptain
            { "A Captain of Gofria's ranks, be careful", "填入汉化文本" }, // GintzeSolider
            { "Lowest of the Gintze but can wipe you out fast! They need food too yknow :(", "填入汉化文本" }, // Gintzling
            { "The highest form of worshippers of Gothivia corrupted and risen from the grounds of the fallen Govheil Castle", "填入汉化文本" }, // Tulacrowe
            { "A lowly civilian who bought old parts from Irradia before being contaminated. They now seek revenge after having their minds altered by the acid.", "填入汉化文本" }, // IrravheilSprayer
            { "Guardians who are ready to die for Gothivia?", "填入汉化文本" }, // GovheilGuardian
            { "The last protectors of the govheil, and they are pretty formidable...", "填入汉化文本" }, // GovheilProtector
            { "A crystal which holds the power of summoning one of the three deities", "填入汉化文本" }, // GraveShard
            { "A respected sorcerer from Sigfried's old rein", "填入汉化文本" }, // IllurianMage
            { "Extremely powerful jellyfish that has been aflicted by the gild in the morrow, very dangerour", "填入汉化文本" }, // MorrowedJellyFish
            { "Even the weakest, most poor among the warriors in the morrow are still decent foes..", "填入汉化文本" }, // TribalPeasant
            { "A much richer form of the trible worshippers", "填入汉化文本" }, // TribalPriest
            { "The slime kings Royal heir, it will take his place opon death...", "填入汉化文本" }, // RoyalSlime
            { "A slime formed of pure darkness conjured by powerful beasts", "填入汉化文本" }, // ShadeSlime
            { "Powerful skulls sent by skeletron to roam the darkness for the next pray", "填入汉化文本" }, // ShadowWraith
            { "A strange lady, she seems to overflow with magical energy!", "一名奇怪的女士.她身上的魔力几乎满溢..." }, // LonelySorceress
            { "Lonely Feeble Sorceress", "孤独可怜的魔法少女" }, // LonelySorceress
            { "An old rusted cog with some magical abilities", "填入汉化文本" }, // Rustwork
            { "ewgegegeg", "填入汉化文本" }, // wwwwwwwwwwwwww
            { "ewgegegeg", "填入汉化文本" }, // wwwwwwwwwwwwww
            { "ewgegegeg", "填入汉化文本" }, // wwwwwwwwwwwwww
            { "ewgegegeg", "填入汉化文本" }, // wwwwwwwwwwwwww
            { "ewgegegeg", "填入汉化文本" }, // wwwwwwwwwwwwww
            { "ewgegegeg", "填入汉化文本" }, // wwwwwwwwwwwwww
            
        });
    }
}
