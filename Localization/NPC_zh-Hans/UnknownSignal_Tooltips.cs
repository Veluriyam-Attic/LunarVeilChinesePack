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
    //UnknownSignal 
    public class UnknownSignal_Tooltips : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.ModNPC != null)
            {
                if (npc.ModNPC.Mod.Name.Equals("Stellamod") && npc.ModNPC.Name.Equals("UnknownSignal"))
                {
                    chat = chat.Replace("A static voice confirms the identity of the user, you are in the right place.", "请输入汉化文本");
                    chat = chat.Replace("A static voice confirms the identity of the user, you are in the right place.", "请输入汉化文本");
                    chat = chat.Replace("...", "请输入汉化文本");
                }
            }
            base.GetChat(npc, ref chat);
        }
    }
}
