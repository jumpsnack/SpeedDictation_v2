namespace SpeedDictation_v2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.labelScore = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelWordTimer = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.labelWord = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(109, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "SpeedDictation";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(302, 412);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelPlay
            // 
            this.panelPlay.Controls.Add(this.labelScore);
            this.panelPlay.Controls.Add(this.progressBar);
            this.panelPlay.Controls.Add(this.labelTimer);
            this.panelPlay.Controls.Add(this.labelWordTimer);
            this.panelPlay.Controls.Add(this.txtInput);
            this.panelPlay.Controls.Add(this.labelWord);
            this.panelPlay.Controls.Add(this.btnBack);
            this.panelPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlay.Location = new System.Drawing.Point(0, 0);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(684, 561);
            this.panelPlay.TabIndex = 2;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(263, 35);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(74, 18);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "Score : ";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 480);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(678, 78);
            this.progressBar.Step = 0;
            this.progressBar.TabIndex = 5;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(607, 436);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(38, 18);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "100";
            // 
            // labelWordTimer
            // 
            this.labelWordTimer.AutoSize = true;
            this.labelWordTimer.Location = new System.Drawing.Point(318, 285);
            this.labelWordTimer.Name = "labelWordTimer";
            this.labelWordTimer.Size = new System.Drawing.Size(28, 18);
            this.labelWordTimer.TabIndex = 3;
            this.labelWordTimer.Text = "10";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtInput.Location = new System.Drawing.Point(218, 365);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(243, 41);
            this.txtInput.TabIndex = 2;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // labelWord
            // 
            this.labelWord.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.Location = new System.Drawing.Point(3, 161);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(681, 91);
            this.labelWord.TabIndex = 1;
            this.labelWord.Text = "-----";
            this.labelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(32, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panelPlay);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.Panel panelPlay;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.ProgressBar progressBar;
        internal System.Windows.Forms.Label labelTimer;
        internal System.Windows.Forms.Label labelWordTimer;
        internal System.Windows.Forms.TextBox txtInput;
        internal System.Windows.Forms.Label labelWord;
        internal System.Windows.Forms.Label labelScore;
    }
}

