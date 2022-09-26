
namespace LibraryAutomation
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btnExitMember = new System.Windows.Forms.Button();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(406, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(41, 39);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(125, 15);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(275, 22);
            this.txt_Search.TabIndex = 9;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_search.Font = new System.Drawing.Font("Kristen ITC", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(23, 11);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(96, 31);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btnExitMember
            // 
            this.btnExitMember.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExitMember.Font = new System.Drawing.Font("Kristen ITC", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMember.Location = new System.Drawing.Point(23, 362);
            this.btnExitMember.Name = "btnExitMember";
            this.btnExitMember.Size = new System.Drawing.Size(107, 43);
            this.btnExitMember.TabIndex = 8;
            this.btnExitMember.Text = "EXIT";
            this.btnExitMember.UseVisualStyleBackColor = false;
            this.btnExitMember.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bookName,
            this.author,
            this.language,
            this.publisher,
            this.kind,
            this.amount,
            this.page,
            this.Year});
            this.dataGridViewUser.Location = new System.Drawing.Point(23, 62);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUser.Size = new System.Drawing.Size(891, 294);
            this.dataGridViewUser.TabIndex = 11;
            // 
            // bookID
            // 
            this.bookID.HeaderText = "bookID";
            this.bookID.MinimumWidth = 6;
            this.bookID.Name = "bookID";
            this.bookID.Width = 75;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "bookName";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.Width = 125;
            // 
            // author
            // 
            this.author.HeaderText = "author";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.Width = 125;
            // 
            // language
            // 
            this.language.HeaderText = "language";
            this.language.MinimumWidth = 6;
            this.language.Name = "language";
            this.language.Width = 125;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "publisher";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.Width = 125;
            // 
            // kind
            // 
            this.kind.HeaderText = "kind";
            this.kind.MinimumWidth = 6;
            this.kind.Name = "kind";
            this.kind.Width = 75;
            // 
            // amount
            // 
            this.amount.HeaderText = "amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.Width = 60;
            // 
            // page
            // 
            this.page.HeaderText = "page";
            this.page.MinimumWidth = 6;
            this.page.Name = "page";
            this.page.Width = 50;
            // 
            // Year
            // 
            this.Year.HeaderText = "year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.Width = 75;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(926, 417);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btnExitMember);
            this.Controls.Add(this.btn_search);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btnExitMember;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn page;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
    }
}