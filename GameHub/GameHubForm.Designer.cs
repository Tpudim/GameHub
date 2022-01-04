using GameHub;
namespace GameHub
{
    partial class GameHubForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameHubForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Minimize = new GameHub.Extras.RoundPictureBox();
            this.pb_Exit = new GameHub.Extras.RoundPictureBox();
            this.EmulatorInfo = new System.Windows.Forms.Panel();
            this.btn_File = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.EmulatorTitle = new System.Windows.Forms.Label();
            this.pb_SelectedEmulator = new System.Windows.Forms.PictureBox();
            this.flp_EmulatorsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.emulador_VisualBoyAdvance = new GameHub.Designs.Emulators();
            this.emulator_DeSmuME = new GameHub.Designs.Emulators();
            this.emulator_Dolphin = new GameHub.Designs.Emulators();
            this.emulator_Cemu = new GameHub.Designs.Emulators();
            this.emulator_Snes9x = new GameHub.Designs.Emulators();
            this.emulator_Yuzu = new GameHub.Designs.Emulators();
            this.emulator_Citra = new GameHub.Designs.Emulators();
            this.emulator_Project64 = new GameHub.Designs.Emulators();
            this.emulator_RYUJINX = new GameHub.Designs.Emulators();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.EmulatorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SelectedEmulator)).BeginInit();
            this.flp_EmulatorsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.pb_Minimize);
            this.panel1.Controls.Add(this.pb_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 38);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
            // 
            // pb_Minimize
            // 
            this.pb_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.pb_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Minimize.Image = global::GameHub.Properties.Resources.minus_111123;
            this.pb_Minimize.Location = new System.Drawing.Point(1045, 2);
            this.pb_Minimize.Name = "pb_Minimize";
            this.pb_Minimize.Size = new System.Drawing.Size(32, 33);
            this.pb_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Minimize.TabIndex = 1;
            this.pb_Minimize.TabStop = false;
            this.pb_Minimize.Click += new System.EventHandler(this.roundPictureBox2_Click);
            this.pb_Minimize.MouseEnter += new System.EventHandler(this.pb_Minimize_MouseEnter);
            this.pb_Minimize.MouseLeave += new System.EventHandler(this.pb_Minimize_MouseLeave);
            // 
            // pb_Exit
            // 
            this.pb_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.pb_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Exit.Image = global::GameHub.Properties.Resources.close_111152;
            this.pb_Exit.Location = new System.Drawing.Point(1083, 2);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(32, 33);
            this.pb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Exit.TabIndex = 0;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.roundPictureBox1_Click);
            this.pb_Exit.MouseEnter += new System.EventHandler(this.pb_Exit_MouseEnter);
            this.pb_Exit.MouseLeave += new System.EventHandler(this.pb_Exit_MouseLeave);
            // 
            // EmulatorInfo
            // 
            this.EmulatorInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.EmulatorInfo.Controls.Add(this.btn_File);
            this.EmulatorInfo.Controls.Add(this.btn_Start);
            this.EmulatorInfo.Controls.Add(this.EmulatorTitle);
            this.EmulatorInfo.Controls.Add(this.pb_SelectedEmulator);
            this.EmulatorInfo.Controls.Add(this.lbl_Version);
            this.EmulatorInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmulatorInfo.Location = new System.Drawing.Point(740, 38);
            this.EmulatorInfo.Name = "EmulatorInfo";
            this.EmulatorInfo.Size = new System.Drawing.Size(378, 636);
            this.EmulatorInfo.TabIndex = 1;
            // 
            // btn_File
            // 
            this.btn_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.btn_File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_File.Location = new System.Drawing.Point(115, 307);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(135, 36);
            this.btn_File.TabIndex = 3;
            this.btn_File.Text = "File";
            this.btn_File.UseVisualStyleBackColor = false;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Location = new System.Drawing.Point(115, 242);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(135, 36);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // EmulatorTitle
            // 
            this.EmulatorTitle.AutoSize = true;
            this.EmulatorTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmulatorTitle.Location = new System.Drawing.Point(115, 157);
            this.EmulatorTitle.Name = "EmulatorTitle";
            this.EmulatorTitle.Size = new System.Drawing.Size(135, 30);
            this.EmulatorTitle.TabIndex = 1;
            this.EmulatorTitle.Text = "EmulatorTitle";
            // 
            // pb_SelectedEmulator
            // 
            this.pb_SelectedEmulator.Location = new System.Drawing.Point(115, 32);
            this.pb_SelectedEmulator.Name = "pb_SelectedEmulator";
            this.pb_SelectedEmulator.Size = new System.Drawing.Size(135, 103);
            this.pb_SelectedEmulator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_SelectedEmulator.TabIndex = 0;
            this.pb_SelectedEmulator.TabStop = false;
            // 
            // flp_EmulatorsPanel
            // 
            this.flp_EmulatorsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.flp_EmulatorsPanel.Controls.Add(this.emulador_VisualBoyAdvance);
            this.flp_EmulatorsPanel.Controls.Add(this.emulator_DeSmuME);
            this.flp_EmulatorsPanel.Controls.Add(this.emulator_Dolphin);
            this.flp_EmulatorsPanel.Controls.Add(this.emulator_Cemu);
            this.flp_EmulatorsPanel.Controls.Add(this.emulator_Snes9x);
            this.flp_EmulatorsPanel.Controls.Add(this.emulator_Yuzu);
            this.flp_EmulatorsPanel.Controls.Add(this.emulator_Citra);
            this.flp_EmulatorsPanel.Controls.Add(this.emulator_Project64);
            this.flp_EmulatorsPanel.Controls.Add(this.emulator_RYUJINX);
            this.flp_EmulatorsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_EmulatorsPanel.Location = new System.Drawing.Point(0, 38);
            this.flp_EmulatorsPanel.Name = "flp_EmulatorsPanel";
            this.flp_EmulatorsPanel.Size = new System.Drawing.Size(734, 636);
            this.flp_EmulatorsPanel.TabIndex = 2;
            // 
            // emulador_VisualBoyAdvance
            // 
            this.emulador_VisualBoyAdvance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.emulador_VisualBoyAdvance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emulador_VisualBoyAdvance.Location = new System.Drawing.Point(3, 3);
            this.emulador_VisualBoyAdvance.Name = "emulador_VisualBoyAdvance";
            this.emulador_VisualBoyAdvance.Size = new System.Drawing.Size(224, 78);
            this.emulador_VisualBoyAdvance.TabIndex = 0;
            this.emulador_VisualBoyAdvance.Click += new System.EventHandler(this.emulador_VisualBoyAdvance_Click_1);
            // 
            // emulator_DeSmuME
            // 
            this.emulator_DeSmuME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.emulator_DeSmuME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emulator_DeSmuME.Location = new System.Drawing.Point(233, 3);
            this.emulator_DeSmuME.Name = "emulator_DeSmuME";
            this.emulator_DeSmuME.Size = new System.Drawing.Size(224, 78);
            this.emulator_DeSmuME.TabIndex = 1;
            this.emulator_DeSmuME.Click += new System.EventHandler(this.emulator_DeSmuME_Click);
            // 
            // emulator_Dolphin
            // 
            this.emulator_Dolphin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.emulator_Dolphin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emulator_Dolphin.Location = new System.Drawing.Point(463, 3);
            this.emulator_Dolphin.Name = "emulator_Dolphin";
            this.emulator_Dolphin.Size = new System.Drawing.Size(224, 78);
            this.emulator_Dolphin.TabIndex = 2;
            this.emulator_Dolphin.Click += new System.EventHandler(this.emulator_Dolphin_Click);
            // 
            // emulator_Cemu
            // 
            this.emulator_Cemu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.emulator_Cemu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emulator_Cemu.Location = new System.Drawing.Point(3, 87);
            this.emulator_Cemu.Name = "emulator_Cemu";
            this.emulator_Cemu.Size = new System.Drawing.Size(224, 78);
            this.emulator_Cemu.TabIndex = 3;
            this.emulator_Cemu.Click += new System.EventHandler(this.emulator_Cemu_Click);
            // 
            // emulator_Snes9x
            // 
            this.emulator_Snes9x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.emulator_Snes9x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emulator_Snes9x.Location = new System.Drawing.Point(233, 87);
            this.emulator_Snes9x.Name = "emulator_Snes9x";
            this.emulator_Snes9x.Size = new System.Drawing.Size(224, 78);
            this.emulator_Snes9x.TabIndex = 4;
            this.emulator_Snes9x.Click += new System.EventHandler(this.emulator_Snes9x_Click);
            // 
            // emulator_Yuzu
            // 
            this.emulator_Yuzu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.emulator_Yuzu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emulator_Yuzu.Location = new System.Drawing.Point(463, 87);
            this.emulator_Yuzu.Name = "emulator_Yuzu";
            this.emulator_Yuzu.Size = new System.Drawing.Size(224, 80);
            this.emulator_Yuzu.TabIndex = 5;
            this.emulator_Yuzu.Click += new System.EventHandler(this.emulator_Yuzu_Click);
            // 
            // emulator_Citra
            // 
            this.emulator_Citra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.emulator_Citra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emulator_Citra.Location = new System.Drawing.Point(3, 173);
            this.emulator_Citra.Name = "emulator_Citra";
            this.emulator_Citra.Size = new System.Drawing.Size(224, 78);
            this.emulator_Citra.TabIndex = 6;
            this.emulator_Citra.Click += new System.EventHandler(this.emulator_Citra_Click);
            // 
            // emulator_Project64
            // 
            this.emulator_Project64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.emulator_Project64.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emulator_Project64.Location = new System.Drawing.Point(233, 173);
            this.emulator_Project64.Name = "emulator_Project64";
            this.emulator_Project64.Size = new System.Drawing.Size(224, 78);
            this.emulator_Project64.TabIndex = 7;
            this.emulator_Project64.Click += new System.EventHandler(this.emulator_Project64_Click);
            // 
            // emulator_RYUJINX
            // 
            this.emulator_RYUJINX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.emulator_RYUJINX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emulator_RYUJINX.Location = new System.Drawing.Point(463, 173);
            this.emulator_RYUJINX.Name = "emulator_RYUJINX";
            this.emulator_RYUJINX.Size = new System.Drawing.Size(224, 80);
            this.emulator_RYUJINX.TabIndex = 8;
            this.emulator_RYUJINX.Click += new System.EventHandler(this.emulator_RYUJINX_Click);
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Version.Location = new System.Drawing.Point(287, 616);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(91, 20);
            this.lbl_Version.TabIndex = 9;
            this.lbl_Version.Text = "Version 1.2.0";
            // 
            // GameHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1118, 674);
            this.Controls.Add(this.flp_EmulatorsPanel);
            this.Controls.Add(this.EmulatorInfo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameHubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameHub";
            this.Load += new System.EventHandler(this.GameHub_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.EmulatorInfo.ResumeLayout(false);
            this.EmulatorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SelectedEmulator)).EndInit();
            this.flp_EmulatorsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GameHub.Extras.RoundPictureBox pb_Exit;
        private GameHub.Extras.RoundPictureBox pb_Minimize;
        private System.Windows.Forms.Panel EmulatorInfo;
        private System.Windows.Forms.FlowLayoutPanel flp_EmulatorsPanel;
        private Designs.Emulators emulador_VisualBoyAdvance;
        private Designs.Emulators emulator_DeSmuME;
        private Designs.Emulators emulator_Dolphin;
        private Designs.Emulators emulator_Cemu;
        private Designs.Emulators emulator_Snes9x;
        private Designs.Emulators emulator_Yuzu;
        private Designs.Emulators emulator_Citra;
        private Designs.Emulators emulator_Project64;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label EmulatorTitle;
        private System.Windows.Forms.PictureBox pb_SelectedEmulator;
        private System.Windows.Forms.Button btn_File;
        private Designs.Emulators emulator_RYUJINX;
        private System.Windows.Forms.Label lbl_Version;
    }
}

