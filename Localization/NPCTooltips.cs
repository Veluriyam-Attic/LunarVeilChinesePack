using Microsoft.Build.Tasks;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace LunarVeilChinesePack.Localization
{
    public class NPCTooltips : GlobalNPC
    {
        //public override void AI(NPC npc)
        //{
        //    base.AI(npc);
        //}
        ////修改名称列表
        //public override void ModifyNPCNameList(NPC npc, List<string> nameList)
        //{
        //    base.ModifyNPCNameList(npc, nameList);
        //}

        //public override void ModifyTypeName(NPC npc, ref string typeName)
        //{
        //    base.ModifyTypeName(npc, ref typeName);
        //}
        public override void OnChatButtonClicked(NPC npc, bool firstButton)
        {
            if (npc.ModNPC != null && firstButton == false)
            {
                //Gambler
                ModNPC mn = null;
                Mod mo = null;
                if (npc.ModNPC != null)
                {
                    mn = npc.ModNPC;
                    if (npc.ModNPC.Mod != null)
                    {
                        mo = mn.Mod;
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

                            if (npc.TypeName.Equals("波尔杜克"))
                            {
                                //I want you to prove to me you're ready to obtain this, I've given you a broken core, if you restore its power, it's all yours. Show me your determination to be Gothivia's doll! You won't be the first to fail.. And maybe she'll come to thank you one day. 
                                Main.npcChatText = $"填入文本汉化";
                            }

                            if (npc.TypeName.Equals("戴尔格林"))
                            {
                                switch (Main.rand.Next(30))
                                {
                                    case 0:
                                        //An old time there was a thriving capital, we used to call it the Harboring Morrow. It was a thriving city under the protection of Gothivia, Verlia, and Irradia. I used to be a member. Gothivia loved every one of us, Verlia would be off directing armies and Irradia well she spent time making electronics. 
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 1:
                                        //Irradia would make amazing tech, and I would come to every show she would host and watch her mechanic sword fights and spare parts, Verlia would sometimes participate and tear all of them apart. Verlia was just too good of a swordsman.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 2:
                                        //Gothivia would always come down at 10 A.M in the morning to greet all the city members, it used to be the time of my life. She'd give us goodies and Rek would come by with his binding light to empower the underground and brighten things up. 
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 3:
                                        //Verlia and Gothivia are sisters, although they don't look it anymore, they used to be twins yet they couldn't be different from each other. Verlia was always rambunctious and outgoing while Gothivia was a calm and loving soul, the two got along.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 4:
                                        //Of all the inventions Irradia made, by far my favorite was a rendition of Gothivia's Rek called Havoc. It was a magnificent beast. It held it's own against Verlia in the shows, if only I could go back to those days. 
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 5:
                                        //Verlia always would be training the army, the gintze army wasn't exactly the most reliable mainly because of Verlia's idiocity and lack of care for danger. The army would always charge head first without a care for defense. I wonder where the army was when we were defending against the Carian warriors and knights
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 6:
                                        //Some days I look back on the Harboring Morrow and wonder why we fell so hard. I remember BORDOC, an excellent blacksmith but too arrogant to read his ways. Irradia taught me some amazing things I carry with me today and all the people. the people.. 
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 7:
                                        //You know, I had loved Irradia, until we seperated through war our connection was magically I would say. Damn witches and their artistry.I don't hate magic, but its the reason I lost so much. That commander, I will never forget the smirk on that face. So called Fenix and her army of Carian knights. 
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 8:
                                        //One day in the Harboring Morrow, the most joyous of days, some collectors came back infected by some strange disease, as you may know now it's called the Virulent. An acid like corruption that eats at the soul. It tore our village apart like the black plague. It weakened us, right before a Carian army swept us away at our worst, we stood no chance.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 9:
                                        //Verlia one day left the Morrow to search and make peace with the witches in the upcoming villages, she was by far the most magical out of the three of them, so she would stand a chance to help, when she came back, she was out of her mind.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 10:
                                        //When Verlia came back from her excursion, she well, gave information that changed the course of our lives. Me being in a relationship with Irradia I was able to be let in on that information. She shared to us a tome from a small witch village. This would a fatal mistake.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 11:
                                        //Verlia's excursion took place right when the corruption started occuring, she went to look for a way to heal the damaged. Gothivia would do her best to heal everyone but she was only one person in the biggest capital in terraria. 
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 12:
                                        //One harrowing day, a fox appears at the doorstep of Verlia and Gothivia's abode. I knew my eyes decieved me when I had seen the fox transform into a tall Nero, they are like human cats but I thought they'd been extinct for millenia! 
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 13:
                                        //When a fox arrived on the doorsteps of our beloved, The fox lady brings out what I can only think was a lantern and all I could make out inside that room was a giant blue flash and the screams of Gothivia. This was the last time anyone heard of Verlia.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 14:
                                        //After what I call the 'blue flash,' everyone hurried to a sign of screaming in the middle of the night. We all come to see Gothivia crying with a note in her hand and the fox lady. She introduced herself as Fenix. 
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 15:
                                        //Fenix was a tall statured woman yet extremely menacing, at times a lot of us thought she may have been more powerful than Gothivia, but deep down Gothivia's suppressed feelings for her family would probably overcome that. 
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 16:
                                        //The illnesses started to rack up and since Verlia disappeared, our Harboring Morrow was not complete, there was nobody to keep our armies in check, Gothivia wasn't mentally there anymore and Irradia was trying her best to get everyone to calm down. It was a horrible time.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 17:
                                        //Irradia did explain what happened to Verlia, but I thought it was just downright evil. Fenix trapped Verlia's soul inside a lantern and bounded it to a secret power for experimentation because she stole a book from their village. We'll never get to see her again will we?
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 18:
                                        //I think Irradia's way of coping to the loss of Verlia was teaching me now that Im starting to recollect. She may have used it as a way of reflecting, and I didn't see that she was hurting yet I was always there for her.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 19:
                                        //I kept on living, hell I even got sick from the Virulent, yet I was Gothivia's last person to get healed from her. Rek eventually got infected too yet since havoc was electronic, he stayed normal. The creatures that lived the best were mostly metallic, its what remains of our old village.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 20:
                                        //After the last healing in from Gothivia, I'd say about 90% of our village was wiped out from the Virulent, our soliders, our love, and will to live all started to fall apart. 
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 21:
                                        //I could recall me laying on a bed as I watched our city crumble, Irradia would stay by my side and we'd comfort each other as the world caved in for us.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 22:
                                        //After a while of our suffering in the city Gothivia would leave to seek vengence and power to save her sister, leaving Irradia to be at the helm. Take a guess who arrived not so soon afterwards? Fenix, she came to take what was left of us.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 23:
                                        //Fenix is like a scouraging raven looking for its next feast, and we were on the menu. I was forced to split from my love due to her sacrifices of being a leader. We haven't seen each other since, yet I know she's out there somewhere. No way would she loose to Fenix..
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 24:
                                        //The Great Departure, that's what I call the leaving from what was left in our city. As the Carian army approached, we hid through underground tunnels to escape, some of us, including me, haven't gone back to the surface. I was even invited to come to the Fable.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 25:
                                        //Those who made it to the surface from the Great Departure reinvented the Harboring Morrow yet from all the messages from BORDOC, it isn't the same. They close their doors to everyone in fear and they look for Gothivia, she never said where she went.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 26:
                                        //I was in tunnels underground for 10 of my years, now I lay here with all the corpses and electronics that I bear, I've travelled every part of this world except the surface, to ever find Fenix again would send me over my limit.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 27:
                                        //You know, maybe I should have travelled with the rest of the members of the morrow, many of us split up in our escape, many died, hell, maybe I'm the only standing survivor, but I'm here.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 28:
                                        //My creations that I make now are from my explorations, I will find Irradia again, I need to apologize, to say something. These are all for her anyway. If only I could have stopped this from getting this way, maybe I could have stayed against her will.
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                    case 29:
                                        //Of all my years to live and ever to live, I will never understand things like Fenix, her torturous additude, why she went to such lengths to kill us, why the infection was so hard to fend off, and why I couldn't stay, these are all for you, Irradia. 
                                        Main.npcChatText = $"填入汉化文本";
                                        break;

                                }

                            }
                        }
                    }
                }
            }
            
                
            base.OnChatButtonClicked(npc, firstButton);
        }
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.ModNPC != null)
            {
                Mod mn = null;
                if (npc.ModNPC.Mod != null)
                {
                    mn = npc.ModNPC.Mod;
                }
                if (mn != null && mn.Name.Equals("Stellamod"))
                {
                    //戴尔格林
                    chat = chat.Replace("You're chill aren't ya?", "填入汉化文本");
                    chat = chat.Replace("Everyone comes in for the same stuff, come and go please.", "填入汉化文本");
                    chat = chat.Replace("Another visitor?", "填入汉化文本");
                    chat = chat.Replace("What goes on in the world nowadays?", "填入汉化文本");
                    chat = chat.Replace("I don't mean trouble, but do as you please.", "填入汉化文本");

                    //chat = chat.Replace("", "填入汉化文本");
                    //分子转换器 CellConverter 待研究
                    chat = chat.Replace("KRTTCAVSJKSC", "填入汉化文本");
                    chat = chat.Replace("I WANT SCRAP", "填入汉化文本");
                    chat = chat.Replace("MAKE YOUR SCRAP TOKENS FOR TRADE. KRM", "填入汉化文本");
                    chat = chat.Replace("YEEERRRM", "填入汉化文本");

                    //受缚的吉娅
                    chat = chat.Replace("Oh goodness thank you for saving me. I dont know how long I was tied up... I got stranded down here by a bunch of scouts I presume are from the morrow. I really caused a mess this time but I am really glad you saved me. D'you have a place to stay?", "填入汉化文本");

                    //Main.NewText(npc.TypeName == "安魅凯拉");
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

                    //波尔杜克
                    chat = chat.Replace("Shes got some great cogs", "填入汉化文本");
                    chat = chat.Replace("BRMMMM", "填入汉化文本");
                    chat = chat.Replace("Everyone always uses me but never asked how I'm able to talk.. ", "填入汉化文本");
                    chat = chat.Replace("I don't care I need to gamble", "填入汉化文本");
                    chat = chat.Replace("My armors are the best in the lands", "填入汉化文本");
                    chat = chat.Replace("Sirestias and Aimacra game by recently and they laughed at me because they thought my shop was useless", "填入汉化文本");
                    chat = chat.Replace("Im always feeling hot!", "填入汉化文本");
                    chat = chat.Replace("Heh, nobody is as good as me", "填入汉化文本");
                    chat = chat.Replace("Burning Burning, heat and heat", "填入汉化文本");
                    chat = chat.Replace("I'm inpenetrable", "填入汉化文本");
                    chat = chat.Replace("Damn we have some hot shit here", "填入汉化文本");
                    chat = chat.Replace("Only I know that Gothivia has so many barriers between her and the rest of the world, nobody will be able to kill her.", "填入汉化文本");
                    chat = chat.Replace("Those idiot gintze have made a horrible decision, now they can't use my armors I made for them.", "填入汉化文本");
                    chat = chat.Replace("KRMMMKTEYYYMMMM BRMMMMM", "填入汉化文本");

                    //chat = chat.Replace("","");

                }
            }

            //chat = chat.Replace("", "填入汉化文本");
            base.GetChat(npc, ref chat);
        }
    }
}
