namespace CSharpBootcamp_301.PresentationLayer
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.btnList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rdCategoryActive = new System.Windows.Forms.RadioButton();
			this.rdCategoryPassive = new System.Windows.Forms.RadioButton();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnFindById = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(108, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Category ID:";
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(112, 66);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(283, 28);
			this.txtCategoryId.TabIndex = 1;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(155, 269);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(185, 51);
			this.btnList.TabIndex = 2;
			this.btnList.Text = "List All";
			this.btnList.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(585, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(793, 650);
			this.dataGridView1.TabIndex = 3;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(112, 126);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(283, 28);
			this.txtCategoryName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(108, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 21);
			this.label2.TabIndex = 4;
			this.label2.Text = "Category Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(108, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 21);
			this.label3.TabIndex = 6;
			this.label3.Text = "Category Status:";
			// 
			// rdCategoryActive
			// 
			this.rdCategoryActive.AutoSize = true;
			this.rdCategoryActive.Location = new System.Drawing.Point(112, 191);
			this.rdCategoryActive.Name = "rdCategoryActive";
			this.rdCategoryActive.Size = new System.Drawing.Size(73, 25);
			this.rdCategoryActive.TabIndex = 7;
			this.rdCategoryActive.TabStop = true;
			this.rdCategoryActive.Text = "Active";
			this.rdCategoryActive.UseVisualStyleBackColor = true;
			// 
			// rdCategoryPassive
			// 
			this.rdCategoryPassive.AutoSize = true;
			this.rdCategoryPassive.Location = new System.Drawing.Point(202, 191);
			this.rdCategoryPassive.Name = "rdCategoryPassive";
			this.rdCategoryPassive.Size = new System.Drawing.Size(82, 25);
			this.rdCategoryPassive.TabIndex = 8;
			this.rdCategoryPassive.TabStop = true;
			this.rdCategoryPassive.Text = "Passive";
			this.rdCategoryPassive.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(155, 326);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(185, 51);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(155, 383);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(185, 51);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(155, 440);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(185, 51);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnFindById
			// 
			this.btnFindById.Location = new System.Drawing.Point(155, 497);
			this.btnFindById.Name = "btnFindById";
			this.btnFindById.Size = new System.Drawing.Size(185, 51);
			this.btnFindById.TabIndex = 12;
			this.btnFindById.Text = "Find By ID:";
			this.btnFindById.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1390, 674);
			this.Controls.Add(this.btnFindById);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.rdCategoryPassive);
			this.Controls.Add(this.rdCategoryActive);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Category Panel";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rdCategoryActive;
		private System.Windows.Forms.RadioButton rdCategoryPassive;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnFindById;
	}
}

