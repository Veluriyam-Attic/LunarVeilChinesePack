using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace LunarVeilChinesePack.Localization
{
    public class NPCTooltips : GlobalNPC
    {
        public override void AI(NPC npc)
        {
            base.AI(npc);
        }
        //修改名称列表
        public override void ModifyNPCNameList(NPC npc, List<string> nameList)
        {
            base.ModifyNPCNameList(npc, nameList);
        }

        public override void ModifyTypeName(NPC npc, ref string typeName)
        {
            base.ModifyTypeName(npc, ref typeName);
        }
        public override void OnChatButtonClicked(NPC npc, bool firstButton)
        {
            ModNPC mn = npc.ModNPC;
            Mod mo = mn.Mod;
            try
            {
                if (mo.Name.Equals("Stellamod"))
                {
                    if (npc.TypeName.Equals("安魅凯拉"))
                    {
                        switch (Main.rand.Next(10))
                        {
                            case 0:
                                //Heyyy at least we're out of Ekrose alive! I'm glad Vixyl is safe back at the main house.
                                Main.npcChatText = $"填入汉化文本";

                                break;

                            case 1:
                                //I hate being Sirestias's Assassin.. Speaking of I met a guy named Veldris and he's totally cool!
                                Main.npcChatText = $"填入汉化文本";

                                break;

                            case 2:
                                //I'll be back I may go to look for some new stuff underground. 
                                Main.npcChatText = $"填入汉化文本";

                                break;

                            case 3:
                                //What is a thug shaker? To shake or not to shake? Sometimes I wonder if life truly does give lemons.
                                Main.npcChatText = $"填入汉化文本";

                                break;

                            case 4:
                                //What class would I even be? 
                                Main.npcChatText = $"填入汉化文本";

                                break;

                            case 5:
                                //Hey sorry for what may of happened on Ekrose but I hope we can still be friends and make up to each other.
                                Main.npcChatText = $"填入汉化文本";

                                break;

                            case 6:
                                //STARBOMBERS ARE ON THIS PLANET TOOOOO!!!
                                Main.npcChatText = $"填入汉化文本";

                                break;

                            case 7:
                                //I totally haven't been playing geometry dash.
                                Main.npcChatText = $"填入汉化文本";

                                break;

                            case 8:
                                //I've seen some weird things in my life, but never would I have thought Fenix would be more chronically horny than Sirestias, but to be fair Sirestias just gets more power doing that.
                                Main.npcChatText = $"填入汉化文本";

                                break;

                            case 9:
                                //I hate being part human.
                                Main.npcChatText = $"填入汉化文本";

                                break;
                        }
                    }
                }
            }
            catch { };
            base.OnChatButtonClicked(npc, firstButton);
        }
        public override void GetChat(NPC npc, ref string chat)
        {
            Mod mn = npc.ModNPC.Mod;
            try
            {
                if (mn.Equals("Stellamod"))
                {
                    //安魅凯拉
                    chat = chat.Replace("They also have fox ears like me lmao", "填入汉化文本");
                    chat = chat.Replace("This world seems a bit off don't you think?", "填入汉化文本");
                    chat = chat.Replace("I'm not one to brag but this place is so much better than Ekrose", "填入汉化文本");
                    chat = chat.Replace("Did Sirestias ask me to find her again?", "填入汉化文本");
                    chat = chat.Replace("Yeah I've been traveling while you were out.", "填入汉化文本");
                    chat = chat.Replace("Go play Diari on steam? I have no idea what that means", "填入汉化文本");
                    chat = chat.Replace("Do people think I'm not into pans?", "填入汉化文本");
                    chat = chat.Replace("Sooo can we forget about everything that happened in Ekrose?", "填入汉化文本");
                    chat = chat.Replace("I am really sorry for what we went through but now were here you know?", "填入汉化文本");
                    chat = chat.Replace("Sirestias went out again, and this time I'm not finding her.", "填入汉化文本");
                    chat = chat.Replace("Hey could you go do something, I'm about to get dressed, but honestly I say that like you haven't seen me before.", "填入汉化文本");
                }
            }
            catch {}
            //chat = chat.Replace("", "填入汉化文本");
            base.GetChat(npc, ref chat);
        }
    }
}
