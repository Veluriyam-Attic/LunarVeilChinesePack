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
    //Veldris 
    public class Veldris_Tooltips : GlobalNPC
    {
        //Stellamod
        public override void OnChatButtonClicked(NPC npc, bool firstButton)
        {
            if(npc.ModNPC.Name.Equals("Veldris") && npc.ModNPC.Mod.Name.Equals("Stellamod") && firstButton == false)
            {
                
                Main.npcChatText = Main.npcChatText.Replace($"You doing good? I mean it's a hellhole out here. Sometimes I even start to wonder what brings you here. I'm just some lonesome seller, just be sure not to get on someone's deadlist or else I'll be seeing ya. ", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Everytime I hear someone talk about gods I want to just puke in their faces, like ew. I'm kind of glad that Sirestias woman is getting rid of them. Her and Fenix don't seem all too power driven. Fenix is just revenge driven, and I can respect that.", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"If my weapons we're ever used, they better be in the right hands. My tools were crafted with some Luminull and some special metals, they better hold together- I had to steal some stuff from that Illuria place", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"I'm just gonna rant about this Illuria place honestly. WHY IS THERE A DRAGON JUST ROAMING. Like I thought those went extinct with the the virulent- oh I meant acid. I really just needed some scales but oh noo the watcher of society is there. ", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Back in my day building this house was my masterpiece, Fenix really gathered up an army just to build this cathedral here and that temple below just to trap some harlet who took her stuff. Down right evil though on Fenix's behalf, maybe overkill. ", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Some knights visited me the other day talking of this 'peace and formality' and I couldn't take it so I went to the Lunar tree, which for some reason they live on and I stole some fragments and some luminull? It seems pretty powerful and is probably related to Lumi in some way.", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"I love myself commissions, just sayingg if you wanna commission me I'm all available, the last person I went to kill was some goofy guy named Rallad, some girl named Sylia asked me if I could do it for her since she didnt want to be seen, took forever to find him though. ", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Interestingly enough me and Sylia have fun sometimes, shes pretty nice once you get to know her, sadly she stays away from her sister Merena and the rest of the capital, she's pretty chill. Kind of wanna travel with her though. ", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"The small joys of life comes from not having your house destroyed by some malevolent gods throwing down their trap cards when youre trying to sleep. It makes me annoyed when I have to peek out my window to make sure the black hole isn't going to hit my house.", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"You knowww, I was named Veldris by my friend, I always grew up without a name since my parents died by a stupid raging black hole guy, name was Sepsis I believe? He killed off so much 30 years ago yet I remember it like yesterday.", "请输入汉化文本");
            }
            base.OnChatButtonClicked(npc, firstButton);
        }
        public override void GetChat(NPC npc, ref string chat)
        {
            if(npc.ModNPC.Name.Equals("Veldris") && npc.ModNPC.Mod.Name.Equals("Stellamod"))
            {
                chat = chat.Replace("Shes got some great cogs", "请输入汉化文本");
                chat = chat.Replace("Who's next on this list to kill?", "请输入汉化文本");
                chat = chat.Replace("How are you doing? ", "请输入汉化文本");
                chat = chat.Replace("I need to gamble a bit more today", "请输入汉化文本");
                chat = chat.Replace("That Sirestias woman creeps me out.", "请输入汉化文本");
                chat = chat.Replace("I gotta get to the Royal Capital some day. Maybe they can empower my weapons.", "请输入汉化文本");
                chat = chat.Replace("So coldddd", "请输入汉化文本");
                chat = chat.Replace("Hey you, come buy some stuff from me!", "请输入汉化文本");
                chat = chat.Replace("Im starting to warm up this winter", "请输入汉化文本");
                chat = chat.Replace("Everyone and all this damn god talk, it makes me crazy", "请输入汉化文本");
                chat = chat.Replace("Interestingly, I don't know why those sisters all are disconnected, it seems like they're always hiding something", "请输入汉化文本");
                chat = chat.Replace("I wish I was someone important", "请输入汉化文本");
                chat = chat.Replace("Sometimes I wanna lead an army you know? I just wanna see Veiizal again", "请输入汉化文本");
                chat = chat.Replace("You gonna buy something lad?", "请输入汉化文本");
            }
            base.GetChat(npc, ref chat);
        }
    }
}
