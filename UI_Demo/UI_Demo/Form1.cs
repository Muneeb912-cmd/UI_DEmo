using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Demo
{
    public partial class Form1 : Form
    {
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {            
            InitializeComponent();
            submenu1.Visible = false;
            submenu2.Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panel4_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool menu1_clicked = false;
        private void menu1_MouseClick(object sender, MouseEventArgs e)
        {
            if (menu1_clicked == false)
            {
                submenu1.Visible = true;
                menu1_clicked = true;
                submenu2.Visible = false;
                menu3_clicked = false;
                menu2_clicked = false;
                sub_menu3.BackColor = Color.LightSkyBlue;
                sub_menu4.BackColor = Color.LightSkyBlue;
                DisplayPanel.Controls.Clear();
                DisplayPanel.Controls.Add(new Menu1());
            }
        }
        bool menu3_clicked = false;
        private void panel11_MouseClick(object sender, MouseEventArgs e)
        {
            if (menu3_clicked == false)
            {
                submenu2.Visible = true;
                menu3_clicked = true;
                submenu1.Visible = false;
                menu1_clicked = false;
                menu2_clicked = false;
                sub_menu1.BackColor = Color.LightSkyBlue;
                sub_menu2.BackColor = Color.LightSkyBlue;
                DisplayPanel.Controls.Clear();
                DisplayPanel.Controls.Add(new Menu3());
            }
            
        }
        bool menu2_clicked = false;
        private void panel10_MouseClick(object sender, MouseEventArgs e)
        {
            if (menu2_clicked == false)
            {
                menu2_clicked = true;
                submenu2.Visible = false ;
                menu2_clicked = false;
                submenu1.Visible = false;
                menu1_clicked = false;
                menu3_clicked = false;
                sub_menu1.BackColor = Color.LightSkyBlue;
                sub_menu2.BackColor = Color.LightSkyBlue;
                sub_menu3.BackColor = Color.LightSkyBlue;
                sub_menu4.BackColor = Color.LightSkyBlue;
                DisplayPanel.Controls.Clear();
                DisplayPanel.Controls.Add(new Menu2());

            }
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            if (menu1_clicked == false)
            {
                submenu1.Visible = true;
                menu1_clicked = true;
                submenu2.Visible = false;
                menu3_clicked = false;
                menu2_clicked = false;
                sub_menu3.BackColor = Color.LightSkyBlue;
                sub_menu4.BackColor = Color.LightSkyBlue;
            }
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            if (menu2_clicked == false)
            {
                menu2_clicked = true;
                submenu2.Visible = false;
                menu2_clicked = false;
                submenu1.Visible = false;
                menu1_clicked = false;
                menu3_clicked = false;
                sub_menu1.BackColor = Color.LightSkyBlue;
                sub_menu2.BackColor = Color.LightSkyBlue;
                sub_menu3.BackColor = Color.LightSkyBlue;
                sub_menu4.BackColor = Color.LightSkyBlue;
            }
        }

        private void label8_MouseClick(object sender, MouseEventArgs e)
        {
            if (menu3_clicked == false)
            {
                submenu2.Visible = true;
                menu3_clicked = true;
                submenu1.Visible = false;
                menu1_clicked = false;
                menu2_clicked = false;
                sub_menu1.BackColor = Color.LightSkyBlue;
                sub_menu2.BackColor = Color.LightSkyBlue;
                DisplayPanel.Controls.Clear();
                DisplayPanel.Controls.Add(new Menu3());
            }
        }

        private void menu1_MouseEnter(object sender, EventArgs e)
        {
            menu1.BackColor = Color.Violet;
        }

        private void menu1_MouseLeave(object sender, EventArgs e)
        {
            menu1.BackColor = Color.Cyan;
        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            menu2.BackColor = Color.Violet;
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            menu2.BackColor = Color.Cyan;
        }

        private void menu3_MouseEnter(object sender, EventArgs e)
        {
            menu3.BackColor = Color.Violet;
        }

        private void menu3_MouseLeave(object sender, EventArgs e)
        {
            menu3.BackColor = Color.Cyan;
        }

        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {
            sub_menu1.BackColor = Color.Plum;
            sub_menu2.BackColor = Color.LightSkyBlue;
            DisplayPanel.Controls.Clear();
            DisplayPanel.Controls.Add(new SubMenu1());
        }

        private void sub_menu2_MouseClick(object sender, MouseEventArgs e)
        {
            sub_menu2.BackColor = Color.Plum;
            sub_menu1.BackColor = Color.LightSkyBlue;
            DisplayPanel.Controls.Clear();
            DisplayPanel.Controls.Add(new SubMunu2());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            sub_menu1.BackColor = Color.Plum;
            sub_menu2.BackColor = Color.LightSkyBlue;
            DisplayPanel.Controls.Clear();
            DisplayPanel.Controls.Add(new SubMenu1());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            sub_menu2.BackColor = Color.Plum;
            sub_menu1.BackColor = Color.LightSkyBlue;
            DisplayPanel.Controls.Clear();
            DisplayPanel.Controls.Add(new SubMunu2());
        }

        private void panel15_MouseClick(object sender, MouseEventArgs e)
        {
            sub_menu3.BackColor=Color.Plum;
            sub_menu4.BackColor=Color.LightSkyBlue;
            DisplayPanel.Controls.Clear();
            DisplayPanel.Controls.Add(new SubMenu3());
        }

        private void sub_menu4_MouseClick(object sender, MouseEventArgs e)
        {
            sub_menu3.BackColor = Color.LightSkyBlue;
            sub_menu4.BackColor = Color.Plum;
            DisplayPanel.Controls.Clear();
            DisplayPanel.Controls.Add(new SubMenu4());
        }

        private void label10_MouseClick(object sender, MouseEventArgs e)
        {
            sub_menu3.BackColor = Color.Plum;
            sub_menu4.BackColor = Color.LightSkyBlue;
            DisplayPanel.Controls.Clear();
            DisplayPanel.Controls.Add(new SubMenu3());
        }

        private void label9_MouseClick(object sender, MouseEventArgs e)
        {
            sub_menu3.BackColor = Color.LightSkyBlue;
            sub_menu4.BackColor = Color.Plum;
            DisplayPanel.Controls.Clear();
            DisplayPanel.Controls.Add(new SubMenu4());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DisplayPanel.Controls.Clear();
            DisplayPanel.Controls.Add(new Menu2());
        }
    }
}
