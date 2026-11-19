namespace AdoNetTasks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.lblBooks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.lblLoans = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(10, 8);
            this.lblBooks.Text = "KİTABLAR";
            this.lblBooks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Text = "Ad:";
            this.label1.Name = "label1";
            this.label1.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(45, 32);
            this.txtTitle.Size = new System.Drawing.Size(200, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 36);
            this.label2.Text = "Müəllif:";
            this.label2.Name = "label2";
            this.label2.TabIndex = 3;
            // 
            // cbAuthor
            // 
            this.cbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(320, 32);
            this.cbAuthor.Size = new System.Drawing.Size(190, 23);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 36);
            this.label3.Text = "İl:";
            this.label3.Name = "label3";
            this.label3.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(555, 32);
            this.txtYear.Size = new System.Drawing.Size(60, 23);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.TabIndex = 6;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(10, 65);
            this.btnAddBook.Size = new System.Drawing.Size(100, 28);
            this.btnAddBook.Text = "Əlavə et";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(120, 65);
            this.btnUpdateBook.Size = new System.Drawing.Size(100, 28);
            this.btnUpdateBook.Text = "Düzəlt";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.TabIndex = 8;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(230, 65);
            this.btnDeleteBook.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteBook.Text = "Sil";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.TabIndex = 9;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.Location = new System.Drawing.Point(10, 100);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(940, 190);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.TabIndex = 10;
            this.dgvBooks.SelectionChanged += new System.EventHandler(this.dgvBooks_SelectionChanged);
            // 
            // lblLoans
            // 
            this.lblLoans.AutoSize = true;
            this.lblLoans.Location = new System.Drawing.Point(10, 302);
            this.lblLoans.Text = "İCARƏLƏR (hələ qaytarılmamış kitablar)";
            this.lblLoans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoans.Name = "lblLoans";
            this.lblLoans.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 330);
            this.label4.Text = "Kitab:";
            this.label4.Name = "label4";
            this.label4.TabIndex = 12;
            // 
            // cbBook
            // 
            this.cbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(60, 326);
            this.cbBook.Size = new System.Drawing.Size(220, 23);
            this.cbBook.Name = "cbBook";
            this.cbBook.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 330);
            this.label5.Text = "Üzv:";
            this.label5.Name = "label5";
            this.label5.TabIndex = 14;
            // 
            // cbMember
            // 
            this.cbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(335, 326);
            this.cbMember.Size = new System.Drawing.Size(200, 23);
            this.cbMember.Name = "cbMember";
            this.cbMember.TabIndex = 15;
            // 
            // btnLend
            // 
            this.btnLend.Location = new System.Drawing.Point(550, 324);
            this.btnLend.Size = new System.Drawing.Size(110, 28);
            this.btnLend.Text = "İcarəyə ver";
            this.btnLend.UseVisualStyleBackColor = true;
            this.btnLend.Name = "btnLend";
            this.btnLend.TabIndex = 16;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(670, 324);
            this.btnReturn.Size = new System.Drawing.Size(100, 28);
            this.btnReturn.Text = "Qaytar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvLoans
            // 
            this.dgvLoans.AllowUserToAddRows = false;
            this.dgvLoans.AllowUserToDeleteRows = false;
            this.dgvLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoans.Location = new System.Drawing.Point(10, 360);
            this.dgvLoans.MultiSelect = false;
            this.dgvLoans.ReadOnly = true;
            this.dgvLoans.RowHeadersVisible = false;
            this.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.Size = new System.Drawing.Size(940, 310);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 680);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.lblLoans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMember);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvLoans);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitabxana proqramı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label lblLoans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.Button btnLend;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvLoans;
    }
}
