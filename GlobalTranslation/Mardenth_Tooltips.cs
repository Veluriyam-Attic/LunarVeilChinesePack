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
    /// <summary>
    /// Mardenth 玛登斯 
    /// </summary>
    public class Mardenth_Tooltips : GlobalNPC
    {
        public override void OnChatButtonClicked(NPC npc, bool firstButton)
        {
            string ModName = npc.ModNPC.Mod.Name;
            string NpcName = npc.ModNPC.Name;
            if(ModName.Equals("Stellamod") && NpcName.Equals("Mardenth") && firstButton==false)
            {
                Main.npcChatText = npc.GetChat().Replace("Heheheh, I like to eat little wormy guys but they won't stop squiggling. Reminds me of when our dad Daeden left us. ","请输入汉化文本");
                Main.npcChatText = npc.GetChat().Replace("Where did Daedus go?  He left us so long ago. I hope he wasn't swayed by that Harlet Gothivia. She seemed power obsessed and hungry. Maybe that's just me though", "请输入汉化文本");
                Main.npcChatText = npc.GetChat().Replace("I might be the only one but, Ereshkigal is kind of hot isn't she? Hell you wouldn't even know would you. You're taste in women is flat.", "请输入汉化文本");
                Main.npcChatText = npc.GetChat().Replace("You don't understand how we are. We're higher than all below us, which is everyone except a god. Only they can be held to such high status. Squirm off you worm.", "请输入汉化文本");
                Main.npcChatText = npc.GetChat().Replace("I wish Sigfried didn't go insane. He's such an asshole, even our dear Ereshkigal left with him to seal him away...  ", "请输入汉化文本");
                Main.npcChatText = npc.GetChat().Replace("Maybe I may be the only person to question the gene pools of these people. Like where do they all look so pretty from??? Im wearing this mask cuz I look like a goblin.", "请输入汉化文本");
                Main.npcChatText = npc.GetChat().Replace("I want a beach episode with Zui and Ereshkigal now! ", "请输入汉化文本");
                Main.npcChatText = npc.GetChat().Replace("I would want to be more powerful but that takes a lot of training. Anyone who dares to take more than what they are given should be punished. ", "请输入汉化文本");
                Main.npcChatText = npc.GetChat().Replace("Those guys in the well? They are trapped down there because they made some goofy deals in their lives to get more power and just like the great Veil people we are, we trapped them away for good.", "请输入汉化文本");
                Main.npcChatText = npc.GetChat().Replace("I don't know what the outside world is like.", "请输入汉化文本");
            }
            base.OnChatButtonClicked(npc, firstButton);
        }
        public override void GetChat(NPC npc, ref string chat)
        {
            string ModName = npc.ModNPC.Mod.Name;
            string NpcName = npc.ModNPC.Name;
            if (ModName.Equals("Stellamod") && NpcName.Equals("Mardenth"))
            {
                chat = chat.Replace("So many cool contraptions she has, I love them!", "填入汉化文本");
                chat = chat.Replace("Damn that Sigfried guy.", "填入汉化文本");
                chat = chat.Replace("Where's Ereshkigal?", "填入汉化文本");
                chat = chat.Replace("Daedus, Jovhia, Daeden? Where'd you all go?", "填入汉化文本");
                chat = chat.Replace("I'm quite formiddable you see. I can destroy anything with my hands.", "填入汉化文本");
                chat = chat.Replace("I need to study up on my electric magic. If my dad wasn't dead he'd be proud of me. Gosh I wish you were here Daeden", "填入汉化文本");
                chat = chat.Replace("I never knew my mom..", "填入汉化文本");
                chat = chat.Replace("Why is Jovhia always in the sky?", "填入汉化文本");
                chat = chat.Replace("Hey you, get out of here!", "填入汉化文本");
                chat = chat.Replace("Scadabble you women harrasser.", "填入汉化文本");
            }

            base.GetChat(npc, ref chat);
        }
    }
}
