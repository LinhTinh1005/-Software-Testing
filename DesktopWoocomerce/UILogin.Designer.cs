namespace DesktopWoocomerce
{
    partial class UILogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UILogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLoginName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLoginUI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // tbxLoginName
            // 
            this.tbxLoginName.Location = new System.Drawing.Point(286, 135);
            this.tbxLoginName.Multiline = true;
            this.tbxLoginName.Name = "tbxLoginName";
            this.tbxLoginName.Size = new System.Drawing.Size(252, 35);
            this.tbxLoginName.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 201);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 33);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnLoginUI
            // 
            this.btnLoginUI.BackColor = System.Drawing.Color.Silver;
            this.btnLoginUI.Location = new System.Drawing.Point(268, 290);
            this.btnLoginUI.Name = "btnLoginUI";
            this.btnLoginUI.Size = new System.Drawing.Size(200, 33);
            this.btnLoginUI.TabIndex = 2;
            this.btnLoginUI.Text = "Đăng nhập";
            this.btnLoginUI.UseVisualStyleBackColor = false;
            // 
            // UILogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.btnLoginUI);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbxLoginName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UILogin";
            this.Text = "UILogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxLoginName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnLoginUI;
    }
}