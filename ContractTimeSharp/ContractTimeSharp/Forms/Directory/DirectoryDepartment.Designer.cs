namespace ContractTimeSharp.Forms.Directory
{
    partial class DirectoryDepartment
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
            this.mnuUserDel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeptAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeptEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.gridDepartment = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelParam = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.tbNameDept = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFirm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartment)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelParam.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUserDel
            // 
            this.mnuUserDel.Name = "mnuUserDel";
            this.mnuUserDel.Size = new System.Drawing.Size(152, 22);
            this.mnuUserDel.Text = "Удалить";
            // 
            // mnuDeptAdd
            // 
            this.mnuDeptAdd.Name = "mnuDeptAdd";
            this.mnuDeptAdd.Size = new System.Drawing.Size(152, 22);
            this.mnuDeptAdd.Text = "Добавить";
            this.mnuDeptAdd.Click += new System.EventHandler(this.mnuDeptAdd_Click);
            // 
            // mnuDepartment
            // 
            this.mnuDepartment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeptAdd,
            this.mnuDeptEdit,
            this.mnuUserDel});
            this.mnuDepartment.Name = "mnuDepartment";
            this.mnuDepartment.Size = new System.Drawing.Size(104, 20);
            this.mnuDepartment.Text = "Подразделение";
            // 
            // mnuDeptEdit
            // 
            this.mnuDeptEdit.Name = "mnuDeptEdit";
            this.mnuDeptEdit.Size = new System.Drawing.Size(152, 22);
            this.mnuDeptEdit.Text = "Изменить";
            this.mnuDeptEdit.Click += new System.EventHandler(this.mnuDeptEdit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDepartment});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.gridDepartment);
            this.panelGrid.Controls.Add(this.menuStrip1);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(772, 559);
            this.panelGrid.TabIndex = 3;
            // 
            // gridDepartment
            // 
            this.gridDepartment.AllowUserToAddRows = false;
            this.gridDepartment.AllowUserToDeleteRows = false;
            this.gridDepartment.AllowUserToOrderColumns = true;
            this.gridDepartment.AllowUserToResizeRows = false;
            this.gridDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDepartment.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDepartment.Location = new System.Drawing.Point(0, 24);
            this.gridDepartment.MultiSelect = false;
            this.gridDepartment.Name = "gridDepartment";
            this.gridDepartment.ReadOnly = true;
            this.gridDepartment.RowHeadersVisible = false;
            this.gridDepartment.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDepartment.ShowEditingIcon = false;
            this.gridDepartment.Size = new System.Drawing.Size(772, 535);
            this.gridDepartment.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(162, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть панель";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 24);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(159, 122);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(159, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panelParam
            // 
            this.panelParam.Controls.Add(this.flowLayoutPanel1);
            this.panelParam.Controls.Add(this.panel1);
            this.panelParam.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelParam.Location = new System.Drawing.Point(772, 0);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(237, 559);
            this.panelParam.TabIndex = 2;
            this.panelParam.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelFirstName);
            this.flowLayoutPanel1.Controls.Add(this.tbNameDept);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.cbFirm);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.cbDepartment);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 535);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(3, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Название";
            // 
            // tbNameDept
            // 
            this.tbNameDept.Location = new System.Drawing.Point(3, 16);
            this.tbNameDept.Name = "tbNameDept";
            this.tbNameDept.Size = new System.Drawing.Size(231, 20);
            this.tbNameDept.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Организация";
            // 
            // cbFirm
            // 
            this.cbFirm.FormattingEnabled = true;
            this.cbFirm.Location = new System.Drawing.Point(3, 55);
            this.cbFirm.Name = "cbFirm";
            this.cbFirm.Size = new System.Drawing.Size(231, 21);
            this.cbFirm.TabIndex = 17;
            this.cbFirm.SelectedIndexChanged += new System.EventHandler(this.cbFirm_SelectedIndexChanged);
            this.cbFirm.SelectedValueChanged += new System.EventHandler(this.cbFirm_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Подразделение родитель";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(3, 95);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(231, 21);
            this.cbDepartment.TabIndex = 11;
            // 
            // DirectoryDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 559);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelParam);
            this.Name = "DirectoryDepartment";
            this.Text = "Справочник подразделений";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelParam.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuDepartment;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameDept;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView gridDepartment;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDeptEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuDeptAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuUserDel;
        private System.Windows.Forms.ComboBox cbFirm;
        private System.Windows.Forms.Label label2;
    }
}