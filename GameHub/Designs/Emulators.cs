using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameHub.Designs
{
    public partial class Emulators : UserControl
    {
        public static Emulators Instance;
        
        public Emulators()
        {
            InitializeComponent();
            Instance = this;
            EmulatorImage.BackColor = Color.FromArgb(0, 100, 110);
            this.BackColor = Color.FromArgb(0, 100, 110);
        }

        private void Emulators_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 90, 180);
            EmulatorImage.BackColor = this.BackColor;
        }

        private void Emulators_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 100, 110);
            EmulatorImage.BackColor = this.BackColor;
        }

        private void EmulatorImage_Click(object sender, EventArgs e)
        {

        }

        private void TittleText_Click(object sender, EventArgs e)
        {

        }

        private void Emulators_Load(object sender, EventArgs e)
        {            
        }

        private void Emulators_Click(object sender, EventArgs e)
        {

        }
    }
}
