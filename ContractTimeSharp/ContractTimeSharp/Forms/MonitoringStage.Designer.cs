namespace ContractTimeSharp.Forms
{
    partial class MonitoringStage
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
            this.tabMonitor = new System.Windows.Forms.TabControl();
            this.tabDate = new System.Windows.Forms.TabPage();
            this.gridProject = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFilter = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.butnShow = new System.Windows.Forms.Button();
            this.btnSendDay = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbPlan = new System.Windows.Forms.RadioButton();
            this.rbProg = new System.Windows.Forms.RadioButton();
            this.rbNot = new System.Windows.Forms.RadioButton();
            this.tabTree = new System.Windows.Forms.TabPage();
            this.treeViewProject = new System.Windows.Forms.TreeView();
            this.treeProject = new Aga.Controls.Tree.TreeViewAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.sendMessage = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMonitor.SuspendLayout();
            this.tabDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProject)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabTree.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMonitor
            // 
            this.tabMonitor.Controls.Add(this.tabDate);
            this.tabMonitor.Controls.Add(this.tabTree);
            this.tabMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMonitor.Location = new System.Drawing.Point(0, 0);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.SelectedIndex = 0;
            this.tabMonitor.Size = new System.Drawing.Size(1075, 647);
            this.tabMonitor.TabIndex = 0;
            // 
            // tabDate
            // 
            this.tabDate.Controls.Add(this.gridProject);
            this.tabDate.Controls.Add(this.panel1);
            this.tabDate.Location = new System.Drawing.Point(4, 22);
            this.tabDate.Name = "tabDate";
            this.tabDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabDate.Size = new System.Drawing.Size(1067, 621);
            this.tabDate.TabIndex = 0;
            this.tabDate.Text = "На дату";
            this.tabDate.UseVisualStyleBackColor = true;
            // 
            // gridProject
            // 
            this.gridProject.AllowUserToAddRows = false;
            this.gridProject.AllowUserToDeleteRows = false;
            this.gridProject.AllowUserToOrderColumns = true;
            this.gridProject.AllowUserToResizeRows = false;
            this.gridProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProject.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProject.ContextMenuStrip = this.contextMenuStrip1;
            this.gridProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProject.Location = new System.Drawing.Point(3, 68);
            this.gridProject.MultiSelect = false;
            this.gridProject.Name = "gridProject";
            this.gridProject.ReadOnly = true;
            this.gridProject.RowHeadersVisible = false;
            this.gridProject.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProject.ShowEditingIcon = false;
            this.gridProject.Size = new System.Drawing.Size(1061, 550);
            this.gridProject.TabIndex = 3;
            this.gridProject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridProject_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 65);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.labelFilter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.butnShow, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSendDay, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1061, 65);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(3, 0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(103, 13);
            this.labelFilter.TabIndex = 0;
            this.labelFilter.Text = "Дата начала этапа";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(356, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // butnShow
            // 
            this.butnShow.Location = new System.Drawing.Point(709, 3);
            this.butnShow.Name = "butnShow";
            this.butnShow.Size = new System.Drawing.Size(145, 22);
            this.butnShow.TabIndex = 2;
            this.butnShow.Text = "Показать";
            this.butnShow.UseVisualStyleBackColor = true;
            this.butnShow.Click += new System.EventHandler(this.butnShow_Click);
            // 
            // btnSendDay
            // 
            this.btnSendDay.Location = new System.Drawing.Point(709, 35);
            this.btnSendDay.Name = "btnSendDay";
            this.btnSendDay.Size = new System.Drawing.Size(145, 22);
            this.btnSendDay.TabIndex = 3;
            this.btnSendDay.Text = "Отправить уведомления";
            this.btnSendDay.UseVisualStyleBackColor = true;
            this.btnSendDay.Click += new System.EventHandler(this.btnSendDay_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbPlan);
            this.flowLayoutPanel1.Controls.Add(this.rbProg);
            this.flowLayoutPanel1.Controls.Add(this.rbNot);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(356, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(347, 27);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // rbPlan
            // 
            this.rbPlan.AutoSize = true;
            this.rbPlan.Checked = true;
            this.rbPlan.Location = new System.Drawing.Point(3, 3);
            this.rbPlan.Name = "rbPlan";
            this.rbPlan.Size = new System.Drawing.Size(51, 17);
            this.rbPlan.TabIndex = 0;
            this.rbPlan.TabStop = true;
            this.rbPlan.Text = "План";
            this.rbPlan.UseVisualStyleBackColor = true;
            // 
            // rbProg
            // 
            this.rbProg.AutoSize = true;
            this.rbProg.Location = new System.Drawing.Point(60, 3);
            this.rbProg.Name = "rbProg";
            this.rbProg.Size = new System.Drawing.Size(68, 17);
            this.rbProg.TabIndex = 1;
            this.rbProg.Text = "Прогноз";
            this.rbProg.UseVisualStyleBackColor = true;
            // 
            // rbNot
            // 
            this.rbNot.AutoSize = true;
            this.rbNot.Location = new System.Drawing.Point(134, 3);
            this.rbNot.Name = "rbNot";
            this.rbNot.Size = new System.Drawing.Size(100, 17);
            this.rbNot.TabIndex = 2;
            this.rbNot.TabStop = true;
            this.rbNot.Text = "Просроченные";
            this.rbNot.UseVisualStyleBackColor = true;
            // 
            // tabTree
            // 
            this.tabTree.Controls.Add(this.treeViewProject);
            this.tabTree.Controls.Add(this.treeProject);
            this.tabTree.Controls.Add(this.panel2);
            this.tabTree.Location = new System.Drawing.Point(4, 22);
            this.tabTree.Name = "tabTree";
            this.tabTree.Padding = new System.Windows.Forms.Padding(3);
            this.tabTree.Size = new System.Drawing.Size(1067, 621);
            this.tabTree.TabIndex = 1;
            this.tabTree.Text = "Дерево проектов";
            this.tabTree.UseVisualStyleBackColor = true;
            // 
            // treeViewProject
            // 
            this.treeViewProject.CheckBoxes = true;
            this.treeViewProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewProject.FullRowSelect = true;
            this.treeViewProject.HotTracking = true;
            this.treeViewProject.Location = new System.Drawing.Point(3, 45);
            this.treeViewProject.Name = "treeViewProject";
            this.treeViewProject.Size = new System.Drawing.Size(1061, 573);
            this.treeViewProject.TabIndex = 8;
            this.treeViewProject.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewProject_AfterCheck);
            // 
            // treeProject
            // 
            this.treeProject.BackColor = System.Drawing.SystemColors.Window;
            this.treeProject.DefaultToolTipProvider = null;
            this.treeProject.DragDropMarkColor = System.Drawing.Color.Black;
            this.treeProject.FullRowSelect = true;
            this.treeProject.GridLineStyle = ((Aga.Controls.Tree.GridLineStyle)((Aga.Controls.Tree.GridLineStyle.Horizontal | Aga.Controls.Tree.GridLineStyle.Vertical)));
            this.treeProject.LineColor = System.Drawing.Color.Black;
            this.treeProject.Location = new System.Drawing.Point(603, 294);
            this.treeProject.Model = null;
            this.treeProject.Name = "treeProject";
            this.treeProject.RowHeight = 20;
            this.treeProject.SelectedNode = null;
            this.treeProject.Size = new System.Drawing.Size(109, 96);
            this.treeProject.TabIndex = 7;
            this.treeProject.Text = "treeViewAdv1";
            this.treeProject.UseColumns = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.sendMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 42);
            this.panel2.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.Location = new System.Drawing.Point(911, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 42);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // sendMessage
            // 
            this.sendMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendMessage.Location = new System.Drawing.Point(986, 0);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(75, 42);
            this.sendMessage.TabIndex = 0;
            this.sendMessage.Text = "Отправить письма";
            this.sendMessage.UseVisualStyleBackColor = true;
            this.sendMessage.Click += new System.EventHandler(this.sendMessage_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExcel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 26);
            // 
            // mnuExcel
            // 
            this.mnuExcel.Name = "mnuExcel";
            this.mnuExcel.Size = new System.Drawing.Size(168, 22);
            this.mnuExcel.Text = "выгрузить в Excel";
            this.mnuExcel.Click += new System.EventHandler(this.mnuExcel_Click);
            // 
            // MonitoringStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 647);
            this.Controls.Add(this.tabMonitor);
            this.Name = "MonitoringStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система \"Букля\" - Этапы проекта по дате";
            this.Load += new System.EventHandler(this.MonitoringStage_Load);
            this.tabMonitor.ResumeLayout(false);
            this.tabDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProject)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabTree.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMonitor;
        private System.Windows.Forms.TabPage tabDate;
        private System.Windows.Forms.TabPage tabTree;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butnShow;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridProject;
        private Aga.Controls.Tree.TreeViewAdv treeProject;
        private System.Windows.Forms.TreeView treeViewProject;
        private System.Windows.Forms.Button sendMessage;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSendDay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbPlan;
        private System.Windows.Forms.RadioButton rbProg;
        private System.Windows.Forms.RadioButton rbNot;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuExcel;
    }
}