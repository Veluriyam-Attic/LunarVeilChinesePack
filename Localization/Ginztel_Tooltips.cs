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
    /// <summary>
    /// Ginztel 玄铁军官
    /// </summary>
    public class Ginztel_Tooltips : GlobalNPC
    {
        //public override void OnChatButtonClicked(NPC npc, bool firstButton)
        //{
        //    string npcName = npc.ModNPC.Name;
        //    string modName = npc.ModNPC.Mod.Name;
        //    if (modName.Equals("Stellamod") && npcName.Equals("Ginztel"))
        //    {
        //        //Main.npcChatText = npc.GetChat().Replace("");
        //    }

        //        base.OnChatButtonClicked(npc, firstButton);
        //}
        public override void GetChat(NPC npc, ref string chat)
        {
            string npcName = npc.ModNPC.Name;
            string modName = npc.ModNPC.Mod.Name;
            if(modName.Equals("Stellamod") && npcName.Equals("Ginztel"))
            {
                chat = chat.Replace("Hehe the Demonilitionist guy is pretty cool, he's got bombs..", "填入汉化文本");
                chat = chat.Replace("Im just peeping around, I might stay for a while..", "填入汉化文本");
                chat = chat.Replace("My team was quite weak to say, I apologize for the inconvience", "填入汉化文本");
                chat = chat.Replace("Some of the things I'm selling are from base, we've all taken quite a liking to you all.", "填入汉化文本");
                chat = chat.Replace("If you can kill Gothivia for us we can scavange and steal their items, please help us do that", "填入汉化文本");
                chat = chat.Replace("We may be weak but we still give all of our little praise to Verlia, hence why we stole from her sister..", "填入汉化文本");
                chat = chat.Replace("Could you murder Gothivia in the most brutal fashion possible? She is way too dauntless and carefree, we hate her and she took our home..", "填入汉化文本");
            }
            base.GetChat(npc, ref chat);
        }
    }
}
