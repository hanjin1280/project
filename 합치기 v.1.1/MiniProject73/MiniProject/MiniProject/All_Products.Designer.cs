namespace MiniProject
{
    partial class All_Products
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSpecific = new MetroFramework.Controls.MetroButton();
            this.grdPhonetbl = new MetroFramework.Controls.MetroGrid();
            this.cboPrice = new System.Windows.Forms.ComboBox();
            this.CboData = new System.Windows.Forms.ComboBox();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.priceTbl = new MetroFramework.Controls.MetroGrid();
            this.btnInit = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.NewRecommend = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhonetbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSpecific
            // 
            this.BtnSpecific.Location = new System.Drawing.Point(722, 127);
            this.BtnSpecific.Name = "BtnSpecific";
            this.BtnSpecific.Size = new System.Drawing.Size(109, 26);
            this.BtnSpecific.TabIndex = 1;
            this.BtnSpecific.Text = "자세히";
            this.BtnSpecific.UseSelectable = true;
            this.BtnSpecific.UseWaitCursor = true;
            this.BtnSpecific.Click += new System.EventHandler(this.btnSpecific_Click);
            // 
            // grdPhonetbl
            // 
            this.grdPhonetbl.AllowUserToAddRows = false;
            this.grdPhonetbl.AllowUserToDeleteRows = false;
            this.grdPhonetbl.AllowUserToResizeColumns = false;
            this.grdPhonetbl.AllowUserToResizeRows = false;
            this.grdPhonetbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPhonetbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdPhonetbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdPhonetbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPhonetbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPhonetbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdPhonetbl.ColumnHeadersHeight = 15;
            this.grdPhonetbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPhonetbl.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdPhonetbl.EnableHeadersVisualStyles = false;
            this.grdPhonetbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdPhonetbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPhonetbl.Location = new System.Drawing.Point(23, 127);
            this.grdPhonetbl.Name = "grdPhonetbl";
            this.grdPhonetbl.ReadOnly = true;
            this.grdPhonetbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPhonetbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdPhonetbl.RowHeadersWidth = 30;
            this.grdPhonetbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPhonetbl.RowTemplate.Height = 27;
            this.grdPhonetbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPhonetbl.Size = new System.Drawing.Size(679, 408);
            this.grdPhonetbl.TabIndex = 0;
            this.grdPhonetbl.UseWaitCursor = true;
            this.grdPhonetbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPhonetbl_CellClick);
            this.grdPhonetbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPhonetbl_CellContentClick);
            // 
            // cboPrice
            // 
            this.cboPrice.FormattingEnabled = true;
            this.cboPrice.Location = new System.Drawing.Point(23, 98);
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(163, 23);
            this.cboPrice.TabIndex = 2;
            this.cboPrice.UseWaitCursor = true;
            // 
            // CboData
            // 
            this.CboData.FormattingEnabled = true;
            this.CboData.Location = new System.Drawing.Point(192, 98);
            this.CboData.Name = "CboData";
            this.CboData.Size = new System.Drawing.Size(163, 23);
            this.CboData.TabIndex = 2;
            this.CboData.UseWaitCursor = true;
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(361, 98);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(163, 23);
            this.cboService.TabIndex = 2;
            this.cboService.UseWaitCursor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(541, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseWaitCursor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // priceTbl
            // 
            this.priceTbl.AllowUserToResizeRows = false;
            this.priceTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.priceTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.priceTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.priceTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.priceTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.priceTbl.DefaultCellStyle = dataGridViewCellStyle11;
            this.priceTbl.EnableHeadersVisualStyles = false;
            this.priceTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.priceTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.priceTbl.Location = new System.Drawing.Point(835, 534);
            this.priceTbl.Name = "priceTbl";
            this.priceTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.priceTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.priceTbl.RowHeadersWidth = 51;
            this.priceTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.priceTbl.RowTemplate.Height = 27;
            this.priceTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.priceTbl.Size = new System.Drawing.Size(10, 10);
            this.priceTbl.TabIndex = 4;
            this.priceTbl.UseWaitCursor = true;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(722, 75);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(109, 23);
            this.btnInit.TabIndex = 5;
            this.btnInit.Text = "모든 목록 보기";
            this.btnInit.UseSelectable = true;
            this.btnInit.UseWaitCursor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(76, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "가 격";
            this.metroLabel1.UseWaitCursor = true;
            this.metroLabel1.Click += new System.EventHandler(this.btnSpecific_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(245, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "데이터";
            this.metroLabel2.UseWaitCursor = true;
            this.metroLabel2.Click += new System.EventHandler(this.btnSpecific_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(426, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "혜택";
            this.metroLabel3.UseWaitCursor = true;
            this.metroLabel3.Click += new System.EventHandler(this.btnSpecific_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(260, 18);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 19);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "login";
            this.lblUser.UseWaitCursor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(189, 18);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "사용자 : ";
            this.metroLabel4.UseWaitCursor = true;
            // 
            // NewRecommend
            // 
            this.NewRecommend.Location = new System.Drawing.Point(722, 206);
            this.NewRecommend.Name = "NewRecommend";
            this.NewRecommend.Size = new System.Drawing.Size(109, 26);
            this.NewRecommend.TabIndex = 1;
            this.NewRecommend.Text = "새로운 추천!";
            this.NewRecommend.UseSelectable = true;
            this.NewRecommend.UseWaitCursor = true;
            this.NewRecommend.Click += new System.EventHandler(this.NewRecommend_Click);
            // 
            // All_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 567);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.priceTbl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.CboData);
            this.Controls.Add(this.cboPrice);
            this.Controls.Add(this.NewRecommend);
            this.Controls.Add(this.BtnSpecific);
            this.Controls.Add(this.grdPhonetbl);
            this.Name = "All_Products";
            this.Text = "전체 상품";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.All_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhonetbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnSpecific;
        private MetroFramework.Controls.MetroGrid grdPhonetbl;
        private System.Windows.Forms.ComboBox cboPrice;
        private System.Windows.Forms.ComboBox CboData;
        private System.Windows.Forms.ComboBox cboService;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroGrid priceTbl;
        private MetroFramework.Controls.MetroButton btnInit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblUser;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton NewRecommend;
    }
}

