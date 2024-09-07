using Stellamod.NPCs.Town;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace LunarVeilChinesePack.GlobalTranslation
{
    //Ordin 奥丁
    public class Ordin_Tooltips : GlobalNPC
    {
        public override void OnChatButtonClicked(NPC npc, bool firstButton)
        {
            string npcname = npc.ModNPC.Name;
            string modname = npc.ModNPC.Mod.Name;
            if (modname.Equals("Stellamod") && npcname.Equals("Ordin"))
            {
                
                Main.npcChatText = Main.npcChatText.Replace($"Thy is so resilient, unhand me from these this trecherous nagging and take this for thy shall not be astute to your prescence no longer.", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"To be one of the forth or forward, the lands that I rest in reek of falsification of hypocrisy and power.", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Sigfried was once a young fellow, thy brother in one's eye's and a villian in anothers'.", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Our sacred castle falls ill to such burning. Our wishes have been grafted under the curse of Sigfried's unveiling.", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Fall away, dear brother ", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Mark thy words with caution. Ereshkigal is a loveless harlet who took the life of the brother of many. Yet thy fulfills their prophecy among lovers, hence she is not a false goddess.", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"All our goals are put to rest following the lands of the veil. Finish all those who have wronged our beloved world.", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Manifest their souls and bring them to my company. You shall be rewarded until the rekoning begs for your place to be silenced. ", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Niivi, the protector of the lands of the veil, yet curse all upon thy brother to be selfish and steal among those of power and wealth. He was greedy and in his expense payed the lovers' prison.", "请输入汉化文本");
                Main.npcChatText = Main.npcChatText.Replace($"Now I sit ill waiting for the lands of the veil to change.", "请输入汉化文本");
            }

            base.OnChatButtonClicked(npc, firstButton);
        }
        public override void GetChat(NPC npc, ref string chat)
        {
            string npcname = npc.ModNPC.Name;
            string modname = npc.ModNPC.Mod.Name;
            if (modname.Equals("Stellamod") && npcname.Equals("Ordin"))
            {
                
                chat = chat.Replace("Shes got some great cogs", "请输入汉化文本");
                chat = chat.Replace("Remove yourself from my sight", "请输入汉化文本");
                chat = chat.Replace("You walk like an infant with no tucas", "请输入汉化文本");
                chat = chat.Replace("What a pitiful endearment, praise to the ones above.", "请输入汉化文本");
                chat = chat.Replace("...", "请输入汉化文本");
                chat = chat.Replace("You are not fit to become a god", "请输入汉化文本");
                chat = chat.Replace("Oh Sigfried, return in good health or I shall slay you with my own hands from such a succubus!", "请输入汉化文本");
                chat = chat.Replace("Bring me their Manifestations", "请输入汉化文本");
            }
            base.GetChat(npc, ref chat);
        }
    }
}
