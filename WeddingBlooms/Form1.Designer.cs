namespace WeddingBloomsDraft3
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
            this.clientButton = new System.Windows.Forms.Button();
            this.weddingButton = new System.Windows.Forms.Button();
            this.supplyButton = new System.Windows.Forms.Button();
            this.vendorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientButton
            // 
            this.clientButton.Location = new System.Drawing.Point(26, 117);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(161, 72);
            this.clientButton.TabIndex = 0;
            this.clientButton.Text = "Add Client";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // weddingButton
            // 
            this.weddingButton.Location = new System.Drawing.Point(273, 118);
            this.weddingButton.Name = "weddingButton";
            this.weddingButton.Size = new System.Drawing.Size(156, 71);
            this.weddingButton.TabIndex = 1;
            this.weddingButton.Text = "Wedding Details";
            this.weddingButton.UseVisualStyleBackColor = true;
            this.weddingButton.Click += new System.EventHandler(this.weddingButton_Click);
            // 
            // supplyButton
            // 
            this.supplyButton.Location = new System.Drawing.Point(549, 119);
            this.supplyButton.Name = "supplyButton";
            this.supplyButton.Size = new System.Drawing.Size(151, 70);
            this.supplyButton.TabIndex = 2;
            this.supplyButton.Text = "Supplies";
            this.supplyButton.UseVisualStyleBackColor = true;
            this.supplyButton.Click += new System.EventHandler(this.supplyButton_Click);
            // 
            // vendorButton
            // 
            this.vendorButton.Location = new System.Drawing.Point(273, 281);
            this.vendorButton.Name = "vendorButton";
            this.vendorButton.Size = new System.Drawing.Size(170, 71);
            this.vendorButton.TabIndex = 3;
            this.vendorButton.Text = "Vendors";
            this.vendorButton.UseVisualStyleBackColor = true;
            this.vendorButton.Click += new System.EventHandler(this.vendorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vendorButton);
            this.Controls.Add(this.supplyButton);
            this.Controls.Add(this.weddingButton);
            this.Controls.Add(this.clientButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Button weddingButton;
        private System.Windows.Forms.Button supplyButton;
        private System.Windows.Forms.Button vendorButton;
    }
}

