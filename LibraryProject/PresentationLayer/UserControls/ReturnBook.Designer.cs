﻿namespace PresentationLayer.UserControls
{
    partial class ReturnBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewReturn = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxReturnBookJmbg = new System.Windows.Forms.TextBox();
            this.textBoxReturnBookName = new System.Windows.Forms.TextBox();
            this.textBoxReturnBookSurname = new System.Windows.Forms.TextBox();
            this.textBoxReturnBookTitle = new System.Windows.Forms.TextBox();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxReturnUsertBy = new System.Windows.Forms.ComboBox();
            this.labelSearchReturn = new System.Windows.Forms.Label();
            this.textBoxReturnUserSearch = new System.Windows.Forms.TextBox();
            this.JMBGUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 399);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewReturn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.583692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.25321F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.16309F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewReturn
            // 
            this.dataGridViewReturn.AllowUserToAddRows = false;
            this.dataGridViewReturn.AllowUserToDeleteRows = false;
            this.dataGridViewReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JMBGUser,
            this.Name,
            this.Surname,
            this.IdBook,
            this.Title,
            this.Quantity,
            this.NameAuthor,
            this.DateOfIssue,
            this.ReturnDate});
            this.dataGridViewReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReturn.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewReturn.Name = "dataGridViewReturn";
            this.dataGridViewReturn.ReadOnly = true;
            this.dataGridViewReturn.Size = new System.Drawing.Size(779, 302);
            this.dataGridViewReturn.TabIndex = 0;
            this.dataGridViewReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReturn_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxReturnBookJmbg, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxReturnBookName, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxReturnBookSurname, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxReturnBookTitle, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonReturnBook, 8, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 345);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(779, 51);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "JMBG:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book title:";
            // 
            // textBoxReturnBookJmbg
            // 
            this.textBoxReturnBookJmbg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReturnBookJmbg.Location = new System.Drawing.Point(89, 9);
            this.textBoxReturnBookJmbg.Name = "textBoxReturnBookJmbg";
            this.textBoxReturnBookJmbg.Size = new System.Drawing.Size(80, 20);
            this.textBoxReturnBookJmbg.TabIndex = 4;
            // 
            // textBoxReturnBookName
            // 
            this.textBoxReturnBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReturnBookName.Location = new System.Drawing.Point(261, 9);
            this.textBoxReturnBookName.Name = "textBoxReturnBookName";
            this.textBoxReturnBookName.Size = new System.Drawing.Size(80, 20);
            this.textBoxReturnBookName.TabIndex = 5;
            // 
            // textBoxReturnBookSurname
            // 
            this.textBoxReturnBookSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReturnBookSurname.Location = new System.Drawing.Point(433, 9);
            this.textBoxReturnBookSurname.Name = "textBoxReturnBookSurname";
            this.textBoxReturnBookSurname.Size = new System.Drawing.Size(80, 20);
            this.textBoxReturnBookSurname.TabIndex = 6;
            // 
            // textBoxReturnBookTitle
            // 
            this.textBoxReturnBookTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReturnBookTitle.Location = new System.Drawing.Point(605, 9);
            this.textBoxReturnBookTitle.Name = "textBoxReturnBookTitle";
            this.textBoxReturnBookTitle.Size = new System.Drawing.Size(80, 20);
            this.textBoxReturnBookTitle.TabIndex = 7;
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonReturnBook.Location = new System.Drawing.Point(701, 7);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(75, 23);
            this.buttonReturnBook.TabIndex = 8;
            this.buttonReturnBook.Text = "Return";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.comboBoxReturnUsertBy, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelSearchReturn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxReturnUserSearch, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(779, 28);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // comboBoxReturnUsertBy
            // 
            this.comboBoxReturnUsertBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxReturnUsertBy.FormattingEnabled = true;
            this.comboBoxReturnUsertBy.Location = new System.Drawing.Point(3, 3);
            this.comboBoxReturnUsertBy.Name = "comboBoxReturnUsertBy";
            this.comboBoxReturnUsertBy.Size = new System.Drawing.Size(110, 21);
            this.comboBoxReturnUsertBy.TabIndex = 0;
            // 
            // labelSearchReturn
            // 
            this.labelSearchReturn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSearchReturn.AutoSize = true;
            this.labelSearchReturn.Location = new System.Drawing.Point(535, 7);
            this.labelSearchReturn.Name = "labelSearchReturn";
            this.labelSearchReturn.Size = new System.Drawing.Size(44, 13);
            this.labelSearchReturn.TabIndex = 1;
            this.labelSearchReturn.Text = "Search:";
            // 
            // textBoxReturnUserSearch
            // 
            this.textBoxReturnUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReturnUserSearch.Location = new System.Drawing.Point(585, 4);
            this.textBoxReturnUserSearch.Name = "textBoxReturnUserSearch";
            this.textBoxReturnUserSearch.Size = new System.Drawing.Size(191, 20);
            this.textBoxReturnUserSearch.TabIndex = 2;
            this.textBoxReturnUserSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxReturnUserSearch_KeyDown);
            // 
            // JMBGUser
            // 
            this.JMBGUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JMBGUser.HeaderText = "JMBGUser";
            this.JMBGUser.Name = "JMBGUser";
            this.JMBGUser.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // IdBook
            // 
            this.IdBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdBook.HeaderText = "IdBook";
            this.IdBook.Name = "IdBook";
            this.IdBook.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // NameAuthor
            // 
            this.NameAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameAuthor.HeaderText = "NameAuthor";
            this.NameAuthor.Name = "NameAuthor";
            this.NameAuthor.ReadOnly = true;
            // 
            // DateOfIssue
            // 
            this.DateOfIssue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfIssue.HeaderText = "DateOfIssue";
            this.DateOfIssue.Name = "DateOfIssue";
            this.DateOfIssue.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            ///this.Name = "ReturnBook";
            this.Size = new System.Drawing.Size(785, 399);
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewReturn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxReturnBookJmbg;
        private System.Windows.Forms.TextBox textBoxReturnBookName;
        private System.Windows.Forms.TextBox textBoxReturnBookSurname;
        private System.Windows.Forms.TextBox textBoxReturnBookTitle;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox comboBoxReturnUsertBy;
        private System.Windows.Forms.Label labelSearchReturn;
        private System.Windows.Forms.TextBox textBoxReturnUserSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBGUser;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
    }
}
