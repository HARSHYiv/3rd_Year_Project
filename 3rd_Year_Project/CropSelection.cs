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
    public partial class frmCropSelection : Form
    {
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        public frmCropSelection()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCropSelection_Load(object sender, EventArgs e)
        {
            //Styling
            btnSave.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#5A8731"));
            btnMinimize.BackColor = ColorTranslator.FromHtml("#5A8731");
            pnlTop.BackColor = ColorTranslator.FromHtml("#5A8731");
            pnlbottom.BackColor = ColorTranslator.FromHtml("#5A8731");
            btnClose.BackColor = ColorTranslator.FromHtml("#5A8731");
        }

      
        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain m = new frmMain();
            m.Show();
            this.Close();
        }


        //Move the form by panel
        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);

            }
        }
        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
