namespace ContractTimeSharp.Forms
{
    partial class DirectoryUserForm
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
            this.panelParam = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelParam
            // 
            this.panelParam.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelParam.Location = new System.Drawing.Point(682, 0);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(200, 639);
            this.panelParam.TabIndex = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.gridUsers);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(682, 639);
            this.panelGrid.TabIndex = 1;
            // 
            // gridUsers
            // 
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.AllowUserToDeleteRows = false;
            this.gridUsers.AllowUserToOrderColumns = true;
            this.gridUsers.AllowUserToResizeRows = false;
            this.gridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUsers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUsers.Location = new System.Drawing.Point(0, 0);
            this.gridUsers.MultiSelect = false;
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            this.gridUsers.RowHeadersVisible = false;
            this.gridUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsers.ShowEditingIcon = false;
            this.gridUsers.Size = new System.Drawing.Size(682, 639);
            this.gridUsers.TabIndex = 1;
            // 
            // DirectoryUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 639);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelParam);
            this.Name = "DirectoryUserForm";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.DirectoryUserForm_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView gridUsers;
    }
}