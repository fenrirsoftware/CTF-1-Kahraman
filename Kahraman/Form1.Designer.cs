namespace Kahraman
{
    partial class 窗体
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.按钮检查密码 = new System.Windows.Forms.Button();
            this.文本框密码 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 按钮检查密码
            // 
            this.按钮检查密码.Location = new System.Drawing.Point(61, 71);
            this.按钮检查密码.Name = "按钮检查密码";
            this.按钮检查密码.Size = new System.Drawing.Size(119, 52);
            this.按钮检查密码.TabIndex = 1;
            this.按钮检查密码.Text = "Login";
            this.按钮检查密码.UseVisualStyleBackColor = true;
            this.按钮检查密码.Click += new System.EventHandler(this.按钮检查密码_Click);
            // 
            // 文本框密码
            // 
            this.文本框密码.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.文本框密码.Location = new System.Drawing.Point(61, 25);
            this.文本框密码.Name = "文本框密码";
            this.文本框密码.Size = new System.Drawing.Size(119, 31);
            this.文本框密码.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pass";
            // 
            // 窗体
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.文本框密码);
            this.Controls.Add(this.按钮检查密码);
            this.Name = "窗体";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button 按钮检查密码;
        private System.Windows.Forms.TextBox 文本框密码;
        private System.Windows.Forms.Label label1;
    }
}

