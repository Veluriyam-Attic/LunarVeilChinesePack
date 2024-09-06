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
                chat = chat.Replace("Here to give me some company I see?", "请输入汉化文本");
                chat = chat.Replace("Hmph how's Aimacra doing? Nevermind I already know that answer.", "请输入汉化文本");
                chat = chat.Replace("Enjoying yourself?", "请输入汉化文本");
                chat = chat.Replace("Sometimes I forget you're bounded with me always", "请输入汉化文本");
                chat = chat.Replace("Its always sweet to see you do things for me", "请输入汉化文本");
                chat = chat.Replace("...", "请输入汉化文本");
            }

            base.GetChat(npc, ref chat);
        }
        public override void OnChatButtonClicked(NPC npc, bool firstButton)
        {
            string modname = npc.ModNPC.Mod.Name;
            string npcname = npc.ModNPC.Name;
            if (modname.Equals("Stellamod") && npcname.Equals("Sirestias"))
            {
                Main.npcChatText = Main.npcChatText.Replace($"Kill the stone guardian, commander gintzia will soon raid you with his army of failed troops from the govheil. He will be very easy so take him swiftly and beat him into submission hun. ", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($" I'd recommend going into the Fabled Swamp over to the right or collecting resources to get ready to fight either Jack or find a sun alter in a desert and prepare for Sunstalker! Zui may be a good person to talk to in the witch village for quest items too :) ", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Nice babe, I want you to go kill Jack in the Fabled swamp on the right then, you need a wandering essence and he shouldn't be too difficult. ", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Nice work! I want you to go headhunt a bird in the desert, his name is Sunstalker and they are a bit challenging but less so than the last, collect some mandibles in the desert to make the Sun stone! Find the alter on the surface of a desert!", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"You're next target is Daedus, he's a strong one. Hes a very loyal Guardian to one of the biggest threats here being Gothivia, we need him gone to get to the big fish in the sea. For some reason he holds some power of a singularity so beware. He resides low in the temple in the Fabled Swamp, no extra preperation needed.", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Oh my gosh nice, so here's where things are going to get difficult. If a blood moon happens we need to exterminate Dreadmire, she spawns after killing a blood cyst during a blood moon, you can also get some terror fragments too! She'll pose too much of a threat if we let her live. She's I think one of the three sisters, formally known as cozmire. She needs to die and after that I'll give some great rewards.", "填入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"We are making big progress now! I don't know if you have been killing other ravenous monsters but I'd recommend doing so as the next one on our list is Verlia but to get to her we have quite a few things to do first. Make yourself a void key and find a temple deep in the ice biome, there should be some loot and hopefully an alter that'll give you a lantern. She was trapped by Fenix but she needs to die so we can bring out Gothivia.", "填入汉化文本");
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
