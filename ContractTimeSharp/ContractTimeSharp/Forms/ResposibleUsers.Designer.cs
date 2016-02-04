namespace ContractTimeSharp.Forms
{
    partial class ResposibleUsers
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabNotComplete = new System.Windows.Forms.TabPage();
            this.gridNotComplete = new System.Windows.Forms.DataGridView();
            this.tabComplete = new System.Windows.Forms.TabPage();
            this.gridComplete = new System.Windows.Forms.DataGridView();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.gridAll = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabNotComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotComplete)).BeginInit();
            this.tabComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridComplete)).BeginInit();
            this.tabAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAll)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabNotComplete);
            this.tabControl.Controls.Add(this.tabComplete);
            this.tabControl.Controls.Add(this.tabAll);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(617, 441);
            this.tabControl.TabIndex = 2;
            // 
            // tabNotComplete
            // 
            this.tabNotComplete.Controls.Add(this.gridNotComplete);
            this.tabNotComplete.Location = new System.Drawing.Point(4, 22);
            this.tabNotComplete.Name = "tabNotComplete";
            this.tabNotComplete.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotComplete.Size = new System.Drawing.Size(609, 415);
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
            this.gridNotComplete.Size = new System.Drawing.Size(603, 409);
            this.gridNotComplete.TabIndex = 1;
            this.gridNotComplete.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNotComplete_CellDoubleClick);
            this.gridNotComplete.DoubleClick += new System.EventHandler(this.gridNotComplete_DoubleClick);
            // 
            // tabComplete
            // 
            this.tabComplete.Controls.Add(this.gridComplete);
            this.tabComplete.Location = new System.Drawing.Point(4, 22);
            this.tabComplete.Name = "tabComplete";
            this.tabComplete.Padding = new System.Windows.Forms.Padding(3);
            this.tabComplete.Size = new System.Drawing.Size(609, 415);
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
            this.gridComplete.Size = new System.Drawing.Size(603, 409);
            this.gridComplete.TabIndex = 2;
            this.gridComplete.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridComplete_CellDoubleClick);
            this.gridComplete.DoubleClick += new System.EventHandler(this.gridComplete_DoubleClick);
            // 
            // tabAll
            // 
            this.tabAll.Controls.Add(this.gridAll);
            this.tabAll.Location = new System.Drawing.Point(4, 22);
            this.tabAll.Name = "tabAll";
            this.tabAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabAll.Size = new System.Drawing.Size(609, 415);
            this.tabAll.TabIndex = 2;
            this.tabAll.Text = "Все";
            this.tabAll.UseVisualStyleBackColor = true;
            // 
            // gridAll
            // 
            this.gridAll.AllowUserToAddRows = false;
            this.gridAll.AllowUserToDeleteRows = false;
            this.gridAll.AllowUserToOrderColumns = true;
            this.gridAll.AllowUserToResizeRows = false;
            this.gridAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAll.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAll.Location = new System.Drawing.Point(3, 3);
            this.gridAll.MultiSelect = false;
            this.gridAll.Name = "gridAll";
            this.gridAll.ReadOnly = true;
            this.gridAll.RowHeadersVisible = false;
            this.gridAll.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAll.ShowEditingIcon = false;
            this.gridAll.Size = new System.Drawing.Size(603, 409);
            this.gridAll.TabIndex = 3;
            this.gridAll.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAll_CellDoubleClick);
            this.gridAll.DoubleClick += new System.EventHandler(this.gridAll_DoubleClick);
            // 
            // ResposibleUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 441);
            this.Controls.Add(this.tabControl);
            this.Name = "ResposibleUsers";
            this.Text = "Система \"Букля\" - Мониторинг задач пользователей";
            this.tabControl.ResumeLayout(false);
            this.tabNotComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNotComplete)).EndInit();
            this.tabComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridComplete)).EndInit();
            this.tabAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNotComplete;
        private System.Windows.Forms.DataGridView gridNotComplete;
        private System.Windows.Forms.TabPage tabComplete;
        private System.Windows.Forms.DataGridView gridComplete;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.DataGridView gridAll;
    }
}