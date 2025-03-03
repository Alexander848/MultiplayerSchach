using System.Windows.Forms;

namespace MultiplayerSchach
{
    partial class MainMenu
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
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();

            int screenWidth = GuiSettings.Default.FrameSize.Width;
            int screenHeight = GuiSettings.Default.FrameSize.Height;
            // 
            // button1
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(screenWidth/40, screenHeight/40);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(screenWidth - (screenWidth/20), screenHeight/4 - screenHeight/20);
            this.btnCreateGame.TabIndex = 0;
            this.btnCreateGame.Text = "Create Game";
            this.btnCreateGame.Click += MainMenu_btnCreateGame_Click;
            this.btnCreateGame.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.btnJoinGame.Location = new System.Drawing.Point(screenWidth / 40, (screenHeight * 10) / 40);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Size = new System.Drawing.Size(screenWidth - (screenWidth / 20), screenHeight / 4 - screenHeight / 20);
            this.btnJoinGame.TabIndex = 1;
            this.btnJoinGame.Text = "Join Game";
            this.btnJoinGame.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.btnSettings.Location = new System.Drawing.Point(screenWidth / 40, (screenHeight * 20) / 40);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(screenWidth - (screenWidth / 20), screenHeight / 4 - screenHeight / 20);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.btnExitGame.Location = new System.Drawing.Point(screenWidth / 40, (screenHeight * 30) / 40);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(screenWidth - (screenWidth / 20), screenHeight / 4 - screenHeight / 20);
            this.btnExitGame.TabIndex = 3;
            this.btnExitGame.Text = "Exit Game";
            this.btnExitGame.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 900);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnJoinGame);
            this.Controls.Add(this.btnCreateGame);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.FormClosing += MainMenu_FormClosing;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCreateGame;
        private Button btnJoinGame;
        private Button btnSettings;
        private Button btnExitGame;
    }
}

