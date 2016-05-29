using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedDictation_v2
{
    public partial class Form1 : Form
    {
        internal bool _putEnter;
        internal bool _goBack;

        public Form1()
        {
            InitializeComponent();

            panelPlay.Visible = false;
            this._putEnter = false;
            this._goBack = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelPlay.Visible = false;
            this._goBack = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelPlay.Visible = true;
            this._goBack = false;
            new PlayGround(this);
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if(txtInput.Text != "")
                    _putEnter = true;
            }
        }

        /* 좀비 프로세스 방지 */
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}
