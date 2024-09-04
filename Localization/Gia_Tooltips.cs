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
                Main.npcChatText = npc.GetChat().Replace("I give you my thanks for this Desert artifact, it'll help further my reserch to fixing this mess!","感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！");
                Main.npcChatText = npc.GetChat().Replace("I give you my thanks for this Sky artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！");
                Main.npcChatText = npc.GetChat().Replace("I give you my thanks for this Overworld artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！");
                Main.npcChatText = npc.GetChat().Replace("I give you my thanks for this Ocean artifact, I'll research it greatly, heres something in return..", "感谢你帮我找到了这块符文，我会仔细研究它的.这是些回礼，难表谢意...");
                Main.npcChatText = npc.GetChat().Replace("I give you my thanks for this Jungle artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！");
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
                chat = chat.Replace("So many cool contraptions she has, I love them!", "她有那么多超棒的机械！我好想要啊.");
                chat = chat.Replace("A long time ago, I used to experiment with Biotech. It went wrong, and teleported pieces of itself all over the world. You might have found some by now.", "很久之前我还在研究生物科技，但是那件作品出了岔子，残片飞散到了世界各处.你可能已经找到了其中的几片.");
                chat = chat.Replace("Maybe if you find some of my lost tech, you could craft my original biotech and retry my experiments!", "如果你能找到那些我遗失的科技零件，就能造出我的独创机器，重试我的试验！");
                chat = chat.Replace("The guide seems to know too much for a human being. I feel like he has something else connected to him…", "向导知道的实在太多了，他真的只是个人类吗？我感觉有什么其它东西与他有联系...");
                chat = chat.Replace("The merchant keeps telling me about this dangerous eye thing. I could just zap it with my Bio laser.", "商人一直在说什么危险的大眼球...它要是敢来，我就让它尝尝我的反生物激光.");
                chat = chat.Replace("Aimacra seems pretty neat, too bad she's taken", "安魅凯拉看起来不错，可惜她已经有伴了.");
                chat = chat.Replace("I wouldn't mind hooking up with the Steampunker :)", "蒸汽朋克人也不赖嘛，我想和她试试：）");
                chat = chat.Replace("So many spare parts and materials, bring them all to me!", "有多少零件材料就给我拿来多少！");
                chat = chat.Replace("I can't believe I let it get loose, I've complicated too many things.", "真不敢相信我居然一时疏忽把“它”放出来了...这下事情复杂了好多.");
                chat = chat.Replace("Can you go collect some runes for me? I'd love for you to get working.", "给我收集一些符文碎片吧！反正你闲着也是闲着.");
            }
            base.GetChat(npc, ref chat);
        }
    }
}
