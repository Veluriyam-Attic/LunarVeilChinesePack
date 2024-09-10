using Stellamod.NPCs.Bosses.Ereshkigal;
using Stellamod.NPCs.Bosses.Zui.Projectiles;
using Stellamod.NPCs.Town;

namespace LunarVeilChinesePack.NPCs;
public class TownNPCLocalizer : ModSystem {
    public override void Load() {
        #region Aimacra 安魅凯拉
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.SetBestiary), new() {
            { "Aimacra??? From Diari?? Crazy", "安魅凯拉？？？从Diari来的？？好疯狂噢！" },
            { "Aimacra", "安魅凯拉" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.GetChat), new() {
            { "They also have fox ears like me lmao", "填入汉化文本" },
            { "This world seems a bit off don't you think?", "填入汉化文本" },
            { "I'm not one to brag but this place is so much better than Ekrose", "填入汉化文本" },
            { "Did Sirestias ask me to find her again?", "填入汉化文本" },
            { "Yeah I've been traveling while you were out.", "填入汉化文本" },
            { "Go play Diari on steam? I have no idea what that means", "填入汉化文本" },
            { "Do people think I'm not into pans?", "填入汉化文本" },
            { "Sooo can we forget about everything that happened in Ekrose?", "填入汉化文本" },
            { "I am really sorry for what we went through but now were here you know?", "填入汉化文本" },
            { "Sirestias went out again, and this time I'm not finding her.", "填入汉化文本" },
            { "Hey could you go do something, I'm about to get dressed, but honestly I say that like you haven't seen me before.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Aimacra), nameof(Aimacra.SetNPCNameList), new() {
            // 安魅凯拉有三个名字,  一个是 Aimacra, 一个是 Aimacra, 一个还是 Aimacra
            { "Aimacra", "Aimacra" },
            { "Aimacra", "Aimacra" },
            { "Aimacra", "Aimacra" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.SetChatButtons), new() {
            { "Talk", "闲聊" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.OnChatButtonClicked), new() {
            { "Heyyy at least we're out of Ekrose alive! I'm glad Vixyl is safe back at the main house.", "填入汉化文本" },
            { "I hate being Sirestias's Assassin.. Speaking of I met a guy named Veldris and he's totally cool!", "填入汉化文本" },
            { "I'll be back I may go to look for some new stuff underground. ", "填入汉化文本" },
            { "What is a thug shaker? To shake or not to shake? Sometimes I wonder if life truly does give lemons.", "填入汉化文本" },
            { "What class would I even be? ", "填入汉化文本" },
            { "Hey sorry for what may of happened on Ekrose but I hope we can still be friends and make up to each other.", "填入汉化文本" },
            { "STARBOMBERS ARE ON THIS PLANET TOOOOO!!!", "填入汉化文本" },
            { "I totally haven't been playing geometry dash.", "填入汉化文本" },
            { "I've seen some weird things in my life, but never would I have thought Fenix would be more chronically horny than Sirestias, but to be fair Sirestias just gets more power doing that.", "填入汉化文本" },
            { "I hate being part human.", "填入汉化文本" },
        });
        #endregion
        #region Bordoc 波尔杜克
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.SetBestiary), new() {
            { "Steaming from the depths", "燃烧，冒烟" },
            { "Bordoc the eternal blacksmith", "铁匠波尔杜克" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.GetChat), new() {
            { "Shes got some great cogs", "填入汉化文本" },
            { "BRMMMM", "喀 喀" },
            { "Everyone always uses me but never asked how I'm able to talk.. ", "所有认识我的人中，没人问过我是怎么说话的..." },
            { "I don't care I need to gamble", "我对赌博不屑一顾" },
            { "My armors are the best in the lands", "我打造的盔甲无可匹敌！" },
            { "Sirestias and Aimacra game by recently and they laughed at me because they thought my shop was useless", "希丝忒莉亚和安魅凯拉最近过来转了一圈，她们居然敢嘲笑我的工艺！" },
            { "Im always feeling hot!", "我炎热无比！" },
            { "Heh, nobody is as good as me", "我的技巧天下无双！" },
            { "Burning Burning, heat and heat", "燃烧，燃烧，热量，热量！" },
            { "I'm inpenetrable", "我坚固无比！" },
            { "Damn we have some hot shit here", "这里有点热啊" },
            { "Only I know that Gothivia has so many barriers between her and the rest of the world, nobody will be able to kill her.", "我只知道，歌瑟梵在她与世界之间设下了重重阻碍，没人能找到她." },
            { "Those idiot gintze have made a horrible decision, now they can't use my armors I made for them.", "那些玄铁蠢货们真是不识时务，现在他们用不了我造的盔甲了." },
            { "KRMMMKTEYYYMMMM BRMMMMM", "咯咯咯咯 嗡嗡嗡 咯吱咯吱" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Bordoc), nameof(Bordoc.SetNPCNameList), new() {
            { "Blacksmith BORDOC", "铁匠波尔杜克" },
            { "Blacksmith BORDOC", "铁匠波尔杜克" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.SetChatButtons), new() {
            { "Heart of the Morrow", "幽曦之心" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.OnChatButtonClicked), new() {
            { "I want you to prove to me you're ready to obtain this, I've given you a broken core, if you restore its power, it's all yours. Show me your determination to be Gothivia's doll! You won't be the first to fail.. And maybe she'll come to thank you one day. ", "向我证明你值得拥有它：这是一个破损的核心，如果你能修复它，它就归你了.你对歌瑟梵的忠诚能够支持你走出这一步吗？如果你失败了,你可不是第一个.如果你成功了，她会由衷感谢你的." },
        });
        #endregion
        #region BoundGia 受缚的吉娅
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BoundGia), nameof(BoundGia.OnKill), new() {
            { "Im being taken away help!", "我被抓走了！救命！" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BoundGia), nameof(BoundGia.SetBestiary), new() {
            { "A bound scientist lurking in the Virulent", "瘴煞之地的一名被绑架的科学家" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BoundGia), nameof(BoundGia.GetChat), new() {
            { "Oh goodness thank you for saving me. I dont know how long I was tied up... I got stranded down here by a bunch of scouts I presume are from the morrow. I really caused a mess this time but I am really glad you saved me. D'you have a place to stay?", "天哪，太谢谢你帮我松绑了！我都记不清我在这里呆了多久...一群应该是幽曦那里的斥候把我扔到这就走了.正当我要放弃的时候你就把我救了！你有能住的地方吗？" },
        });
        #endregion
        #region CellConverter 分子转换器
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.SetBestiary), new() {
            { "Burning in a magical laboratory", "在一个古老的魔法工厂里仍然运转着" },
            { "The Cell converter", "分子转换器" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.GetChat), new() {
            { "KRTTCAVSJKSC", "咯咯 哒哒 吱 喀" },
            { "I WANT SCRAP", "我 要 废料" },
            { "MAKE YOUR SCRAP TOKENS FOR TRADE. KRM", "请 做 一些 废料 来 交换. 喀." },
            { "YEEERRRM", "呜呜呜 轰" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.SetNPCNameList), new() {
            { "Cell Converter", "分子转换器" },
            { "Cell Converter", "分子转换器" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.SetChatButtons), new() {
            { "Put in scrap token", "放入废料" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.OnChatButtonClicked), new() {
            { "Weapon Converted!", "武器 类型 已 转化 完成" },
            { "KRRRT, Sensors say you have inputed a token, here you go per request.", "咯咯， 传感器 检测 到 废料， 给 你 东西" },
            { "Womp womp, looks like nothing for you!", "呜 呜， 没有 东西 给 你" },
            { "Error, try again.", "出现 错误， 请 再次 尝试" },
            { "Put in another token.", "请 继续 放入 废料" },
        });
        #endregion
        #region Delgrim 戴尔格林
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.SetBestiary), new() {
            { "A magical engineer huh?", "魔法，工匠？有趣..." },
            { "Delgrim the eternal engineer.", "永世工匠戴尔格林" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.GetChat), new() {
            { "You're chill aren't ya?", "填入汉化文本" },
            { "Everyone comes in for the same stuff, come and go please.", "填入汉化文本" },
            { "Another visitor?", "填入汉化文本" },
            { "What goes on in the world nowadays?", "填入汉化文本" },
            { "I don't mean trouble, but do as you please.", "填入汉化文本" },
            { "...", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Delgrim), nameof(Delgrim.SetNPCNameList), new() {
            { "Magical Engineer Delgrim", "魔法工匠戴尔格林" },
            { "Magical Engineer Delgrim", "魔法工匠戴尔格林" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.SetChatButtons), new() {
            { "Old Tales", "听他讲些往事" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.OnChatButtonClicked), new() {
            { "An old time there was a thriving capital, we used to call it the Harboring Morrow. It was a thriving city under the protection of Gothivia, Verlia, and Irradia. I used to be a member. Gothivia loved every one of us, Verlia would be off directing armies and Irradia well she spent time making electronics. ", "填入汉化文本" },
            { "Irradia would make amazing tech, and I would come to every show she would host and watch her mechanic sword fights and spare parts, Verlia would sometimes participate and tear all of them apart. Verlia was just too good of a swordsman.", "填入汉化文本" },
            { "Gothivia would always come down at 10 A.M in the morning to greet all the city members, it used to be the time of my life. She'd give us goodies and Rek would come by with his binding light to empower the underground and brighten things up. ", "填入汉化文本" },
            { "Verlia and Gothivia are sisters, although they don't look it anymore, they used to be twins yet they couldn't be different from each other. Verlia was always rambunctious and outgoing while Gothivia was a calm and loving soul, the two got along.", "填入汉化文本" },
            { "Of all the inventions Irradia made, by far my favorite was a rendition of Gothivia's Rek called Havoc. It was a magnificent beast. It held it's own against Verlia in the shows, if only I could go back to those days. ", "填入汉化文本" },
            { "Verlia always would be training the army, the gintze army wasn't exactly the most reliable mainly because of Verlia's idiocity and lack of care for danger. The army would always charge head first without a care for defense. I wonder where the army was when we were defending against the Carian warriors and knights", "填入汉化文本" },
            { "Some days I look back on the Harboring Morrow and wonder why we fell so hard. I remember BORDOC, an excellent blacksmith but too arrogant to read his ways. Irradia taught me some amazing things I carry with me today and all the people. the people.. ", "填入汉化文本" },
            { "You know, I had loved Irradia, until we seperated through war our connection was magically I would say. Damn witches and their artistry. I don't hate magic, but its the reason I lost so much. That commander, I will never forget the smirk on that face. So called Fenix and her army of Carian knights. ", "填入汉化文本" },
            { "One day in the Harboring Morrow, the most joyous of days, some collectors came back infected by some strange disease, as you may know now it's called the Virulent. An acid like corruption that eats at the soul. It tore our village apart like the black plague. It weakened us, right before a Carian army swept us away at our worst, we stood no chance.", "填入汉化文本" },
            { "Verlia one day left the Morrow to search and make peace with the witches in the upcoming villages, she was by far the most magical out of the three of them, so she would stand a chance to help, when she came back, she was out of her mind.", "填入汉化文本" },
            { "When Verlia came back from her excursion, she well, gave information that changed the course of our lives. Me being in a relationship with Irradia I was able to be let in on that information. She shared to us a tome from a small witch village. This would a fatal mistake.", "填入汉化文本" },
            { "Verlia's excursion took place right when the corruption started occuring, she went to look for a way to heal the damaged. Gothivia would do her best to heal everyone but she was only one person in the biggest capital in terraria. ", "填入汉化文本" },
            { "One harrowing day, a fox appears at the doorstep of Verlia and Gothivia's abode. I knew my eyes decieved me when I had seen the fox transform into a tall Nero, they are like human cats but I thought they'd been extinct for millenia! ", "填入汉化文本" },
            { "When a fox arrived on the doorsteps of our beloved, The fox lady brings out what I can only think was a lantern and all I could make out inside that room was a giant blue flash and the screams of Gothivia. This was the last time anyone heard of Verlia.", "填入汉化文本" },
            { "After what I call the 'blue flash,' everyone hurried to a sign of screaming in the middle of the night. We all come to see Gothivia crying with a note in her hand and the fox lady. She introduced herself as Fenix. ", "填入汉化文本" },
            { "Fenix was a tall statured woman yet extremely menacing, at times a lot of us thought she may have been more powerful than Gothivia, but deep down Gothivia's suppressed feelings for her family would probably overcome that. ", "填入汉化文本" },
            { "The illnesses started to rack up and since Verlia disappeared, our Harboring Morrow was not complete, there was nobody to keep our armies in check, Gothivia wasn't mentally there anymore and Irradia was trying her best to get everyone to calm down. It was a horrible time.", "填入汉化文本" },
            { "Irradia did explain what happened to Verlia, but I thought it was just downright evil. Fenix trapped Verlia's soul inside a lantern and bounded it to a secret power for experimentation because she stole a book from their village. We'll never get to see her again will we?", "填入汉化文本" },
            { "I think Irradia's way of coping to the loss of Verlia was teaching me now that Im starting to recollect. She may have used it as a way of reflecting, and I didn't see that she was hurting yet I was always there for her.", "填入汉化文本" },
            { "I kept on living, hell I even got sick from the Virulent, yet I was Gothivia's last person to get healed from her. Rek eventually got infected too yet since havoc was electronic, he stayed normal. The creatures that lived the best were mostly metallic, its what remains of our old village.", "填入汉化文本" },
            { "After the last healing in from Gothivia, I'd say about 90% of our village was wiped out from the Virulent, our soliders, our love, and will to live all started to fall apart. ", "填入汉化文本" },
            { "I could recall me laying on a bed as I watched our city crumble, Irradia would stay by my side and we'd comfort each other as the world caved in for us.", "填入汉化文本" },
            { "After a while of our suffering in the city Gothivia would leave to seek vengence and power to save her sister, leaving Irradia to be at the helm. Take a guess who arrived not so soon afterwards? Fenix, she came to take what was left of us.", "填入汉化文本" },
            { "Fenix is like a scouraging raven looking for its next feast, and we were on the menu. I was forced to split from my love due to her sacrifices of being a leader. We haven't seen each other since, yet I know she's out there somewhere. No way would she loose to Fenix..", "填入汉化文本" },
            { "The Great Departure, that's what I call the leaving from what was left in our city. As the Carian army approached, we hid through underground tunnels to escape, some of us, including me, haven't gone back to the surface. I was even invited to come to the Fable.", "填入汉化文本" },
            { "Those who made it to the surface from the Great Departure reinvented the Harboring Morrow yet from all the messages from BORDOC, it isn't the same. They close their doors to everyone in fear and they look for Gothivia, she never said where she went.", "填入汉化文本" },
            { "I was in tunnels underground for 10 of my years, now I lay here with all the corpses and electronics that I bear, I've travelled every part of this world except the surface, to ever find Fenix again would send me over my limit.", "填入汉化文本" },
            { "You know, maybe I should have travelled with the rest of the members of the morrow, many of us split up in our escape, many died, hell, maybe I'm the only standing survivor, but I'm here.", "填入汉化文本" },
            { "My creations that I make now are from my explorations, I will find Irradia again, I need to apologize, to say something. These are all for her anyway. If only I could have stopped this from getting this way, maybe I could have stayed against her will.", "填入汉化文本" },
            { "Of all my years to live and ever to live, I will never understand things like Fenix, her torturous additude, why she went to such lengths to kill us, why the infection was so hard to fend off, and why I couldn't stay, these are all for you, Irradia. ", "填入汉化文本" },
        });
        #endregion
        #region Gambit 赌徒
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.SetBestiary), new() {
            { "She loves those ruin medals huh?, so much so that she is now attracted to you :(", "她太喜欢那些遗迹勋章了！以至于她已经对你生出了感情 :(" },
            { "Zielie the Gambit", "赌徒泽丽" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.GetChat), new() {
            { "I love the party girl! Shes really sweet! Umm could you maybe hook us up :(", "我太喜欢派对女孩啦！她又善良又有趣！你觉得你能不能...给我们互相介绍一下？" },
            { "Hii, it is a me, Zielie! I'm frantic at moments but what can you expect when your in a world full of death and loooove?", "嗨~，我叫泽丽！我有时会有点神经质，但在一个充满爱与死亡的世界中这样不是最好了吗！！" },
            { "Ive heard that the morrow is very pretty, I talked to veribloom and she said her society is falling apart though so maybe not.", "听说幽曦之地很漂亮，但我问薇绿的时候她说那里的社会已经快要完全失控了，我还是先不去那里了为妙." },
            { "I have some things on the market for you, I go around collecting items and I get more stuff when you beat bosses and honestly, you seem really cool! :0", "我这里有点好东西卖给你！都是我自己捡来的和你打Boss剩下的东西~你也很棒哟！" },
            { "You know who is responsible for your dice rolling righttt? You know, uh after you beat bosses? Yeah, thats me ya silly lovebug", "哎，你知道你的赌博骰子都是谁在扔对吧？就是我呀你个小傻瓜." },
            { "Can we get married?", "咱们来结个婚，你意下如何？" },
            { "Soo are we gonna get married or are you gonna buy something?", "买点东西吧！难不成你想把自己卖给我？" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Delgrim), nameof(Delgrim.SetNPCNameList), new() {
            { "Zielie", "Zielie" },
            { "Zemmie", "Zemmie" },
            { "Zeilie", "Zielie" },
            { "Zielie", "Zielie" },
            { "Wenomechinimasama", "Wenomechinimasama" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.SetChatButtons), new() {
            { "Marry", "求婚！" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.OnChatButtonClicked), new() {
            { "OMG YOU DOOOO? Aww youre so sweet \nwe can hold off until a bit later :3", "天哪你答应了？？？！！！当然啦甜心~但我们还是可以再等一会的吧:3" },
            { "Aww cmon, don't be so silly, \nlets wait until we fix this world, \nlet me help you out :P", "小傻瓜~等这个世界的问题解决了再说吧.让我来帮帮你！" },
            { "Awaaaaaaaaaaaaaaaaaaaaaaaa~ \n(Zielie is too flustered to continue)", "哇啊啊啊啊啊啊啊啊啊啊~（泽丽激动到语无伦次）" },
        });
        #endregion
        #region Gia 吉娅
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gia), nameof(Gia.SetBestiary), new() {
            { "Wow you done messed up this time with the Virulent spill huh.", "看看这瘴煞的势头，你这次可真惹上大麻烦了." },
            { "Gia the Scientist", "研究员吉娅" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gia), nameof(Gia.GetChat), new() {
            { "So many cool contraptions she has, I love them!", "她有那么多超棒的机械！我好想要啊." },
            { "A long time ago, I used to experiment with Biotech. It went wrong, and teleported pieces of itself all over the world. You might have found some by now.", "很久之前我还在研究生物科技，但是那件作品出了岔子，残片飞散到了世界各处.你可能已经找到了其中的几片." },
            { "Maybe if you find some of my lost tech, you could craft my original biotech and retry my experiments!", "如果你能找到那些我遗失的科技零件，就能造出我的独创机器，重试我的试验！" },
            { "The guide seems to know too much for a human being. I feel like he has something else connected to him…", "向导知道的实在太多了，他真的只是个人类吗？我感觉有什么其它东西与他有联系..." },
            { "The merchant keeps telling me about this dangerous eye thing. I could just zap it with my Bio laser.", "商人一直在说什么危险的大眼球...它要是敢来，我就让它尝尝我的反生物激光." },
            { "Aimacra seems pretty neat, too bad she's taken", "安魅凯拉看起来不错，可惜她已经有伴了." },
            { "I wouldn't mind hooking up with the Steampunker :)", "蒸汽朋克人也不赖嘛，我想和她试试：）" },
            { "So many spare parts and materials, bring them all to me!", "有多少零件材料就给我拿来多少！" },
            { "I can't believe I let it get loose, I've complicated too many things.", "真不敢相信我居然一时疏忽把“它”放出来了...这下事情复杂了好多." },
            { "Can you go collect some runes for me? I'd love for you to get working.", "给我收集一些符文碎片吧！反正你闲着也是闲着." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Gia), nameof(Gia.SetNPCNameList), new() {
            { "Gia", "Gia" },
            { "Gia", "Gia" },
            { "Gia", "Gia" },
            { "Gia", "Gia" },
            { "Gia", "Gia" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gia), nameof(Gia.SetChatButtons), new() {
            { "Trade Rune", "交付符文" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Gia), nameof(Gia.OnChatButtonClicked), new() {
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" }, // 勿动, 下同
            { "I give you my thanks for this Desert artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Sky artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },

            // 这里应该是 Ice artifact, 但是笨笨作者复制粘贴时忘改了, 导致只能使用 InOrder 的方式改
            { "I give you my thanks for this Sky artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Overworld artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Ocean artifact, I'll research it greatly, heres something in return..", "感谢你帮我找到了这块符文，我会仔细研究它的.这是些回礼，难表谢意..." },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Jungle artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
        });
        #endregion
        #region Ginztel 玄铁军官
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ginztel), nameof(Ginztel.SetBestiary), new() {
            { "Dumbfounded by your strength, the commander retired and came to your base for a visit and a free hotel.", "这名已退休的玄铁军官被你的力量大为震惊，他决定来看看...以及蹭个住处." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Ginztel), nameof(Ginztel.SetNPCNameList), new() {
            { "Gintzia", "Gintzia" },
            { "Ginztel", "Ginztel" },
            { "Steven Universe", "Steven Universe" },
            { "Gintzel", "Gintzel" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ginztel), nameof(Ginztel.GetChat), new() {
            { "Hehe the Demonilitionist guy is pretty cool, he's got bombs..", "嘿嘿，那个爆破专家不错，他有好多炸弹..." },
            { "Im just peeping around, I might stay for a while..", "俺只是来看看...或者在这住一小会." },
            { "My team was quite weak to say, I apologize for the inconvience", "俺的那帮人好弱啊.真是给你添麻烦了." },
            { "Some of the things I'm selling are from base, we've all taken quite a liking to you all.", "俺卖的东西好多都是是从俺们基地拿来的！俺们都觉得你还是个不错的家伙！" },
            { "If you can kill Gothivia for us we can scavange and steal their items, please help us do that", "如果歌瑟梵挂了俺们就能抢她的东西啦！你一定要赢啊！" },
            { "We may be weak but we still give all of our little praise to Verlia, hence why we stole from her sister..", "俺们不强，但俺们最稀罕薇莉娅，才敢偷她姐姐的东西." },
            { "Could you murder Gothivia in the most brutal fashion possible? She is way too dauntless and carefree, we hate her and she took our home..", "你一定要把歌瑟梵狠狠的揍一顿呀！俺们看着她那副目中无人的表情就来气！她还霸占了俺们的家..." },
        });
        #endregion
        #region Ishtar 狂渊
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ishtar), nameof(Ishtar.SetBestiary), new() {
            { "Entrance", "狂渊入口" },
            { "The entrance to the Ishtar Citadel", "狂渊的入口" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Ishtar), nameof(Ishtar.SetNPCNameList), new() {
            { "Ishtar Pin location", "狂渊" },
            { "Ishtar Pin location", "狂渊" },
        });
        #endregion
        #region Mardenth 玛登斯
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.SetBestiary), new() {
            { "One of the 3 Children of Daeden, this one being the most useless", "填入汉化文本" },
            { "Mardenth of the Veil", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.GetChat), new() {
            { "So many cool contraptions she has, I love them!", "填入汉化文本" },
            { "Damn that Sigfried guy.", "填入汉化文本" },
            { "Where's Ereshkigal?", "填入汉化文本" },
            { "Daedus, Jovhia, Daeden? Where'd you all go?", "填入汉化文本" },
            { "I'm quite formiddable you see. I can destroy anything with my hands.", "填入汉化文本" },
            { "I need to study up on my electric magic. If my dad wasn't dead he'd be proud of me. Gosh I wish you were here Daeden", "填入汉化文本" },
            { "I never knew my mom..", "填入汉化文本" },
            { "Why is Jovhia always in the sky?", "填入汉化文本" },
            { "Hey you, get out of here!", "填入汉化文本" },
            { "Scadabble you women harrasser.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Mardenth), nameof(Mardenth.SetNPCNameList), new() {
            { "Mardenth", "填入汉化文本" },
            { "Mardenth", "填入汉化文本" },
            { "Mardenth", "填入汉化文本" },
            { "Mardenth", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.SetChatButtons), new() {
            { "Talk", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.OnChatButtonClicked), new() {
            { "Heheheh, I like to eat little wormy guys but they won't stop squiggling. Reminds me of when our dad Daeden left us. ", "填入汉化文本" },
            { "Where did Daedus go?  He left us so long ago. I hope he wasn't swayed by that Harlet Gothivia. She seemed power obsessed and hungry. Maybe that's just me though", "填入汉化文本" },
            { "I might be the only one but, Ereshkigal is kind of hot isn't she? Hell you wouldn't even know would you. You're taste in women is flat.", "填入汉化文本" },
            { "You don't understand how we are. We're higher than all below us, which is everyone except a god. Only they can be held to such high status. Squirm off you worm.", "填入汉化文本" },
            { "I wish Sigfried didn't go insane. He's such an asshole, even our dear Ereshkigal left with him to seal him away...  ", "填入汉化文本" },
            { "Maybe I may be the only person to question the gene pools of these people. Like where do they all look so pretty from??? Im wearing this mask cuz I look like a goblin.", "填入汉化文本" },
            { "I want a beach episode with Zui and Ereshkigal now! ", "填入汉化文本" },
            { "I would want to be more powerful but that takes a lot of training. Anyone who dares to take more than what they are given should be punished. ", "填入汉化文本" },
            { "Those guys in the well? They are trapped down there because they made some goofy deals in their lives to get more power and just like the great Veil people we are, we trapped them away for good.", "填入汉化文本" },
            { "I don't know what the outside world is like.", "填入汉化文本" },
        });
        #endregion
        #region Merena 梅瑞娜
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), nameof(Merena.SetBestiary), new() {
            { "Magic Magic MAGIC", "魔法，魔法，还有更多魔法！" },
            { "Merena the bewitched sorcerer", "着迷术士梅瑞娜" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), nameof(Merena.GetChat), new() {
            { "Funny enough the clothier used to come through here all the time for some of our amazing fabrics", "填入汉化文本" },
            { "I wonder what my sister Sylia is up to nowadays, do you know her?", "填入汉化文本" },
            { "I'm gonna be the very best, like no one ever was... ", "填入汉化文本" },
            { "Fenix is the best queen there will ever be! She gives us all what we want :P", "填入汉化文本" },
            { "This place is so calming, I can't stand it but I would give everything to be near Fenix", "填入汉化文本" },
            { "Aimacra seems pretty cool, she came here recently looking for some brooches", "填入汉化文本" },
            { "Hey uh could you do something for me? I have a little favor, just ask what it is!", "填入汉化文本" },
            { "I've always wanted to be the best witch there is! I've always been outshined by exiles though, including my sisters sadly.", "填入汉化文本" },
            { "I really need to beat my sister in a battle someday.", "填入汉化文本" },
            { "It's strange, the economic system here is almost like communism", "填入汉化文本" },
            { "Damn we have some cool shit here", "填入汉化文本" },
            { "No doubt about it but Fenix is truly the strongest witch in all of the lands, maybe even more powerful than the witch of light in the hallow, I don't like her.", "填入汉化文本" },
            { "Hahh, I remember that goon Verlia, she's kind of dumb but shes at least powerful, I remember she got exiled for stealing tomes, I might need that from her.", "填入汉化文本" },
            { "Can you go collect some runes for me? I'd love for you to get working.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Merena), nameof(Merena.SetNPCNameList), new() {
            { "Merena the Sorcerer", "术士梅瑞娜" },
            { "Merena the Sorcerer", "术士梅瑞娜" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), nameof(Merena.SetChatButtons), new() {
            { "Merenas Quest", "任务" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_VerliaStart", new() {
            { "What are you standing there for, go kill Verlia! She's an enemy of the royal capital and she has a book I need lmao", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_VerliaComplete", new() {
            { "Oh damn thanks! Next on the list I need you to steal an orb from a village in an underground morrowed village, the orb contains a magic unlike any other. I have no idea how it was manifested but it's needed for this tome.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_MorrowStart", new() {
            { "Oh damn thanks! Next on the list I need you to steal an orb from a village in an underground morrowed village, the orb contains a magic unlike any other. I have no idea how it was manifested but it's needed for this tome.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_MorrowComplete", new() {
            { "Woa, the energy is pouring out of this one with seamless orange stripes! How did you even get your hands on this?? Either way thanks, now I just need 100 dust bags, it helps with the brewery.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_DustBagsStart", new() {
            { "Woa, the energy is pouring out of this one with seamless orange stripes! How did you even get your hands on this?? Either way thanks, now I just need 100 dust bags, it helps with the brewery.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_DustBagsComplete", new() {
            { "Neat neat, that shouldn't have been too bad for you I think. Next I need some magical paper, there are magical creatures all over the world of hardmode who drop these, most of them being rare and unique creatures, go get em'!", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_MagicPaperStart", new() {
            { "Neat neat, that shouldn't have been too bad for you I think. Next I need some magical paper, there are magical creatures all over the world of hardmode who drop these, most of them being rare and unique creatures, go get em'!", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_MagicPaperComplete", new() {
            { "OHH Great lmao. Ok we have one more thing we need to do. Legend has it an old thief of this Royal Capital stole an extremely special Carian tome, they stay deep underground hidden far away underneath the abyss. Even if the rumors arent true I'd love for you to find this scroll, it may take years...", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_TomeStart", new() {
            { "OHH Great lmao. Ok we have one more thing we need to do. Legend has it an old thief of this Royal Capital stole an extremely special Carian tome, they stay deep underground hidden far away underneath the abysm. Even if the rumors arent true I'd love for you to find this scroll, it may take years...", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_TomeComplete", new() {
            { "THANK YOU THANK YOU THANK YOU, omg this is the best day of my life! I never knew this actually existed! Were the rumors true??! dsfjhnbhfribdhs- Nevermind who cares anymore, we can both be the best mages ever! I open my shop to you and here, a token of my graditude. ", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "StartQuests", new() {
            { "Hey, I have nothing else for you to do! Thanks for all of your help, have you checked out my shop yet?", "填入汉化文本" },
        });
        #endregion
        #region NaturalWitch 自然女巫
        ForceLocalizeSystem.LocalizeByTypeName(nameof(NaturalWitch), nameof(NaturalWitch.SetBestiary), new() {
            { "A Captain of Gofria's ranks, be careful", "当心歌瑟梵军团的小队长." },
        });
        #endregion
        #region Ordin 奥丁
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.SetBestiary), new() {
            { "Steaming from the depths", "地下深处的火焰与浓烟" },
            { "Ordin, The New Monarch", "星树新君奥丁" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.GetChat), new() {
            { "Shes got some great cogs", "填入汉化文本" },
            { "Remove yourself from my sight", "填入汉化文本" },
            { "You walk like an infant with no tucas", "填入汉化文本" },
            { "What a pitiful endearment, praise to the ones above.", "填入汉化文本" },
            { "...", "填入汉化文本" },
            { "You are not fit to become a god", "填入汉化文本" },
            { "Oh Sigfried, return in good health or I shall slay you with my own hands from such a succubus!", "填入汉化文本" },
            { "Bring me their Manifestations", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Ordin), nameof(Ordin.SetNPCNameList), new() {
            { "Ordin, Illurian Monarch", "星树之君奥丁" },
            { "Ordin, Illurian Monarch", "星树之君奥丁" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.SetChatButtons), new() {
            { "Reminisce of Sigfried", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.OnChatButtonClicked), new() {
            { "Thy is so resilient, unhand me from these this trecherous nagging and take this for thy shall not be astute to your prescence no longer.", "填入汉化文本" },
            { "To be one of the forth or forward, the lands that I rest in reek of falsification of hypocrisy and power.", "填入汉化文本" },
            { "Sigfried was once a young fellow, thy brother in one's eye's and a villian in anothers'.", "填入汉化文本" },
            { "Our sacred castle falls ill to such burning. Our wishes have been grafted under the curse of Sigfried's unveiling.", "填入汉化文本" },
            { "Fall away, dear brother ", "填入汉化文本" },
            { "Mark thy words with caution. Ereshkigal is a loveless harlet who took the life of the brother of many. Yet thy fulfills their prophecy among lovers, hence she is not a false goddess.", "填入汉化文本" },
            { "All our goals are put to rest following the lands of the veil. Finish all those who have wronged our beloved world.", "填入汉化文本" },
            { "Manifest their souls and bring them to my company. You shall be rewarded until the rekoning begs for your place to be silenced. ", "填入汉化文本" },
            { "Niivi, the protector of the lands of the veil, yet curse all upon thy brother to be selfish and steal among those of power and wealth. He was greedy and in his expense payed the lovers' prison.", "填入汉化文本" },
            { "Now I sit ill waiting for the lands of the veil to change.", "填入汉化文本" },
        });
        #endregion
        #region PULSARHOLE 脉 冲 黑 洞
        // 暂无需要强制本地化的内容
        #endregion
        #region Sirestias 希丝忒莉亚
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.SetBestiary), new() {
            { "Your eternal bonding with this individual resonates with everyone throughout!", "你与这位存在之间永恒的羁绊回荡不绝..." },
            { "Sirestias", "希丝忒莉亚" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.GetChat), new() {
            { "Here to give me some company I see?", "哦？来陪陪我吗？" },
            { "Hmph how's Aimacra doing? Nevermind I already know that answer.", "嗯，安魅凯拉怎么样了？算了，我又不是不知道." },
            { "Enjoying yourself?", "玩的还开心吗？" },
            { "Sometimes I forget you're bounded with me always", "我都快忘了你和我已经绑定在一起." },
            { "Its always sweet to see you do things for me", "你愿意为我做事，我真是欣慰啊." },
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Sirestias), nameof(Sirestias.SetNPCNameList), new() {
            { "Sirestias", "希丝忒莉亚" },
            { "Sirestias", "希丝忒莉亚" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.SetChatButtons), new() {
            { "What do I do next?", "接下来做什么？" },
            { "Give Completion Idol", "给予陨神之像" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.OnChatButtonClicked), new() {
            { "Kill the stone guardian, commander gintzia will soon raid you with his army of failed troops from the govheil. He will be very easy so take him swiftly and beat him into submission hun. ", "填入汉化文本" },
            { " I'd recommend going into the Fabled Swamp over to the right or collecting resources to get ready to fight either Jack or find a sun alter in a desert and prepare for Sunstalker! Zui may be a good person to talk to in the witch village for quest items too :) ", "填入汉化文本" },
            { "Nice babe, I want you to go kill Jack in the Fabled swamp on the right then, you need a wandering essence and he shouldn't be too difficult. ", "填入汉化文本" },
            { "Nice work! I want you to go headhunt a bird in the desert, his name is Sunstalker and they are a bit challenging but less so than the last, collect some mandibles in the desert to make the Sun stone! Find the alter on the surface of a desert!", "填入汉化文本" },
            { "You're next target is Daedus, he's a strong one. Hes a very loyal Guardian to one of the biggest threats here being Gothivia, we need him gone to get to the big fish in the sea. For some reason he holds some power of a singularity so beware. He resides low in the temple in the Fabled Swamp, no extra preperation needed.", "填入汉化文本" },
            { "Oh my gosh nice, so here's where things are going to get difficult. If a blood moon happens we need to exterminate Dreadmire, she spawns after killing a blood cyst during a blood moon, you can also get some terror fragments too! She'll pose too much of a threat if we let her live. She's I think one of the three sisters, formally known as cozmire. She needs to die and after that I'll give some great rewards.", "填入汉化文本" },
            { "We are making big progress now! I don't know if you have been killing other ravenous monsters but I'd recommend doing so as the next one on our list is Verlia but to get to her we have quite a few things to do first. Make yourself a void key and find a temple deep in the ice biome, there should be some loot and hopefully an alter that'll give you a lantern. She was trapped by Fenix but she needs to die so we can bring out Gothivia.", "填入汉化文本" },
            我们的计划正大步前进！
            { "Ok you got the lantern! Go to the cathedral overtop the ice biome and summon her at the top at night. This will be our biggest foe yet but I know you can kill her, sorry Aimacra is tired of being my assasin so it's your turn.", "OK，你拿到那盏灯了！等到晚上去到冰雪地圣殿的顶端释放她.这是直到如今我们最大的挑战，但我相信你的能力.抱歉，安魅凯拉不想再被我当刺客使唤了，这次轮到你上了！" },
            { "Oh damn this is great. I think that completes our list for now, check back in with me in Hardmode! We'll purify this world of all danger and create peace and then we can be together and move on. Thank you again.", "哦天，这也太棒了！我们现阶段的任务全都完成了！等到你打败了血肉墙再来找我吧！我们一定能净化这个世界上的一切威胁，一起向前.感谢你的付出." },
            { "Welp here we go again. So theres a strange issue we have, so Daedus isn't the only barrier to trying to stop us from getting to Gothivia, Aimacra just went and explored around and found some new places and there was this castle underground in a green biome? I noticed Gothivia's marks on it and the Sun hasnt started turning green, could you look at that? There should be some catacombs underground in the desert, ocean and caverns to help power up too.", "哟，又见面了.我发现了个问题，代达斯并不是歌瑟梵筑起的唯一一道障碍.安魅凯拉刚在那个绿油油的地方地下找到了一座城堡，上面有歌瑟梵的印记，你能去看看吗？至少太阳还没变绿，说明我们还有时间.还有，沙漠地下，海洋里，洞穴中存在着三座墓穴，里面的东西应该会帮到你." },
            { "There was a person down there claiming to be Gothiva? Thats strange. Gothivia seems to be making an appearance on the world. Apparently things are changing the skies and things are falling from them, Beware of STARBOMBERS, Aimacra warned me that they were manufactured here as well as Ekrose and you have experience with them.", "那边有个人在假装歌瑟梵？奇怪.歌瑟梵本人貌似也正在赶回这个世界.再者，这个世界的天空好像出现了些异变，掉下奇怪的东西.小心 星 爆 者，安魅凯拉告诉我它们在这里也有被制造，和在艾科洛斯一样." },
            { "I didn't think Rosemary's creations would've made it here. Ekrose sure does have an affect on this world. I saw some strange disturbance on the left side of the underworld though, can you check that out? I went to talk to Veldris and he told me Sylia may be up to some demonic magic that could ruin our process, so killing her is a good option. ", "我之前还觉得迷迭香城的造物不会出现在这里呢.看来艾科洛斯和这个世界确实有一定联系.我感受到地狱的左侧有个奇异的能量扰动，维尔德斯告诉我那可能是赛莉亚搞的鬼，她的黑暗魔法可能会阻碍我们，我们要先发制人把她除掉." },
            { "It was a void witch... Interesting. Must be related to that Merena person Aimacra talked about. I haven't been to the Royal Capital much, mainly because it's so far out but maybe we should kill the Queen there, she is definitely extremely powerful but I don't really know how to talk to her, I haven't seen her yet. If you can could you go kill her for us? ", "虚空女巫...真有意思.应该和安魅凯拉说的那个梅瑞娜有点关系.我没怎么去过皇室首都，那里太远，但那个女王也在我们的名单上.她的力量很强，而且我没和她沟通过.要不你去把她干掉？" },
            { "Ereshkigal huh? I think I know her, she also isn't supposed to be here. However she got lost I guess we can give her some sense", "厄莉什基迦勒？我知道这个名字.她也不应该出现在这里的.如果她是迷路了，我们也许可以帮帮她？" },
            { "Weheeee! You're doing so well! I can like get off to this! I'm kidding :(. Maybe you can try and explore around some more. We need to prepare for moonlord!", "哇呜！你也太高效了！我要不要直接让你接手整个计划呢...开玩笑的啦.接下来你就自由探索吧，好好准备迎战月球领主." },
            { "I did not expect you to want to kill her honestly. I went and explored around and she seemed nice. Wait you didn't kill her? Oh dang, well she isn't on our list anyway so it's fine lmao. She isn't causing us any issues.", "我真没想到你去打她...我在四处转悠的时候遇见了她，感觉她还不错的.你说你没杀了她？也好，反正她也不在我们的名单上，也没给我们添乱." },
            { "Ok ok we got some good stuff done. Time for Gothivia as she's not particularly the worst but she keeps inspiring bad people to do ad things and we need to teach her not to do that.", "干得不错.是时候去找歌瑟梵了.凭心而论她并不坏，但她的领导力总能激励坏人去干坏事，我们就给她一个教训，让她停止这样." },
            { "Maybe we shouldn't have killed her, I don't know if there was a reason to kill Niivi. You just wanted weapons and gear? I mean if it helps I guess. She was doing more good than harm", "我本来没想杀她的，我们没有理由对尼伊维下手.你想要装备？要是有帮助的话，那好吧，但她可没有做任何恶事." },
            { "Okie dokie, Gothivia has agree to stay calm so we aren't going to assassinate her anymore, I feel bad for killing her sister now. I hope Vixyl doesn't find out.", "好好，歌瑟梵答应暂时保持冷静，我们应该不用刺杀她了.我现在对杀了她的姐妹感到有些抱歉...希望维西尔不会发现吧." },
            { "YESSS, we're getting closer to our goals!! Aren't you excited <3", "好耶！！我们距离目标又进了一步！你不觉得激动吗？<3" },
            { "I couldnt find anything more so I'll give you an extra token!", "我也没找到什么更好的东西，所以多给你一颗宝珠吧！" },
            { "Please go do something for me, we don't have all day you know ;P", "去做些我规划的事吧，咱们的时间可不多啊." },

        });
        #endregion
        #region UnknownSignal 神秘信号源
        ForceLocalizeSystem.LocalizeByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.SetBestiary), new() {
            { "An Unknown Signal", "一个未知的信号从这里发出" },
            { "Unknown Signal", "神秘信号源" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.GetChat), new() {
            { "A static voice confirms the identity of the user, you are in the right place.", "一个模糊的声音确认了你的身份.看来这里是对的." },
            { "A static voice confirms the identity of the user, you are in the right place.", "一个模糊的声音确认了你的身份.看来这里是对的." },
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.SetChatButtons), new() {
            { "Touch Unknown Circuitry", "触碰" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.SetNPCNameList), new() {
            { "Unknown Signal Source", "神秘信号源" },
            { "Unknown Signal Source", "神秘信号源" },
        });
        #endregion
        #region Veldris 维尔迪斯
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Veldris), nameof(Veldris.SetBestiary), new() {
            { "Freezing to death", "冰寒刺骨" },
            { "Veldris the assassin", "刺客维尔迪斯" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Veldris), nameof(Veldris.GetChat), new() {
            { "Shes got some great cogs", "填入汉化文本" },
            { "Who's next on this list to kill?", "填入汉化文本" },
            { "How are you doing? ", "填入汉化文本" },
            { "I need to gamble a bit more today", "填入汉化文本" },
            { "That Sirestias woman creeps me out.", "填入汉化文本" },
            { "I gotta get to the Royal Capital some day. Maybe they can empower my weapons.", "填入汉化文本" },
            { "So coldddd", "填入汉化文本" },
            { "Hey you, come buy some stuff from me!", "填入汉化文本" },
            { "Im starting to warm up this winter", "填入汉化文本" },
            { "Everyone and all this damn god talk, it makes me crazy", "填入汉化文本" },
            { "Interestingly, I don't know why those sisters all are disconnected, it seems like they're always hiding something", "填入汉化文本" },
            { "I wish I was someone important", "填入汉化文本" },
            { "Sometimes I wanna lead an army you know? I just wanna see Veiizal again", "填入汉化文本" },
            { "You gonna buy something lad?", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Veldris), nameof(Veldris.SetNPCNameList), new() {
            { "Veldris the Calm Assassin", "沉静刺客维尔迪斯" },
            { "Veldris the Calm Assassin", "沉静刺客维尔迪斯" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Veldris), nameof(Veldris.SetChatButtons), new() {
            { "Talk", "闲聊" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Veldris), nameof(Veldris.OnChatButtonClicked), new() {
            { "You doing good? I mean it's a hellhole out here. Sometimes I even start to wonder what brings you here. I'm just some lonesome seller, just be sure not to get on someone's deadlist or else I'll be seeing ya. ", "填入汉化文本" },
            { "Everytime I hear someone talk about gods I want to just puke in their faces, like ew. I'm kind of glad that Sirestias woman is getting rid of them. Her and Fenix don't seem all too power driven. Fenix is just revenge driven, and I can respect that.", "填入汉化文本" },
            { "If my weapons we're ever used, they better be in the right hands. My tools were crafted with some Luminull and some special metals, they better hold together- I had to steal some stuff from that Illuria place", "填入汉化文本" },
            { "I'm just gonna rant about this Illuria place honestly. WHY IS THERE A DRAGON JUST ROAMING. Like I thought those went extinct with the the virulent- oh I meant acid. I really just needed some scales but oh noo the watcher of society is there. ", "填入汉化文本" },
            { "Back in my day building this house was my masterpiece, Fenix really gathered up an army just to build this cathedral here and that temple below just to trap some harlet who took her stuff. Down right evil though on Fenix's behalf, maybe overkill. ", "填入汉化文本" },
            { "Some knights visited me the other day talking of this 'peace and formality' and I couldn't take it so I went to the Lunar tree, which for some reason they live on and I stole some fragments and some luminull? It seems pretty powerful and is probably related to Lumi in some way.", "填入汉化文本" },
            { "I love myself commissions, just sayingg if you wanna commission me I'm all available, the last person I went to kill was some goofy guy named Rallad, some girl named Sylia asked me if I could do it for her since she didnt want to be seen, took forever to find him though. ", "填入汉化文本" },
            { "Interestingly enough me and Sylia have fun sometimes, shes pretty nice once you get to know her, sadly she stays away from her sister Merena and the rest of the capital, she's pretty chill. Kind of wanna travel with her though. ", "填入汉化文本" },
            { "The small joys of life comes from not having your house destroyed by some malevolent gods throwing down their trap cards when youre trying to sleep. It makes me annoyed when I have to peek out my window to make sure the black hole isn't going to hit my house.", "填入汉化文本" },
            { "You knowww, I was named Veldris by my friend, I always grew up without a name since my parents died by a stupid raging black hole guy, name was Sepsis I believe? He killed off so much 30 years ago yet I remember it like yesterday.", "填入汉化文本" },
        });
        #endregion
        #region Zui 蕊
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), nameof(Zui.SetBestiary), new() {
            { "A traveller of the lands who may hold great power", "一名周游大陆的旅者，似乎掌握着强大的力量." },
            { "Zui the Traveller", "旅者 蕊" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), nameof(Zui.GetChat), new() {
            { "The dryad is pretty fun after all, she's pretty sweet and helps us with the gardening!", "树妖是个好人呀！她对我们都很友好，还帮我做些种花的杂务！" },
            { "We've had to kick a few witches out of this town you know, its quite a shame..", "我们之前不得不把几名女巫从这里赶了出去，真可惜啊..." },
            { "I keep going out to find more plants but somehow you're always here when I return. ", "我其实没有一直站在这里不动.只是碰巧每次你来我都在这里而已." },
            { "I'm trying to find a way to stop the corruption and virulent from spreading but I have no fix currently.", "我在想办法阻止邪恶地形和瘴煞之地的扩散，但目前为止我还没想出什么良策." },
            { "Hey love, you know you could be collecting stuff for me!", "如果你正闲着，去给我收集一些东西如何？" },
            { "Sirestias? Oh um yeahh we go pretty far back.", "希丝忒莉亚？啊...对...我和她有过一段交情." },
            { "Aimacra is cool too, this is my first time meeting her lol", "安魅凯拉也挺棒的，虽然我才认识她." },
            { "I wouldn't say I'm too powerful, afterall I a just a traveller", "我很强吗？不不不，我只是个旅者而已." },
            { "Sometimes I wonder what they did in Vodhome after we all left. I really have to catch up with Sirestias and the others.", "我在想，我们离开了那里之后，沃德府怎么样了.看来有必要去和她们叙叙旧了." },
            { "Are you here with Sirestias?", "你是和希丝忒莉亚一起来这里的吗？" },
            { "All these plants are so cool! I did just arrive here before Sirestias, there was some commotion and I think people here are trying to disrupt time and power.", "这里的植物太棒了！我比希丝忒莉亚早一小会来的，当时正赶上一片骚乱，好像是有人想要扰乱时间和能量." },
            { "Sirestias is a balancer, same goes for me but I like to just collect things.", "希丝忒莉亚的目标是“平衡”.其实我也一样，但我还是更喜欢干些悠闲一点的事，比如收集些植物." },
            { "Hey if you collect some items for me I can give you some stuff!", "帮我收集我想要的东西，我能给你奖励！" },
            { "Hey can you go collect for me?", "帮帮我嘛~" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Zui), nameof(Zui.SetNPCNameList), new() {
            { "Zui The Traveller", "旅者 蕊" },
            { "Zui The Traveller", "旅者 蕊" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), nameof(Zui.SetChatButtons), new() {
            { "Zui's Quests", "任务" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_NotCheckmarked", new() {
            { "Hi hii! Thanks for asking! Could you fetch me some plants, you can use this bag! Just fill it up with some different types of plants and I'll give you some stuff afterwards!", "嗨~谢谢你来帮我！给我收集一些植物之类的吧，就装在这个袋子里！我会给你回礼的！" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_NotCheckmarkedHardmode", new() {
            { "Hehe I'm gonna up the difficulty of these, I'm gonna need some bigger plants, so you'll need to fill up this bag! Thanks!", "嘿嘿，接下来的任务有点难了哦.去给我找一些更加稀有的植物吧，装满这个袋子就行！感谢！" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_1Complete", new() {
            { "Nice nice, I'll take these, could you fetch some more for me!  ", "好的，这些我就收下了，拿好你的奖励！能再给我收集一点吗？" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_16Complete", new() {
            { "Nice nice, I'll take these, could you fetch some more for me!  ", "好的，这些我就收下了，拿好你的奖励！能再给我收集一点吗？" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_3Complete", new() {
            { "Ok ok, 3 quests is kind of good, thanks for caring a lot about this! I've got more items in my shop for you, bring me 3 more and I'll get more for ya!", "完成3个任务了，棒哎！我在商店里给你准备了更多好东西！再来3个，还有更多惊喜！" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_6Complete", new() {
            { "6 Quests is actually kind of crazy, I've opened up with a few more items for you if you want! Bring me 4 more ;p", "6个任务，疯狂！我又进了一批你可能想要的好东西！再给我收集4个吧 ;p" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_10Complete", new() {
            { "Damn, 10 quests? You're on a role you know! I've got some more items for you in my shop actually, I went travelling and Sirestias gave me a few items! I'll give you some more items if you can do 10 more!", "哎呀，10个任务完成了？你真是前所未有啊！正好前段时间我去找希丝忒莉亚，她给了我些东西我都放在商店里了，你看看吧.再做10个任务，还有好东西！" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_20Complete", new() {
            { "You have finished 20 quests for me! Thank you! I've got more items in my shop because of it too! If you want more from me bring me ten more and maybe we can have some fun! ", "你完成了20个任务！万分感激！我的商店里又有新东西啦！还想要更多？再完成10个任务，就差不多到了咱们的玩乐时间啦！" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_30Complete", new() {
            { "My graditude is of the utmost thanks, in return you can have anything in my shop! And I'll help you out personally sometime if you need me ;p ", "真是太太太感谢你了！我的商店完全对你开放了！等以后你需要我的帮助时，我一定会答应的 ;p" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "StartQuests", new() {
            { "Hiya! I think that's all the things I need, you can get some stuff in my shop but thanks babe!", "嗨呀！我觉得我需要的东西已经够用了.谢谢你的好意，看看我的商店如何？" },
        });
        #endregion

        #region ZuiDeath
        ForceLocalizeSystem.LocalizeByTypeName(nameof(ZuiDeath), nameof(ZuiDeath.AI), new() {
            { "I think I have a headache..", "我的头好晕..." },
            { "I'll see you later at my shop! Fun time :)", "干得好！想要找我的话就再来我的商店吧！" },
        });
        #endregion
        #region EreshkigalIdle
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.SetBestiary), new() {
            { "A mystical veil user who took accountability to chain up Sigfried", "禁锢了齐格飞的神秘人物" },
            { "Ereshkigal the Lover", "痴恋者厄莉什基迦勒" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.GetChat), new() {
            { "Leave me and my husband alone", "让我和我的丈夫在这里独享二人时光吧" },
            { "You should all be jealous that I'm here.", "你们都应该羡慕我！" },
            { "Welcome welcome! Come here to feast your eyes on us?", "欢迎！欢迎！来一饱眼福吧" },
            { "Oh dear Sigfried how we've met..", "亲爱的齐格飞...我还记得我们相遇的那天..." },
            { "Come and go you will, you'll be broken more than the others.", "匆忙的来，匆忙的走，将自己搞得支离破碎..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.SetNPCNameList), new() {
            { "Ereshkigal the Lover", "痴恋者厄莉什基迦勒" },
            { "Ereshkigal the Lover", "痴恋者厄莉什基迦勒" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.SetChatButtons), new() {
            { "Give her something.", "给她送一件礼物" },
            { "Sigfried?", "询问关于齐格飞" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.OnChatButtonClicked), new() {
            { "OMG, OMG OMG OMG OMG", "天哪天哪天哪天哪！！" },
            { "What is this? Nothing of importance to me... You are worthless, you're life is as valuable as a cinderspark summer ant, you mean nothing. You should get me something good NOW. You should burn in the Cinderspark..", "这是什么...不要紧，它和你一样毫无用处，像一只蚂蚁一样不值一提.赶紧给我找到点有价值的东西，不然我就把你扔到烬火之地永世焚烧." },
            { "Oh what a darling he is. Too bad I'm tasked with keeping him here forever right? He can't escape me :3 ", "我的任务就是把他永远关在这里，对他来说可不是什么好消息对吧 :3" },
            { "Sigfried is my husband you know. We met on the sacred lands of the Illuria, I may have been kicked out numerous times to talk to my king but I'd do anything to get with him", "我丈夫就是齐格飞.我们初次见面是在星树的圣地，我已经被他的守卫赶出那里不知道多少次了，但为了他这一切都值得." },
            { "He's so pure, going for such high level threats such as Lumi and stealing her singularity. That's the type of man I like, one who isn't afraid to get their hands dirty.", "他是那么的纯粹，敢向琉明那样的高级威胁下手，还偷走了她的奇点！我就喜欢这种干事干净利落毫无顾忌的男人." },
            { "I wish we could stay together always.", "我们要永远在一起~" },
            { "Oh his dear Mordred, I bet he doesn't even know hit wife was trapped within a weapon :)", "哦，那个莫德雷德呀...我敢肯定他都不知道他的妻子已经被囚禁在一把武器里了." },
            { "Stupid dragon always getting in the way to getting to my wonderous babe, I would trap it as well but then it'd anger my dearest here.", "那条蠢龙，总是守着我的宝贝不让我靠近...要不是他会生气，我早就把那龙也关到这里了." },
            { "How many doors do I need to store Lumi? I don't really know but I don't care. As long as she doesn't come after my husband.", "我要用多少扇门才能困住琉明？算了，也不重要，只要她不来找我的丈夫就行." },
        });
        #endregion
    }
}
