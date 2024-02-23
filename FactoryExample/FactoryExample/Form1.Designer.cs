namespace FactoryExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ColorButton = new Button();
            IsFilledCheck = new CheckBox();
            ShapeComboBox = new ComboBox();
            SizeNum = new NumericUpDown();
            CenterCheck = new CheckBox();
            label1 = new Label();
            colorDialog = new ColorDialog();
            canvas1 = new Canvas();
            EnableButton = new Button();
            DisableButton = new Button();
            DecoratorCombo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)SizeNum).BeginInit();
            SuspendLayout();
            // 
            // ColorButton
            // 
            ColorButton.BackColor = Color.Red;
            ColorButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ColorButton.Location = new Point(355, 8);
            ColorButton.Name = "ColorButton";
            ColorButton.Size = new Size(83, 31);
            ColorButton.TabIndex = 0;
            ColorButton.Text = "Barva";
            ColorButton.UseVisualStyleBackColor = false;
            ColorButton.BackColorChanged += ColorButton_BackColorChanged;
            ColorButton.Click += ColorButton_Click;
            // 
            // IsFilledCheck
            // 
            IsFilledCheck.AutoSize = true;
            IsFilledCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsFilledCheck.Location = new Point(605, 11);
            IsFilledCheck.Name = "IsFilledCheck";
            IsFilledCheck.Size = new Size(94, 25);
            IsFilledCheck.TabIndex = 1;
            IsFilledCheck.Text = "Vyplněný";
            IsFilledCheck.UseVisualStyleBackColor = true;
            IsFilledCheck.CheckedChanged += IsFilledCheck_CheckedChanged;
            // 
            // ShapeComboBox
            // 
            ShapeComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShapeComboBox.FormattingEnabled = true;
            ShapeComboBox.Items.AddRange(new object[] { "Kolečko", "Čtvereček" });
            ShapeComboBox.Location = new Point(12, 10);
            ShapeComboBox.Name = "ShapeComboBox";
            ShapeComboBox.Size = new Size(121, 29);
            ShapeComboBox.TabIndex = 2;
            // 
            // SizeNum
            // 
            SizeNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SizeNum.Location = new Point(528, 10);
            SizeNum.Name = "SizeNum";
            SizeNum.Size = new Size(64, 29);
            SizeNum.TabIndex = 3;
            SizeNum.Value = new decimal(new int[] { 50, 0, 0, 0 });
            SizeNum.ValueChanged += SizeNum_ValueChanged;
            // 
            // CenterCheck
            // 
            CenterCheck.AutoSize = true;
            CenterCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CenterCheck.Location = new Point(705, 11);
            CenterCheck.Name = "CenterCheck";
            CenterCheck.Size = new Size(141, 25);
            CenterCheck.TabIndex = 4;
            CenterCheck.Text = "Vykrestlit středy";
            CenterCheck.UseVisualStyleBackColor = true;
            CenterCheck.CheckedChanged += CenterCheck_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(455, 12);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 5;
            label1.Text = "Velikost:";
            // 
            // canvas1
            // 
            canvas1.BackColor = Color.White;
            canvas1.BorderStyle = BorderStyle.Fixed3D;
            canvas1.Location = new Point(12, 45);
            canvas1.Name = "canvas1";
            canvas1.Size = new Size(1053, 384);
            canvas1.TabIndex = 6;
            canvas1.Paint += canvas1_Paint_1;
            canvas1.MouseClick += canvas1_MouseClick_1;
            // 
            // EnableButton
            // 
            EnableButton.BackColor = SystemColors.Control;
            EnableButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnableButton.Location = new Point(154, 8);
            EnableButton.Name = "EnableButton";
            EnableButton.Size = new Size(83, 31);
            EnableButton.TabIndex = 7;
            EnableButton.Text = "Zapnout";
            EnableButton.UseVisualStyleBackColor = false;
            EnableButton.Click += EnableButton_Click;
            // 
            // DisableButton
            // 
            DisableButton.BackColor = SystemColors.Control;
            DisableButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DisableButton.Location = new Point(256, 8);
            DisableButton.Name = "DisableButton";
            DisableButton.Size = new Size(83, 31);
            DisableButton.TabIndex = 8;
            DisableButton.Text = "Vypnout";
            DisableButton.UseVisualStyleBackColor = false;
            DisableButton.Click += DisableButton_Click;
            // 
            // DecoratorCombo
            // 
            DecoratorCombo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DecoratorCombo.FormattingEnabled = true;
            DecoratorCombo.Items.AddRange(new object[] { "Ohraničení", "Stín", "Ohraničení i Stín", "Nic" });
            DecoratorCombo.Location = new Point(852, 11);
            DecoratorCombo.Name = "DecoratorCombo";
            DecoratorCombo.Size = new Size(213, 29);
            DecoratorCombo.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 443);
            Controls.Add(DecoratorCombo);
            Controls.Add(DisableButton);
            Controls.Add(EnableButton);
            Controls.Add(canvas1);
            Controls.Add(label1);
            Controls.Add(CenterCheck);
            Controls.Add(SizeNum);
            Controls.Add(ShapeComboBox);
            Controls.Add(IsFilledCheck);
            Controls.Add(ColorButton);
            Name = "Form1";
            Text = "FactoryExample";
            ((System.ComponentModel.ISupportInitialize)SizeNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ColorButton;
        private CheckBox IsFilledCheck;
        private ComboBox ShapeComboBox;
        private NumericUpDown SizeNum;
        private CheckBox CenterCheck;
        private Label label1;
        private ColorDialog colorDialog;
        private Canvas canvas1;
        private Button EnableButton;
        private Button DisableButton;
        private ComboBox DecoratorCombo;
    }
}