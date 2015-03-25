﻿namespace ThetaMessager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pbEditMap = new System.Windows.Forms.PictureBox();
            this.pbControlMap = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.miSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpControl = new System.Windows.Forms.TabPage();
            this.tpMapEdit = new System.Windows.Forms.TabPage();
            this.cmStripMapEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbControlMap)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.tpMapEdit.SuspendLayout();
            this.cmStripMapEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 534);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 573);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pbEditMap
            // 
            this.pbEditMap.Image = global::ThetaMessager.Properties.Resources.map;
            this.pbEditMap.Location = new System.Drawing.Point(-4, 0);
            this.pbEditMap.Name = "pbEditMap";
            this.pbEditMap.Size = new System.Drawing.Size(600, 431);
            this.pbEditMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEditMap.TabIndex = 0;
            this.pbEditMap.TabStop = false;
            this.pbEditMap.Click += new System.EventHandler(this.pbEditMap_Click);
            // 
            // pbControlMap
            // 
            this.pbControlMap.Image = ((System.Drawing.Image)(resources.GetObject("pbControlMap.Image")));
            this.pbControlMap.Location = new System.Drawing.Point(-4, 0);
            this.pbControlMap.Name = "pbControlMap";
            this.pbControlMap.Size = new System.Drawing.Size(600, 431);
            this.pbControlMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbControlMap.TabIndex = 0;
            this.pbControlMap.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.AllowMerge = false;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSystem,
            this.miFunction});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1026, 25);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // miSystem
            // 
            this.miSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.miSystem.Name = "miSystem";
            this.miSystem.Size = new System.Drawing.Size(44, 21);
            this.miSystem.Text = "系统";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(100, 22);
            this.miExit.Text = "退出";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miFunction
            // 
            this.miFunction.Name = "miFunction";
            this.miFunction.Size = new System.Drawing.Size(44, 21);
            this.miFunction.Text = "功能";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpControl);
            this.tcMain.Controls.Add(this.tpMapEdit);
            this.tcMain.Location = new System.Drawing.Point(12, 28);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(877, 487);
            this.tcMain.TabIndex = 7;
            // 
            // tpControl
            // 
            this.tpControl.Controls.Add(this.pbControlMap);
            this.tpControl.Location = new System.Drawing.Point(4, 22);
            this.tpControl.Name = "tpControl";
            this.tpControl.Padding = new System.Windows.Forms.Padding(3);
            this.tpControl.Size = new System.Drawing.Size(869, 461);
            this.tpControl.TabIndex = 0;
            this.tpControl.Text = "控制中心";
            this.tpControl.UseVisualStyleBackColor = true;
            // 
            // tpMapEdit
            // 
            this.tpMapEdit.Controls.Add(this.pbEditMap);
            this.tpMapEdit.Location = new System.Drawing.Point(4, 22);
            this.tpMapEdit.Name = "tpMapEdit";
            this.tpMapEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpMapEdit.Size = new System.Drawing.Size(869, 461);
            this.tpMapEdit.TabIndex = 1;
            this.tpMapEdit.Text = "节点编辑";
            this.tpMapEdit.UseVisualStyleBackColor = true;
            // 
            // cmStripMapEdit
            // 
            this.cmStripMapEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiAdd,
            this.cmiEdit});
            this.cmStripMapEdit.Name = "cmStripMapEdit";
            this.cmStripMapEdit.Size = new System.Drawing.Size(153, 70);
            // 
            // cmiAdd
            // 
            this.cmiAdd.Name = "cmiAdd";
            this.cmiAdd.Size = new System.Drawing.Size(152, 22);
            this.cmiAdd.Text = "新增节点";
            this.cmiAdd.Click += new System.EventHandler(this.cmiAdd_Click);
            // 
            // cmiEdit
            // 
            this.cmiEdit.Name = "cmiEdit";
            this.cmiEdit.Size = new System.Drawing.Size(152, 22);
            this.cmiEdit.Text = "编辑节点";
            this.cmiEdit.Click += new System.EventHandler(this.cmiEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 611);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Theta Messager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEditMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbControlMap)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.tpControl.PerformLayout();
            this.tpMapEdit.ResumeLayout(false);
            this.tpMapEdit.PerformLayout();
            this.cmStripMapEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pbControlMap;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem miSystem;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miFunction;
        private System.Windows.Forms.PictureBox pbEditMap;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpControl;
        private System.Windows.Forms.TabPage tpMapEdit;
        private System.Windows.Forms.ContextMenuStrip cmStripMapEdit;
        private System.Windows.Forms.ToolStripMenuItem cmiAdd;
        private System.Windows.Forms.ToolStripMenuItem cmiEdit;

    }
}
