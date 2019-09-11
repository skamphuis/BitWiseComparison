namespace BitWiseComparison
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
            this.iiIntWaarde = new DevComponents.Editors.IntegerInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.chkRood = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.chkGroen = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkBlauw = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkOranje = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkPaars = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.iiIntWaarde)).BeginInit();
            this.SuspendLayout();
            // 
            // iiIntWaarde
            // 
            this.iiIntWaarde.AllowEmptyState = false;
            this.iiIntWaarde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.iiIntWaarde.BackgroundStyle.Class = "DateTimeInputBackground";
            this.iiIntWaarde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iiIntWaarde.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iiIntWaarde.Location = new System.Drawing.Point(242, 12);
            this.iiIntWaarde.Name = "iiIntWaarde";
            this.iiIntWaarde.ShowUpDown = true;
            this.iiIntWaarde.Size = new System.Drawing.Size(80, 20);
            this.iiIntWaarde.TabIndex = 0;
            this.iiIntWaarde.ValueChanged += new System.EventHandler(this.IiIntWaarde_ValueChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Integer waarde";
            // 
            // chkRood
            // 
            // 
            // 
            // 
            this.chkRood.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkRood.Location = new System.Drawing.Point(13, 75);
            this.chkRood.Name = "chkRood";
            this.chkRood.Size = new System.Drawing.Size(100, 23);
            this.chkRood.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkRood.TabIndex = 2;
            this.chkRood.Text = "Rood";
            this.chkRood.CheckedChanged += new System.EventHandler(this.ChkKleur_CheckedChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(13, 46);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Kleuren:";
            // 
            // chkGroen
            // 
            // 
            // 
            // 
            this.chkGroen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkGroen.Location = new System.Drawing.Point(13, 104);
            this.chkGroen.Name = "chkGroen";
            this.chkGroen.Size = new System.Drawing.Size(100, 23);
            this.chkGroen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkGroen.TabIndex = 4;
            this.chkGroen.Text = "Groen";
            this.chkGroen.CheckedChanged += new System.EventHandler(this.ChkKleur_CheckedChanged);
            // 
            // chkBlauw
            // 
            // 
            // 
            // 
            this.chkBlauw.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkBlauw.Location = new System.Drawing.Point(13, 133);
            this.chkBlauw.Name = "chkBlauw";
            this.chkBlauw.Size = new System.Drawing.Size(100, 23);
            this.chkBlauw.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkBlauw.TabIndex = 5;
            this.chkBlauw.Text = "Blauw";
            this.chkBlauw.CheckedChanged += new System.EventHandler(this.ChkKleur_CheckedChanged);
            // 
            // chkOranje
            // 
            // 
            // 
            // 
            this.chkOranje.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkOranje.Location = new System.Drawing.Point(13, 162);
            this.chkOranje.Name = "chkOranje";
            this.chkOranje.Size = new System.Drawing.Size(100, 23);
            this.chkOranje.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkOranje.TabIndex = 6;
            this.chkOranje.Text = "Oranje";
            this.chkOranje.CheckedChanged += new System.EventHandler(this.ChkKleur_CheckedChanged);
            // 
            // chkPaars
            // 
            // 
            // 
            // 
            this.chkPaars.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkPaars.Location = new System.Drawing.Point(12, 191);
            this.chkPaars.Name = "chkPaars";
            this.chkPaars.Size = new System.Drawing.Size(100, 23);
            this.chkPaars.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkPaars.TabIndex = 7;
            this.chkPaars.Text = "Paars";
            this.chkPaars.CheckedChanged += new System.EventHandler(this.ChkKleur_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 288);
            this.Controls.Add(this.chkPaars);
            this.Controls.Add(this.chkOranje);
            this.Controls.Add(this.chkBlauw);
            this.Controls.Add(this.chkGroen);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.chkRood);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.iiIntWaarde);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.iiIntWaarde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.IntegerInput iiIntWaarde;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkRood;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkGroen;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkBlauw;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkOranje;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkPaars;
    }
}

