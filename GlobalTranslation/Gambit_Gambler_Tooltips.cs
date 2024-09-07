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

namespace LunarVeilChinesePack.GlobalTranslation
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
                chat = chat.Replace("I love the party girl! Shes really sweet! Umm could you maybe hook us up :(", "我太喜欢派对女孩啦！她又善良又有趣！你觉得你能不能...给我们互相介绍一下？");
                chat = chat.Replace("Hii, it is a me, Zielie! I'm frantic at moments but what can you expect when your in a world full of death and loooove?", "嗨~，我叫泽丽！我有时会有点神经质，但在一个充满爱与死亡的世界中这样不是最好了吗！！");
                chat = chat.Replace("Ive heard that the morrow is very pretty, I talked to veribloom and she said her society is falling apart though so maybe not.", "听说幽曦之地很漂亮，但我问薇绿的时候她说那里的社会已经快要完全失控了，我还是先不去那里了为妙.");
                chat = chat.Replace("I have some things on the market for you, I go around collecting items and I get more stuff when you beat bosses and honestly, you seem really cool! :0", "我这里有点好东西卖给你！都是我自己捡来的和你打Boss剩下的东西~你也很棒哟！");
                chat = chat.Replace("You know who is responsible for your dice rolling righttt? You know, uh after you beat bosses? Yeah, thats me ya silly lovebug", "就是，你知道你的赌博骰子都是谁在扔对吧？就是我呀你个小傻瓜.");
                chat = chat.Replace("Can we get married?", "咱们来结个婚，你意下如何？");
                chat = chat.Replace("Soo are we gonna get married or are you gonna buy something?", "买点东西吧！难不成你想把自己卖给我？");
            }
            base.GetChat(npc, ref chat);
        }
    }
}
