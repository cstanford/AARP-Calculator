namespace p1_cxs0290
{

/* Author:          Connor Stanford
 * CLID:            cxs0290
 * Class:           CMPS 358
 * Assignment:      project #1
 * Due Date:        Tuesday, 13 October 2015, 11:55 PM
 * Description:     A calculator program with a GUI that also accepts user input from the keyboard and numberpad. 
 */
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DropDownMenuButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.Clear_DropDownMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit_DropDownMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripButton();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.CalculatorScreen = new System.Windows.Forms.TextBox();
            this.EightButton = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackSpaceButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDownMenuButton,
            this.ExitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(314, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // DropDownMenuButton
            // 
            this.DropDownMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DropDownMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Clear_DropDownMenuItem,
            this.Quit_DropDownMenuItem});
            this.DropDownMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("DropDownMenuButton.Image")));
            this.DropDownMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDownMenuButton.Name = "DropDownMenuButton";
            this.DropDownMenuButton.Size = new System.Drawing.Size(29, 22);
            // 
            // Clear_DropDownMenuItem
            // 
            this.Clear_DropDownMenuItem.Name = "Clear_DropDownMenuItem";
            this.Clear_DropDownMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Clear_DropDownMenuItem.Text = "Clear";
            this.Clear_DropDownMenuItem.Click += new System.EventHandler(this.Clear_DropDownMenuItem_Click);
            // 
            // Quit_DropDownMenuItem
            // 
            this.Quit_DropDownMenuItem.Name = "Quit_DropDownMenuItem";
            this.Quit_DropDownMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Quit_DropDownMenuItem.Text = "Quit";
            this.Quit_DropDownMenuItem.Click += new System.EventHandler(this.Quit_DropDownMenuItem_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExitButton.Size = new System.Drawing.Size(23, 22);
            this.ExitButton.Text = "toolStripButton1";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ApplicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationLabel.Location = new System.Drawing.Point(36, 7);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(68, 16);
            this.ApplicationLabel.TabIndex = 1;
            this.ApplicationLabel.Text = "Calculator";
            // 
            // CalculatorScreen
            // 
            this.CalculatorScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CalculatorScreen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CalculatorScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorScreen.Location = new System.Drawing.Point(0, 26);
            this.CalculatorScreen.Multiline = true;
            this.CalculatorScreen.Name = "CalculatorScreen";
            this.CalculatorScreen.ReadOnly = true;
            this.CalculatorScreen.Size = new System.Drawing.Size(314, 74);
            this.CalculatorScreen.TabIndex = 2;
            this.CalculatorScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EightButton.FlatAppearance.BorderSize = 0;
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EightButton.Location = new System.Drawing.Point(86, 162);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(68, 49);
            this.EightButton.TabIndex = 16;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PlusMinusButton.FlatAppearance.BorderSize = 0;
            this.PlusMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusMinusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PlusMinusButton.Location = new System.Drawing.Point(234, 106);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(68, 49);
            this.PlusMinusButton.TabIndex = 17;
            this.PlusMinusButton.Text = "±";
            this.PlusMinusButton.UseVisualStyleBackColor = false;
            this.PlusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MinusButton.FlatAppearance.BorderSize = 0;
            this.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MinusButton.Location = new System.Drawing.Point(234, 272);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(68, 49);
            this.MinusButton.TabIndex = 18;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MultiplyButton.FlatAppearance.BorderSize = 0;
            this.MultiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MultiplyButton.Location = new System.Drawing.Point(234, 217);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(68, 49);
            this.MultiplyButton.TabIndex = 19;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PlusButton.FlatAppearance.BorderSize = 0;
            this.PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PlusButton.Location = new System.Drawing.Point(234, 327);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(68, 49);
            this.PlusButton.TabIndex = 20;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.DivideButton.FlatAppearance.BorderSize = 0;
            this.DivideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DivideButton.Location = new System.Drawing.Point(234, 161);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(68, 49);
            this.DivideButton.TabIndex = 21;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = false;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearButton.Location = new System.Drawing.Point(160, 106);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(68, 49);
            this.ClearButton.TabIndex = 22;
            this.ClearButton.Text = "Clr";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BackSpaceButton
            // 
            this.BackSpaceButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackSpaceButton.FlatAppearance.BorderSize = 0;
            this.BackSpaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackSpaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackSpaceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackSpaceButton.Location = new System.Drawing.Point(12, 107);
            this.BackSpaceButton.Name = "BackSpaceButton";
            this.BackSpaceButton.Size = new System.Drawing.Size(68, 49);
            this.BackSpaceButton.TabIndex = 23;
            this.BackSpaceButton.Text = "Bksp";
            this.BackSpaceButton.UseVisualStyleBackColor = false;
            this.BackSpaceButton.Click += new System.EventHandler(this.BackSpaceButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NineButton.FlatAppearance.BorderSize = 0;
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.ForeColor = System.Drawing.SystemColors.Control;
            this.NineButton.Location = new System.Drawing.Point(160, 162);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(68, 49);
            this.NineButton.TabIndex = 24;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SevenButton.FlatAppearance.BorderSize = 0;
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SevenButton.Location = new System.Drawing.Point(12, 162);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(68, 49);
            this.SevenButton.TabIndex = 25;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SixButton.FlatAppearance.BorderSize = 0;
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SixButton.Location = new System.Drawing.Point(160, 217);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(68, 49);
            this.SixButton.TabIndex = 26;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FiveButton.FlatAppearance.BorderSize = 0;
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FiveButton.Location = new System.Drawing.Point(86, 218);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(68, 49);
            this.FiveButton.TabIndex = 27;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FourButton.FlatAppearance.BorderSize = 0;
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FourButton.Location = new System.Drawing.Point(12, 218);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(68, 49);
            this.FourButton.TabIndex = 28;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZeroButton.FlatAppearance.BorderSize = 0;
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ZeroButton.Location = new System.Drawing.Point(12, 328);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(68, 49);
            this.ZeroButton.TabIndex = 29;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DecimalButton.FlatAppearance.BorderSize = 0;
            this.DecimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DecimalButton.Location = new System.Drawing.Point(86, 328);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(68, 49);
            this.DecimalButton.TabIndex = 30;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EqualsButton.FlatAppearance.BorderSize = 0;
            this.EqualsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EqualsButton.Location = new System.Drawing.Point(160, 328);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(68, 49);
            this.EqualsButton.TabIndex = 31;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OneButton.FlatAppearance.BorderSize = 0;
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OneButton.Location = new System.Drawing.Point(12, 273);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(68, 49);
            this.OneButton.TabIndex = 32;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TwoButton.FlatAppearance.BorderSize = 0;
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TwoButton.Location = new System.Drawing.Point(86, 273);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(68, 49);
            this.TwoButton.TabIndex = 33;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ThreeButton.FlatAppearance.BorderSize = 0;
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ThreeButton.Location = new System.Drawing.Point(160, 272);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(68, 49);
            this.ThreeButton.TabIndex = 34;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(314, 388);
            this.ControlBox = false;
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.BackSpaceButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusMinusButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.CalculatorScreen);
            this.Controls.Add(this.ApplicationLabel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(330, 427);
            this.MinimumSize = new System.Drawing.Size(330, 427);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton DropDownMenuButton;
        private System.Windows.Forms.ToolStripMenuItem Clear_DropDownMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Quit_DropDownMenuItem;
        private System.Windows.Forms.ToolStripButton ExitButton;
        private System.Windows.Forms.Label ApplicationLabel;
        private System.Windows.Forms.TextBox CalculatorScreen;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackSpaceButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
    }
}

