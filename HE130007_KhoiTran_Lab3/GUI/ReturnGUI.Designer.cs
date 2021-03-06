﻿namespace HE130007_KhoiTran_Lab3.GUI
{
    partial class ReturnGUI
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
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.txtBorrowerNumber = new System.Windows.Forms.TextBox();
         this.txtName = new System.Windows.Forms.TextBox();
         this.txtReturnedDate = new System.Windows.Forms.TextBox();
         this.txtFineAmount = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.btnMember = new System.Windows.Forms.Button();
         this.btnFine = new System.Windows.Forms.Button();
         this.btnReturn = new System.Windows.Forms.Button();
         this.lblNumberBorrowedBooks = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(50, 128);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(701, 208);
         this.dataGridView1.TabIndex = 0;
         // 
         // txtBorrowerNumber
         // 
         this.txtBorrowerNumber.Location = new System.Drawing.Point(125, 27);
         this.txtBorrowerNumber.Name = "txtBorrowerNumber";
         this.txtBorrowerNumber.Size = new System.Drawing.Size(148, 20);
         this.txtBorrowerNumber.TabIndex = 1;
         // 
         // txtName
         // 
         this.txtName.Location = new System.Drawing.Point(125, 53);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(148, 20);
         this.txtName.TabIndex = 2;
         // 
         // txtReturnedDate
         // 
         this.txtReturnedDate.Location = new System.Drawing.Point(125, 342);
         this.txtReturnedDate.Name = "txtReturnedDate";
         this.txtReturnedDate.Size = new System.Drawing.Size(148, 20);
         this.txtReturnedDate.TabIndex = 3;
         this.txtReturnedDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtReturnedDate_Validating);
         // 
         // txtFineAmount
         // 
         this.txtFineAmount.Location = new System.Drawing.Point(603, 342);
         this.txtFineAmount.Name = "txtFineAmount";
         this.txtFineAmount.Size = new System.Drawing.Size(148, 20);
         this.txtFineAmount.TabIndex = 4;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(53, 34);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(72, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Member code";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(84, 60);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(35, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "Name";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(47, 112);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(158, 13);
         this.label3.TabIndex = 7;
         this.label3.Text = "The number of borrowed books:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(56, 349);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(63, 13);
         this.label4.TabIndex = 8;
         this.label4.Text = "Return date";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(531, 349);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(66, 13);
         this.label5.TabIndex = 9;
         this.label5.Text = "Fine Amount";
         // 
         // btnMember
         // 
         this.btnMember.Location = new System.Drawing.Point(348, 34);
         this.btnMember.Name = "btnMember";
         this.btnMember.Size = new System.Drawing.Size(170, 23);
         this.btnMember.TabIndex = 10;
         this.btnMember.Text = "Check member";
         this.btnMember.UseVisualStyleBackColor = true;
         this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
         // 
         // btnFine
         // 
         this.btnFine.Location = new System.Drawing.Point(59, 387);
         this.btnFine.Name = "btnFine";
         this.btnFine.Size = new System.Drawing.Size(100, 23);
         this.btnFine.TabIndex = 11;
         this.btnFine.Text = "Confirm fine";
         this.btnFine.UseVisualStyleBackColor = true;
         this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
         // 
         // btnReturn
         // 
         this.btnReturn.Location = new System.Drawing.Point(173, 387);
         this.btnReturn.Name = "btnReturn";
         this.btnReturn.Size = new System.Drawing.Size(100, 23);
         this.btnReturn.TabIndex = 12;
         this.btnReturn.Text = "Return";
         this.btnReturn.UseVisualStyleBackColor = true;
         this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
         // 
         // lblNumberBorrowedBooks
         // 
         this.lblNumberBorrowedBooks.AutoSize = true;
         this.lblNumberBorrowedBooks.Location = new System.Drawing.Point(208, 112);
         this.lblNumberBorrowedBooks.Name = "lblNumberBorrowedBooks";
         this.lblNumberBorrowedBooks.Size = new System.Drawing.Size(13, 13);
         this.lblNumberBorrowedBooks.TabIndex = 13;
         this.lblNumberBorrowedBooks.Text = "--";
         // 
         // ReturnGUI
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.lblNumberBorrowedBooks);
         this.Controls.Add(this.btnReturn);
         this.Controls.Add(this.btnFine);
         this.Controls.Add(this.btnMember);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtFineAmount);
         this.Controls.Add(this.txtReturnedDate);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.txtBorrowerNumber);
         this.Controls.Add(this.dataGridView1);
         this.Name = "ReturnGUI";
         this.Text = "ReturnGUI";
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBorrowerNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtReturnedDate;
        private System.Windows.Forms.TextBox txtFineAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnFine;
        private System.Windows.Forms.Button btnReturn;
      private System.Windows.Forms.Label lblNumberBorrowedBooks;
   }
}