namespace MiniProject
{
    partial class DiffShowForm
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
            this.GrdDiffShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDiffShow)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdDiffShow
            // 
            this.GrdDiffShow.AllowUserToAddRows = false;
            this.GrdDiffShow.AllowUserToDeleteRows = false;
            this.GrdDiffShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDiffShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdDiffShow.Location = new System.Drawing.Point(0, 0);
            this.GrdDiffShow.Name = "GrdDiffShow";
            this.GrdDiffShow.ReadOnly = true;
            this.GrdDiffShow.RowHeadersWidth = 51;
            this.GrdDiffShow.RowTemplate.Height = 27;
            this.GrdDiffShow.Size = new System.Drawing.Size(800, 450);
            this.GrdDiffShow.TabIndex = 1;
            // 
            // DiffShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrdDiffShow);
            this.Name = "DiffShowForm";
            this.Text = "DiffShow";
            this.Load += new System.EventHandler(this.DiffShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDiffShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdDiffShow;
    }
}