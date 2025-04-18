using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison_Escape_Game.View.Forms
{
    internal class GameForm : Form
    {
        private Button exitButton;
        private ProgressBar healthBar;
        private Label healthLabel;
        private const int InventorySize = 5;
        private PictureBox[] inventory;

        public GameForm()
        {
            InitializeComponent();
            SetupLayout();
            SetupEvents();
        }

        private void SetupEvents()
        {
            throw new NotImplementedException();
        }

        private void SetupLayout()
        {
            throw new NotImplementedException();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GameForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
