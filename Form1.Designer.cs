namespace WindowsFormsApp1
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lvBuy = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lvRead = new System.Windows.Forms.ListView();
            this.lblRead = new System.Windows.Forms.Label();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnSome = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveState = new System.Windows.Forms.Button();
            this.btnRestoreState = new System.Windows.Forms.Button();
            this.btnSanveToFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Location = new System.Drawing.Point(469, 551);
            this.btnAddBook.Name = "button1";
            this.btnAddBook.Size = new System.Drawing.Size(192, 58);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Добавить книгу";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvBuy
            // 
            this.lvBuy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvBuy.FullRowSelect = true;
            this.lvBuy.GridLines = true;
            this.lvBuy.HideSelection = false;
            this.lvBuy.LabelEdit = true;
            this.lvBuy.Location = new System.Drawing.Point(91, 150);
            this.lvBuy.Name = "lvBuy";
            this.lvBuy.Size = new System.Drawing.Size(368, 361);
            this.lvBuy.TabIndex = 1;
            this.lvBuy.UseCompatibleStateImageBehavior = false;
            this.lvBuy.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Автор";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Год";
            this.columnHeader3.Width = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(506, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Мои книги";
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBuy.Location = new System.Drawing.Point(244, 96);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(97, 29);
            this.lblBuy.TabIndex = 3;
            this.lblBuy.Text = "Купил:";
            // 
            // lvRead
            // 
            this.lvRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvRead.HideSelection = false;
            this.lvRead.Location = new System.Drawing.Point(632, 150);
            this.lvRead.Name = "lvRead";
            this.lvRead.Size = new System.Drawing.Size(347, 361);
            this.lvRead.TabIndex = 4;
            this.lvRead.UseCompatibleStateImageBehavior = false;
            this.lvRead.View = System.Windows.Forms.View.List;
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRead.Location = new System.Drawing.Point(733, 96);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(142, 29);
            this.lblRead.TabIndex = 5;
            this.lblRead.Text = "Прочитал:";
            // 
            // btnOne
            // 
            this.btnOne.Enabled = false;
            this.btnOne.Location = new System.Drawing.Point(512, 177);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(90, 54);
            this.btnOne.TabIndex = 6;
            this.btnOne.Text = ">";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnSome
            // 
            this.btnSome.Enabled = false;
            this.btnSome.Location = new System.Drawing.Point(512, 260);
            this.btnSome.Name = "btnSome";
            this.btnSome.Size = new System.Drawing.Size(90, 54);
            this.btnSome.TabIndex = 7;
            this.btnSome.Text = ">>";
            this.btnSome.UseVisualStyleBackColor = true;
            this.btnSome.Click += new System.EventHandler(this.btnSome_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(512, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 54);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveState
            // 
            this.btnSaveState.Location = new System.Drawing.Point(153, 525);
            this.btnSaveState.Name = "btnSaveState";
            this.btnSaveState.Size = new System.Drawing.Size(188, 38);
            this.btnSaveState.TabIndex = 9;
            this.btnSaveState.Text = "Сохранить состояние";
            this.btnSaveState.UseVisualStyleBackColor = true;
            this.btnSaveState.Click += new System.EventHandler(this.btnSaveState_Click);
            // 
            // btnRestoreState
            // 
            this.btnRestoreState.Location = new System.Drawing.Point(153, 569);
            this.btnRestoreState.Name = "btnRestoreState";
            this.btnRestoreState.Size = new System.Drawing.Size(188, 38);
            this.btnRestoreState.TabIndex = 10;
            this.btnRestoreState.Text = "Восстановить состояние";
            this.btnRestoreState.UseVisualStyleBackColor = true;
            this.btnRestoreState.Click += new System.EventHandler(this.btnRestoreState_Click);
            // 
            // btnSanveToFile
            // 
            this.btnSanveToFile.Location = new System.Drawing.Point(153, 613);
            this.btnSanveToFile.Name = "btnSanveToFile";
            this.btnSanveToFile.Size = new System.Drawing.Size(188, 38);
            this.btnSanveToFile.TabIndex = 11;
            this.btnSanveToFile.Text = "Сохранить на диск";
            this.btnSanveToFile.UseVisualStyleBackColor = true;
            this.btnSanveToFile.Click += new System.EventHandler(this.btnSanveToFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 663);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSanveToFile);
            this.Controls.Add(this.btnRestoreState);
            this.Controls.Add(this.btnSaveState);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSome);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.lblRead);
            this.Controls.Add(this.lvRead);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvBuy);
            this.Controls.Add(this.btnAddBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "Мои книги";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        public System.Windows.Forms.ListView lvBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBuy;
        public System.Windows.Forms.ListView lvRead;
        private System.Windows.Forms.Label lblRead;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnSome;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveState;
        private System.Windows.Forms.Button btnRestoreState;
        private System.Windows.Forms.Button btnSanveToFile;
        private System.Windows.Forms.Label label2;
    }
}

