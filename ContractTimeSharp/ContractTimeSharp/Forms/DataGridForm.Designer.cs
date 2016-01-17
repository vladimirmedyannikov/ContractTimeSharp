namespace ContractTimeSharp
{
    partial class DialogGridForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridInvestProject = new System.Windows.Forms.DataGridView();
            this.menuInvestProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПоектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.контрактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewAdv1 = new Aga.Controls.Tree.TreeViewAdv();
            this.treeColumn1 = new Aga.Controls.Tree.TreeColumn();
            this.menuStageProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAddStage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddSubStage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditStage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteStage = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeTextBox1 = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInvestProject)).BeginInit();
            this.menuInvestProject.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStageProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridInvestProject
            // 
            this.dataGridInvestProject.AllowUserToAddRows = false;
            this.dataGridInvestProject.AllowUserToDeleteRows = false;
            this.dataGridInvestProject.AllowUserToOrderColumns = true;
            this.dataGridInvestProject.AllowUserToResizeRows = false;
            this.dataGridInvestProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridInvestProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridInvestProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInvestProject.ContextMenuStrip = this.menuInvestProject;
            this.dataGridInvestProject.Location = new System.Drawing.Point(12, 27);
            this.dataGridInvestProject.MultiSelect = false;
            this.dataGridInvestProject.Name = "dataGridInvestProject";
            this.dataGridInvestProject.ReadOnly = true;
            this.dataGridInvestProject.RowHeadersVisible = false;
            this.dataGridInvestProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridInvestProject.ShowEditingIcon = false;
            this.dataGridInvestProject.Size = new System.Drawing.Size(870, 227);
            this.dataGridInvestProject.TabIndex = 0;
            // 
            // menuInvestProject
            // 
            this.menuInvestProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьПроектToolStripMenuItem,
            this.редактироватьПроектToolStripMenuItem,
            this.удалитьПоектToolStripMenuItem});
            this.menuInvestProject.Name = "menuInvestProject";
            this.menuInvestProject.Size = new System.Drawing.Size(196, 70);
            // 
            // создатьПроектToolStripMenuItem
            // 
            this.создатьПроектToolStripMenuItem.Name = "создатьПроектToolStripMenuItem";
            this.создатьПроектToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.создатьПроектToolStripMenuItem.Text = "Создать проект";
            this.создатьПроектToolStripMenuItem.Click += new System.EventHandler(this.insertInvestProjectMenu);
            // 
            // редактироватьПроектToolStripMenuItem
            // 
            this.редактироватьПроектToolStripMenuItem.Name = "редактироватьПроектToolStripMenuItem";
            this.редактироватьПроектToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.редактироватьПроектToolStripMenuItem.Text = "Редактировать проект";
            this.редактироватьПроектToolStripMenuItem.Click += new System.EventHandler(this.editInvestProjectMenu);
            // 
            // удалитьПоектToolStripMenuItem
            // 
            this.удалитьПоектToolStripMenuItem.Name = "удалитьПоектToolStripMenuItem";
            this.удалитьПоектToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.удалитьПоектToolStripMenuItem.Text = "Удалить поект";
            this.удалитьПоектToolStripMenuItem.Click += new System.EventHandler(this.deleteInvestProjectMenu);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрактыToolStripMenuItem,
            this.сервисToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // контрактыToolStripMenuItem
            // 
            this.контрактыToolStripMenuItem.Name = "контрактыToolStripMenuItem";
            this.контрактыToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.контрактыToolStripMenuItem.Text = "Контракты";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewAdv1.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewAdv1.Columns.Add(this.treeColumn1);
            this.treeViewAdv1.ContextMenuStrip = this.menuStageProject;
            this.treeViewAdv1.DefaultToolTipProvider = null;
            this.treeViewAdv1.DragDropMarkColor = System.Drawing.Color.Black;
            this.treeViewAdv1.LineColor = System.Drawing.SystemColors.ControlDark;
            this.treeViewAdv1.Location = new System.Drawing.Point(12, 260);
            this.treeViewAdv1.Model = null;
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.NodeControls.Add(this.nodeTextBox1);
            this.treeViewAdv1.SelectedNode = null;
            this.treeViewAdv1.ShiftFirstNode = true;
            this.treeViewAdv1.Size = new System.Drawing.Size(870, 387);
            this.treeViewAdv1.TabIndex = 6;
            this.treeViewAdv1.Text = "treeViewAdv1";
            this.treeViewAdv1.UseColumns = true;
            this.treeViewAdv1.RowDraw += new System.EventHandler<Aga.Controls.Tree.TreeViewRowDrawEventArgs>(this.treeViewAdv1_RowDraw);
            this.treeViewAdv1.Click += new System.EventHandler(this.treeViewAdv1_Click);
            this.treeViewAdv1.DoubleClick += new System.EventHandler(this.treeViewAdv1_DoubleClick);
            // 
            // treeColumn1
            // 
            this.treeColumn1.Header = "";
            this.treeColumn1.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeColumn1.TooltipText = null;
            // 
            // menuStageProject
            // 
            this.menuStageProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddStage,
            this.mnuAddSubStage,
            this.mnuEditStage,
            this.mnuDeleteStage});
            this.menuStageProject.Name = "menuStageProject";
            this.menuStageProject.Size = new System.Drawing.Size(174, 92);
            this.menuStageProject.Opening += new System.ComponentModel.CancelEventHandler(this.menuStageProject_Opening);
            // 
            // mnuAddStage
            // 
            this.mnuAddStage.Name = "mnuAddStage";
            this.mnuAddStage.Size = new System.Drawing.Size(173, 22);
            this.mnuAddStage.Text = "Добавить этап";
            this.mnuAddStage.Click += new System.EventHandler(this.mnuAddStage_Click);
            // 
            // mnuAddSubStage
            // 
            this.mnuAddSubStage.Name = "mnuAddSubStage";
            this.mnuAddSubStage.Size = new System.Drawing.Size(173, 22);
            this.mnuAddSubStage.Text = "Добавить подэтап";
            this.mnuAddSubStage.Click += new System.EventHandler(this.mnuAddSubStage_Click);
            // 
            // mnuEditStage
            // 
            this.mnuEditStage.Name = "mnuEditStage";
            this.mnuEditStage.Size = new System.Drawing.Size(173, 22);
            this.mnuEditStage.Text = "Редактировать";
            this.mnuEditStage.Click += new System.EventHandler(this.mnuEditStage_Click);
            // 
            // mnuDeleteStage
            // 
            this.mnuDeleteStage.Name = "mnuDeleteStage";
            this.mnuDeleteStage.Size = new System.Drawing.Size(173, 22);
            this.mnuDeleteStage.Text = "Удалить";
            // 
            // nodeTextBox1
            // 
            this.nodeTextBox1.DataPropertyName = "DateEnd";
            this.nodeTextBox1.IncrementalSearchEnabled = true;
            this.nodeTextBox1.LeftMargin = 3;
            this.nodeTextBox1.ParentColumn = null;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "Инвестиционные проекты\r\n";
            this.notifyIcon1.Visible = true;
            // 
            // DialogGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 659);
            this.Controls.Add(this.treeViewAdv1);
            this.Controls.Add(this.dataGridInvestProject);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DialogGridForm";
            this.Text = "Проекты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInvestProject)).EndInit();
            this.menuInvestProject.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStageProject.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridInvestProject;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem контрактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private Aga.Controls.Tree.TreeViewAdv treeViewAdv1;
        private Aga.Controls.Tree.TreeColumn treeColumn1;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBox1;
        private System.Windows.Forms.ContextMenuStrip menuInvestProject;
        private System.Windows.Forms.ToolStripMenuItem создатьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПоектToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuStageProject;
        private System.Windows.Forms.ToolStripMenuItem mnuAddStage;
        private System.Windows.Forms.ToolStripMenuItem mnuAddSubStage;
        private System.Windows.Forms.ToolStripMenuItem mnuEditStage;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteStage;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

