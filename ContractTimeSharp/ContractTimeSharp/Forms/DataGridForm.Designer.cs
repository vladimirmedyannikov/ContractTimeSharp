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
            this.mnuInvestPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПоектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuContract = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMyTask = new System.Windows.Forms.ToolStripMenuItem();
            this.menuService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSendMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonStage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResposibleUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDateMonitoring = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLib = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUser = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridInvestProject.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridInvestProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInvestProject.ContextMenuStrip = this.menuInvestProject;
            this.dataGridInvestProject.Location = new System.Drawing.Point(12, 27);
            this.dataGridInvestProject.MultiSelect = false;
            this.dataGridInvestProject.Name = "dataGridInvestProject";
            this.dataGridInvestProject.ReadOnly = true;
            this.dataGridInvestProject.RowHeadersVisible = false;
            this.dataGridInvestProject.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridInvestProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridInvestProject.ShowEditingIcon = false;
            this.dataGridInvestProject.Size = new System.Drawing.Size(870, 227);
            this.dataGridInvestProject.TabIndex = 0;
            this.dataGridInvestProject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInvestProject_CellContentClick);
            // 
            // menuInvestProject
            // 
            this.menuInvestProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьПроектToolStripMenuItem,
            this.редактироватьПроектToolStripMenuItem,
            this.mnuInvestPrint,
            this.удалитьПоектToolStripMenuItem});
            this.menuInvestProject.Name = "menuInvestProject";
            this.menuInvestProject.Size = new System.Drawing.Size(196, 92);
            this.menuInvestProject.Opening += new System.ComponentModel.CancelEventHandler(this.menuInvestProject_Opening);
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
            // mnuInvestPrint
            // 
            this.mnuInvestPrint.Name = "mnuInvestPrint";
            this.mnuInvestPrint.Size = new System.Drawing.Size(195, 22);
            this.mnuInvestPrint.Text = "Печать проекта";
            this.mnuInvestPrint.Click += new System.EventHandler(this.mnuInvestPrint_Click);
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
            this.menuContract,
            this.menuMyTask,
            this.menuService,
            this.mnuLib});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuContract
            // 
            this.menuContract.Name = "menuContract";
            this.menuContract.Size = new System.Drawing.Size(78, 20);
            this.menuContract.Text = "Контракты";
            this.menuContract.Visible = false;
            // 
            // menuMyTask
            // 
            this.menuMyTask.Name = "menuMyTask";
            this.menuMyTask.Size = new System.Drawing.Size(84, 20);
            this.menuMyTask.Text = "Мои задачи";
            this.menuMyTask.Click += new System.EventHandler(this.menuMyTask_Click);
            // 
            // menuService
            // 
            this.menuService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSendMessage,
            this.mnuMonStage,
            this.mnuLog});
            this.menuService.Name = "menuService";
            this.menuService.Size = new System.Drawing.Size(59, 20);
            this.menuService.Text = "Сервис";
            // 
            // mnuSendMessage
            // 
            this.mnuSendMessage.Name = "mnuSendMessage";
            this.mnuSendMessage.Size = new System.Drawing.Size(184, 22);
            this.mnuSendMessage.Text = "Отправка писем";
            // 
            // mnuMonStage
            // 
            this.mnuMonStage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResposibleUsers,
            this.mnuDateMonitoring});
            this.mnuMonStage.Name = "mnuMonStage";
            this.mnuMonStage.Size = new System.Drawing.Size(184, 22);
            this.mnuMonStage.Text = "Мониторинг этапов";
            // 
            // mnuResposibleUsers
            // 
            this.mnuResposibleUsers.Name = "mnuResposibleUsers";
            this.mnuResposibleUsers.Size = new System.Drawing.Size(116, 22);
            this.mnuResposibleUsers.Text = "Список";
            this.mnuResposibleUsers.Click += new System.EventHandler(this.mnuResposibleUsers_Click);
            // 
            // mnuDateMonitoring
            // 
            this.mnuDateMonitoring.Name = "mnuDateMonitoring";
            this.mnuDateMonitoring.Size = new System.Drawing.Size(116, 22);
            this.mnuDateMonitoring.Text = "По дате";
            this.mnuDateMonitoring.Click += new System.EventHandler(this.mnuDateMonitoring_Click);
            // 
            // mnuLog
            // 
            this.mnuLog.Name = "mnuLog";
            this.mnuLog.Size = new System.Drawing.Size(184, 22);
            this.mnuLog.Text = "Логи входа";
            // 
            // mnuLib
            // 
            this.mnuLib.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUser});
            this.mnuLib.Name = "mnuLib";
            this.mnuLib.Size = new System.Drawing.Size(94, 20);
            this.mnuLib.Text = "Справочники";
            // 
            // mnuUser
            // 
            this.mnuUser.Name = "mnuUser";
            this.mnuUser.Size = new System.Drawing.Size(152, 22);
            this.mnuUser.Text = "Пользователи";
            this.mnuUser.Click += new System.EventHandler(this.mnuUser_Click);
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
            this.treeViewAdv1.FullRowSelect = true;
            this.treeViewAdv1.GridLineStyle = ((Aga.Controls.Tree.GridLineStyle)((Aga.Controls.Tree.GridLineStyle.Horizontal | Aga.Controls.Tree.GridLineStyle.Vertical)));
            this.treeViewAdv1.LineColor = System.Drawing.Color.Black;
            this.treeViewAdv1.Location = new System.Drawing.Point(12, 260);
            this.treeViewAdv1.Model = null;
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.NodeControls.Add(this.nodeTextBox1);
            this.treeViewAdv1.RowHeight = 20;
            this.treeViewAdv1.SelectedNode = null;
            this.treeViewAdv1.Size = new System.Drawing.Size(870, 387);
            this.treeViewAdv1.TabIndex = 6;
            this.treeViewAdv1.Text = "treeViewAdv1";
            this.treeViewAdv1.UseColumns = true;
            this.treeViewAdv1.RowDraw += new System.EventHandler<Aga.Controls.Tree.TreeViewRowDrawEventArgs>(this.treeViewAdv1_RowDraw);
            this.treeViewAdv1.Click += new System.EventHandler(this.treeViewAdv1_Click);
            this.treeViewAdv1.DoubleClick += new System.EventHandler(this.treeViewAdv1_DoubleClick);
            this.treeViewAdv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeViewAdv1_KeyDown);
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
            this.mnuDeleteStage.Click += new System.EventHandler(this.mnuDeleteStage_Click);
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
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "DialogGridForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem menuContract;
        private System.Windows.Forms.ToolStripMenuItem menuService;
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
        private System.Windows.Forms.ToolStripMenuItem menuMyTask;
        private System.Windows.Forms.ToolStripMenuItem mnuInvestPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuSendMessage;
        private System.Windows.Forms.ToolStripMenuItem mnuMonStage;
        private System.Windows.Forms.ToolStripMenuItem mnuLog;
        private System.Windows.Forms.ToolStripMenuItem mnuLib;
        private System.Windows.Forms.ToolStripMenuItem mnuUser;
        private System.Windows.Forms.ToolStripMenuItem mnuResposibleUsers;
        private System.Windows.Forms.ToolStripMenuItem mnuDateMonitoring;
    }
}

