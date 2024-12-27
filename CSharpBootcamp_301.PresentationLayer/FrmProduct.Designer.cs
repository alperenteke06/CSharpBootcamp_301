namespace CSharpBootcamp_301.PresentationLayer
{
	partial class FrmProduct
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
			this.btnFindById = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnList = new System.Windows.Forms.Button();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProductStock = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProductCategory = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtProductDesc = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFindById
			// 
			this.btnFindById.Location = new System.Drawing.Point(219, 580);
			this.btnFindById.Name = "btnFindById";
			this.btnFindById.Size = new System.Drawing.Size(128, 51);
			this.btnFindById.TabIndex = 25;
			this.btnFindById.Text = "Find By ID:";
			this.btnFindById.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(64, 580);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(128, 51);
			this.btnUpdate.TabIndex = 24;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(219, 523);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(128, 51);
			this.btnDelete.TabIndex = 23;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(64, 523);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(128, 51);
			this.btnAdd.TabIndex = 22;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(64, 126);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(283, 28);
			this.txtProductName.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 21);
			this.label2.TabIndex = 17;
			this.label2.Text = "Product Name:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(407, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(971, 650);
			this.dataGridView1.TabIndex = 16;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(219, 466);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(128, 51);
			this.btnList.TabIndex = 15;
			this.btnList.Text = "List All";
			this.btnList.UseVisualStyleBackColor = true;
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(64, 66);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.Size = new System.Drawing.Size(283, 28);
			this.txtProductID.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 21);
			this.label1.TabIndex = 13;
			this.label1.Text = "Product ID:";
			// 
			// txtProductStock
			// 
			this.txtProductStock.Location = new System.Drawing.Point(64, 184);
			this.txtProductStock.Name = "txtProductStock";
			this.txtProductStock.Size = new System.Drawing.Size(283, 28);
			this.txtProductStock.TabIndex = 27;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(60, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 21);
			this.label3.TabIndex = 26;
			this.label3.Text = "Product Stock:";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Location = new System.Drawing.Point(64, 246);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(283, 28);
			this.txtProductPrice.TabIndex = 29;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(60, 222);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 21);
			this.label4.TabIndex = 28;
			this.label4.Text = "Product Price:";
			// 
			// txtProductCategory
			// 
			this.txtProductCategory.Location = new System.Drawing.Point(64, 305);
			this.txtProductCategory.Name = "txtProductCategory";
			this.txtProductCategory.Size = new System.Drawing.Size(283, 28);
			this.txtProductCategory.TabIndex = 31;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(60, 281);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 21);
			this.label5.TabIndex = 30;
			this.label5.Text = "Category:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(60, 347);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 21);
			this.label6.TabIndex = 32;
			this.label6.Text = "Description:";
			// 
			// txtProductDesc
			// 
			this.txtProductDesc.Location = new System.Drawing.Point(64, 371);
			this.txtProductDesc.Name = "txtProductDesc";
			this.txtProductDesc.Size = new System.Drawing.Size(283, 74);
			this.txtProductDesc.TabIndex = 34;
			this.txtProductDesc.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(64, 466);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 51);
			this.button1.TabIndex = 35;
			this.button1.Text = "List All - 2";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrmProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1390, 674);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtProductDesc);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtProductCategory);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtProductStock);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnFindById);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtProductID);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Calibri", 10.2F);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FrmProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmProduct";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFindById;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtProductStock;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtProductCategory;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox txtProductDesc;
		private System.Windows.Forms.Button button1;
	}
}