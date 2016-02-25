namespace ContractTimeSharp.Forms
{
    partial class UserStageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserStageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textPost = new System.Windows.Forms.TextBox();
            this.textDept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textFio = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabNotComplete = new System.Windows.Forms.TabPage();
            this.gridNotComplete = new System.Windows.Forms.DataGridView();
            this.tabComplete = new System.Windows.Forms.TabPage();
            this.gridComplete = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabNotComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotComplete)).BeginInit();
            this.tabComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridComplete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 75);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.textPost, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textDept, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textFio, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.92857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.07143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 75);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textPost
            // 
            this.textPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPost.Location = new System.Drawing.Point(431, 28);
            this.textPost.Multiline = true;
            this.textPost.Name = "textPost";
            this.textPost.ReadOnly = true;
            this.textPost.Size = new System.Drawing.Size(208, 44);
            this.textPost.TabIndex = 5;
            // 
            // textDept
            // 
            this.textDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDept.Location = new System.Drawing.Point(217, 28);
            this.textDept.Multiline = true;
            this.textDept.Name = "textDept";
            this.textDept.ReadOnly = true;
            this.textDept.Size = new System.Drawing.Size(208, 44);
            this.textDept.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(431, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(217, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Подразделение";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFio
            // 
            this.textFio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textFio.Location = new System.Drawing.Point(3, 28);
            this.textFio.Multiline = true;
            this.textFio.Name = "textFio";
            this.textFio.ReadOnly = true;
            this.textFio.Size = new System.Drawing.Size(208, 44);
            this.textFio.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabNotComplete);
            this.tabControl.Controls.Add(this.tabComplete);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 75);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(642, 365);
            this.tabControl.TabIndex = 1;
            // 
            // tabNotComplete
            // 
            this.tabNotComplete.Controls.Add(this.gridNotComplete);
            this.tabNotComplete.Location = new System.Drawing.Point(4, 22);
            this.tabNotComplete.Name = "tabNotComplete";
            this.tabNotComplete.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotComplete.Size = new System.Drawing.Size(634, 339);
            this.tabNotComplete.TabIndex = 0;
            this.tabNotComplete.Text = "Планируемые";
            this.tabNotComplete.UseVisualStyleBackColor = true;
            // 
            // gridNotComplete
            // 
            this.gridNotComplete.AllowUserToAddRows = false;
            this.gridNotComplete.AllowUserToDeleteRows = false;
            this.gridNotComplete.AllowUserToOrderColumns = true;
            this.gridNotComplete.AllowUserToResizeRows = false;
            this.gridNotComplete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNotComplete.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridNotComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNotComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNotComplete.Location = new System.Drawing.Point(3, 3);
            this.gridNotComplete.MultiSelect = false;
            this.gridNotComplete.Name = "gridNotComplete";
            this.gridNotComplete.ReadOnly = true;
            this.gridNotComplete.RowHeadersVisible = false;
            this.gridNotComplete.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridNotComplete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNotComplete.ShowEditingIcon = false;
            this.gridNotComplete.Size = new System.Drawing.Size(628, 333);
            this.gridNotComplete.TabIndex = 1;
            this.gridNotComplete.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNotComplete_CellDoubleClick);
            this.gridNotComplete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridNotComplete_KeyDown);
            // 
            // tabComplete
            // 
            this.tabComplete.Controls.Add(this.gridComplete);
            this.tabComplete.Location = new System.Drawing.Point(4, 22);
            this.tabComplete.Name = "tabComplete";
            this.tabComplete.Padding = new System.Windows.Forms.Padding(3);
            this.tabComplete.Size = new System.Drawing.Size(634, 339);
            this.tabComplete.TabIndex = 1;
            this.tabComplete.Text = "Фактические";
            this.tabComplete.UseVisualStyleBackColor = true;
            // 
            // gridComplete
            // 
            this.gridComplete.AllowUserToAddRows = false;
            this.gridComplete.AllowUserToDeleteRows = false;
            this.gridComplete.AllowUserToOrderColumns = true;
            this.gridComplete.AllowUserToResizeRows = false;
            this.gridComplete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridComplete.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridComplete.Location = new System.Drawing.Point(3, 3);
            this.gridComplete.MultiSelect = false;
            this.gridComplete.Name = "gridComplete";
            this.gridComplete.ReadOnly = true;
            this.gridComplete.RowHeadersVisible = false;
            this.gridComplete.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridComplete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridComplete.ShowEditingIcon = false;
            this.gridComplete.Size = new System.Drawing.Size(628, 333);
            this.gridComplete.TabIndex = 2;
            this.gridComplete.DoubleClick += new System.EventHandler(this.gridComplete_DoubleClick);
            this.gridComplete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridComplete_KeyDown);
            // 
            // UserStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 440);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserStageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система \"Феникс\" - Мои задачи";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabNotComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNotComplete)).EndInit();
            this.tabComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridComplete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNotComplete;
        private System.Windows.Forms.TabPage tabComplete;
        private System.Windows.Forms.DataGridView gridNotComplete;
        private System.Windows.Forms.DataGridView gridComplete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPost;
        private System.Windows.Forms.TextBox textDept;
        private System.Windows.Forms.TextBox textFio;
    }
}