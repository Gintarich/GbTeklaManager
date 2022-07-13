namespace GbTeklaManager
{
    partial class TeklaManager
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCommands = new System.Windows.Forms.TabPage();
            this.groupCreateCuts = new System.Windows.Forms.GroupBox();
            this.buttonCreateCuts = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupRounding = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tbCutObjName = new System.Windows.Forms.TextBox();
            this.tbOffset = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOffset = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabCommands.SuspendLayout();
            this.groupCreateCuts.SuspendLayout();
            this.groupRounding.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCommands);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(972, 559);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // tabCommands
            // 
            this.tabCommands.BackColor = System.Drawing.SystemColors.Control;
            this.tabCommands.Controls.Add(this.button3);
            this.tabCommands.Controls.Add(this.groupCreateCuts);
            this.tabCommands.Controls.Add(this.vScrollBar1);
            this.tabCommands.Controls.Add(this.groupRounding);
            this.tabCommands.Location = new System.Drawing.Point(4, 22);
            this.tabCommands.Name = "tabCommands";
            this.tabCommands.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommands.Size = new System.Drawing.Size(964, 533);
            this.tabCommands.TabIndex = 0;
            this.tabCommands.Text = "Commands";
            // 
            // groupCreateCuts
            // 
            this.groupCreateCuts.Controls.Add(this.labelOffset);
            this.groupCreateCuts.Controls.Add(this.labelName);
            this.groupCreateCuts.Controls.Add(this.tbOffset);
            this.groupCreateCuts.Controls.Add(this.tbCutObjName);
            this.groupCreateCuts.Controls.Add(this.button2);
            this.groupCreateCuts.Controls.Add(this.buttonCreateCuts);
            this.groupCreateCuts.Location = new System.Drawing.Point(3, 88);
            this.groupCreateCuts.Name = "groupCreateCuts";
            this.groupCreateCuts.Size = new System.Drawing.Size(382, 81);
            this.groupCreateCuts.TabIndex = 3;
            this.groupCreateCuts.TabStop = false;
            this.groupCreateCuts.Text = "CreateCuts";
            // 
            // buttonCreateCuts
            // 
            this.buttonCreateCuts.Location = new System.Drawing.Point(259, 28);
            this.buttonCreateCuts.MaximumSize = new System.Drawing.Size(0, 30);
            this.buttonCreateCuts.Name = "buttonCreateCuts";
            this.buttonCreateCuts.Size = new System.Drawing.Size(0, 30);
            this.buttonCreateCuts.TabIndex = 0;
            this.buttonCreateCuts.Text = "CreateCuts";
            this.buttonCreateCuts.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(938, 3);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(23, 527);
            this.vScrollBar1.TabIndex = 2;
            // 
            // groupRounding
            // 
            this.groupRounding.Controls.Add(this.checkBox1);
            this.groupRounding.Controls.Add(this.button1);
            this.groupRounding.Location = new System.Drawing.Point(3, 3);
            this.groupRounding.Name = "groupRounding";
            this.groupRounding.Size = new System.Drawing.Size(382, 79);
            this.groupRounding.TabIndex = 0;
            this.groupRounding.TabStop = false;
            this.groupRounding.Text = "RoundingCommands";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(259, 16);
            this.button1.MaximumSize = new System.Drawing.Size(120, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbCutObjName
            // 
            this.tbCutObjName.Location = new System.Drawing.Point(6, 19);
            this.tbCutObjName.Name = "tbCutObjName";
            this.tbCutObjName.Size = new System.Drawing.Size(100, 20);
            this.tbCutObjName.TabIndex = 4;
            // 
            // tbOffset
            // 
            this.tbOffset.Location = new System.Drawing.Point(6, 45);
            this.tbOffset.Name = "tbOffset";
            this.tbOffset.Size = new System.Drawing.Size(100, 20);
            this.tbOffset.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(112, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelOffset
            // 
            this.labelOffset.AutoSize = true;
            this.labelOffset.Location = new System.Drawing.Point(112, 48);
            this.labelOffset.Name = "labelOffset";
            this.labelOffset.Size = new System.Drawing.Size(35, 13);
            this.labelOffset.TabIndex = 6;
            this.labelOffset.Text = "Offset";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TeklaManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 559);
            this.Controls.Add(this.tabControl);
            this.Name = "TeklaManager";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabCommands.ResumeLayout(false);
            this.groupCreateCuts.ResumeLayout(false);
            this.groupCreateCuts.PerformLayout();
            this.groupRounding.ResumeLayout(false);
            this.groupRounding.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCommands;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupRounding;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupCreateCuts;
        private System.Windows.Forms.Button buttonCreateCuts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbCutObjName;
        private System.Windows.Forms.Label labelOffset;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox tbOffset;
        private System.Windows.Forms.Button button3;
    }
}

