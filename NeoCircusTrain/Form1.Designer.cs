namespace NeoCircusTrain
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
            CBOXLarge = new CheckBox();
            CBOXMedium = new CheckBox();
            CBOXSmall = new CheckBox();
            CBOXCarnivore = new CheckBox();
            BTNAdd = new Button();
            AnimalsOverview = new ListBox();
            SuspendLayout();
            // 
            // CBOXLarge
            // 
            CBOXLarge.AutoSize = true;
            CBOXLarge.Location = new Point(435, 41);
            CBOXLarge.Name = "CBOXLarge";
            CBOXLarge.Size = new Size(68, 24);
            CBOXLarge.TabIndex = 0;
            CBOXLarge.Text = "Large";
            CBOXLarge.UseVisualStyleBackColor = true;
            CBOXLarge.CheckedChanged += CBOXLarge_CheckedChanged;
            // 
            // CBOXMedium
            // 
            CBOXMedium.AutoSize = true;
            CBOXMedium.Location = new Point(323, 41);
            CBOXMedium.Name = "CBOXMedium";
            CBOXMedium.Size = new Size(86, 24);
            CBOXMedium.TabIndex = 1;
            CBOXMedium.Text = "Medium";
            CBOXMedium.UseVisualStyleBackColor = true;
            CBOXMedium.CheckedChanged += CBOXMedium_CheckedChanged;
            // 
            // CBOXSmall
            // 
            CBOXSmall.AutoSize = true;
            CBOXSmall.Location = new Point(224, 41);
            CBOXSmall.Name = "CBOXSmall";
            CBOXSmall.Size = new Size(68, 24);
            CBOXSmall.TabIndex = 2;
            CBOXSmall.Text = "Small";
            CBOXSmall.UseVisualStyleBackColor = true;
            CBOXSmall.CheckedChanged += CBOXSmall_CheckedChanged;
            // 
            // CBOXCarnivore
            // 
            CBOXCarnivore.AutoSize = true;
            CBOXCarnivore.Location = new Point(323, 82);
            CBOXCarnivore.Name = "CBOXCarnivore";
            CBOXCarnivore.Size = new Size(94, 24);
            CBOXCarnivore.TabIndex = 3;
            CBOXCarnivore.Text = "Carnivore";
            CBOXCarnivore.UseVisualStyleBackColor = true;
            // 
            // BTNAdd
            // 
            BTNAdd.Location = new Point(323, 122);
            BTNAdd.Name = "BTNAdd";
            BTNAdd.Size = new Size(94, 29);
            BTNAdd.TabIndex = 4;
            BTNAdd.Text = "Add";
            BTNAdd.UseVisualStyleBackColor = true;
            BTNAdd.Click += BTNAdd_Click;
            // 
            // AnimalsOverview
            // 
            AnimalsOverview.FormattingEnabled = true;
            AnimalsOverview.Location = new Point(575, 25);
            AnimalsOverview.Name = "AnimalsOverview";
            AnimalsOverview.Size = new Size(554, 404);
            AnimalsOverview.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 450);
            Controls.Add(AnimalsOverview);
            Controls.Add(BTNAdd);
            Controls.Add(CBOXCarnivore);
            Controls.Add(CBOXSmall);
            Controls.Add(CBOXMedium);
            Controls.Add(CBOXLarge);
            Name = "Form1";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox CBOXLarge;
        private CheckBox CBOXMedium;
        private CheckBox CBOXSmall;
        private CheckBox CBOXCarnivore;
        private Button BTNAdd;
        private ListBox AnimalsOverview;
    }
}
