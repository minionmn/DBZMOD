﻿using System;
using System.Linq;
using DBZMOD.Buffs;
using DBZMOD;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;
using Enums;
using Util;

namespace DBZMOD.UI
{
    internal class WishMenu : EasyMenu
    {
        public static bool menuvisible = false;
        private UIText titleText;
        private UIText descText;
        public UIImage backPanelImage;
        private UIImageButton WishButtonPower;        
        private static string descTextValue = "Select one of the wishes above to grant your deepest desire." +
            "\nCertain wishes have limits.";


        public static WishSelectionID WishSelection;
        private Player player;

        public override void OnInitialize()
        {
            base.OnInitialize();

            backPanel = new UIPanel();
            backPanel.Width.Set(364f, 0f);
            backPanel.Height.Set(192f, 0f);
            backPanel.Left.Set(Main.screenWidth / 2f - backPanel.Width.Pixels / 2f, 0f);
            backPanel.Top.Set(Main.screenHeight / 2f - backPanel.Height.Pixels / 2f, 0f);
            backPanel.BackgroundColor = new Color(0, 0, 0, 0);
            Append(backPanel);

            backPanelImage = new UIImage(GFX.WishBackPanel);
            backPanelImage.Width.Set(GFX.WishBackPanel.Width, 0f);
            backPanelImage.Height.Set(GFX.WishBackPanel.Height, 0f);
            backPanelImage.Left.Set(-12, 0f);
            backPanelImage.Top.Set(-12, 0f);
            backPanel.Append(backPanelImage);

            InitText(ref titleText, "I Wish for...", 0.66f, 4, 6, Color.Yellow, backPanelImage);

            InitText(ref descText, descTextValue, 0.66f, 10, 82, Color.Yellow, backPanelImage);

            InitButton(ref WishButtonPower, GFX.WishIconEmpty, new MouseEvent(SelectButtonPower), 10, 20, backPanelImage);
        }

        
        private void SelectButtonPower(UIMouseEvent evt, UIElement listeningelement)
        {
            MyPlayer modplayer = Main.LocalPlayer.GetModPlayer<MyPlayer>();
            descTextValue = "Power" +
                "\nWish for a permanent increase in" +
                "\nMaximum Health, Maximum Ki and Damage." +
                "\nWish limit = 3" +
                "\nWishes left = " + modplayer.PowerWishesLeft;
            WishSelection = WishSelectionID.Power;
            Main.PlaySound(SoundID.MenuTick);
            Initialize();
            DBZMOD.ActivateWishmenu();
        }
    }
}