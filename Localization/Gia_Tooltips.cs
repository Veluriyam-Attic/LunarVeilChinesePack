using Stellamod.NPCs.Harvesting.Morrow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.Main.CurrentFrameFlags;
namespace LunarVeilChinesePack.Localization.NPC_zh_Hans
{
    /// <summary>
    /// Gia 吉娅 待定
    /// </summary>
    public class Gia_Tooltips:GlobalNPC
    {
        public override void OnChatButtonClicked(NPC npc, bool firstButton)
        {
            string modname = npc.ModNPC.Mod.Name;
            string npcname = npc.ModNPC.Name;
            //Main.NewText(npc.GetChat());
            if (modname.Equals("Stellamod") && npcname.Equals("Gia"))
            {
                Main.npcChatText = npc.GetChat().Replace("I give you my thanks for this Desert artifact, it'll help further my reserch to fixing this mess!","填入汉化文本");
                Main.npcChatText = npc.GetChat().Replace("I give you my thanks for this Sky artifact, it'll help further my reserch to fixing this mess!", "填入汉化文本");
                Main.npcChatText = npc.GetChat().Replace("I give you my thanks for this Overworld artifact, it'll help further my reserch to fixing this mess!", "填入汉化文本");
                Main.npcChatText = npc.GetChat().Replace("I give you my thanks for this Ocean artifact, I'll research it greatly, heres something in return..", "填入汉化文本");
                Main.npcChatText = npc.GetChat().Replace("I give you my thanks for this Jungle artifact, it'll help further my reserch to fixing this mess!", "填入汉化文本");
                //Main.npcChatText = npc.GetChat().Replace("", "填入汉化文本");
                //DesertRuneI

            }
            base.OnChatButtonClicked(npc, firstButton);
        }
        public override void GetChat(NPC npc, ref string chat)
        {
            string modname = npc.ModNPC.Mod.Name;
            string npcname = npc.ModNPC.Name;
            if(modname.Equals("Stellamod") && npcname.Equals("Gia"))
            {
                chat = chat.Replace("So many cool contraptions she has, I love them!", "填入汉化文本");
                chat = chat.Replace("A long time ago, I used to experiment with Biotech. It went wrong, and teleported pieces of itself all over the world. You might have found some by now.", "填入汉化文本");
                chat = chat.Replace("Maybe if you find some of my lost tech, you could craft my original biotech and retry my experiments!", "填入汉化文本");
                chat = chat.Replace("The guide seems to know too much for a human being. I feel like he has something else connected to him…", "填入汉化文本");
                chat = chat.Replace("The merchant keeps telling me about this dangerous eye thing. I could just zap it with my Bio laser.", "填入汉化文本");
                chat = chat.Replace("Aimacra seems pretty neat, too bad she's taken", "填入汉化文本");
                chat = chat.Replace("I wouldn't mind hooking up with the Steampunker :)", "填入汉化文本");
                chat = chat.Replace("So many spare parts and materials, bring them all to me!", "填入汉化文本");
                chat = chat.Replace("I can't believe I let it get loose, I've complicated too many things.", "填入汉化文本");
                chat = chat.Replace("Can you go collect some runes for me? I'd love for you to get working.", "填入汉化文本");
            }
            base.GetChat(npc, ref chat);
        }
    }
}
