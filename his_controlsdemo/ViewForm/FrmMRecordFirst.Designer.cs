﻿namespace TestControls
{
    partial class FrmMRecordFirst
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnGetJson = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.txtJsonData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mRecordFirstBrower1 = new MRecordFirst.Controls.MRecordFirstBrower();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnGetJson);
            this.panel1.Controls.Add(this.btnRef);
            this.panel1.Controls.Add(this.txtJsonData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(481, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 471);
            this.panel1.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(8, 29);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnGetJson
            // 
            this.btnGetJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetJson.Location = new System.Drawing.Point(89, 29);
            this.btnGetJson.Name = "btnGetJson";
            this.btnGetJson.Size = new System.Drawing.Size(75, 23);
            this.btnGetJson.TabIndex = 7;
            this.btnGetJson.Text = "获取数据";
            this.btnGetJson.UseVisualStyleBackColor = true;
            this.btnGetJson.Click += new System.EventHandler(this.btnGetJson_Click);
            // 
            // btnRef
            // 
            this.btnRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRef.Location = new System.Drawing.Point(170, 29);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(75, 23);
            this.btnRef.TabIndex = 6;
            this.btnRef.Text = "刷新";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // txtJsonData
            // 
            this.txtJsonData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJsonData.Location = new System.Drawing.Point(4, 58);
            this.txtJsonData.Multiline = true;
            this.txtJsonData.Name = "txtJsonData";
            this.txtJsonData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJsonData.Size = new System.Drawing.Size(241, 410);
            this.txtJsonData.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入测试Json数据：";
            // 
            // mRecordFirstBrower1
            // 
            this.mRecordFirstBrower1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mRecordFirstBrower1.IsContextMenuShow = true;
            this.mRecordFirstBrower1.Location = new System.Drawing.Point(0, 0);
            this.mRecordFirstBrower1.Name = "mRecordFirstBrower1";
            this.mRecordFirstBrower1.Size = new System.Drawing.Size(481, 471);
            this.mRecordFirstBrower1.TabIndex = 2;
            // 
            // FrmMRecordFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 471);
            this.Controls.Add(this.mRecordFirstBrower1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMRecordFirst";
            this.Text = "FrmMRecordFirst";
            this.Load += new System.EventHandler(this.FrmMRecordFirst_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnGetJson;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.TextBox txtJsonData;
        private System.Windows.Forms.Label label1;
        private MRecordFirst.Controls.MRecordFirstBrower mRecordFirstBrower1;

    }
}