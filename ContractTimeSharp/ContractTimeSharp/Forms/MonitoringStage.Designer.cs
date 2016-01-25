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
            this.tabMonitor = new System.Windows.Forms.TabControl();
            this.tabDate = new System.Windows.Forms.TabPage();
            this.tabTree = new System.Windows.Forms.TabPage();
            this.dataStage = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFilter = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.butnShow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeProject = new Aga.Controls.Tree.TreeViewAdv();
            this.treeViewProject = new System.Windows.Forms.TreeView();
            this.sendMessage = new System.Windows.Forms.Button();
            this.tabMonitor.SuspendLayout();
            this.tabDate.SuspendLayout();
            this.tabTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStage)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tabMonitor.Size = new System.Drawing.Size(1000, 647);
            this.tabMonitor.TabIndex = 0;
            // 
            // tabDate
            // 
            this.tabDate.Controls.Add(this.dataStage);
            this.tabDate.Controls.Add(this.panel1);
            this.tabDate.Location = new System.Drawing.Point(4, 22);
            this.tabDate.Name = "tabDate";
            this.tabDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabDate.Size = new System.Drawing.Size(992, 621);
            this.tabDate.TabIndex = 0;
            this.tabDate.Text = "На дату";
            this.tabDate.UseVisualStyleBackColor = true;
            // 
            // tabTree
            // 
            this.tabTree.Controls.Add(this.treeViewProject);
            this.tabTree.Controls.Add(this.treeProject);
            this.tabTree.Controls.Add(this.panel2);
            this.tabTree.Location = new System.Drawing.Point(4, 22);
            this.tabTree.Name = "tabTree";
            this.tabTree.Padding = new System.Windows.Forms.Padding(3);
            this.tabTree.Size = new System.Drawing.Size(992, 621);
            this.tabTree.TabIndex = 1;
            this.tabTree.Text = "Дерево проектов";
            this.tabTree.UseVisualStyleBackColor = true;
            // 
            // dataStage
            // 
            this.dataStage.AllowUserToAddRows = false;
            this.dataStage.AllowUserToDeleteRows = false;
            this.dataStage.AllowUserToOrderColumns = true;
            this.dataStage.AllowUserToResizeRows = false;
            this.dataStage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStage.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataStage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataStage.Location = new System.Drawing.Point(3, 59);
            this.dataStage.MultiSelect = false;
            this.dataStage.Name = "dataStage";
            this.dataStage.ReadOnly = true;
            this.dataStage.RowHeadersVisible = false;
            this.dataStage.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataStage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStage.ShowEditingIcon = false;
            this.dataStage.Size = new System.Drawing.Size(986, 559);
            this.dataStage.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 56);
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 56);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(331, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // butnShow
            // 
            this.butnShow.Location = new System.Drawing.Point(659, 3);
            this.butnShow.Name = "butnShow";
            this.butnShow.Size = new System.Drawing.Size(75, 22);
            this.butnShow.TabIndex = 2;
            this.butnShow.Text = "Показать";
            this.butnShow.UseVisualStyleBackColor = true;
            this.butnShow.Click += new System.EventHandler(this.butnShow_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sendMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 58);
            this.panel2.TabIndex = 1;
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
            // treeViewProject
            // 
            this.treeViewProject.CheckBoxes = true;
            this.treeViewProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewProject.Location = new System.Drawing.Point(3, 61);
            this.treeViewProject.Name = "treeViewProject";
            this.treeViewProject.Size = new System.Drawing.Size(986, 557);
            this.treeViewProject.TabIndex = 8;
            // 
            // sendMessage
            // 
            this.sendMessage.Location = new System.Drawing.Point(906, 29);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(75, 23);
            this.sendMessage.TabIndex = 0;
            this.sendMessage.Text = "Отправить письма";
            this.sendMessage.UseVisualStyleBackColor = true;
            this.sendMessage.Click += new System.EventHandler(this.sendMessage_Click);
            // 
            // MonitoringStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 647);
            this.Controls.Add(this.tabMonitor);
            this.Name = "MonitoringStage";
            this.Text = "Этапы проекта по дате";
            this.tabMonitor.ResumeLayout(false);
            this.tabDate.ResumeLayout(false);
            this.tabTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataStage;
        private Aga.Controls.Tree.TreeViewAdv treeProject;
        private System.Windows.Forms.TreeView treeViewProject;
        private System.Windows.Forms.Button sendMessage;
    }
}