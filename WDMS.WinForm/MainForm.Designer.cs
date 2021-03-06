﻿namespace WDMS.WinForm
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
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysconfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabCtrlToDelivery = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridToDelivery = new System.Windows.Forms.DataGridView();
            this.lblToDeliveryDesc = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStripMainForm.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tabCtrlToDelivery.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridToDelivery)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.styleToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.sysconfigToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Size = new System.Drawing.Size(826, 24);
            this.menuStripMainForm.TabIndex = 0;
            this.menuStripMainForm.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.menuToolStripMenuItem.Text = "菜单(&F)";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.summaryToolStripMenuItem.Text = "总览(&F)";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerSearchToolStripMenuItem,
            this.queryCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.customerToolStripMenuItem.Text = "客户(&C)";
            // 
            // newCustomerSearchToolStripMenuItem
            // 
            this.newCustomerSearchToolStripMenuItem.Name = "newCustomerSearchToolStripMenuItem";
            this.newCustomerSearchToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.newCustomerSearchToolStripMenuItem.Text = "新增客户";
            this.newCustomerSearchToolStripMenuItem.Click += new System.EventHandler(this.newCustomerSearchToolStripMenuItem_Click);
            // 
            // queryCustomerToolStripMenuItem
            // 
            this.queryCustomerToolStripMenuItem.Name = "queryCustomerToolStripMenuItem";
            this.queryCustomerToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.queryCustomerToolStripMenuItem.Text = "客户查询";
            this.queryCustomerToolStripMenuItem.Click += new System.EventHandler(this.queryCustomerToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.queryOrderToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.orderToolStripMenuItem.Text = "订单(&O)";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.newOrderToolStripMenuItem.Text = "新建订单";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // queryOrderToolStripMenuItem
            // 
            this.queryOrderToolStripMenuItem.Name = "queryOrderToolStripMenuItem";
            this.queryOrderToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.queryOrderToolStripMenuItem.Text = "订单查询";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStyleToolStripMenuItem,
            this.queryStyleToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.styleToolStripMenuItem.Text = "款式(&S)";
            // 
            // newStyleToolStripMenuItem
            // 
            this.newStyleToolStripMenuItem.Name = "newStyleToolStripMenuItem";
            this.newStyleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.newStyleToolStripMenuItem.Text = "新建款式";
            this.newStyleToolStripMenuItem.Click += new System.EventHandler(this.newStyleToolStripMenuItem_Click);
            // 
            // queryStyleToolStripMenuItem
            // 
            this.queryStyleToolStripMenuItem.Name = "queryStyleToolStripMenuItem";
            this.queryStyleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.queryStyleToolStripMenuItem.Text = "款式查询";
            this.queryStyleToolStripMenuItem.Click += new System.EventHandler(this.queryStyleToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newInventoryToolStripMenuItem,
            this.queryInventoryToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.inventoryToolStripMenuItem.Text = "库存(&I)";
            // 
            // newInventoryToolStripMenuItem
            // 
            this.newInventoryToolStripMenuItem.Name = "newInventoryToolStripMenuItem";
            this.newInventoryToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.newInventoryToolStripMenuItem.Text = "新增库存";
            this.newInventoryToolStripMenuItem.Click += new System.EventHandler(this.newInventoryToolStripMenuItem_Click);
            // 
            // queryInventoryToolStripMenuItem
            // 
            this.queryInventoryToolStripMenuItem.Name = "queryInventoryToolStripMenuItem";
            this.queryInventoryToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.queryInventoryToolStripMenuItem.Text = "库存查询";
            this.queryInventoryToolStripMenuItem.Click += new System.EventHandler(this.queryInventoryToolStripMenuItem_Click);
            // 
            // sysconfigToolStripMenuItem
            // 
            this.sysconfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminConfigToolStripMenuItem,
            this.ParamConfigToolStripMenuItem});
            this.sysconfigToolStripMenuItem.Name = "sysconfigToolStripMenuItem";
            this.sysconfigToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.sysconfigToolStripMenuItem.Text = "配置(&G)";
            // 
            // adminConfigToolStripMenuItem
            // 
            this.adminConfigToolStripMenuItem.Name = "adminConfigToolStripMenuItem";
            this.adminConfigToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.adminConfigToolStripMenuItem.Text = "管理员";
            this.adminConfigToolStripMenuItem.Click += new System.EventHandler(this.adminConfigToolStripMenuItem_Click);
            // 
            // ParamConfigToolStripMenuItem
            // 
            this.ParamConfigToolStripMenuItem.Name = "ParamConfigToolStripMenuItem";
            this.ParamConfigToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ParamConfigToolStripMenuItem.Text = "参数设置";
            this.ParamConfigToolStripMenuItem.Click += new System.EventHandler(this.ParamConfigToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "关于(&A)";
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.tabCtrlToDelivery);
            this.panelMain.Location = new System.Drawing.Point(12, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(802, 528);
            this.panelMain.TabIndex = 1;
            // 
            // tabCtrlToDelivery
            // 
            this.tabCtrlToDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrlToDelivery.Controls.Add(this.tabPage1);
            this.tabCtrlToDelivery.Controls.Add(this.tabPage2);
            this.tabCtrlToDelivery.Controls.Add(this.tabPage3);
            this.tabCtrlToDelivery.Location = new System.Drawing.Point(3, 3);
            this.tabCtrlToDelivery.Name = "tabCtrlToDelivery";
            this.tabCtrlToDelivery.SelectedIndex = 0;
            this.tabCtrlToDelivery.Size = new System.Drawing.Size(796, 522);
            this.tabCtrlToDelivery.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridToDelivery);
            this.tabPage1.Controls.Add(this.lblToDeliveryDesc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "待发件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridToDelivery
            // 
            this.gridToDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridToDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridToDelivery.Location = new System.Drawing.Point(6, 31);
            this.gridToDelivery.Name = "gridToDelivery";
            this.gridToDelivery.RowTemplate.Height = 23;
            this.gridToDelivery.Size = new System.Drawing.Size(776, 459);
            this.gridToDelivery.TabIndex = 1;
            this.gridToDelivery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridToDelivery_CellClick);
            // 
            // lblToDeliveryDesc
            // 
            this.lblToDeliveryDesc.AutoSize = true;
            this.lblToDeliveryDesc.Location = new System.Drawing.Point(6, 15);
            this.lblToDeliveryDesc.Name = "lblToDeliveryDesc";
            this.lblToDeliveryDesc.Size = new System.Drawing.Size(73, 13);
            this.lblToDeliveryDesc.TabIndex = 0;
            this.lblToDeliveryDesc.Text = "7日内待发件";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "已发件";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(788, 496);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "待收回";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(137, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "刷新(&F)";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 564);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 48);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelivery);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(575, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 48);
            this.panel2.TabIndex = 3;
            // 
            // btnDelivery
            // 
            this.btnDelivery.Location = new System.Drawing.Point(15, 13);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(53, 23);
            this.btnDelivery.TabIndex = 3;
            this.btnDelivery.Text = "发件(&S)";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStripMainForm);
            this.MainMenuStrip = this.menuStripMainForm;
            this.Name = "MainForm";
            this.Text = "WDMS";
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.tabCtrlToDelivery.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridToDelivery)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sysconfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryInventoryToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblToDeliveryDesc;
        private System.Windows.Forms.TabControl tabCtrlToDelivery;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridToDelivery;
        private System.Windows.Forms.ToolStripMenuItem adminConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParamConfigToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

