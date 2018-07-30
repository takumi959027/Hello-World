namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Answer = new System.Windows.Forms.Label();
            this.TxtAnswer = new System.Windows.Forms.TextBox();
            this.Rdb10 = new System.Windows.Forms.RadioButton();
            this.Rdb20 = new System.Windows.Forms.RadioButton();
            this.Rdb30 = new System.Windows.Forms.RadioButton();
            this.RdbNum = new System.Windows.Forms.RadioButton();
            this.RdbSub = new System.Windows.Forms.RadioButton();
            this.TxtQue = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblMondai = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbMul = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rdb40 = new System.Windows.Forms.RadioButton();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Answer.Location = new System.Drawing.Point(18, 452);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(53, 24);
            this.Answer.TabIndex = 0;
            this.Answer.Text = "答え";
            // 
            // TxtAnswer
            // 
            this.TxtAnswer.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtAnswer.Location = new System.Drawing.Point(77, 442);
            this.TxtAnswer.Name = "TxtAnswer";
            this.TxtAnswer.Size = new System.Drawing.Size(81, 39);
            this.TxtAnswer.TabIndex = 1;
            this.TxtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
            // 
            // Rdb10
            // 
            this.Rdb10.AutoSize = true;
            this.Rdb10.Checked = true;
            this.Rdb10.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Rdb10.Location = new System.Drawing.Point(6, 24);
            this.Rdb10.Name = "Rdb10";
            this.Rdb10.Size = new System.Drawing.Size(83, 28);
            this.Rdb10.TabIndex = 2;
            this.Rdb10.TabStop = true;
            this.Rdb10.Text = "10問";
            this.Rdb10.UseVisualStyleBackColor = true;
            // 
            // Rdb20
            // 
            this.Rdb20.AutoSize = true;
            this.Rdb20.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Rdb20.Location = new System.Drawing.Point(125, 24);
            this.Rdb20.Name = "Rdb20";
            this.Rdb20.Size = new System.Drawing.Size(83, 28);
            this.Rdb20.TabIndex = 3;
            this.Rdb20.Text = "20問";
            this.Rdb20.UseVisualStyleBackColor = true;
            // 
            // Rdb30
            // 
            this.Rdb30.AutoSize = true;
            this.Rdb30.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Rdb30.Location = new System.Drawing.Point(243, 24);
            this.Rdb30.Name = "Rdb30";
            this.Rdb30.Size = new System.Drawing.Size(83, 28);
            this.Rdb30.TabIndex = 4;
            this.Rdb30.Text = "30問";
            this.Rdb30.UseVisualStyleBackColor = true;
            // 
            // RdbNum
            // 
            this.RdbNum.AutoSize = true;
            this.RdbNum.Checked = true;
            this.RdbNum.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RdbNum.Location = new System.Drawing.Point(6, 25);
            this.RdbNum.Name = "RdbNum";
            this.RdbNum.Size = new System.Drawing.Size(95, 26);
            this.RdbNum.TabIndex = 6;
            this.RdbNum.TabStop = true;
            this.RdbNum.Text = "足し算";
            this.RdbNum.UseVisualStyleBackColor = true;
            // 
            // RdbSub
            // 
            this.RdbSub.AutoSize = true;
            this.RdbSub.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RdbSub.Location = new System.Drawing.Point(125, 25);
            this.RdbSub.Name = "RdbSub";
            this.RdbSub.Size = new System.Drawing.Size(96, 26);
            this.RdbSub.TabIndex = 7;
            this.RdbSub.Text = "引き算";
            this.RdbSub.UseVisualStyleBackColor = true;
            // 
            // TxtQue
            // 
            this.TxtQue.BackColor = System.Drawing.Color.White;
            this.TxtQue.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtQue.Location = new System.Drawing.Point(310, 198);
            this.TxtQue.Multiline = true;
            this.TxtQue.Name = "TxtQue";
            this.TxtQue.ReadOnly = true;
            this.TxtQue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtQue.Size = new System.Drawing.Size(267, 340);
            this.TxtQue.TabIndex = 9;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(12, 214);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(118, 55);
            this.BtnStart.TabIndex = 10;
            this.BtnStart.Text = "開 始";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblMondai
            // 
            this.LblMondai.BackColor = System.Drawing.Color.White;
            this.LblMondai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMondai.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblMondai.Location = new System.Drawing.Point(16, 294);
            this.LblMondai.Name = "LblMondai";
            this.LblMondai.Size = new System.Drawing.Size(247, 115);
            this.LblMondai.TabIndex = 11;
            this.LblMondai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbMul);
            this.groupBox1.Controls.Add(this.RdbNum);
            this.groupBox1.Controls.Add(this.RdbSub);
            this.groupBox1.Location = new System.Drawing.Point(16, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 59);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "タイプ";
            // 
            // RdbMul
            // 
            this.RdbMul.AutoSize = true;
            this.RdbMul.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RdbMul.Location = new System.Drawing.Point(243, 24);
            this.RdbMul.Name = "RdbMul";
            this.RdbMul.Size = new System.Drawing.Size(97, 26);
            this.RdbMul.TabIndex = 8;
            this.RdbMul.Text = "掛け算";
            this.RdbMul.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rdb40);
            this.groupBox2.Controls.Add(this.Rdb10);
            this.groupBox2.Controls.Add(this.Rdb20);
            this.groupBox2.Controls.Add(this.Rdb30);
            this.groupBox2.Location = new System.Drawing.Point(16, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 60);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "問題数";
            // 
            // Rdb40
            // 
            this.Rdb40.AutoSize = true;
            this.Rdb40.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Rdb40.Location = new System.Drawing.Point(367, 24);
            this.Rdb40.Name = "Rdb40";
            this.Rdb40.Size = new System.Drawing.Size(83, 28);
            this.Rdb40.TabIndex = 5;
            this.Rdb40.Text = "40問";
            this.Rdb40.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(141, 214);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(118, 55);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "終 了";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 550);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblMondai);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TxtQue);
            this.Controls.Add(this.TxtAnswer);
            this.Controls.Add(this.Answer);
            this.Name = "Form1";
            this.Text = "算数ドリル";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.TextBox TxtAnswer;
        private System.Windows.Forms.RadioButton Rdb10;
        private System.Windows.Forms.RadioButton Rdb20;
        private System.Windows.Forms.RadioButton Rdb30;
        private System.Windows.Forms.RadioButton RdbNum;
        private System.Windows.Forms.RadioButton RdbSub;
        private System.Windows.Forms.TextBox TxtQue;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblMondai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdbMul;
        private System.Windows.Forms.RadioButton Rdb40;
        private System.Windows.Forms.Button BtnClose;
    }
}

