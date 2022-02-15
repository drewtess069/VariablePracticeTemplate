namespace VariablePractice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hockeyButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.carpetButton = new System.Windows.Forms.Button();
            this.areaButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hockeyButton
            // 
            this.hockeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hockeyButton.Location = new System.Drawing.Point(26, 18);
            this.hockeyButton.Margin = new System.Windows.Forms.Padding(2);
            this.hockeyButton.Name = "hockeyButton";
            this.hockeyButton.Size = new System.Drawing.Size(81, 33);
            this.hockeyButton.TabIndex = 1;
            this.hockeyButton.Text = "Hockey";
            this.hockeyButton.UseVisualStyleBackColor = true;
            this.hockeyButton.Click += new System.EventHandler(this.hockeyButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(124, 18);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(287, 257);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "...";
            // 
            // payButton
            // 
            this.payButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.Location = new System.Drawing.Point(26, 69);
            this.payButton.Margin = new System.Windows.Forms.Padding(2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(81, 33);
            this.payButton.TabIndex = 5;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // carpetButton
            // 
            this.carpetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetButton.Location = new System.Drawing.Point(26, 184);
            this.carpetButton.Margin = new System.Windows.Forms.Padding(2);
            this.carpetButton.Name = "carpetButton";
            this.carpetButton.Size = new System.Drawing.Size(81, 33);
            this.carpetButton.TabIndex = 6;
            this.carpetButton.Text = "Carpet";
            this.carpetButton.UseVisualStyleBackColor = true;
            this.carpetButton.Click += new System.EventHandler(this.carpetButton_Click);
            // 
            // areaButton
            // 
            this.areaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaButton.Location = new System.Drawing.Point(26, 128);
            this.areaButton.Margin = new System.Windows.Forms.Padding(2);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(81, 33);
            this.areaButton.TabIndex = 7;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // billButton
            // 
            this.billButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billButton.Location = new System.Drawing.Point(26, 242);
            this.billButton.Margin = new System.Windows.Forms.Padding(2);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(81, 33);
            this.billButton.TabIndex = 8;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(431, 302);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.carpetButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.hockeyButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Variables Practice";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button hockeyButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button carpetButton;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button billButton;
    }
}

