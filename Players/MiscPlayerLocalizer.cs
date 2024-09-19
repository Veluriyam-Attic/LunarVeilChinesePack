using Stellamod;
using Stellamod.Items.Accessories.Catacombs;

namespace LunarVeilChinesePack.Players;

public class MiscPlayerLocalizer : ModSystem
{
    public override void Load()
    {
        #region 进入世界时的消息
        ForceLocalizeSystem.LocalizeByType(typeof(MyPlayer), nameof(MyPlayer.OnEnterWorld), new() {
            { "[Lunar Veil] Hi hi! Thank you for checking out the mod! If you want more, you can check out my game Diari!", "【穹月天纱作者】你好啊！感谢你游玩我的mod！如果你还想要看看我做的其他东西，上steam搜Diari就好！\n行走的wiki群：909428503" },
        });
        #endregion
        #region FlamecrestPlayer
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Items.Accessories.Catacombs.FlamecrestPlayer", "BlockVisuals", new() {
            { "Resisted!", "抵抗！" },
            { "The Lunar tree rumbles...", "星月巨树颤抖著..." },
            { "The Abysm and Virulent stir...", "无尽深渊和瘴煞之地蠢蠢欲动..." },
            { "Azurewrath's dreams alcadize the sky.", "蔚蓝之梦将天空魔力化" },
            { "The toxic reunion begins! Gothivia's love bleeds through as the sun burns with everlasting hue.", "恒日高升，歌瑟梵的爱意从中渗出.团聚在即..." },
        });
        #endregion
        #region 某些时候会从玩家头上弹出的文字
        ForceLocalizeSystem.LocalizeByType(typeof(MyPlayer), nameof(MyPlayer.PostUpdate), new() {
            { "Wohooo", "芜湖！" },
            { "Omg, its something!", "哎呦！掉东西了！" },
            { "Are you disappointed? You should be.", "失望吗？失望就对啦" },
            { "Wow, you have no maidens and no luck..", "幸运女神完全不搭理你呢" },
            { "Sooo lucky!", "幸运！" },
            { "How can someone be so interesting?", "你真有意思！" },
            { "Hiii its a me Bridget your friendly companion :3", "你好~是我呀！你的好伙伴布里姬！" },
            { "Please dont replace me :(", "请别扔掉我 :(" },
            { "This world is soo pretty! Just like you :p", "这世界好漂亮！和你一样 :p" },
            { "Im so much better than Lucy :)", "我比露西斧强太多了好吗！" },
            { "I used to have a roommate, they stink really badly", "我之前和另一个人住在一起过，他身上的味道可重了." },
            { "I love these journeys! I hope you won't throw me away...", "和你一起旅行好开心！不要抛下我哦..." },
            { "Are you gonna get married someday? I'm always an option yknow >~<", "想要结婚吗？我也是个不错的选择哦 >~<" },
            { "When I was in my human form I was the Queen of the uh, morrow? I forgot.", "当我还是人类的时候我是...嗯...幽曦的女王？好像是吧." },
            { "Don't forget to brush your teeth! Its good for you :)", "别忘了刷牙！精气神一定要好！" },
            { "I completely forgot what it feels like to be flat and everyday you hold me is a reminder.", "我都快忘了我变得这么扁，但你一把我拿起来我就想起来了." },
            { "I can't tell if I like you holding me or sexual assault.", "你这么握著我已经算是骚扰了吧" },
            { "I have so many stories I can share to you :)", "我有好多故事要讲呢 :)" },
            { "My sister turned me into a sword but I think you can get me out rightttt?", "我姐把我变成了一把剑，你能帮帮我的对吧？" },
            { "I totally don't like you at all, all you did was pull me from a stone yknow :(", "我..我才不喜欢你呢！你不就是把我从石头里拔出来了吗？哼！" },
            { "You're soooo stupid :)", "大傻瓜~ :)" },
            { "I'm you're daily reminder that you aren't alone :p", "我会天天提醒你你不是独自一人的 :p" },
            { "Hey so will you take me all the way to the end, I've taken a liking to you >:)", "把我带在身上直到永远吧，我好喜欢你哦 >:)" },
            { "It's not hehe, its HEHE", "嘻嘻，不嘻嘻" },
            { "I loveee painting, I think I could get back to form if I'm merged with something related", "我超爱画画！如果你把我和其它什么东西合在一起，说不定我的本体就能解放了！" },
            { "Use me for a spin will ya!", "大风车那个吱呦呦地转~" },
            { "I'm not your normal yandere girl you know, please dont leave me :<", "我才不是傲娇呢！你别走好吗 :<" },
            { "It's all fun and games until you get slashed by a dirt sword with boobs", "被一把女性的剑砍可不好受吧？" },
            { "I am so R rated", "我的评级是R" },
            { "Shawty get your head in the game", "宝贝，专心点！" },
            { "Can we get to painting or volleyball pleasee?", "咱可以画个画，打打排球什么的吗？" },
            { "You're holding me in all the right ways >:)", "被你握著好舒服噢 >:)" },
            { "I dont care what you are, you obviously cared enough to get me :P", "我才不会评价你呢，你都把我从那里救出来了." },
            { "LALALA you're wrong I'm right LALALALA", "啦啦啦，不听不听，啦啦啦~" },
        });
        #endregion
        #region 钓鱼时
        ForceLocalizeSystem.LocalizeByType(typeof(MyPlayer), nameof(MyPlayer.CatchFish), new() {
            { "You feel threatened...", "你感觉到威胁逼近..." },
        });
        #endregion
        #region 死亡信息
        ForceLocalizeSystem.LocalizeByType(typeof(MyPlayer), "CustomDeath", new() {
            { " was consumed by the abyss.", "被深渊吞噬了" },
            { " was contaminated", "被污染吞并了" },
            { "You touched a black hole... WHAT DID YOU THINK WOULD HAPPEN?", "你觉得触碰一个黑洞的结果还能是怎样？？？" },
        });
        #endregion
    }
}
