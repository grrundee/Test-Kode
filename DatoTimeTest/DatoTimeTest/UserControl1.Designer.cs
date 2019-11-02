namespace DatoTimeTest
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnSendDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(283, 179);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(242, 26);
            this.txtInput.TabIndex = 1;
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(283, 228);
            this.txtShow.Name = "txtShow";
            this.txtShow.ReadOnly = true;
            this.txtShow.Size = new System.Drawing.Size(242, 26);
            this.txtShow.TabIndex = 1;
            // 
            // btnSendDate
            // 
            this.btnSendDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendDate.Location = new System.Drawing.Point(283, 61);
            this.btnSendDate.Name = "btnSendDate";
            this.btnSendDate.Size = new System.Drawing.Size(242, 36);
            this.btnSendDate.TabIndex = 2;
            this.btnSendDate.Text = "Send dato til database";
            this.btnSendDate.UseVisualStyleBackColor = true;
            this.btnSendDate.Click += new System.EventHandler(this.btnSendDate_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSendDate);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.button1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnSendDate;
    }
}
