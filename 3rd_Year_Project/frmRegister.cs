using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVFDemoUI
{
    public partial class frmRegister : Form
    {
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            //Styling
            pnlTop.BackColor = ColorTranslator.FromHtml("#5A8731");
            pnlbottom.BackColor = ColorTranslator.FromHtml("#5A8731");
            btnRegister.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#5A8731"));
            btnClose.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#5A8731"));
            btnMinimize.BackColor = ColorTranslator.FromHtml("#5A8731");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmLogin l = new frmLogin();
            l.Show();
            this.Close();
        }

        //Moving form using panel
        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);

            }
        }
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
