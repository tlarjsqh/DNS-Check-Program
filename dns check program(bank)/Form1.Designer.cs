namespace dns_check_program_bank_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.NH = new System.Windows.Forms.Button();
            this.shinhan = new System.Windows.Forms.Button();
            this.kb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(66, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNS 변조 확인(ver.Bank)";
            // 
            // NH
            // 
            this.NH.BackColor = System.Drawing.Color.Transparent;
            this.NH.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NH.Image = ((System.Drawing.Image)(resources.GetObject("NH.Image")));
            this.NH.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NH.Location = new System.Drawing.Point(56, 147);
            this.NH.Name = "NH";
            this.NH.Size = new System.Drawing.Size(434, 75);
            this.NH.TabIndex = 1;
            this.NH.UseVisualStyleBackColor = false;
            this.NH.Click += new System.EventHandler(this.NH_Click);
            // 
            // shinhan
            // 
            this.shinhan.BackColor = System.Drawing.Color.Transparent;
            this.shinhan.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.shinhan.Image = ((System.Drawing.Image)(resources.GetObject("shinhan.Image")));
            this.shinhan.Location = new System.Drawing.Point(56, 274);
            this.shinhan.Name = "shinhan";
            this.shinhan.Size = new System.Drawing.Size(434, 75);
            this.shinhan.TabIndex = 2;
            this.shinhan.UseVisualStyleBackColor = false;
            this.shinhan.Click += new System.EventHandler(this.shinhan_Click);
            // 
            // kb
            // 
            this.kb.BackColor = System.Drawing.Color.Transparent;
            this.kb.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kb.Image = ((System.Drawing.Image)(resources.GetObject("kb.Image")));
            this.kb.Location = new System.Drawing.Point(56, 393);
            this.kb.Name = "kb";
            this.kb.Size = new System.Drawing.Size(434, 75);
            this.kb.TabIndex = 3;
            this.kb.UseVisualStyleBackColor = false;
            this.kb.Click += new System.EventHandler(this.kb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 520);
            this.Controls.Add(this.kb);
            this.Controls.Add(this.shinhan);
            this.Controls.Add(this.NH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DNS Check Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NH;
        private System.Windows.Forms.Button shinhan;
        private System.Windows.Forms.Button kb;
    }
}

