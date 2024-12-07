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
	public partial class FRM_Location : Form
	{
		BootcampEFTravelDBEntities_new db = new BootcampEFTravelDBEntities_new();

		public FRM_Location()
		{
			InitializeComponent();
		}

		private void btnListLocation_Click(object sender, EventArgs e)
		{
			FillGridWithLocationValues();
		}

		private void FRM_Location_Load(object sender, EventArgs e)
		{
			FillComboWithGuiders();
			FillGridWithLocationValues();
		}

		private void btnAddLocation_Click(object sender, EventArgs e)
		{
			SaveLocation();
			FillGridWithLocationValues();
		}

		private void btnDeleteLocation_Click(object sender, EventArgs e)
		{
			DeleteLocation();
			FillGridWithLocationValues();
		}

		#region Methods
		private void FillComboWithGuiders()
		{
			var values = db.Guides.Select(x => new
			{
				FullName = x.GuideName + " " + x.GuideSurname,
				x.GuideID,
			}).ToList();

			comboGuiders.DisplayMember = "FullName";
			comboGuiders.ValueMember = "GuideID";
			comboGuiders.DataSource = values;
		}

		private void FillGridWithLocationValues()
		{
			var values = db.Locations.ToList();
			dataGridView1.DataSource = values;
		}

		private void SaveLocation()
		{
			Location lct = new Location();
			lct.Capacity = byte.Parse(numericCapacity.Value.ToString());
			lct.City = txtLocationCity.Text;
			lct.Country = txtLocationCountry.Text;
			lct.Price = decimal.Parse(txtLocationPrice.Text);
			lct.DayNight = txtLocationDayNight.Text;
			lct.GuideID = int.Parse(comboGuiders.SelectedValue.ToString());
			db.Locations.Add(lct);
			db.SaveChanges();
		}

		private void DeleteLocation()
		{
			int id = int.Parse(txtLocationID.Text);
			var deletedValue = db.Locations.Find(id);
			db.Locations.Remove(deletedValue);
			db.SaveChanges();
		}

		private void UpdateLocation()
		{
			var id = int.Parse(txtLocationID.Text);
			var updatedValue = db.Locations.Find(id);

			updatedValue.Capacity = byte.Parse(numericCapacity.Value.ToString());
			updatedValue.City = txtLocationCity.Text;
			updatedValue.Country = txtLocationCountry.Text;
			updatedValue.Price = decimal.Parse(txtLocationPrice.Text);
			updatedValue.DayNight = txtLocationDayNight.Text;
			updatedValue.GuideID = int.Parse(comboGuiders.SelectedValue.ToString());

			db.SaveChanges();
		}
		#endregion

		private void btnUpdateLocation_Click(object sender, EventArgs e)
		{
			UpdateLocation();
			FillGridWithLocationValues();
		}
	}
}
