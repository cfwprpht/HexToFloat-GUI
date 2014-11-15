namespace HexToFloa
{
    partial class HexToFloat
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HexToFloat));
            this.textSingleHex = new System.Windows.Forms.TextBox();
            this.textSingleFloat = new System.Windows.Forms.TextBox();
            this.textDoubleFloat = new System.Windows.Forms.TextBox();
            this.textDoubleHex = new System.Windows.Forms.TextBox();
            this.ConvertToSingleFloat = new System.Windows.Forms.Button();
            this.ConvertToSingleHex = new System.Windows.Forms.Button();
            this.ConvertToDoubleFloat = new System.Windows.Forms.Button();
            this.ConvertToDoubleHex = new System.Windows.Forms.Button();
            this.labelWORD = new System.Windows.Forms.Label();
            this.labelSingleFloat = new System.Windows.Forms.Label();
            this.labelDWORD = new System.Windows.Forms.Label();
            this.labelDoubleFloat = new System.Windows.Forms.Label();
            this.checkReverse = new System.Windows.Forms.CheckBox();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textSingleHex
            // 
            this.textSingleHex.Location = new System.Drawing.Point(51, 51);
            this.textSingleHex.Name = "textSingleHex";
            this.textSingleHex.Size = new System.Drawing.Size(80, 20);
            this.textSingleHex.TabIndex = 0;
            // 
            // textSingleFloat
            // 
            this.textSingleFloat.Location = new System.Drawing.Point(66, 77);
            this.textSingleFloat.Name = "textSingleFloat";
            this.textSingleFloat.Size = new System.Drawing.Size(114, 20);
            this.textSingleFloat.TabIndex = 1;
            // 
            // textDoubleFloat
            // 
            this.textDoubleFloat.Location = new System.Drawing.Point(71, 139);
            this.textDoubleFloat.Name = "textDoubleFloat";
            this.textDoubleFloat.Size = new System.Drawing.Size(141, 20);
            this.textDoubleFloat.TabIndex = 2;
            // 
            // textDoubleHex
            // 
            this.textDoubleHex.Location = new System.Drawing.Point(56, 113);
            this.textDoubleHex.Name = "textDoubleHex";
            this.textDoubleHex.Size = new System.Drawing.Size(127, 20);
            this.textDoubleHex.TabIndex = 3;
            // 
            // ConvertToSingleFloat
            // 
            this.ConvertToSingleFloat.Location = new System.Drawing.Point(137, 49);
            this.ConvertToSingleFloat.Name = "ConvertToSingleFloat";
            this.ConvertToSingleFloat.Size = new System.Drawing.Size(75, 23);
            this.ConvertToSingleFloat.TabIndex = 9;
            this.ConvertToSingleFloat.Text = "To Single";
            this.ConvertToSingleFloat.UseVisualStyleBackColor = true;
            this.ConvertToSingleFloat.Click += new System.EventHandler(this.ConvertToSingleFloat_Click);
            // 
            // ConvertToSingleHex
            // 
            this.ConvertToSingleHex.Location = new System.Drawing.Point(186, 75);
            this.ConvertToSingleHex.Name = "ConvertToSingleHex";
            this.ConvertToSingleHex.Size = new System.Drawing.Size(75, 23);
            this.ConvertToSingleHex.TabIndex = 10;
            this.ConvertToSingleHex.Text = "To Hex";
            this.ConvertToSingleHex.UseVisualStyleBackColor = true;
            this.ConvertToSingleHex.Click += new System.EventHandler(this.ConvertToSingleHex_Click);
            // 
            // ConvertToDoubleFloat
            // 
            this.ConvertToDoubleFloat.Location = new System.Drawing.Point(189, 111);
            this.ConvertToDoubleFloat.Name = "ConvertToDoubleFloat";
            this.ConvertToDoubleFloat.Size = new System.Drawing.Size(75, 23);
            this.ConvertToDoubleFloat.TabIndex = 11;
            this.ConvertToDoubleFloat.Text = "To Double";
            this.ConvertToDoubleFloat.UseVisualStyleBackColor = true;
            this.ConvertToDoubleFloat.Click += new System.EventHandler(this.ConvertToDoubleFloat_Click);
            // 
            // ConvertToDoubleHex
            // 
            this.ConvertToDoubleHex.Location = new System.Drawing.Point(218, 137);
            this.ConvertToDoubleHex.Name = "ConvertToDoubleHex";
            this.ConvertToDoubleHex.Size = new System.Drawing.Size(75, 23);
            this.ConvertToDoubleHex.TabIndex = 12;
            this.ConvertToDoubleHex.Text = "To Hex";
            this.ConvertToDoubleHex.UseVisualStyleBackColor = true;
            this.ConvertToDoubleHex.Click += new System.EventHandler(this.ConvertToDoubleHex_Click);
            // 
            // labelWORD
            // 
            this.labelWORD.AutoSize = true;
            this.labelWORD.Location = new System.Drawing.Point(0, 54);
            this.labelWORD.Name = "labelWORD";
            this.labelWORD.Size = new System.Drawing.Size(42, 13);
            this.labelWORD.TabIndex = 13;
            this.labelWORD.Text = "WORD";
            // 
            // labelSingleFloat
            // 
            this.labelSingleFloat.AutoSize = true;
            this.labelSingleFloat.Location = new System.Drawing.Point(0, 80);
            this.labelSingleFloat.Name = "labelSingleFloat";
            this.labelSingleFloat.Size = new System.Drawing.Size(62, 13);
            this.labelSingleFloat.TabIndex = 14;
            this.labelSingleFloat.Text = "Single Float";
            // 
            // labelDWORD
            // 
            this.labelDWORD.AutoSize = true;
            this.labelDWORD.Location = new System.Drawing.Point(0, 116);
            this.labelDWORD.Name = "labelDWORD";
            this.labelDWORD.Size = new System.Drawing.Size(50, 13);
            this.labelDWORD.TabIndex = 15;
            this.labelDWORD.Text = "DWORD";
            // 
            // labelDoubleFloat
            // 
            this.labelDoubleFloat.AutoSize = true;
            this.labelDoubleFloat.Location = new System.Drawing.Point(0, 142);
            this.labelDoubleFloat.Name = "labelDoubleFloat";
            this.labelDoubleFloat.Size = new System.Drawing.Size(67, 13);
            this.labelDoubleFloat.TabIndex = 16;
            this.labelDoubleFloat.Text = "Double Float";
            // 
            // checkReverse
            // 
            this.checkReverse.AutoSize = true;
            this.checkReverse.Location = new System.Drawing.Point(241, 43);
            this.checkReverse.Name = "checkReverse";
            this.checkReverse.Size = new System.Drawing.Size(66, 17);
            this.checkReverse.TabIndex = 17;
            this.checkReverse.Text = "Reverse";
            this.checkReverse.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(23, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(256, 32);
            this.Title.TabIndex = 18;
            this.Title.Text = "Hex2Float and Float2Hex";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // HexToFloat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 167);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.checkReverse);
            this.Controls.Add(this.labelDoubleFloat);
            this.Controls.Add(this.labelDWORD);
            this.Controls.Add(this.labelSingleFloat);
            this.Controls.Add(this.labelWORD);
            this.Controls.Add(this.ConvertToDoubleHex);
            this.Controls.Add(this.ConvertToDoubleFloat);
            this.Controls.Add(this.ConvertToSingleHex);
            this.Controls.Add(this.ConvertToSingleFloat);
            this.Controls.Add(this.textDoubleHex);
            this.Controls.Add(this.textDoubleFloat);
            this.Controls.Add(this.textSingleFloat);
            this.Controls.Add(this.textSingleHex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HexToFloat";
            this.Text = "HexToFloat";
            this.Load += new System.EventHandler(this.HexToFloat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSingleHex;
        private System.Windows.Forms.TextBox textSingleFloat;
        private System.Windows.Forms.TextBox textDoubleFloat;
        private System.Windows.Forms.TextBox textDoubleHex;
        private System.Windows.Forms.Button ConvertToSingleFloat;
        private System.Windows.Forms.Button ConvertToSingleHex;
        private System.Windows.Forms.Button ConvertToDoubleFloat;
        private System.Windows.Forms.Button ConvertToDoubleHex;
        private System.Windows.Forms.Label labelWORD;
        private System.Windows.Forms.Label labelSingleFloat;
        private System.Windows.Forms.Label labelDWORD;
        private System.Windows.Forms.Label labelDoubleFloat;
        private System.Windows.Forms.CheckBox checkReverse;
        private System.Windows.Forms.Label Title;
    }
}

