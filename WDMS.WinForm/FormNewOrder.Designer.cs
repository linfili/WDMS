﻿namespace WDMS.WinForm
{
    partial class FormNewOrder
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxCustomerName = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblRemarkDesc = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.lblWeddingDate = new System.Windows.Forms.Label();
            this.lblWeddingDateDesc = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblMobileDesc = new System.Windows.Forms.Label();
            this.lblCustomerNameDesc = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteOrderDetail = new System.Windows.Forms.Button();
            this.btnModifyOrderDetail = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblOperatorDesc = new System.Windows.Forms.Label();
            this.cmbAssistant = new System.Windows.Forms.ComboBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.lblAssistantDesc = new System.Windows.Forms.Label();
            this.lblOrderMessage = new System.Windows.Forms.Label();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.gridOrderList = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.groupBoxCustomerName.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBoxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxCustomerName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 142);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxCustomerName
            // 
            this.groupBoxCustomerName.Controls.Add(this.panel5);
            this.groupBoxCustomerName.Controls.Add(this.lblRemark);
            this.groupBoxCustomerName.Controls.Add(this.lblRemarkDesc);
            this.groupBoxCustomerName.Controls.Add(this.btnSearchCustomer);
            this.groupBoxCustomerName.Controls.Add(this.lblWeddingDate);
            this.groupBoxCustomerName.Controls.Add(this.lblWeddingDateDesc);
            this.groupBoxCustomerName.Controls.Add(this.lblMobile);
            this.groupBoxCustomerName.Controls.Add(this.lblMobileDesc);
            this.groupBoxCustomerName.Controls.Add(this.lblCustomerNameDesc);
            this.groupBoxCustomerName.Controls.Add(this.lblCustomerName);
            this.groupBoxCustomerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCustomerName.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCustomerName.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.groupBoxCustomerName.Name = "groupBoxCustomerName";
            this.groupBoxCustomerName.Size = new System.Drawing.Size(733, 130);
            this.groupBoxCustomerName.TabIndex = 2;
            this.groupBoxCustomerName.TabStop = false;
            this.groupBoxCustomerName.Text = "客户信息";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(264, 83);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(427, 44);
            this.panel5.TabIndex = 3;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(89, 101);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(31, 13);
            this.lblRemark.TabIndex = 8;
            this.lblRemark.Text = "未知";
            // 
            // lblRemarkDesc
            // 
            this.lblRemarkDesc.AutoSize = true;
            this.lblRemarkDesc.Location = new System.Drawing.Point(15, 101);
            this.lblRemarkDesc.Name = "lblRemarkDesc";
            this.lblRemarkDesc.Size = new System.Drawing.Size(43, 13);
            this.lblRemarkDesc.TabIndex = 7;
            this.lblRemarkDesc.Text = "备注：";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(170, 25);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCustomer.TabIndex = 6;
            this.btnSearchCustomer.Text = "查找";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // lblWeddingDate
            // 
            this.lblWeddingDate.AutoSize = true;
            this.lblWeddingDate.Location = new System.Drawing.Point(446, 67);
            this.lblWeddingDate.Name = "lblWeddingDate";
            this.lblWeddingDate.Size = new System.Drawing.Size(31, 13);
            this.lblWeddingDate.TabIndex = 5;
            this.lblWeddingDate.Text = "未知";
            // 
            // lblWeddingDateDesc
            // 
            this.lblWeddingDateDesc.AutoSize = true;
            this.lblWeddingDateDesc.Location = new System.Drawing.Point(396, 67);
            this.lblWeddingDateDesc.Name = "lblWeddingDateDesc";
            this.lblWeddingDateDesc.Size = new System.Drawing.Size(43, 13);
            this.lblWeddingDateDesc.TabIndex = 4;
            this.lblWeddingDateDesc.Text = "婚期：";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(89, 67);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(31, 13);
            this.lblMobile.TabIndex = 3;
            this.lblMobile.Text = "未知";
            // 
            // lblMobileDesc
            // 
            this.lblMobileDesc.AutoSize = true;
            this.lblMobileDesc.Location = new System.Drawing.Point(15, 67);
            this.lblMobileDesc.Name = "lblMobileDesc";
            this.lblMobileDesc.Size = new System.Drawing.Size(67, 13);
            this.lblMobileDesc.TabIndex = 2;
            this.lblMobileDesc.Text = "联系方式：";
            // 
            // lblCustomerNameDesc
            // 
            this.lblCustomerNameDesc.AutoSize = true;
            this.lblCustomerNameDesc.Location = new System.Drawing.Point(15, 30);
            this.lblCustomerNameDesc.Name = "lblCustomerNameDesc";
            this.lblCustomerNameDesc.Size = new System.Drawing.Size(67, 13);
            this.lblCustomerNameDesc.TabIndex = 0;
            this.lblCustomerNameDesc.Text = "客户名称：";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(89, 30);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(43, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "未指定";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblMessage);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 458);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(733, 39);
            this.panel3.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblMessage.Location = new System.Drawing.Point(15, 17);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDeleteOrderDetail);
            this.panel4.Controls.Add(this.btnModifyOrderDetail);
            this.panel4.Controls.Add(this.btnAddOrder);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(366, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 39);
            this.panel4.TabIndex = 1;
            // 
            // btnDeleteOrderDetail
            // 
            this.btnDeleteOrderDetail.Location = new System.Drawing.Point(274, 6);
            this.btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            this.btnDeleteOrderDetail.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteOrderDetail.TabIndex = 5;
            this.btnDeleteOrderDetail.Text = "删除订单(&D)";
            this.btnDeleteOrderDetail.UseVisualStyleBackColor = true;
            this.btnDeleteOrderDetail.Click += new System.EventHandler(this.btnDeleteOrderDetail_Click);
            // 
            // btnModifyOrderDetail
            // 
            this.btnModifyOrderDetail.Location = new System.Drawing.Point(178, 6);
            this.btnModifyOrderDetail.Name = "btnModifyOrderDetail";
            this.btnModifyOrderDetail.Size = new System.Drawing.Size(79, 23);
            this.btnModifyOrderDetail.TabIndex = 4;
            this.btnModifyOrderDetail.Text = "修改订单(&M)";
            this.btnModifyOrderDetail.UseVisualStyleBackColor = true;
            this.btnModifyOrderDetail.Click += new System.EventHandler(this.btnModifyOrderDetail_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(83, 6);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(83, 23);
            this.btnAddOrder.TabIndex = 3;
            this.btnAddOrder.Text = "添加订单(&A)";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lblOrderMessage);
            this.panel1.Controls.Add(this.groupBoxOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 316);
            this.panel1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblOperatorDesc);
            this.panel6.Controls.Add(this.cmbAssistant);
            this.panel6.Controls.Add(this.cmbOperator);
            this.panel6.Controls.Add(this.lblAssistantDesc);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(347, 263);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(386, 53);
            this.panel6.TabIndex = 1;
            // 
            // lblOperatorDesc
            // 
            this.lblOperatorDesc.AutoSize = true;
            this.lblOperatorDesc.Location = new System.Drawing.Point(18, 16);
            this.lblOperatorDesc.Name = "lblOperatorDesc";
            this.lblOperatorDesc.Size = new System.Drawing.Size(55, 13);
            this.lblOperatorDesc.TabIndex = 2;
            this.lblOperatorDesc.Text = "负责人：";
            // 
            // cmbAssistant
            // 
            this.cmbAssistant.FormattingEnabled = true;
            this.cmbAssistant.Location = new System.Drawing.Point(255, 13);
            this.cmbAssistant.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.cmbAssistant.Name = "cmbAssistant";
            this.cmbAssistant.Size = new System.Drawing.Size(121, 21);
            this.cmbAssistant.TabIndex = 1;
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(79, 13);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(121, 21);
            this.cmbOperator.TabIndex = 1;
            // 
            // lblAssistantDesc
            // 
            this.lblAssistantDesc.AutoSize = true;
            this.lblAssistantDesc.Location = new System.Drawing.Point(206, 16);
            this.lblAssistantDesc.Name = "lblAssistantDesc";
            this.lblAssistantDesc.Size = new System.Drawing.Size(43, 13);
            this.lblAssistantDesc.TabIndex = 2;
            this.lblAssistantDesc.Text = "助理：";
            // 
            // lblOrderMessage
            // 
            this.lblOrderMessage.AutoSize = true;
            this.lblOrderMessage.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblOrderMessage.Location = new System.Drawing.Point(37, 287);
            this.lblOrderMessage.Name = "lblOrderMessage";
            this.lblOrderMessage.Size = new System.Drawing.Size(0, 13);
            this.lblOrderMessage.TabIndex = 0;
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.gridOrderList);
            this.groupBoxOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxOrder.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(733, 263);
            this.groupBoxOrder.TabIndex = 0;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "订单列表";
            // 
            // gridOrderList
            // 
            this.gridOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrderList.Location = new System.Drawing.Point(3, 16);
            this.gridOrderList.Name = "gridOrderList";
            this.gridOrderList.Size = new System.Drawing.Size(727, 244);
            this.gridOrderList.TabIndex = 0;
            // 
            // FormNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormNewOrder";
            this.Text = "新建订单";
            this.panel2.ResumeLayout(false);
            this.groupBoxCustomerName.ResumeLayout(false);
            this.groupBoxCustomerName.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBoxOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBoxCustomerName;
        private System.Windows.Forms.Label lblMobileDesc;
        private System.Windows.Forms.Label lblCustomerNameDesc;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblWeddingDateDesc;
        private System.Windows.Forms.Label lblWeddingDate;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblRemarkDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.Label lblAssistantDesc;
        private System.Windows.Forms.ComboBox cmbAssistant;
        private System.Windows.Forms.Label lblOperatorDesc;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Label lblOrderMessage;
        private System.Windows.Forms.DataGridView gridOrderList;
        private System.Windows.Forms.Button btnDeleteOrderDetail;
        private System.Windows.Forms.Button btnModifyOrderDetail;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}