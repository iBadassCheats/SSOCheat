using ClickableTransparentOverlay;
using ImGuiNET;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using ꜱꜱᴏ.ᴜᴛɪʟꜱ;

namespace ꜱꜱᴏ.ʜᴏᴍᴇ
{
    internal class ᴡɪɴᴅᴏᴡ : Overlay
    {
        public static Vector4 ɢᴇᴛᴄᴏʟᴏʀ(Color color) => new Vector4(color.R, color.G, color.B, color.A);

        public static void ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ(string text)
        {
            ImGui.Separator();
            float windowWidth = ImGui.GetWindowSize().X, textWidth = ImGui.CalcTextSize(text).X;
            ImGui.SetCursorPosX((windowWidth - textWidth) * .5f);
            ImGui.TextColored(ɢᴇᴛᴄᴏʟᴏʀ(Color.Purple), text);
            ImGui.Separator();
        }

        public ᴡɪɴᴅᴏᴡ() : base(3840, 2160)
        {

        }

        protected override Task PostInitialized()
        {
            return Task.CompletedTask;
        }

        protected override void Render()
        {
            ᴍᴏᴅᴜʟᴇ.ꜰʟʏᴍᴏᴅᴜʟᴇ(ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ꜰʟʏ);
            ᴍᴏᴅᴜʟᴇ.ꜱᴘᴇᴇᴅᴍᴏᴅᴜʟᴇ(ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ꜱᴘᴇᴇᴅ);
            ᴍᴏᴅᴜʟᴇ.ᴅᴏᴜʙʟᴇꜱᴘᴇᴇᴅᴍᴏᴅᴜʟᴇ(ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ᴅᴏᴜʙʟᴇꜱᴘᴇᴇᴅ);
            ᴍᴏᴅᴜʟᴇ.ɴᴏꜰᴀʟʟᴍᴏᴅᴜʟᴇ(ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ɴᴏꜰᴀʟʟ);
            ᴍᴏᴅᴜʟᴇ.ɴᴏʀᴇꜱᴇᴛᴍᴏᴅᴜʟᴇ(ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ɴᴏʀᴇꜱᴇᴛ);
            ᴍᴏᴅᴜʟᴇ.ꜰᴜʟʟQᴜᴇꜱᴛᴄᴏᴍᴘʟᴇᴛᴇᴍᴏᴅᴜʟᴇ(ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ꜰᴜʟʟQᴜᴇꜱᴛ);
            ᴍᴏᴅᴜʟᴇ.ᴇɴᴅʟᴇꜱꜱᴍᴏᴅᴜʟᴇ(ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ᴇɴᴅʟᴇꜱꜱQᴜᴇꜱᴛ);
            ᴍᴏᴅᴜʟᴇ.ɪɴꜱᴛᴀɴᴛᴅɪᴀʟᴏɢᴍᴏᴅᴜʟᴇ(ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ɪɴꜱᴛᴀɴᴛᴅɪᴀʟᴏɢ);

            if (ImGui.Begin("Open Source Menu, by Jan"))
            {
                if (ImGui.CollapsingHeader("Basic"))
                {
                    ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Movement");
                    ImGui.Checkbox("Fly Up", ref ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ꜰʟʏ);
                    ImGui.Checkbox("Extreme Speed", ref ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ꜱᴘᴇᴇᴅ);
                    ImGui.Checkbox("Double Speed", ref ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ᴅᴏᴜʙʟᴇꜱᴘᴇᴇᴅ);

                    ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Bypass");
                    ImGui.Checkbox("No Fall", ref ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ɴᴏꜰᴀʟʟ);
                    ImGui.Checkbox("No Reset", ref ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ɴᴏʀᴇꜱᴇᴛ);

                    ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Quest");
                    ImGui.Checkbox("Quest Full Complete", ref ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ꜰᴜʟʟQᴜᴇꜱᴛ);
                    ImGui.Checkbox("Quest Endless", ref ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ᴇɴᴅʟᴇꜱꜱQᴜᴇꜱᴛ);
                    ImGui.Checkbox("Quest Instant Dialog", ref ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ɪɴꜱᴛᴀɴᴛᴅɪᴀʟᴏɢ);

                    ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Inventory");
                    ImGui.InputInt("Amount##dupe", ref ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴀᴍᴏᴜɴᴛ_ᴅᴜᴘᴇɪᴛᴇᴍ);
                    //ImGui.Text("|  Max: " + xʜᴇʟᴘᴇʀ.xᴍᴇᴍᴏʀʏ.xɴᴏʀᴍᴀʟ.ʀᴇᴀᴅɪɴᴛ(ᴍᴏᴅᴜʟᴇ.ᴀᴅᴅʀᴇꜱꜱᴇ.ᴅᴜᴘᴇɪᴛᴇᴍ + ",1D4"));
                    //if (ImGui.Button("Dupe Item"))
                    //{
                    //    ᴍᴏᴅᴜʟᴇ.ᴅᴜᴘᴇᴍᴏᴅᴜʟᴇ(ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴀᴍᴏᴜɴᴛ_ᴅᴜᴘᴇɪᴛᴇᴍ - 1);
                    //}

                    ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Special");
                    ImGui.InputInt("Amount##sc_real", ref ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ꜱᴛᴀʀᴄᴏɪɴꜱ);
                    if (ImGui.Button("Set Star Coins")) { ᴍᴏᴅᴜʟᴇ.ꜱᴛᴀʀᴄᴏɪɴꜱᴍᴏᴅᴜʟᴇ(ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ꜱᴛᴀʀᴄᴏɪɴꜱ); }

                    ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Texture");
                }
                if (ImGui.CollapsingHeader("Teleport"))
                {

                }
                if (ImGui.CollapsingHeader("Modding"))
                {
                    if (ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ᴍᴏᴅᴅɪɴɢ)
                    {
                        ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Player");

                        ImGui.Text("Player XP");
                        if (ImGui.Button("Add Player XP x1"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/PXP.QuestComplete();");
                        }
                        if (ImGui.Button("Add Player XP x5"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/PXP.QuestComplete();global/PXP.QuestComplete();global/PXP.QuestComplete();global/PXP.QuestComplete();global/PXP.QuestComplete();");
                        }

                        ImGui.Text("Player Animation");
                        int selectedIndex_player = Array.IndexOf(ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.animations_player, ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.selected_animations_player);
                        if (ImGui.ListBox("##ani_player", ref selectedIndex_player, ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.animations_player, ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.animations_player.Length))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.selected_animations_player = ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.animations_player[selectedIndex_player];
                        }
                        if (ImGui.Button("Set Animation##ani_player"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ($"global/Player.PlayerTPNetPlayAnimationLooping(\"{ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.selected_animations_player}\");");
                        }
                        ImGui.SameLine();
                        if (ImGui.Button("Stop Animation##ani_player"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/Player.PlayerTPNetPlayAnimationEnd();");
                        }

                        ImGui.Text("Player Name");
                        ImGui.InputText("Name##player", ref ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ᴘʟᴀʏᴇʀɴᴀᴍᴇ, 1000);
                        if (ImGui.Button("Set Custom Player Name"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ($@"global/PlayerName.SetDataString(""{ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ᴘʟᴀʏᴇʀɴᴀᴍᴇ}"");");
                        }

                        ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Horse");

                        ImGui.Text("Horse XP");
                        if (ImGui.Button("Add Horse XP x1"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/HXP.QuestComplete();");
                        }
                        if (ImGui.Button("Add Horse XP x5"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/HXP.QuestComplete();global/HXP.QuestComplete();global/HXP.QuestComplete();global/HXP.QuestComplete();global/HXP.QuestComplete();");
                        }

                        ImGui.Text("Horse Name");
                        ImGui.InputText("Name##horse", ref ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ʜᴏʀꜱᴇɴᴀᴍᴇ, 1000);
                        if (ImGui.Button("Set Custom Horse Name"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ($@"global/HorseName.SetDataString(""{ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ʜᴏʀꜱᴇɴᴀᴍᴇ}"");");
                        }

                        ImGui.Text("Horse Change");
                        if (ImGui.Button("Rainbow Zee"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/Horse.HorseAppearanceCustomBody(10,0,0);global/Horse.HorseAppearanceCustomHair(3,4,0);");
                        }
                        if (ImGui.Button("Rainbow Body"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/Horse.HorseAppearanceCustomBody(2,-1,0);");
                        }
                        if (ImGui.Button("Rainbow Mane"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/Horse.HorseAppearanceCustomHair(3,-1,0);");
                        }
                        if (ImGui.Button("Rainbow Both"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/Horse.HorseAppearanceCustomBody(2,-1,0);global/Horse.HorseAppearanceCustomHair(3,-1,0);");
                        }

                        ImGui.InputInt("Change ID", ref ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ʜᴏʀꜱᴇɪᴅ);
                        if (ImGui.Button("Visual Horse"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ($"global/Horse.CloneHorseAppearance({ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ʜᴏʀꜱᴇɪᴅ});");
                        }

                        ImGui.Text("Interface");
                        if (ImGui.Button("Open Horse Hair Style"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/ShopManager/Episode1/HorseHairStyleShop1.ShopOpen();");
                        }

                        ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Shop");

                        ImGui.Text("Inventar Shop");
                        int selectedIndex = Array.IndexOf(ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.shops, ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.selected_shop);
                        if (ImGui.ListBox("##shop", ref selectedIndex, ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.shops, ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.shops.Length))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.selected_shop = ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.shops[selectedIndex];
                        }
                        if (ImGui.Button("Open Shop Name##shop"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ($"global/ShopManager/Episode1/{ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.selected_shop}.ShopOpen();");
                        }

                        ImGui.Text("Horse Shop");
                        ImGui.InputInt("Horse ID##horse", ref ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ʜᴏʀꜱᴇꜱʜᴏᴘɪᴅ);
                        if (ImGui.Button("Open Shop ID##horse"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ($"global/HFSIW.CloneHorse({ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ʜᴏʀꜱᴇꜱʜᴏᴘɪᴅ}, 1);global/HFSIW.HorseForSaleStartBuyWindow();");
                        }

                        ImGui.Text("Reputation");
                        int selectedIndex_rep = Array.IndexOf(ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.rep, ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.selected_rep);
                        if (ImGui.ListBox("##ani_rep", ref selectedIndex_rep, ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.rep, ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.rep.Length))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.selected_rep = ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.rep[selectedIndex_rep];
                        }
                        if (ImGui.Button("Set Reputation##ani_rep"))
                        {
                            if (ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.selected_rep == "SoulRidingWithRhiannon")
                            {
                                ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ($"global/FactionManager/SoulRidingWithRhiannon.FactionAddReputation(10000);");
                            }
                            else
                            {
                                ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ($"global/FactionManager/{ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.selected_rep}.FactionAddReputation(1000);");
                            }
                        }

                        ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Quest");

                        ImGui.Text("Selected");
                        if (ImGui.Button("Discard Quest"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/QuestManager.QuestManagerDiscardSelected();");
                        }

                        ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Objects");

                        ImGui.Text("Objects");
                        ImGui.InputText("Object Name", ref ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴏʙᴊᴇᴄᴛᴍᴀɴᴀɢᴇʀ_ᴏʙᴊᴇᴄᴛ, 1000);
                        if (ImGui.Button("Spawn Object to You##object"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ($"global/SL.SetFileObjectName(\"{ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴏʙᴊᴇᴄᴛᴍᴀɴᴀɢᴇʀ_ᴏʙᴊᴇᴄᴛ}\");" +
                                $"global/SL.FileObjectLoad();" +
                                $"global/SL.Start();" +
                                $"global/SL.SetOrientationByObject(global/Horse);");
                        }

                        ImGui.Text("Wings");
                        if (ImGui.Button("Spawn Wings##object"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ($"global/CWE.SetFileObjectName(\"FO_CloudWorld_Wings.pxo\");" +
                                $"global/CWE.FileObjectLoad();" +
                                $"global/CWE.Start();" +
                                $"global/CWE.Move(global/Horse);" +
                                $"global/CWE.Copy(global/Horse);" +
                                $"global/CWE.SetOrientationByObject(global/Horse);");
                        }

                        ImGui.Text("Remove");
                        if (ImGui.Button("Remove all Objects##object"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ($"global/PSW.FileObjectUnLoad();" +
                                $"global/CWE.FileObjectUnLoad();" +
                                $"global/HBOH.FileObjectUnLoad();" +
                                $"global/PlayerLeftHand/PlayerInLeftHand.FileObjectUnLoad();" +
                                $"global/PlayerRightHand/PlayerInRightHand.FileObjectUnLoad();");
                        }

                        ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Inventory");

                        ImGui.Text("Item Cheat");
                        ImGui.InputInt("ID##item", ref ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ɪᴅ_ɪᴛᴇᴍ);
                        ImGui.InputInt("Amount##item", ref ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴀᴍᴏᴜɴᴛ_ɪᴛᴇᴍ);
                        if (ImGui.Button("Add Item"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ($"{ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ɪᴅ_ɪᴛᴇᴍ} {ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴀᴍᴏᴜɴᴛ_ɪᴛᴇᴍ}");
                        }
                        if (ImGui.Button("Open Newest Items List"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("dumpitems");
                        }

                        ImGui.Text("Money");
                        if (ImGui.Button("Add 5k Item Real JS"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/IJS.QuestComplete();");
                        }
                        if (ImGui.Button("Add 100k Fake SC"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/PlayerStarMoney.AddDataInt(100000);");
                        }

                        ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Movement");

                        ImGui.Text("Bypass");
                        if (ImGui.Button("Everythings is Deleted"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/FPFRA1.Delete();global/FPFRA2.Delete();global/FPFRA3.Delete();global/CSIInspectView/FailedMessageData.SetDataString(\"1\");global/SwimActionBar.Delete();");
                        }

                        ImGui.Text("Horse Speed");
                        ImGui.InputFloat("Speed##sc_real", ref ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ꜱᴘᴇᴇᴅ_ᴀɴɪᴍᴀᴛɪᴏɴ);
                        if (ImGui.Button("Set Speed"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ($"global/Horse/Skin/Pelvis.SetSkinMeshAnimationSpeed({ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ꜱᴘᴇᴇᴅ_ᴀɴɪᴍᴀᴛɪᴏɴ});");
                        }


                        ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Interface");

                        ImGui.Text("Hair");
                        if (ImGui.Button("Open Hair Salon UI"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/MirrorWindow.Start();");
                        }

                        ImGui.Text("Club");
                        if (ImGui.Button("Open Club Create Window"))
                        {
                            ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ("global/ClubCreateWindow.Start();");
                        }

                        ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Custom");

                        ImGui.Text("Any Script");
                        ImGui.InputText("Script##horse", ref ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ᴄᴜꜱᴛᴏᴍꜱᴄʀɪᴘᴛꜱ, 99999);
                        if (ImGui.Button("Execute Custom"))
                        {
                            if (ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ᴄᴜꜱᴛᴏᴍꜱᴄʀɪᴘᴛꜱ.Contains("global/InfoTextWindowNoAutoStop"))
                            {
                                return;
                            }
                            else if (ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ᴄᴜꜱᴛᴏᴍꜱᴄʀɪᴘᴛꜱ.Contains("global/") || ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ᴄᴜꜱᴛᴏᴍꜱᴄʀɪᴘᴛꜱ.Contains(";"))
                            {
                                ᴍᴏᴅᴜʟᴇ.ᴘxꜱᴄʀɪᴘᴛᴍᴏᴅᴜʟᴇ(ᴍᴏᴅᴜʟᴇ.ᴠᴀʟᴜᴇꜱ.ᴠᴀʟᴜᴇ_ᴄᴜꜱᴛᴏᴍꜱᴄʀɪᴘᴛꜱ);
                            }
                        }

                    }
                    else
                    {
                        ᴄᴇɴᴛʀᴇᴛᴇxᴛʟɪɴᴇ("Modding Setup");
                        if (ImGui.Button("Start/Inject Modding"))
                        {
                            try
                            {
                                //var byt = "01 02";

                                //var addr = ᴍᴇᴍᴏʀʏ.ꜱʏɴᴄᴀᴏʙꜱᴄᴀɴ(0x000000000000, 0x7fffffffffff, byt, 0);
                                //ᴍᴏᴅᴜʟᴇ.ᴀᴅᴅʀᴇꜱꜱᴇ.ᴘxꜱᴄʀɪᴘᴛ = addr;
                                ᴍᴏᴅᴜʟᴇ.ʙᴏᴏʟᴇᴀɴ.ᴍᴏᴅᴅɪɴɢ = true;
                                //Debug.WriteLine(ᴍᴏᴅᴜʟᴇ.ᴀᴅᴅʀᴇꜱꜱᴇ.ᴘxꜱᴄʀɪᴘᴛ);
                            }
                            catch
                            {

                            }
                        }
                    }
                }

                ImGui.End();
            }
        }
    }
}
