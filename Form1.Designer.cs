namespace Project5_DapperNorthwind
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
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.DGVCategory = new System.Windows.Forms.DataGridView();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnCatAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCatId = new System.Windows.Forms.TextBox();
            this.btnCatDelete = new System.Windows.Forms.Button();
            this.btnCatUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCatCount = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.lblAvgProductStock = new System.Windows.Forms.Label();
            this.lblSeafoodTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.Location = new System.Drawing.Point(299, 18);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(155, 58);
            this.btnCategoryList.TabIndex = 0;
            this.btnCategoryList.Text = "Category List";
            this.btnCategoryList.UseVisualStyleBackColor = true;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // DGVCategory
            // 
            this.DGVCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategory.Location = new System.Drawing.Point(32, 172);
            this.DGVCategory.Name = "DGVCategory";
            this.DGVCategory.RowHeadersWidth = 51;
            this.DGVCategory.RowTemplate.Height = 24;
            this.DGVCategory.Size = new System.Drawing.Size(602, 379);
            this.DGVCategory.TabIndex = 1;
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(121, 57);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(145, 22);
            this.txtCatName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description: ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(121, 93);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(145, 54);
            this.txtDescription.TabIndex = 5;
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.Location = new System.Drawing.Point(480, 18);
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.Size = new System.Drawing.Size(154, 58);
            this.btnCatAdd.TabIndex = 6;
            this.btnCatAdd.Text = "Category Add";
            this.btnCatAdd.UseVisualStyleBackColor = true;
            this.btnCatAdd.Click += new System.EventHandler(this.btnCatAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category ID:";
            // 
            // txtCatId
            // 
            this.txtCatId.Location = new System.Drawing.Point(121, 18);
            this.txtCatId.Name = "txtCatId";
            this.txtCatId.Size = new System.Drawing.Size(145, 22);
            this.txtCatId.TabIndex = 7;
            // 
            // btnCatDelete
            // 
            this.btnCatDelete.Location = new System.Drawing.Point(480, 93);
            this.btnCatDelete.Name = "btnCatDelete";
            this.btnCatDelete.Size = new System.Drawing.Size(154, 54);
            this.btnCatDelete.TabIndex = 10;
            this.btnCatDelete.Text = "Category Delete";
            this.btnCatDelete.UseVisualStyleBackColor = true;
            this.btnCatDelete.Click += new System.EventHandler(this.btnCatDelete_Click);
            // 
            // btnCatUpdate
            // 
            this.btnCatUpdate.Location = new System.Drawing.Point(299, 93);
            this.btnCatUpdate.Name = "btnCatUpdate";
            this.btnCatUpdate.Size = new System.Drawing.Size(155, 54);
            this.btnCatUpdate.TabIndex = 9;
            this.btnCatUpdate.Text = "Category Update";
            this.btnCatUpdate.UseVisualStyleBackColor = true;
            this.btnCatUpdate.Click += new System.EventHandler(this.btnCatUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.lblSeafoodTotalPrice);
            this.groupBox1.Controls.Add(this.lblAvgProductStock);
            this.groupBox1.Controls.Add(this.lblProductCount);
            this.groupBox1.Controls.Add(this.lblCatCount);
            this.groupBox1.Location = new System.Drawing.Point(681, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 530);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dapper Statistics";
            // 
            // lblCatCount
            // 
            this.lblCatCount.AutoSize = true;
            this.lblCatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCatCount.Location = new System.Drawing.Point(32, 42);
            this.lblCatCount.Name = "lblCatCount";
            this.lblCatCount.Size = new System.Drawing.Size(58, 22);
            this.lblCatCount.TabIndex = 0;
            this.lblCatCount.Text = "label4";
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCount.Location = new System.Drawing.Point(32, 104);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(58, 22);
            this.lblProductCount.TabIndex = 1;
            this.lblProductCount.Text = "label4";
            // 
            // lblAvgProductStock
            // 
            this.lblAvgProductStock.AutoSize = true;
            this.lblAvgProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAvgProductStock.Location = new System.Drawing.Point(32, 177);
            this.lblAvgProductStock.Name = "lblAvgProductStock";
            this.lblAvgProductStock.Size = new System.Drawing.Size(58, 22);
            this.lblAvgProductStock.TabIndex = 2;
            this.lblAvgProductStock.Text = "label4";
            // 
            // lblSeafoodTotalPrice
            // 
            this.lblSeafoodTotalPrice.AutoSize = true;
            this.lblSeafoodTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeafoodTotalPrice.Location = new System.Drawing.Point(32, 248);
            this.lblSeafoodTotalPrice.Name = "lblSeafoodTotalPrice";
            this.lblSeafoodTotalPrice.Size = new System.Drawing.Size(58, 22);
            this.lblSeafoodTotalPrice.TabIndex = 3;
            this.lblSeafoodTotalPrice.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCatDelete);
            this.Controls.Add(this.btnCatUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCatId);
            this.Controls.Add(this.btnCatAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.DGVCategory);
            this.Controls.Add(this.btnCategoryList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.DataGridView DGVCategory;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCatAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCatId;
        private System.Windows.Forms.Button btnCatDelete;
        private System.Windows.Forms.Button btnCatUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCatCount;
        private System.Windows.Forms.Label lblSeafoodTotalPrice;
        private System.Windows.Forms.Label lblAvgProductStock;
        private System.Windows.Forms.Label lblProductCount;
    }
}

