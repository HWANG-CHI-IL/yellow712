namespace WindowsFormsApp9
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClone1 = new System.Windows.Forms.Button();
            this.btnClone2 = new System.Windows.Forms.Button();
            this.btnGC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGC);
            this.panel1.Controls.Add(this.btnClone2);
            this.panel1.Controls.Add(this.btnClone1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 238);
            this.panel1.TabIndex = 0;
            // 
            // btnClone1
            // 
            this.btnClone1.Location = new System.Drawing.Point(74, 29);
            this.btnClone1.Name = "btnClone1";
            this.btnClone1.Size = new System.Drawing.Size(75, 23);
            this.btnClone1.TabIndex = 0;
            this.btnClone1.Text = "Clone #1";
            this.btnClone1.UseVisualStyleBackColor = true;
            this.btnClone1.Click += new System.EventHandler(this.btnClone1_Click);
            // 
            // btnClone2
            // 
            this.btnClone2.Location = new System.Drawing.Point(74, 89);
            this.btnClone2.Name = "btnClone2";
            this.btnClone2.Size = new System.Drawing.Size(75, 23);
            this.btnClone2.TabIndex = 1;
            this.btnClone2.Text = "Clone #2";
            this.btnClone2.UseVisualStyleBackColor = true;
            this.btnClone2.Click += new System.EventHandler(this.btnClone2_Click);
            // 
            // btnGC
            // 
            this.btnGC.Location = new System.Drawing.Point(74, 155);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(75, 23);
            this.btnGC.TabIndex = 2;
            this.btnGC.Text = "GC";
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGC;
        private System.Windows.Forms.Button btnClone2;
        private System.Windows.Forms.Button btnClone1;
    }
}

