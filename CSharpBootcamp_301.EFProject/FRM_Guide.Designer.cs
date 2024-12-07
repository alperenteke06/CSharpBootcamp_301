namespace CSharpBootcamp_301.EFProject
{
	partial class FRM_Guide
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
			this.txtGuideID = new System.Windows.Forms.TextBox();
			this.btnListGuiders = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtGuideName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtGuideSurname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAddGuider = new System.Windows.Forms.Button();
			this.btnDeleteGuider = new System.Windows.Forms.Button();
			this.btnUpdateGuider = new System.Windows.Forms.Button();
			this.btnListGuiderByID = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Guide ID:";
			// 
			// txtGuideID
			// 
			this.txtGuideID.Location = new System.Drawing.Point(123, 12);
			this.txtGuideID.Name = "txtGuideID";
			this.txtGuideID.Size = new System.Drawing.Size(296, 32);
			this.txtGuideID.TabIndex = 1;
			// 
			// btnListGuiders
			// 
			this.btnListGuiders.BackColor = System.Drawing.Color.Cyan;
			this.btnListGuiders.Location = new System.Drawing.Point(123, 270);
			this.btnListGuiders.Name = "btnListGuiders";
			this.btnListGuiders.Size = new System.Drawing.Size(296, 42);
			this.btnListGuiders.TabIndex = 2;
			this.btnListGuiders.Text = "List";
			this.btnListGuiders.UseVisualStyleBackColor = false;
			this.btnListGuiders.Click += new System.EventHandler(this.btnListGuiders_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(485, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(661, 348);
			this.dataGridView1.TabIndex = 3;
			// 
			// txtGuideName
			// 
			this.txtGuideName.Location = new System.Drawing.Point(123, 50);
			this.txtGuideName.Name = "txtGuideName";
			this.txtGuideName.Size = new System.Drawing.Size(296, 32);
			this.txtGuideName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Name:";
			// 
			// txtGuideSurname
			// 
			this.txtGuideSurname.Location = new System.Drawing.Point(123, 88);
			this.txtGuideSurname.Name = "txtGuideSurname";
			this.txtGuideSurname.Size = new System.Drawing.Size(296, 32);
			this.txtGuideSurname.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Surname:";
			// 
			// btnAddGuider
			// 
			this.btnAddGuider.BackColor = System.Drawing.Color.Lime;
			this.btnAddGuider.Location = new System.Drawing.Point(123, 126);
			this.btnAddGuider.Name = "btnAddGuider";
			this.btnAddGuider.Size = new System.Drawing.Size(296, 42);
			this.btnAddGuider.TabIndex = 8;
			this.btnAddGuider.Text = "Add";
			this.btnAddGuider.UseVisualStyleBackColor = false;
			this.btnAddGuider.Click += new System.EventHandler(this.btnAddGuider_Click);
			// 
			// btnDeleteGuider
			// 
			this.btnDeleteGuider.BackColor = System.Drawing.Color.Red;
			this.btnDeleteGuider.Location = new System.Drawing.Point(123, 174);
			this.btnDeleteGuider.Name = "btnDeleteGuider";
			this.btnDeleteGuider.Size = new System.Drawing.Size(296, 42);
			this.btnDeleteGuider.TabIndex = 9;
			this.btnDeleteGuider.Text = "Delete";
			this.btnDeleteGuider.UseVisualStyleBackColor = false;
			this.btnDeleteGuider.Click += new System.EventHandler(this.btnDeleteGuider_Click);
			// 
			// btnUpdateGuider
			// 
			this.btnUpdateGuider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnUpdateGuider.Location = new System.Drawing.Point(123, 222);
			this.btnUpdateGuider.Name = "btnUpdateGuider";
			this.btnUpdateGuider.Size = new System.Drawing.Size(296, 42);
			this.btnUpdateGuider.TabIndex = 10;
			this.btnUpdateGuider.Text = "Update";
			this.btnUpdateGuider.UseVisualStyleBackColor = false;
			this.btnUpdateGuider.Click += new System.EventHandler(this.btnUpdateGuider_Click);
			// 
			// btnListGuiderByID
			// 
			this.btnListGuiderByID.BackColor = System.Drawing.Color.Cyan;
			this.btnListGuiderByID.Location = new System.Drawing.Point(123, 318);
			this.btnListGuiderByID.Name = "btnListGuiderByID";
			this.btnListGuiderByID.Size = new System.Drawing.Size(296, 42);
			this.btnListGuiderByID.TabIndex = 11;
			this.btnListGuiderByID.Text = "Fetch By ID";
			this.btnListGuiderByID.UseVisualStyleBackColor = false;
			this.btnListGuiderByID.Click += new System.EventHandler(this.btnListGuiderByID_Click);
			// 
			// FRM_Guide
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1158, 376);
			this.Controls.Add(this.btnListGuiderByID);
			this.Controls.Add(this.btnUpdateGuider);
			this.Controls.Add(this.btnDeleteGuider);
			this.Controls.Add(this.btnAddGuider);
			this.Controls.Add(this.txtGuideSurname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtGuideName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnListGuiders);
			this.Controls.Add(this.txtGuideID);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FRM_Guide";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Guide Process";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtGuideID;
		private System.Windows.Forms.Button btnListGuiders;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtGuideName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtGuideSurname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnAddGuider;
		private System.Windows.Forms.Button btnDeleteGuider;
		private System.Windows.Forms.Button btnUpdateGuider;
		private System.Windows.Forms.Button btnListGuiderByID;
	}
}

