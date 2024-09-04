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
                chat = chat.Replace("Hehe the Demonilitionist guy is pretty cool, he's got bombs..", "嘿嘿，那个爆破专家不错，他有好多炸弹...");
                chat = chat.Replace("Im just peeping around, I might stay for a while..", "俺只是来看看...或者在这住一小会.");
                chat = chat.Replace("My team was quite weak to say, I apologize for the inconvience", "俺的那帮人好弱啊.真是给你添麻烦了.");
                chat = chat.Replace("Some of the things I'm selling are from base, we've all taken quite a liking to you all.", "俺卖的东西好多都是是从俺们基地拿来的！俺们都觉得你还是个不错的家伙！");
                chat = chat.Replace("If you can kill Gothivia for us we can scavange and steal their items, please help us do that", "如果歌瑟梵挂了俺们就能抢她的东西啦！你一定要赢啊！");
                chat = chat.Replace("We may be weak but we still give all of our little praise to Verlia, hence why we stole from her sister..", "俺们不强，但俺们最稀罕薇莉娅，才敢偷她姐姐的东西.");
                chat = chat.Replace("Could you murder Gothivia in the most brutal fashion possible? She is way too dauntless and carefree, we hate her and she took our home..", "你一定要把歌瑟梵狠狠的揍一顿呀！俺们看着她那副目中无人的表情就来气！她还霸占了俺们的家...");
            }
            base.GetChat(npc, ref chat);
        }
    }
}
