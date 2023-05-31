namespace DemoWcfFormApp
{
    partial class Form1
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
            this.txtGetMessage = new System.Windows.Forms.TextBox();
            this.btnGetMessage = new System.Windows.Forms.Button();
            this.lblGetMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGetMessage
            // 
            this.txtGetMessage.Location = new System.Drawing.Point(50, 23);
            this.txtGetMessage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtGetMessage.Name = "txtGetMessage";
            this.txtGetMessage.Size = new System.Drawing.Size(184, 34);
            this.txtGetMessage.TabIndex = 0;
            // 
            // btnGetMessage
            // 
            this.btnGetMessage.Location = new System.Drawing.Point(283, 23);
            this.btnGetMessage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGetMessage.Name = "btnGetMessage";
            this.btnGetMessage.Size = new System.Drawing.Size(140, 42);
            this.btnGetMessage.TabIndex = 1;
            this.btnGetMessage.Text = "Get Message";
            this.btnGetMessage.UseVisualStyleBackColor = true;
            this.btnGetMessage.Click += new System.EventHandler(this.btnGetMessage_Click);
            // 
            // lblGetMessage
            // 
            this.lblGetMessage.AutoSize = true;
            this.lblGetMessage.Location = new System.Drawing.Point(50, 120);
            this.lblGetMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGetMessage.Name = "lblGetMessage";
            this.lblGetMessage.Size = new System.Drawing.Size(0, 29);
            this.lblGetMessage.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 816);
            this.Controls.Add(this.lblGetMessage);
            this.Controls.Add(this.btnGetMessage);
            this.Controls.Add(this.txtGetMessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGetMessage;
        private System.Windows.Forms.Button btnGetMessage;
        private System.Windows.Forms.Label lblGetMessage;
    }
}

