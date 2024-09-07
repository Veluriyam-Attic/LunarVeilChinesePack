using LunarVeilChinesePack.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
//Zui 蕊


namespace LunarVeilChinesePack.Localization.NPC_zh
{ 
    [Obsolete($"见{nameof(TownNPCLocalizer)}")]
    public class Zui_Tooltips : GlobalNPC
    {
        public override bool IsLoadingEnabled(Mod mod) => false;
        public override void OnChatButtonClicked(NPC npc, bool firstButton)
        {
            if (firstButton == false)
            {
                if (npc.ModNPC != null)
                {
                    if (npc.ModNPC.Name.Equals("Zui") && npc.ModNPC.Mod.Name.Equals("Stellamod") && firstButton == false)
                    {
                        Main.npcChatText = Main.npcChatText.Replace($"Hi hii! Thanks for asking! Could you fetch me some plants, you can use this bag! Just fill it up with some different types of plants and I'll give you some stuff afterwards!", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"Hehe I'm gonna up the difficulty of these, I'm gonna need some bigger plants, so you'll need to fill up this bag! Thanks!", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"Nice nice, I'll take these, could you fetch some more for me!  ", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"Nice nice, I'll take these, could you fetch some more for me!  ", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"Ok ok, 3 quests is kind of good, thanks for caring a lot about this! I've got more items in my shop for you, bring me 3 more and I'll get more for ya!", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"6 Quests is actually kind of crazy, I've opened up with a few more items for you if you want! Bring me 4 more ;p", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"Damn, 10 quests? You're on a role you know! I've got some more items for you in my shop actually, I went travelling and Sirestias gave me a few items! I'll give you some more items if you can do 10 more!", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"You have finished 20 quests for me! Thank you! I've got more items in my shop because of it too! If you want more from me bring me ten more and maybe we can have some fun! ", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"My graditude is of the utmost thanks, in return you can have anything in my shop! And I'll help you out personally sometime if you need me ;p ", "请输入汉化文本");
                        Main.npcChatText = Main.npcChatText.Replace($"Hiya! I think that's all the things I need, you can get some stuff in my shop but thanks babe!", "请输入汉化文本");
                    }
                }
            }
            base.OnChatButtonClicked(npc, firstButton);
        }
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.ModNPC != null)
            {
                if (npc.ModNPC.Name.Equals("Zui") && npc.ModNPC.Mod.Name.Equals("Stellamod"))
                {
                    chat = chat.Replace("The dryad is pretty fun after all, she's pretty sweet and helps us with the gardening!", "请输入汉化文本");
                    chat = chat.Replace("We've had to kick a few witches out of this town you know, its quite a shame..", "请输入汉化文本");
                    chat = chat.Replace("I keep going out to find more plants but somehow you're always here when I return. ", "请输入汉化文本");
                    chat = chat.Replace("I'm trying to find a way to stop the corruption and virulent from spreading but I have no fix currently.", "请输入汉化文本");
                    chat = chat.Replace("Hey love, you know you could be collecting stuff for me!", "请输入汉化文本");
                    chat = chat.Replace("Sirestias? Oh um yeahh we go pretty far back.", "请输入汉化文本");
                    chat = chat.Replace("Aimacra is cool too, this is my first time meeting her lol", "请输入汉化文本");
                    chat = chat.Replace("I wouldn't say I'm too powerful, afterall I a just a traveller", "请输入汉化文本");
                    chat = chat.Replace("Sometimes I wonder what they did in Vodhome after we all left. I really have to catch up with Sirestias and the others.", "请输入汉化文本");
                    chat = chat.Replace("Are you here with Sirestias?", "请输入汉化文本");
                    chat = chat.Replace("All these plants are so cool! I did just arrive here before Sirestias, there was some commotion and I think people here are trying to disrupt time and power.", "请输入汉化文本");
                    chat = chat.Replace("Sirestias is a balancer, same goes for me but I like to just collect things.", "请输入汉化文本");
                    chat = chat.Replace("Hey if you collect some items for me I can give you some stuff!", "请输入汉化文本");
                    chat = chat.Replace("Hey can you go collect for me?", "请输入汉化文本");
                }
            }
            base.GetChat(npc, ref chat);
        }
    }
}
