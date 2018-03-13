namespace WindowsFormsApplication3
{
    partial class chageCal
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chageCal));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sum_rt = new System.Windows.Forms.Label();
            this.elisted = new System.Windows.Forms.DateTimePicker();
            this.sum = new System.Windows.Forms.Label();
            this.bta = new System.Windows.Forms.ComboBox();
            this.percent = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "입대일";
            // 
            // sum_rt
            // 
            this.sum_rt.AutoSize = true;
            this.sum_rt.Location = new System.Drawing.Point(213, 149);
            this.sum_rt.Name = "sum_rt";
            this.sum_rt.Size = new System.Drawing.Size(0, 12);
            this.sum_rt.TabIndex = 5;
            // 
            // elisted
            // 
            this.elisted.Location = new System.Drawing.Point(23, 72);
            this.elisted.Name = "elisted";
            this.elisted.Size = new System.Drawing.Size(246, 21);
            this.elisted.TabIndex = 6;
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.BackColor = System.Drawing.SystemColors.Info;
            this.sum.Location = new System.Drawing.Point(21, 130);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(0, 12);
            this.sum.TabIndex = 8;
            // 
            // bta
            // 
            this.bta.DisplayMember = "육군/의경";
            this.bta.FormattingEnabled = true;
            this.bta.Items.AddRange(new object[] {
            "육군/의경",
            "해군",
            "공군",
            "해병",
            "사회복무"});
            this.bta.Location = new System.Drawing.Point(74, 24);
            this.bta.Name = "bta";
            this.bta.Size = new System.Drawing.Size(139, 20);
            this.bta.TabIndex = 9;
            this.bta.Text = "소속 군대";
            this.bta.UseWaitCursor = true;
            
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(23, 149);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(246, 37);
            this.percent.TabIndex = 10;
            // 
            // chageCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 209);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.bta);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.elisted);
            this.Controls.Add(this.sum_rt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chageCal";
            this.Text = "전역계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sum_rt;
        private System.Windows.Forms.DateTimePicker elisted;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.ComboBox bta;
        private System.Windows.Forms.ProgressBar percent;
    }
}

