using Stellamod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunarVeilChinesePack.BossChecklist
{
    public class CheckilstLocalizer : ModSystem
    {
        public override void Load()
        {
            //[i:别删 开头的[ 别删
            #region DoSunStalkerIntegration(烈日游隼)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoSunStalkerIntegration",
                new()
                {
                    { "Use a [i:","在沙漠的祭坛上使用[i:" },
                    {"] at an altar in the desert.","]以召唤." }
                });
            base.Load();
            #endregion

            #region DoJackIntegration(灯笼杰克)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoJackIntegration",
                new()
                {
                    { "Use a [i:","在夜晚进入古谕遗境的城堡并使用[i:" },
                    {"] at a post in the Fabled Castle to the right at night.","]以召唤." }
                });
            base.Load();
            #endregion

            #region DoDaedusIntegration(世遗者代达斯)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoDaedusIntegration",
                new()
                {
                    { "Disturb with the ruined tablet deep within the morrow.","" },
                });
            base.Load();
            #endregion

            #region DoDreadmireIntegration(绛渊恶巫)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoDreadmireIntegration",
                new()
                {
                    { "Destroy 3 dread monoliths to create a Dread medallion and summon her during night.","摧毁三个恐怖巨石来合成恐惧徽章以召唤." },
                });
            base.Load();
            #endregion

            #region DoCommanderGintziaIntegration(金戈亚指挥官)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoCommanderGintziaIntegration",
                new()
                {
                    { "Randomly each day, if you have 3 npcs and have killed the Stone Guardian, an army will raid you!","随机的一天，当你击杀了石心圣卫并且拥有至少三个NPC时，一只军队将会袭击你！" },
            base.Load();
            #endregion

            #region DoNESTIntegration(辐射巢穴)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoNESTIntegration",
                new()
                {
                    { "Buy a [i:","从吉娅处购买 [i:" },
                    {"] from Gia and use it in the virulent acid or find an Unknown Signal.","] 并使用，以在瘴煞地找到位置信号." }
                });
            base.Load();
            #endregion

            #region DoSingularityFragmentIntegration(破碎奇点)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoSingularityFragmentIntegration",
                new()
                {
                    { "Use a [i:","在冰雪深处的匿影中使用 [i:" },
                    {"] at an altar, in the Aurelus, deep in the ice.","] 以召唤." }
                });
            base.Load();
            #endregion

            #region DoVerliaIntegration(皎月薇莉娅)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoVerliaIntegration",
                new()
                {
                    //Use a [i:{summonItem7}] at a shrine in the Cathedral over the ice biome!
                    { "Use a [i:","在雪原的一个教堂中，找到一个神龛并使用 [i:" },
                    {"] at a shrine in the Cathedral over the ice biome!","] 以召唤." }
                });
            base.Load();
            #endregion

            #region DoGothiviaIntegration(青黯琉曦 歌瑟梵•伊斯)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoGothiviaIntegration",
                new()
                {
                    { "After killing her friend Irradia, Green sun will start and she will await your arrival, kill Rek to challenge her.","在你杀死伊瑞蒂安
后，歌瑟梵将等待着你. 当你击杀莱克后将获得挑战她的资格." },
                });
            base.Load();
            #endregion

            #region DoIrradiaIntegration(辐射巢穴)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoIrradiaIntegration",
                new()
                {
                    { "Give Irradia a [i:","在瘴煞深处的歌维赫堡深处给予伊瑞蒂安
 [i:" },
                    {"] at a bottom of the Govheil Castle, underneath the Virulent.","] 以召唤." }
                });
            base.Load();
            #endregion

            #region DoSyliaIntegration(赛莉亚)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoSyliaIntegration",
                new()
                {
                    { "Interact with the strange anomaly that lies in within the Underworld Ruins.","与地狱中的不稳定裂隙互动以召唤." },
                });
            base.Load();
            #endregion

            #region DoSTARIntegration(星 爆 者)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoSTARIntegration",
                new()
                {
                    {"Randomly during a hardmode Aurorean Starfall, they may fall from the sky.","在困难模式下的极光星雨中有几率掉下来！" }
                });
            base.Load();
            #endregion

            #region DoFenixIntegration(凤涅克丝)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoFenixIntegration",
                new()
                {
                    {"She resides in the royal capital far to the left, she may want to play with you!","在左面天空的皇都上找到她，她很想和你一起玩！" }
                });
            base.Load();
            #endregion

            #region DoZuiIntegration(辉光女神 蕊)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoZuiIntegration",
                new()
                {
                    {"After Plantera, Zui will sell you an item that'll allow you to fight her in the witch town!","在击败世纪之花后，蕊会售卖一个物品以允许你在女巫村庄挑战她." }
                });
            base.Load();
            #endregion

            #region DoStoneGolemIntegration(石心圣卫)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoStoneGolemIntegration",
                new()
                {
                    {"Interact with the Old Guard's Shrine. After using the rock in your Starter bag.","使用新手礼包中的石头以传送到召唤地点，右键圣卫神龛以召唤." }
                });
            base.Load();
            #endregion

            #region DoBlazingSerpentIntegration(烈焰长蛇)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoBlazingSerpentIntegration",
                new()
                {
                    {"Use a Cursed Shard at an altar in the Fire Catacombs, it may appear...","在狱之墓穴中的祭坛使用诅咒残片，它或许会出现..." }
                });
            base.Load();
            #endregion

            #region DoCogworkIntegration(废旧齿轮)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoCogworkIntegration",
                new()
                {
                    {"Use a Cursed Shard at an altar in the Trapped or Water Catacombs, it may appear...","在水之墓穴或陷阱墓穴中的祭坛使用诅咒残片，它或许会出现..." }
                });
            base.Load();
            #endregion

            #region DoWaterJellyfishIntegration(氵母)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoWaterJellyfishIntegration",
                new()
                {
                    {"Use a Cursed Shard at an altar in the Water Catacombs, it may appear...","在水之墓穴中的祭坛使用诅咒残片 它或许会出现..." }
                });
            base.Load();
            #endregion

            #region DoSparnIntegration(斯帕恩)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoSparnIntegration",
                new()
                {
                    {"Use a Cursed Shard at an altar in the Trapped Catacombs, it may appear...","在陷阱墓穴中的祭坛使用诅咒残片，它或许会出现..." }
                });
            base.Load();
            #endregion

            #region DoPandorasFireBoxIntegration(潘多拉火焰盒)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoPandorasFireBoxIntegration",
                new()
                {
                    {"Use a Cursed Shard at an altar in the Fire Catacombs, it may appear...","在狱之墓穴中的祭坛使用诅咒残片，它或许会出现..." }
                });
            base.Load();
            #endregion

            #region DoNiiviIntegration(尼伊维)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoNiiviIntegration",
                new()
                {
                    {"Deal enough damage to Niivi to anger her, you may find her flying around The Great Illuria! -or sleeping...","对尼伊维造成足够的伤害后来激怒它.你可能会发现他在星月巨树附近飞行-或者在睡觉." }
                });
            base.Load();
            #endregion

            #region DoRekIntegration(不熄炽龙 莱克)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoRekIntegration",
                new()
                {
                    {"Gothivia's sworn protector, you must take him down before you can get to Gothivia.","歌瑟梵的忠卫 只有你击败它才有资格挑战歌瑟梵." }
                });
            base.Load();
            #endregion

            #region DoSupernovaFragmentIntegration(破碎超新星)
            ForceLocalizeSystem.LocalizeByTypeName("ModIntegrationsSystem", "DoSupernovaFragmentIntegration",
                new()
                {
                    {"Go down to the Cinderspark and nag Ordin to get a gift for Ereshkigal and she may give you something in return...","前往烬火之地，向奥丁讨要一份给eresh的礼物，接受礼物后，她可能会以你想要的东西来报答你." }
                });
            base.Load();
            #endregion
        }
    }
}
