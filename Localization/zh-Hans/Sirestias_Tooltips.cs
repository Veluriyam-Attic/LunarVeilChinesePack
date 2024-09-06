using Stellamod.NPCs.Town;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace LunarVeilChinesePack.Localization.NPC_zh_Hans
{
    //Sirestias 希丝忒莉亚
    public class Sirestias_Tooltips : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            string modname = npc.ModNPC.Mod.Name;
            string npcname = npc.ModNPC.Name;
            if (modname.Equals("Stellamod") && npcname.Equals("Sirestias"))
            {
                chat = chat.Replace("Here to give me some company I see?", "你来陪我了？真谢谢你！");
                chat = chat.Replace("Hmph how's Aimacra doing? Nevermind I already know that answer.", "嗯，安魅凯拉近来如何？算了我已经知道答案了.");
                chat = chat.Replace("Enjoying yourself?", "玩得还开心吗？");
                chat = chat.Replace("Sometimes I forget you're bounded with me always", "我都快忘了你和我已经是一条绳上的蚂蚱了.");
                chat = chat.Replace("Its always sweet to see you do things for me", "你愿意为我做事真好.");
                chat = chat.Replace("...", "...");
            }

            base.GetChat(npc, ref chat);
        }
        public override void OnChatButtonClicked(NPC npc, bool firstButton)
        {
            string modname = npc.ModNPC.Mod.Name;
            string npcname = npc.ModNPC.Name;
            if (modname.Equals("Stellamod") && npcname.Equals("Sirestias"))
            {
                Main.npcChatText = Main.npcChatText.Replace($"Kill the stone guardian, commander gintzia will soon raid you with his army of failed troops from the govheil. He will be very easy so take him swiftly and beat him into submission hun. ", "去击败那个石头守卫，之后金戈亚指挥官就会带领他的部队从歌维赫堡来进攻你.击败他是小菜一碟.迅速行动，给他点颜色看看，亲爱的");
                Main.npcChatText = Main.npcChatText.Replace($" I'd recommend going into the Fabled Swamp over to the right or collecting resources to get ready to fight either Jack or find a sun alter in a desert and prepare for Sunstalker! Zui may be a good person to talk to in the witch village for quest items too :) ", "我推荐你去右面的古谕沼泽探索，收集材料为灯笼杰克做准备.或者前往沙漠找到耀日祭坛准备挑战猎日游隼！左面的女巫村落里有个名叫蕊的，她也有事情需要你帮忙哦：）");
                Main.npcChatText = Main.npcChatText.Replace($"Nice babe, I want you to go kill Jack in the Fabled swamp on the right then, you need a wandering essence and he shouldn't be too difficult. ", "干得好宝贝.我想让你去古谕之地干掉灯笼杰克，他应该不会太强.");
                Main.npcChatText = Main.npcChatText.Replace($"Nice work! I want you to go headhunt a bird in the desert, his name is Sunstalker and they are a bit challenging but less so than the last, collect some mandibles in the desert to make the Sun stone! Find the alter on the surface of a desert!", "好样的！接下来是时候去把那只鸟打下来了.它的祭坛在沙漠地表，需要蚁狮上颚来制作召唤物！");
                Main.npcChatText = Main.npcChatText.Replace($"You're next target is Daedus, he's a strong one. Hes a very loyal Guardian to one of the biggest threats here being Gothivia, we need him gone to get to the big fish in the sea. For some reason he holds some power of a singularity so beware. He resides low in the temple in the Fabled Swamp, no extra preperation needed.", "下一个目标：守护者代达斯.他忠心耿耿地守护着现有最大的威胁：歌瑟梵.他将会是我们钓上大鱼的诱饵.不知为何，他居然拥有一颗奇点的力量，一定小心！他目前沉睡于古谕沼泽之下，你现在就能前往，不必做额外准备.");
                Main.npcChatText = Main.npcChatText.Replace($"Oh my gosh nice, so here's where things are going to get difficult. If a blood moon happens we need to exterminate Dreadmire, she spawns after killing a blood cyst during a blood moon, you can also get some terror fragments too! She'll pose too much of a threat if we let her live. She's I think one of the three sisters, formally known as cozmire. She needs to die and after that I'll give some great rewards.", "天呀，这么快就完事了？好，接下来是一个难点.我们要挑一个月红风高之夜来除掉绛渊恶巫.在血月发生时找到一个血肉囊并打破它，或者多收集些恐惧残片！绛渊恶巫是天纱三姐妹之一，之前叫“天寰神巫”，好像是.她的威胁太大，不能留她的命.至于回报，干掉她之后我会给你一些超棒的奖励哦！");
                Main.npcChatText = Main.npcChatText.Replace($"We are making big progress now! I don't know if you have been killing other ravenous monsters but I'd recommend doing so as the next one on our list is Verlia but to get to her we have quite a few things to do first. Make yourself a void key and find a temple deep in the ice biome, there should be some loot and hopefully an alter that'll give you a lantern. She was trapped by Fenix but she needs to die so we can bring out Gothivia.", "我们的计划正大步前进！我也不知道你最近又杀了多少怪物，但接下来我们要干正事了.计划上的下一人是薇莉娅，在对付她之前我们还有几件事要干.做一把虚空钥匙，去冰雪地的深处寻找一座殿堂，那里会有丰厚的战利品以及一个祭坛.打败祭坛中的守卫，拿到那盏灯.有了它，我们就能释放薇莉娅，藉由她来引出歌瑟梵.");
                Main.npcChatText = Main.npcChatText.Replace($"Ok you got the lantern! Go to the cathedral overtop the ice biome and summon her at the top at night. This will be our biggest foe yet but I know you can kill her, sorry Aimacra is tired of being my assasin so it's your turn.", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Oh damn this is great. I think that completes our list for now, check back in with me in Hardmode! We'll purify this world of all danger and create peace and then we can be together and move on. Thank you again.", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Welp here we go again. So theres a strange issue we have, so Daedus isn't the only barrier to trying to stop us from getting to Gothivia, Aimacra just went and explored around and found some new places and there was this castle underground in a green biome? I noticed Gothivia's marks on it and the Sun hasnt started turning green, could you look at that? There should be some catacombs underground in the desert, ocean and caverns to help power up too.", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"There was a person down there claiming to be Gothiva? Thats strange. Gothivia seems to be making an appearance on the world. Apparently things are changing the skies and things are falling from them, Beware of STARBOMBERS, Aimacra warned me that they were manufactured here as well as Ekrose and you have experience with them.", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"I didn't think Rosemary's creations would've made it here. Ekrose sure does have an affect on this world. I saw some strange disturbance on the left side of the underworld though, can you check that out? I went to talk to Veldris and he told me Sylia may be up to some demonic magic that could ruin our process, so killing her is a good option. ", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"It was a void witch... Interesting. Must be related to that Merena person Aimacra talked about. I haven't been to the Royal Capital much, mainly because it's so far out but maybe we should kill the Queen there, she is definitely extremely powerful but I don't really know how to talk to her, I haven't seen her yet. If you can could you go kill her for us? ", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Ereshkigal huh? I think I know her, she also isn't supposed to be here. However she got lost I guess we can give her some sense", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Weheeee! You're doing so well! I can like get off to this! I'm kidding :(. Maybe you can try and explore around some more. We need to prepare for moonlord!", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"I did not expect you to want to kill her honestly. I went and explored around and she seemed nice. Wait you didn't kill her? Oh dang, well she isn't on our list anyway so it's fine lmao. She isn't causing us any issues.", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Ok ok we got some good stuff done. Time for Gothivia as she's not particularly the worst but she keeps inspiring bad people to do ad things and we need to teach her not to do that.", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Maybe we shouldn't have killed her, I don't know if there was a reason to kill Niivi. You just wanted weapons and gear? I mean if it helps I guess. She was doing more good than harm", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Okie dokie, Gothivia has agree to stay calm so we aren't going to assassinate her anymore, I feel bad for killing her sister now. I hope Vixyl doesn't find out.", "填入汉化文本");
            }
            base.OnChatButtonClicked(npc, firstButton);
        }
    }
}
