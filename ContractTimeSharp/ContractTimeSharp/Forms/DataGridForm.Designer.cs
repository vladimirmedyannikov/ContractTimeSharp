namespace ContractTimeSharp
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.контрактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewAdv1 = new Aga.Controls.Tree.TreeViewAdv();
            this.treeColumn1 = new Aga.Controls.Tree.TreeColumn();
            this.menuStageProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьЭтапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПодэтапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeTextBox1 = new Aga.Controls.Tree.NodeControls.NodeTextBox();
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
            this.dataGridInvestProject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(769, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.treeViewAdv1.Size = new System.Drawing.Size(870, 387);
            this.treeViewAdv1.TabIndex = 6;
            this.treeViewAdv1.Text = "treeViewAdv1";
            this.treeViewAdv1.UseColumns = true;
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
            this.добавитьЭтапToolStripMenuItem,
            this.добавитьПодэтапToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStageProject.Name = "menuStageProject";
            this.menuStageProject.Size = new System.Drawing.Size(174, 92);
            // 
            // добавитьЭтапToolStripMenuItem
            // 
            this.добавитьЭтапToolStripMenuItem.Name = "добавитьЭтапToolStripMenuItem";
            this.добавитьЭтапToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.добавитьЭтапToolStripMenuItem.Text = "Добавить этап";
            // 
            // добавитьПодэтапToolStripMenuItem
            // 
            this.добавитьПодэтапToolStripMenuItem.Name = "добавитьПодэтапToolStripMenuItem";
            this.добавитьПодэтапToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.добавитьПодэтапToolStripMenuItem.Text = "Добавить подэтап";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // nodeTextBox1
            // 
            this.nodeTextBox1.DataPropertyName = "DateEnd";
            this.nodeTextBox1.IncrementalSearchEnabled = true;
            this.nodeTextBox1.LeftMargin = 3;
            this.nodeTextBox1.ParentColumn = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 659);
            this.Controls.Add(this.treeViewAdv1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridInvestProject);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.ToolStripMenuItem добавитьЭтапToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПодэтапToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}

