using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LunarVeilChinesePack.Localization.NPC_zh_Hans
{
    /// <summary>
    /// 赌徒 待定
    /// </summary>
    public class Gambit_Gambler_Tooltips : GlobalNPC
    {
        //第二个按钮按下
        public override void OnChatButtonClicked(NPC npc, bool firstButton)
        {
            string name = npc.ModNPC.Name;
            //Main.NewText(name); 
            if (npc.ModNPC.Mod.Name.Equals("Stellamod") && name.Equals("Gambit"))
            {

                //Main.NewText(true);
                //Player player = Main.LocalPlayer;
                //WeightedRandom<string> chat = new WeightedRandom<string>();
                //switch (Main.rand.Next(3))
                //{


                //    case 0:
                //        //OMG YOU DOOOO? Aww youre so sweet \nwe can hold off until a bit later :3
                //        CombatText.NewText(npc.getRect(), Color.White, "哈哈哈哈", true, false);
                //        break;
                //    case 1:
                //        CombatText.NewText(npc.getRect(), Color.White, "Aww cmon, don't be so silly, \nlets wait until we fix this world, \nlet me help you out :P", true, false);
                //        break;
                //    case 2:
                //        CombatText.NewText(npc.getRect(), Color.White, "Awaaaaaaaaaaaaaaaaaaaaaaaa~ \n(Zielie is too flustered to continue)", true, false);
                //        break;

                //}

            }
        }
        //普通聊天
        public override void GetChat(NPC npc, ref string chat)
        {
            string name = npc.ModNPC.Mod.Name;
            if(name.Equals("Stellamod"))
            {
                chat = chat.Replace("I love the party girl! Shes really sweet! Umm could you maybe hook us up :(", "填入汉化文本");
                chat = chat.Replace("Hii, it is a me, Zielie! I'm frantic at moments but what can you expect when your in a world full of death and loooove?", "填入汉化文本");
                chat = chat.Replace("Ive heard that the morrow is very pretty, I talked to veribloom and she said her society is falling apart though so maybe not.", "填入汉化文本");
                chat = chat.Replace("I have some things on the market for you, I go around collecting items and I get more stuff when you beat bosses and honestly, you seem really cool! :0", "填入汉化文本");
                chat = chat.Replace("You know who is responsible for your dice rolling righttt? You know, uh after you beat bosses? Yeah, thats me ya silly lovebug", "填入汉化文本");
                chat = chat.Replace("Can we get married?", "填入汉化文本");
                chat = chat.Replace("Soo are we gonna get married or are you gonna buy something?", "填入汉化文本");
            }
            base.GetChat(npc, ref chat);
        }
    }
}
