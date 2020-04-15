using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void customizeDesing()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Hide/Show SubMenu
        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;
            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
#endregion

        #region MediaSubMenu
        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //codes
            openChildForm(new Form2());
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //..
            //codes
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //codes
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //codes
            hideSubMenu();
        }
        #endregion

        #region PlaylistSubMenu
        private void btnPlaylistManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //codes
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //codes
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //codes
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //codes
            hideSubMenu();
        }
        #endregion

        #region ToolsSubMenu
        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //..
            //codes
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //..
            //codes
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //codes
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //codes
            hideSubMenu();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }
    }
}
