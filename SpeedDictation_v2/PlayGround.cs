using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedDictation_v2
{
    class PlayGround
    {
        Form1 mainForm;
        ProgressThread progressThread;

        public PlayGround(Form1 mainForm)
        {
            this.mainForm = mainForm;
            this.progressThread = new ProgressThread(mainForm);

        }
    }
}
