using CSharpBootcamp_301.EFProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBootcamp_301.EFProject
{
	public partial class FRM_Statistics : Form
	{
		public FRM_Statistics()
		{
			InitializeComponent();
		}

		private void FRM_Statistics_Load(object sender, EventArgs e)
		{
			#region Total Location Count
			BootcampEFTravelDBEntities_new db = new BootcampEFTravelDBEntities_new();
			lblLocationCount.Text = db.Locations.Count().ToString();
			#endregion

			#region Sum Capacity
			lblSumCapacity.Text = db.Locations.Sum(x => x.Capacity).ToString();
			#endregion

			#region Total Guide Count
			lblGuideCount.Text = db.Guides.Count().ToString();
			#endregion

			#region Avg Capacity
			lblAvgCapacity.Text = db.Locations.Average(x => x.Capacity).ToString();
			#endregion

			#region Avg Location Price
			lblAvgLocationPrice.Text = db.Locations.Average(x => x.Price)?.ToString("F2") + "₺";
			#endregion

			#region
			var locations = db.Locations.OrderBy(x => x.LocationID).ToList();
			lblLastCountryName.Text = locations.LastOrDefault().Country.ToString();
			#endregion

			#region Istanbul Location Capacity
			lblIstanbulLocaitonCapacity.Text = db.Locations.Where(x => x.City == "Istanbul").Select(x => x.Capacity).FirstOrDefault().ToString();
			#endregion

			#region Turkey Locations Avg Capacity
			var turkeyLocationsCapacity = db.Locations.Where(x => x.Country == "Turkey").Average(x => x.Capacity).ToString();
			lblTurkeyLocationsAvgCapacity.Text = turkeyLocationsCapacity;
			#endregion

			#region Roma Location Guider Name
			var romaGuiderId = db.Locations.Where(x => x.City == "Roma").Select(y => y.GuideID).FirstOrDefault();
			lblRomaLocationGuiderName.Text = db.Guides.Where(x => x.GuideID == romaGuiderId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault();
			#endregion

			#region Max Capacity Of Location
			lblMaxCapacityOfLocation.Text = db.Locations.OrderByDescending(x => x.Capacity).Select(y => y.City).FirstOrDefault();
			#endregion

			#region Max Price Of Location
			var maxPrice = db.Locations.Max(x => x.Price);
			lblMaxPriceOfLocation.Text = db.Locations.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();
			#endregion

			#region Locaions Of Selected Guider
			var selectedGuider = db.Guides.Where(x => x.GuideName == "Müslüm" & x.GuideSurname == "Gürses").FirstOrDefault().GuideID;
			var locationsCount = db.Locations.Where(x => x.GuideID == selectedGuider).Count().ToString();
			lblMuslumGursesLocationCount.Text = locationsCount;
			#endregion
		}
	}
}
