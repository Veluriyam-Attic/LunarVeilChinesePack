using LunarVeilChinesePack.NPCs;
using Stellamod.NPCs.Town;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace LunarVeilChinesePack.Localization.NPC_zh
{
    //Merena 梅瑞娜
    [Obsolete($"见{nameof(TownNPCLocalizer)}")]
    public class Merena_Tooltips : GlobalNPC
    {
        public override bool IsLoadingEnabled(Mod mod) => false;
        public override void OnChatButtonClicked(NPC npc, bool firstButton)
        {
            if (firstButton == false)
            {
                if (npc.ModNPC != null)
                {
                    string npcname = npc.ModNPC.Name;
                    string modname = npc.ModNPC.Mod.Name;
                    if (modname.Equals("Stellamod") && npcname.Equals("Merena") && firstButton == false)
                    {
                        Main.npcChatText = Main.npcChatText.Replace($"Hey, I have nothing else for you to do! Thanks for all of your help, have you checked out my shop yet?", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"THANK YOU THANK YOU THANK YOU, omg this is the best day of my life! I never knew this actually existed! Were the rumors true??! dsfjhnbhfribdhs- Nevermind who cares anymore, we can both be the best mages ever! I open my shop to you and here, a token of my graditude. ", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"OHH Great lmao. Ok we have one more thing we need to do. Legend has it an old thief of this Royal Capital stole an extremely special Carian tome, they stay deep underground hidden far away underneath the abysm. Even if the rumors arent true I'd love for you to find this scroll, it may take years...", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"OHH Great lmao. Ok we have one more thing we need to do. Legend has it an old thief of this Royal Capital stole an extremely special Carian tome, they stay deep underground hidden far away underneath the abyss. Even if the rumors arent true I'd love for you to find this scroll, it may take years...", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"Neat neat, that shouldn't have been too bad for you I think. Next I need some magical paper, there are magical creatures all over the world of hardmode who drop these, most of them being rare and unique creatures, go get em'!", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"Neat neat, that shouldn't have been too bad for you I think. Next I need some magical paper, there are magical creatures all over the world of hardmode who drop these, most of them being rare and unique creatures, go get em'!", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"Woa, the energy is pouring out of this one with seamless orange stripes! How did you even get your hands on this?? Either way thanks, now I just need 100 dust bags, it helps with the brewery.", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"Woa, the energy is pouring out of this one with seamless orange stripes! How did you even get your hands on this?? Either way thanks, now I just need 100 dust bags, it helps with the brewery.", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"Oh damn thanks! Next on the list I need you to steal an orb from a village in an underground morrowed village, the orb contains a magic unlike any other. I have no idea how it was manifested but it's needed for this tome.", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"Oh damn thanks! Next on the list I need you to steal an orb from a village in an underground morrowed village, the orb contains a magic unlike any other. I have no idea how it was manifested but it's needed for this tome.", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"What are you standing there for, go kill Verlia! She's an enemy of the royal capital and she has a book I need lmao", "请输入汉化文本");
                    }
                }
            }
            base.OnChatButtonClicked(npc, firstButton);
        }
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.ModNPC != null)
            {
                string modname = npc.ModNPC.Mod.Name;
                string npcname = npc.ModNPC.Name;
                if (npcname.Equals("Merena"))
                {
                    chat = chat.Replace("Funny enough the clothier used to come through here all the time for some of our amazing fabrics", "请输入汉化文本");
                    chat = chat.Replace("I wonder what my sister Sylia is up to nowadays, do you know her?", "请输入汉化文本");
                    chat = chat.Replace("I'm gonna be the very best, like no one ever was... ", "请输入汉化文本");
                    chat = chat.Replace("Fenix is the best queen there will ever be! She gives us all what we want :P", "请输入汉化文本");
                    chat = chat.Replace("This place is so calming, I can't stand it but I would give everything to be near Fenix", "请输入汉化文本");
                    chat = chat.Replace("Aimacra seems pretty cool, she came here recently looking for some brooches", "请输入汉化文本");
                    chat = chat.Replace("Hey uh could you do something for me? I have a little favor, just ask what it is!", "请输入汉化文本");
                    chat = chat.Replace("I've always wanted to be the best witch there is! I've always been outshined by exiles though, including my sisters sadly.", "请输入汉化文本");
                    chat = chat.Replace("I really need to beat my sister in a battle someday.", "请输入汉化文本");
                    chat = chat.Replace("It's strange, the economic system here is almost like communism", "请输入汉化文本");
                    chat = chat.Replace("Damn we have some cool shit here", "请输入汉化文本");
                    chat = chat.Replace("No doubt about it but Fenix is truly the strongest witch in all of the lands, maybe even more powerful than the witch of light in the hallow, I don't like her.", "请输入汉化文本");
                    chat = chat.Replace("Hahh, I remember that goon Verlia, she's kind of dumb but shes at least powerful, I remember she got exiled for stealing tomes, I might need that from her.", "请输入汉化文本");
                    chat = chat.Replace("Can you go collect some runes for me? I'd love for you to get working.", "请输入汉化文本");
                }
            }

            base.GetChat(npc, ref chat);
        }
    }
}
