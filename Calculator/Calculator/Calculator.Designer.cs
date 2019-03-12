namespace Calculator
{
    partial class SimpleCalculator
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
            this.NumScreen = new System.Windows.Forms.Label();
            this.NumButton1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.NumPlus = new System.Windows.Forms.Button();
            this.NumClear = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.Color.White;
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumScreen.Location = new System.Drawing.Point(33, 28);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(318, 61);
            this.NumScreen.TabIndex = 0;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumButton1
            // 
            this.NumButton1.Location = new System.Drawing.Point(33, 308);
            this.NumButton1.Name = "NumButton1";
            this.NumButton1.Size = new System.Drawing.Size(75, 63);
            this.NumButton1.TabIndex = 1;
            this.NumButton1.Text = "1";
            this.NumButton1.UseVisualStyleBackColor = true;
            this.NumButton1.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(195, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 63);
            this.button4.TabIndex = 4;
            this.button4.Text = "8";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(114, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 63);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(276, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 63);
            this.button6.TabIndex = 6;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(33, 170);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 63);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(195, 308);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 63);
            this.button8.TabIndex = 8;
            this.button8.Text = "3";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(114, 308);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 63);
            this.button9.TabIndex = 9;
            this.button9.Text = "2";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(195, 239);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 63);
            this.button10.TabIndex = 10;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(276, 170);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 63);
            this.button11.TabIndex = 11;
            this.button11.Text = "*";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // NumPlus
            // 
            this.NumPlus.Location = new System.Drawing.Point(276, 308);
            this.NumPlus.Name = "NumPlus";
            this.NumPlus.Size = new System.Drawing.Size(75, 63);
            this.NumPlus.TabIndex = 12;
            this.NumPlus.Text = "+";
            this.NumPlus.UseVisualStyleBackColor = true;
            this.NumPlus.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // NumClear
            // 
            this.NumClear.Location = new System.Drawing.Point(114, 101);
            this.NumClear.Name = "NumClear";
            this.NumClear.Size = new System.Drawing.Size(75, 63);
            this.NumClear.TabIndex = 13;
            this.NumClear.Text = "c";
            this.NumClear.UseVisualStyleBackColor = true;
            this.NumClear.Click += new System.EventHandler(this.NumClear_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(114, 377);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 63);
            this.button14.TabIndex = 14;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(276, 377);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 63);
            this.button15.TabIndex = 15;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 63);
            this.button1.TabIndex = 16;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.NumClear);
            this.Controls.Add(this.NumPlus);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NumButton1);
            this.Controls.Add(this.NumScreen);
            this.Name = "SimpleCalculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NumScreen;
        private System.Windows.Forms.Button NumButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button NumPlus;
        private System.Windows.Forms.Button NumClear;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button1;
    }
}

