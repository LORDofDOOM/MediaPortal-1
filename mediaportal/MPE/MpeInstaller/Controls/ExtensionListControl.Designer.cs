﻿namespace MpeInstaller.Controls
{
    partial class ExtensionListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.panelTop = new System.Windows.Forms.Panel();
      this.panelTop.SuspendLayout();
      this.SuspendLayout();
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.AutoScroll = true;
      this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
      this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 36);
      this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(721, 528);
      this.flowLayoutPanel1.TabIndex = 0;
      this.flowLayoutPanel1.WrapContents = false;
      this.flowLayoutPanel1.SizeChanged += new System.EventHandler(this.flowLayoutPanel1_SizeChanged);
      this.flowLayoutPanel1.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(417, 6);
      this.textBox1.Margin = new System.Windows.Forms.Padding(4);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(298, 22);
      this.textBox1.TabIndex = 1;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(356, 8);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "Search";
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(48, 5);
      this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(302, 24);
      this.comboBox1.TabIndex = 3;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(4, 8);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 17);
      this.label2.TabIndex = 4;
      this.label2.Text = "Tags";
      // 
      // panelTop
      // 
      this.panelTop.Controls.Add(this.comboBox1);
      this.panelTop.Controls.Add(this.label2);
      this.panelTop.Controls.Add(this.textBox1);
      this.panelTop.Controls.Add(this.label1);
      this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTop.Location = new System.Drawing.Point(0, 0);
      this.panelTop.Name = "panelTop";
      this.panelTop.Size = new System.Drawing.Size(721, 36);
      this.panelTop.TabIndex = 5;
      // 
      // ExtensionListControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoSize = true;
      this.Controls.Add(this.flowLayoutPanel1);
      this.Controls.Add(this.panelTop);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "ExtensionListControl";
      this.Size = new System.Drawing.Size(721, 564);
      this.panelTop.ResumeLayout(false);
      this.panelTop.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panelTop;
    }
}
