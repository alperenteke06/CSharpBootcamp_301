using CSharpBootcamp_301.EFProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBootcamp_301.EFProject
{
	public partial class FRM_Guide : Form
	{

		BootcampEFTravelDBEntities_new db = new BootcampEFTravelDBEntities_new();

		public FRM_Guide()
		{
			InitializeComponent();
		}

		private void btnListGuiders_Click(object sender, EventArgs e)
		{
			ListAndShow();
		}

		private void btnAddGuider_Click(object sender, EventArgs e)
		{
			Guide guider = new Guide();
			guider.GuideName = txtGuideName.Text;
			guider.GuideSurname = txtGuideSurname.Text;
			db.Guides.Add(guider);
			db.SaveChanges();
			MessageBox.Show("Guide Added Succesfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ListAndShow();
		}

		#region ListMethod
		private void ListAndShow()
		{
			var values = db.Guides.ToList();
			dataGridView1.DataSource = values;
		}
		#endregion

		private void btnDeleteGuider_Click(object sender, EventArgs e)
		{
			int selectedGuiderID = int.Parse(txtGuideID.Text);
			var removeGuider = db.Guides.Find(selectedGuiderID);
			db.Guides.Remove(removeGuider);
			db.SaveChanges();
			MessageBox.Show("Guide Deleted Succesfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ListAndShow();
		}

		private void btnUpdateGuider_Click(object sender, EventArgs e)
		{
			var selectedGuiderID = int.Parse(txtGuideID.Text);
			var updateGuider = db.Guides.Find(selectedGuiderID);
			updateGuider.GuideName = txtGuideName.Text;
			updateGuider.GuideSurname = txtGuideSurname.Text;
			db.SaveChanges();
			MessageBox.Show("Guide Updated Succesfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ListAndShow();
		}

		private void btnListGuiderByID_Click(object sender, EventArgs e)
		{
			int selectedGuiderID = int.Parse(txtGuideID.Text);
			var getGuider = db.Guides.Where(x => x.GuideID == selectedGuiderID).ToList();
			dataGridView1.DataSource = getGuider;
		}
	}
}
