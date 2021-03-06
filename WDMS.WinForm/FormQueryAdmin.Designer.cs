﻿namespace WDMS.WinForm
{
    partial class FormQueryAdmin
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.gridAdmin = new System.Windows.Forms.DataGridView();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdmin)).BeginInit();
            this.panelMessage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名：";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(75, 11);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(239, 20);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(446, 8);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 25);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查找(&S)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // gridAdmin
            // 
            this.gridAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAdmin.Location = new System.Drawing.Point(12, 59);
            this.gridAdmin.Name = "gridAdmin";
            this.gridAdmin.RowTemplate.Height = 23;
            this.gridAdmin.Size = new System.Drawing.Size(514, 261);
            this.gridAdmin.TabIndex = 3;
            // 
            // panelMessage
            // 
            this.panelMessage.Controls.Add(this.panel2);
            this.panelMessage.Controls.Add(this.panel1);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMessage.Location = new System.Drawing.Point(0, 336);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(538, 48);
            this.panelMessage.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddAdmin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(410, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 35);
            this.panel2.TabIndex = 2;
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAdmin.Location = new System.Drawing.Point(36, 4);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAddAdmin.TabIndex = 1;
            this.btnAddAdmin.Text = "添加管理员";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 48);
            this.panel1.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblMessage.Location = new System.Drawing.Point(4, 22);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 0;
            // 
            // FormQueryAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 384);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.gridAdmin);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.lblName);
            this.Name = "FormQueryAdmin";
            this.Text = "管理员信息查询";
            ((System.ComponentModel.ISupportInitialize)(this.gridAdmin)).EndInit();
            this.panelMessage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView gridAdmin;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddAdmin;
    }
}