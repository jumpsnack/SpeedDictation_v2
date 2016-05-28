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

        public Form1()
        {
            InitializeComponent();

            panelPlay.Visible = false;
            this._putEnter = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelPlay.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelPlay.Visible = true;
            new PlayGround(this);
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtInput.Text != "")
                    _putEnter = true;
            }
        }

        private void labelScore_Click(object sender, EventArgs e)
        {

        }
    }
}
