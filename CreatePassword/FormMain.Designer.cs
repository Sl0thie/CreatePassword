
namespace CreatePassword
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.UseSymbols = new System.Windows.Forms.CheckBox();
            this.UseNumbers = new System.Windows.Forms.CheckBox();
            this.UseLowercase = new System.Windows.Forms.CheckBox();
            this.UseUppercase = new System.Windows.Forms.CheckBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.PasswordLength = new System.Windows.Forms.NumericUpDown();
            this.CreatePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyToClipboard = new System.Windows.Forms.CheckBox();
            this.AutoClose = new System.Windows.Forms.CheckBox();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // UseSymbols
            // 
            this.UseSymbols.AutoSize = true;
            this.UseSymbols.Checked = true;
            this.UseSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseSymbols.Location = new System.Drawing.Point(276, 22);
            this.UseSymbols.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UseSymbols.Name = "UseSymbols";
            this.UseSymbols.Size = new System.Drawing.Size(112, 24);
            this.UseSymbols.TabIndex = 0;
            this.UseSymbols.Text = "Use Symbols";
            this.UseSymbols.UseVisualStyleBackColor = true;
            this.UseSymbols.CheckedChanged += new System.EventHandler(this.ResetTimer);
            // 
            // UseNumbers
            // 
            this.UseNumbers.AutoSize = true;
            this.UseNumbers.Checked = true;
            this.UseNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseNumbers.Location = new System.Drawing.Point(152, 22);
            this.UseNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UseNumbers.Name = "UseNumbers";
            this.UseNumbers.Size = new System.Drawing.Size(116, 24);
            this.UseNumbers.TabIndex = 1;
            this.UseNumbers.Text = "Use Numbers";
            this.UseNumbers.UseVisualStyleBackColor = true;
            this.UseNumbers.CheckedChanged += new System.EventHandler(this.ResetTimer);
            // 
            // UseLowercase
            // 
            this.UseLowercase.AutoSize = true;
            this.UseLowercase.Checked = true;
            this.UseLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseLowercase.Location = new System.Drawing.Point(396, 22);
            this.UseLowercase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UseLowercase.Name = "UseLowercase";
            this.UseLowercase.Size = new System.Drawing.Size(125, 24);
            this.UseLowercase.TabIndex = 2;
            this.UseLowercase.Text = "Use Lowercase";
            this.UseLowercase.UseVisualStyleBackColor = true;
            this.UseLowercase.CheckedChanged += new System.EventHandler(this.ResetTimer);
            // 
            // UseUppercase
            // 
            this.UseUppercase.AutoSize = true;
            this.UseUppercase.Checked = true;
            this.UseUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseUppercase.Location = new System.Drawing.Point(529, 22);
            this.UseUppercase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UseUppercase.Name = "UseUppercase";
            this.UseUppercase.Size = new System.Drawing.Size(126, 24);
            this.UseUppercase.TabIndex = 3;
            this.UseUppercase.Text = "Use Uppercase";
            this.UseUppercase.UseVisualStyleBackColor = true;
            this.UseUppercase.CheckedChanged += new System.EventHandler(this.ResetTimer);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(16, 54);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(905, 27);
            this.Password.TabIndex = 4;
            this.Password.TextChanged += new System.EventHandler(this.ResetTimer);
            // 
            // PasswordLength
            // 
            this.PasswordLength.Location = new System.Drawing.Point(72, 19);
            this.PasswordLength.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.PasswordLength.Name = "PasswordLength";
            this.PasswordLength.Size = new System.Drawing.Size(58, 27);
            this.PasswordLength.TabIndex = 5;
            this.PasswordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PasswordLength.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.PasswordLength.ValueChanged += new System.EventHandler(this.ResetTimer);
            // 
            // CreatePassword
            // 
            this.CreatePassword.Location = new System.Drawing.Point(771, 87);
            this.CreatePassword.Name = "CreatePassword";
            this.CreatePassword.Size = new System.Drawing.Size(150, 34);
            this.CreatePassword.TabIndex = 6;
            this.CreatePassword.Text = "Create Password";
            this.CreatePassword.UseVisualStyleBackColor = true;
            this.CreatePassword.Click += new System.EventHandler(this.CreatePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Length";
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.AutoSize = true;
            this.CopyToClipboard.Checked = true;
            this.CopyToClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CopyToClipboard.Location = new System.Drawing.Point(663, 22);
            this.CopyToClipboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(150, 24);
            this.CopyToClipboard.TabIndex = 8;
            this.CopyToClipboard.Text = "Copy to Clipboard";
            this.CopyToClipboard.UseVisualStyleBackColor = true;
            this.CopyToClipboard.CheckedChanged += new System.EventHandler(this.ResetTimer);
            // 
            // AutoClose
            // 
            this.AutoClose.AutoSize = true;
            this.AutoClose.Location = new System.Drawing.Point(821, 22);
            this.AutoClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AutoClose.Name = "AutoClose";
            this.AutoClose.Size = new System.Drawing.Size(100, 24);
            this.AutoClose.TabIndex = 9;
            this.AutoClose.Text = "Auto Close";
            this.AutoClose.UseVisualStyleBackColor = true;
            this.AutoClose.CheckedChanged += new System.EventHandler(this.ResetTimer);
            // 
            // CloseTimer
            // 
            this.CloseTimer.Enabled = true;
            this.CloseTimer.Interval = 60000;
            this.CloseTimer.Tick += new System.EventHandler(this.CloseTimer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 136);
            this.Controls.Add(this.AutoClose);
            this.Controls.Add(this.CopyToClipboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreatePassword);
            this.Controls.Add(this.PasswordLength);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UseUppercase);
            this.Controls.Add(this.UseLowercase);
            this.Controls.Add(this.UseNumbers);
            this.Controls.Add(this.UseSymbols);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Password Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UseSymbols;
        private System.Windows.Forms.CheckBox UseNumbers;
        private System.Windows.Forms.CheckBox UseLowercase;
        private System.Windows.Forms.CheckBox UseUppercase;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.NumericUpDown PasswordLength;
        private System.Windows.Forms.Button CreatePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CopyToClipboard;
        private System.Windows.Forms.CheckBox AutoClose;
        private System.Windows.Forms.Timer CloseTimer;
    }
}

