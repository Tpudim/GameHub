using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using GameHub.Services;

namespace GameHub
{
    public partial class GameHubForm : Form
    {
        Dictionary<string, string> emulatorsPath;
        string path = "a";
        public string selectedEmulator;
        public GameHubForm()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void GameHub_Load(object sender, EventArgs e)
        {            

            try
            {
                if (!File.Exists(Application.StartupPath + @"\Data\Emulators.save"))
                {
                    emulatorsPath = new Dictionary<string, string>();

                }
                else
                {
                    DataSerializer data = new DataSerializer();
                    emulatorsPath = (Dictionary<string, string>)data.BinaryDeserialize(Application.StartupPath + @"\Data\Emulators.save");
                }
                
            }
            catch(ApplicationException ae)
            {
                MessageBox.Show("error: " + ae.Message);
            }

            emulador_VisualBoyAdvance.TittleText.Text = "VisualBoyAdvance";
            emulador_VisualBoyAdvance.EmulatorImage.SizeMode = PictureBoxSizeMode.Zoom;
            emulador_VisualBoyAdvance.EmulatorImage.ImageLocation = Application.StartupPath + @"\Images\VisualBoyAdvance.png";

            emulator_RYUJINX.TittleText.Text = "RYUJINX";
            emulator_RYUJINX.EmulatorImage.SizeMode = PictureBoxSizeMode.Zoom;
            emulator_RYUJINX.EmulatorImage.ImageLocation = Application.StartupPath + @"\Images\RYUJINX.png";

            emulator_Cemu.TittleText.Text = "Cemu";
            emulator_Cemu.EmulatorImage.SizeMode = PictureBoxSizeMode.Zoom;
            emulator_Cemu.EmulatorImage.ImageLocation = Application.StartupPath + @"\Images\Cemu.png";

            emulator_Citra.TittleText.Text = "Citra";
            emulator_Citra.EmulatorImage.SizeMode = PictureBoxSizeMode.Zoom;
            emulator_Citra.EmulatorImage.ImageLocation = Application.StartupPath + @"\Images\Citra.png";

            emulator_DeSmuME.TittleText.Text = "DeSmuME"; 
            emulator_DeSmuME.EmulatorImage.SizeMode = PictureBoxSizeMode.Zoom;
            emulator_DeSmuME.EmulatorImage.ImageLocation = Application.StartupPath + @"\Images\DesmuMe.png";

            emulator_Snes9x.TittleText.Text = "Snes9x";
            emulator_Snes9x.EmulatorImage.SizeMode = PictureBoxSizeMode.Zoom;
            emulator_Snes9x.EmulatorImage.ImageLocation = Application.StartupPath + @"\Images\Snes9x.png";

            emulator_Project64.TittleText.Text = "Project64";
            emulator_Project64.EmulatorImage.SizeMode = PictureBoxSizeMode.Zoom;
            emulator_Project64.EmulatorImage.ImageLocation = Application.StartupPath + @"\Images\Project64.png";

            emulator_Dolphin.TittleText.Text = "Dolphin";
            emulator_Dolphin.EmulatorImage.SizeMode = PictureBoxSizeMode.Zoom;
            emulator_Dolphin.EmulatorImage.ImageLocation = Application.StartupPath + @"\Images\Dolphin.png";

            emulator_Yuzu.TittleText.Text = "Yuzu";
            emulator_Yuzu.EmulatorImage.SizeMode = PictureBoxSizeMode.Zoom;
            emulator_Yuzu.EmulatorImage.ImageLocation = Application.StartupPath + @"\Images\Yuzu.png";

            emulador_VisualBoyAdvance.EmulatorImage.Click += emulador_VisualBoyAdvance_Click_1;
            emulador_VisualBoyAdvance.TittleText.Click += emulador_VisualBoyAdvance_Click_1;

            emulator_DeSmuME.EmulatorImage.Click += emulator_DeSmuME_Click;
            emulator_DeSmuME.TittleText.Click += emulator_DeSmuME_Click;

            emulator_Cemu.EmulatorImage.Click += emulator_Cemu_Click;
            emulator_Cemu.TittleText.Click += emulator_Cemu_Click;

            emulator_Dolphin.EmulatorImage.Click += emulator_Dolphin_Click;
            emulator_Dolphin.TittleText.Click += emulator_Dolphin_Click;

            emulator_Project64.EmulatorImage.Click += emulator_Project64_Click;
            emulator_Project64.TittleText.Click += emulator_Project64_Click;

            emulator_Snes9x.EmulatorImage.Click += emulator_Snes9x_Click;
            emulator_Snes9x.TittleText.Click += emulator_Snes9x_Click;

            emulator_Yuzu.EmulatorImage.Click += emulator_Yuzu_Click;
            emulator_Yuzu.TittleText.Click += emulator_Yuzu_Click;

            emulator_Citra.EmulatorImage.Click += emulator_Citra_Click;
            emulator_Citra.TittleText.Click += emulator_Citra_Click;

            emulator_RYUJINX.EmulatorImage.Click += emulator_Citra_Click;
            emulator_RYUJINX.TittleText.Click += emulator_Citra_Click;
        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roundPictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_Exit_MouseEnter(object sender, EventArgs e)
        {
            pb_Exit.BackColor = Color.FromArgb(0, 80, 130);
        }

        private void pb_Exit_MouseLeave(object sender, EventArgs e)
        {
            pb_Exit.BackColor = Color.FromArgb(0, 70, 120);
        }
        private void pb_Minimize_MouseEnter(object sender, EventArgs e)
        {
            pb_Minimize.BackColor = Color.FromArgb(0, 80, 130);
        }

        private void pb_Minimize_MouseLeave(object sender, EventArgs e)
        {
            pb_Minimize.BackColor = Color.FromArgb(0, 70, 120);
        }

        #region Move Form
        int moveX;
        int moveY;
        bool isMoving = false;
        private void FormMouseDown(object sender,MouseEventArgs e)
        {
            isMoving = true;
            moveX = e.X;
            moveY = e.Y;
            Cursor.Current = Cursors.SizeAll;
        }
        private void FormMouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
                
            }
        }
        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            Cursor.Current = Cursors.Default;            
        }

        #endregion

        private void emulador_VisualBoyAdvance_Click_1(object sender, EventArgs e)
        {
            selectedEmulator = "VisualBoyAdvance";
            selectedEmulatorShow();
        }

        private void emulator_Cemu_Click(object sender, EventArgs e)
        {
            selectedEmulator = "Cemu";
            selectedEmulatorShow();
        }

        private void emulator_Citra_Click(object sender, EventArgs e)
        {
            selectedEmulator = "Citra";
            selectedEmulatorShow();
        }

        private void emulator_DeSmuME_Click(object sender, EventArgs e)
        {
            selectedEmulator = "DeSmuME";
            selectedEmulatorShow();
        }

        private void emulator_Snes9x_Click(object sender, EventArgs e)
        {
            selectedEmulator = "Snes9x";
            selectedEmulatorShow();
        }

        private void emulator_Project64_Click(object sender, EventArgs e)
        {
            selectedEmulator = "Project64";
            selectedEmulatorShow();
        }

        private void emulator_Dolphin_Click(object sender, EventArgs e)
        {
            selectedEmulator = "Dolphin";
            selectedEmulatorShow();
        }

        private void emulator_Yuzu_Click(object sender, EventArgs e)
        {
            selectedEmulator = "Yuzu";
            selectedEmulatorShow();
        }
        private void emulator_RYUJINX_Click(object sender, EventArgs e)
        {
            selectedEmulator = "RYUJINX";
            selectedEmulatorShow();
        }
        public void selectedEmulatorShow()
        {
            switch (selectedEmulator)
            {
                case "Cemu":
                    EmulatorTitle.Text = emulator_Cemu.TittleText.Text;
                    pb_SelectedEmulator.Image = emulator_Cemu.EmulatorImage.Image;
                    break;
                case "VisualBoyAdvance":
                    EmulatorTitle.Text = emulador_VisualBoyAdvance.TittleText.Text;
                    pb_SelectedEmulator.Image = emulador_VisualBoyAdvance.EmulatorImage.Image;
                    break;
                case "Citra":
                    EmulatorTitle.Text = emulator_Citra.TittleText.Text;
                    pb_SelectedEmulator.Image = emulator_Citra.EmulatorImage.Image;
                    break;
                case "DeSmuME":
                    EmulatorTitle.Text = emulator_DeSmuME.TittleText.Text;
                    pb_SelectedEmulator.Image = emulator_DeSmuME.EmulatorImage.Image;
                    break;
                case "Snes9x":
                    EmulatorTitle.Text = emulator_Snes9x.TittleText.Text;
                    pb_SelectedEmulator.Image = emulator_Snes9x.EmulatorImage.Image;
                    break;
                case "Project64":
                    EmulatorTitle.Text = emulator_Project64.TittleText.Text;
                    pb_SelectedEmulator.Image = emulator_Project64.EmulatorImage.Image;
                    break;
                case "Dolphin":
                    EmulatorTitle.Text = emulator_Dolphin.TittleText.Text;
                    pb_SelectedEmulator.Image = emulator_Dolphin.EmulatorImage.Image;
                    break;
                case "Yuzu":
                    EmulatorTitle.Text = emulator_Yuzu.TittleText.Text;
                    pb_SelectedEmulator.Image = emulator_Yuzu.EmulatorImage.Image;
                    break;
                case "RYUJINX":
                    EmulatorTitle.Text = emulator_RYUJINX.TittleText.Text;
                    pb_SelectedEmulator.Image = emulator_RYUJINX.EmulatorImage.Image;
                    break;

            }
        }
        
        private void btn_File_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(selectedEmulator))
            {
                MessageBox.Show("Selecione um emulador.");
                return;
            }
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if(emulatorsPath.ContainsKey(selectedEmulator))
                    {
                        emulatorsPath[selectedEmulator] = path.ToString();
                        return;
                    }
                    path = new string(ofd.FileName);
                    emulatorsPath.Add(selectedEmulator.ToString(), path.ToString());
                    DataSerializer data = new DataSerializer();
                    data.BinarySerialize(emulatorsPath, Application.StartupPath + @"\Data\Emulators.save");
                }
            }
            catch(ApplicationException ae)
            {
                MessageBox.Show("Save error: " + ae.Message);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (selectedEmulator == null)
            {
                MessageBox.Show("Selecione um emulador.");
                return;
            }

            try
            {
                if (!emulatorsPath.ContainsKey(selectedEmulator))
                {
                    MessageBox.Show("você não especificou um caminho para este emulador, seu animal!");
                    return;
                }
                Process.Start(emulatorsPath[selectedEmulator].ToString());
            }
            catch(ApplicationException ae)
            {
                MessageBox.Show("Erro ao carregar: " +ae.Message);
            }
            
        }

        
    }
}
