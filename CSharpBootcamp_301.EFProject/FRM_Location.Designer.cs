namespace CSharpBootcamp_301.EFProject
{
	partial class FRM_Location
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
			this.btnDeleteLocation = new System.Windows.Forms.Button();
			this.btnAddLocation = new System.Windows.Forms.Button();
			this.txtLocationCountry = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLocationCity = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnListLocation = new System.Windows.Forms.Button();
			this.txtLocationID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnUpdateLocation = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtLocationPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtLocationDayNight = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.numericCapacity = new System.Windows.Forms.NumericUpDown();
			this.comboGuiders = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDeleteLocation
			// 
			this.btnDeleteLocation.BackColor = System.Drawing.Color.Red;
			this.btnDeleteLocation.Location = new System.Drawing.Point(114, 344);
			this.btnDeleteLocation.Name = "btnDeleteLocation";
			this.btnDeleteLocation.Size = new System.Drawing.Size(296, 42);
			this.btnDeleteLocation.TabIndex = 21;
			this.btnDeleteLocation.Text = "Delete";
			this.btnDeleteLocation.UseVisualStyleBackColor = false;
			this.btnDeleteLocation.Click += new System.EventHandler(this.btnDeleteLocation_Click);
			// 
			// btnAddLocation
			// 
			this.btnAddLocation.BackColor = System.Drawing.Color.Lime;
			this.btnAddLocation.Location = new System.Drawing.Point(114, 296);
			this.btnAddLocation.Name = "btnAddLocation";
			this.btnAddLocation.Size = new System.Drawing.Size(296, 42);
			this.btnAddLocation.TabIndex = 20;
			this.btnAddLocation.Text = "Add";
			this.btnAddLocation.UseVisualStyleBackColor = false;
			this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
			// 
			// txtLocationCountry
			// 
			this.txtLocationCountry.Location = new System.Drawing.Point(114, 90);
			this.txtLocationCountry.Name = "txtLocationCountry";
			this.txtLocationCountry.Size = new System.Drawing.Size(296, 32);
			this.txtLocationCountry.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 24);
			this.label3.TabIndex = 18;
			this.label3.Text = "Country:";
			// 
			// txtLocationCity
			// 
			this.txtLocationCity.Location = new System.Drawing.Point(114, 52);
			this.txtLocationCity.Name = "txtLocationCity";
			this.txtLocationCity.Size = new System.Drawing.Size(296, 32);
			this.txtLocationCity.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 24);
			this.label2.TabIndex = 16;
			this.label2.Text = "City:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(476, 14);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(869, 516);
			this.dataGridView1.TabIndex = 15;
			// 
			// btnListLocation
			// 
			this.btnListLocation.BackColor = System.Drawing.Color.Cyan;
			this.btnListLocation.Location = new System.Drawing.Point(114, 440);
			this.btnListLocation.Name = "btnListLocation";
			this.btnListLocation.Size = new System.Drawing.Size(296, 42);
			this.btnListLocation.TabIndex = 14;
			this.btnListLocation.Text = "List";
			this.btnListLocation.UseVisualStyleBackColor = false;
			this.btnListLocation.Click += new System.EventHandler(this.btnListLocation_Click);
			// 
			// txtLocationID
			// 
			this.txtLocationID.Location = new System.Drawing.Point(114, 14);
			this.txtLocationID.Name = "txtLocationID";
			this.txtLocationID.Size = new System.Drawing.Size(296, 32);
			this.txtLocationID.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 24);
			this.label1.TabIndex = 12;
			this.label1.Text = "Location ID:";
			// 
			// btnUpdateLocation
			// 
			this.btnUpdateLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnUpdateLocation.Location = new System.Drawing.Point(114, 392);
			this.btnUpdateLocation.Name = "btnUpdateLocation";
			this.btnUpdateLocation.Size = new System.Drawing.Size(296, 42);
			this.btnUpdateLocation.TabIndex = 22;
			this.btnUpdateLocation.Text = "Update";
			this.btnUpdateLocation.UseVisualStyleBackColor = false;
			this.btnUpdateLocation.Click += new System.EventHandler(this.btnUpdateLocation_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 24);
			this.label4.TabIndex = 24;
			this.label4.Text = "Capacity:";
			// 
			// txtLocationPrice
			// 
			this.txtLocationPrice.Location = new System.Drawing.Point(114, 166);
			this.txtLocationPrice.Name = "txtLocationPrice";
			this.txtLocationPrice.Size = new System.Drawing.Size(296, 32);
			this.txtLocationPrice.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(53, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 24);
			this.label5.TabIndex = 26;
			this.label5.Text = "Price:";
			// 
			// txtLocationDayNight
			// 
			this.txtLocationDayNight.Location = new System.Drawing.Point(114, 204);
			this.txtLocationDayNight.Name = "txtLocationDayNight";
			this.txtLocationDayNight.Size = new System.Drawing.Size(296, 32);
			this.txtLocationDayNight.TabIndex = 29;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 207);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 24);
			this.label6.TabIndex = 28;
			this.label6.Text = "Day Night:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(36, 245);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 24);
			this.label7.TabIndex = 30;
			this.label7.Text = "Guider:";
			// 
			// numericCapacity
			// 
			this.numericCapacity.Location = new System.Drawing.Point(114, 129);
			this.numericCapacity.Name = "numericCapacity";
			this.numericCapacity.Size = new System.Drawing.Size(296, 32);
			this.numericCapacity.TabIndex = 32;
			// 
			// comboGuiders
			// 
			this.comboGuiders.FormattingEnabled = true;
			this.comboGuiders.Location = new System.Drawing.Point(114, 242);
			this.comboGuiders.Name = "comboGuiders";
			this.comboGuiders.Size = new System.Drawing.Size(296, 32);
			this.comboGuiders.TabIndex = 33;
			// 
			// FRM_Location
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1356, 540);
			this.Controls.Add(this.comboGuiders);
			this.Controls.Add(this.numericCapacity);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtLocationDayNight);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtLocationPrice);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnUpdateLocation);
			this.Controls.Add(this.btnDeleteLocation);
			this.Controls.Add(this.btnAddLocation);
			this.Controls.Add(this.txtLocationCountry);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtLocationCity);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnListLocation);
			this.Controls.Add(this.txtLocationID);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Calibri", 12F);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FRM_Location";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FRM_Location";
			this.Load += new System.EventHandler(this.FRM_Location_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnDeleteLocation;
		private System.Windows.Forms.Button btnAddLocation;
		private System.Windows.Forms.TextBox txtLocationCountry;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtLocationCity;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnListLocation;
		private System.Windows.Forms.TextBox txtLocationID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUpdateLocation;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtLocationPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtLocationDayNight;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numericCapacity;
		private System.Windows.Forms.ComboBox comboGuiders;
	}
}