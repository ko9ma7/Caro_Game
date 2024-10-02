﻿namespace Game_Co_Caro
{
    partial class Caro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caro));
            this.pnShow = new System.Windows.Forms.Panel();
            this.lbRule = new System.Windows.Forms.Label();
            this.ptbPayer = new System.Windows.Forms.PictureBox();
            this.psbCooldownTime = new System.Windows.Forms.ProgressBar();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.Avata = new System.Windows.Forms.PictureBox();
            this.pnTableChess = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayerFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComputerFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1VsPlayer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmCooldown = new System.Windows.Forms.Timer(this.components);
            this.pnShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avata)).BeginInit();
            this.pnTableChess.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnShow
            // 
            this.pnShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnShow.Controls.Add(this.lbRule);
            this.pnShow.Controls.Add(this.ptbPayer);
            this.pnShow.Controls.Add(this.psbCooldownTime);
            this.pnShow.Controls.Add(this.txtNamePlayer);
            this.pnShow.Controls.Add(this.Avata);
            this.pnShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnShow.Location = new System.Drawing.Point(971, 0);
            this.pnShow.Margin = new System.Windows.Forms.Padding(4);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(312, 743);
            this.pnShow.TabIndex = 2;
            // 
            // lbRule
            // 
            this.lbRule.AutoSize = true;
            this.lbRule.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbRule.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRule.Location = new System.Drawing.Point(-7, 625);
            this.lbRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRule.Name = "lbRule";
            this.lbRule.Size = new System.Drawing.Size(293, 42);
            this.lbRule.TabIndex = 4;
            this.lbRule.Text = " 5 in a line to win";
            // 
            // ptbPayer
            // 
            this.ptbPayer.BackColor = System.Drawing.Color.Gray;
            this.ptbPayer.Location = new System.Drawing.Point(175, 352);
            this.ptbPayer.Margin = new System.Windows.Forms.Padding(4);
            this.ptbPayer.Name = "ptbPayer";
            this.ptbPayer.Size = new System.Drawing.Size(133, 106);
            this.ptbPayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPayer.TabIndex = 3;
            this.ptbPayer.TabStop = false;
            // 
            // psbCooldownTime
            // 
            this.psbCooldownTime.Location = new System.Drawing.Point(8, 412);
            this.psbCooldownTime.Margin = new System.Windows.Forms.Padding(4);
            this.psbCooldownTime.Maximum = 21000;
            this.psbCooldownTime.Name = "psbCooldownTime";
            this.psbCooldownTime.Size = new System.Drawing.Size(160, 46);
            this.psbCooldownTime.Step = 100;
            this.psbCooldownTime.TabIndex = 1;
            // 
            // txtNamePlayer
            // 
            this.txtNamePlayer.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePlayer.Location = new System.Drawing.Point(8, 352);
            this.txtNamePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamePlayer.Multiline = true;
            this.txtNamePlayer.Name = "txtNamePlayer";
            this.txtNamePlayer.ReadOnly = true;
            this.txtNamePlayer.Size = new System.Drawing.Size(159, 45);
            this.txtNamePlayer.TabIndex = 10;
            // 
            // Avata
            // 
            this.Avata.Image = ((System.Drawing.Image)(resources.GetObject("Avata.Image")));
            this.Avata.Location = new System.Drawing.Point(4, 4);
            this.Avata.Margin = new System.Windows.Forms.Padding(4);
            this.Avata.Name = "Avata";
            this.Avata.Size = new System.Drawing.Size(305, 272);
            this.Avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avata.TabIndex = 0;
            this.Avata.TabStop = false;
            // 
            // pnTableChess
            // 
            this.pnTableChess.BackColor = System.Drawing.Color.BurlyWood;
            this.pnTableChess.Controls.Add(this.menuStrip1);
            this.pnTableChess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTableChess.Location = new System.Drawing.Point(0, 0);
            this.pnTableChess.Margin = new System.Windows.Forms.Padding(4);
            this.pnTableChess.Name = "pnTableChess";
            this.pnTableChess.Size = new System.Drawing.Size(971, 743);
            this.pnTableChess.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuGame
            // 
            this.menuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewGame,
            this.menuUndo,
            this.menuQuit});
            this.menuGame.Image = global::Game_Co_Caro.Properties.Resources.menu_bar__1_;
            this.menuGame.Name = "menuGame";
            this.menuGame.Size = new System.Drawing.Size(95, 29);
            this.menuGame.Text = "Menu";
            // 
            // menuNewGame
            // 
            this.menuNewGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.player1VsPlayer2ToolStripMenuItem});
            this.menuNewGame.Name = "menuNewGame";
            this.menuNewGame.Size = new System.Drawing.Size(224, 30);
            this.menuNewGame.Text = "New game";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayerFirstToolStripMenuItem,
            this.ComputerFirstToolStripMenuItem});
            this.playToolStripMenuItem.Image = global::Game_Co_Caro.Properties.Resources.player;
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.playToolStripMenuItem.Text = "Player vs Computer";
            // 
            // PlayerFirstToolStripMenuItem
            // 
            this.PlayerFirstToolStripMenuItem.Name = "PlayerFirstToolStripMenuItem";
            this.PlayerFirstToolStripMenuItem.Size = new System.Drawing.Size(250, 30);
            this.PlayerFirstToolStripMenuItem.Text = "Người đánh trước";
            this.PlayerFirstToolStripMenuItem.Click += new System.EventHandler(this.PlayerFirstToolStripMenuItem_Click);
            // 
            // ComputerFirstToolStripMenuItem
            // 
            this.ComputerFirstToolStripMenuItem.Name = "ComputerFirstToolStripMenuItem";
            this.ComputerFirstToolStripMenuItem.Size = new System.Drawing.Size(250, 30);
            this.ComputerFirstToolStripMenuItem.Text = "Máy đánh trước";
            this.ComputerFirstToolStripMenuItem.Click += new System.EventHandler(this.ComputerFirstToolStripMenuItem_Click);
            // 
            // player1VsPlayer2ToolStripMenuItem
            // 
            this.player1VsPlayer2ToolStripMenuItem.Image = global::Game_Co_Caro.Properties.Resources.player_versus_player;
            this.player1VsPlayer2ToolStripMenuItem.Name = "player1VsPlayer2ToolStripMenuItem";
            this.player1VsPlayer2ToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.player1VsPlayer2ToolStripMenuItem.Text = "Player 1 vs Player 2";
            this.player1VsPlayer2ToolStripMenuItem.Click += new System.EventHandler(this.player1VsPlayer2);
            // 
            // menuUndo
            // 
            this.menuUndo.Enabled = false;
            this.menuUndo.Image = global::Game_Co_Caro.Properties.Resources.undo__1_;
            this.menuUndo.Name = "menuUndo";
            this.menuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuUndo.Size = new System.Drawing.Size(224, 30);
            this.menuUndo.Text = "Undo";
            this.menuUndo.Click += new System.EventHandler(this.menuUndo_Click);
            // 
            // menuQuit
            // 
            this.menuQuit.Image = global::Game_Co_Caro.Properties.Resources._170796_button_256x256;
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuQuit.Size = new System.Drawing.Size(224, 30);
            this.menuQuit.Text = "Quit";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click_1);
            // 
            // tmCooldown
            // 
            this.tmCooldown.Tick += new System.EventHandler(this.tmCooldown_Tick);
            // 
            // Caro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 743);
            this.Controls.Add(this.pnTableChess);
            this.Controls.Add(this.pnShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Caro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Cờ Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Caro_FormClosing);
            this.pnShow.ResumeLayout(false);
            this.pnShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avata)).EndInit();
            this.pnTableChess.ResumeLayout(false);
            this.pnTableChess.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnShow;
        private System.Windows.Forms.Label lbRule;
        private System.Windows.Forms.PictureBox ptbPayer;
        private System.Windows.Forms.ProgressBar psbCooldownTime;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.PictureBox Avata;
        private System.Windows.Forms.Panel pnTableChess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuGame;
        private System.Windows.Forms.ToolStripMenuItem menuNewGame;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player1VsPlayer2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUndo;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.Timer tmCooldown;
        private System.Windows.Forms.ToolStripMenuItem PlayerFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComputerFirstToolStripMenuItem;
    }
}

