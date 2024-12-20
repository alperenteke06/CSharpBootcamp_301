using CSharpBootcamp_301.BusinessLayer.Abstract;
using CSharpBootcamp_301.BusinessLayer.Concrete;
using CSharpBootcamp_301.DataAccessLayer.EntityFramework;
using CSharpBootcamp_301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBootcamp_301.PresentationLayer
{
	public partial class FrmCategory : Form
	{
		#region Ctor
		private readonly ICategoryService _categoryService;

		public FrmCategory()
		{
			_categoryService = new CategoryManager(new EfCategoryDal());
			InitializeComponent();
		}
		#endregion

		#region List
		private void btnList_Click(object sender, EventArgs e)
		{
			var categoryValues = _categoryService.TGetAll();
			dataGridView1.DataSource = categoryValues;
		}
		#endregion

		#region Add
		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool statusValue;
			if (rdCategoryActive.Checked)
			{
				statusValue = true;
			}
			else
			{
				statusValue = false;
			}
			Category category = new Category()
			{
				CategoryName = txtCategoryName.Text,
				CategoryStatus = statusValue,
			};
			_categoryService.TInsert(category);
			MessageBox.Show("Category Added Succesfully");
		}
		#endregion

		#region Delete
		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			var deletedValue = _categoryService.TGetById(id);

			_categoryService.TDelete(deletedValue);

			MessageBox.Show("Category Deleted Succesfully");
		}
		#endregion

		#region FindById
		private void btnFindById_Click(object sender, EventArgs e)
		{
			var id = int.Parse(txtCategoryId.Text);
			var matchedValue = _categoryService.TGetById(id);

			dataGridView1.DataSource = new List<object> { matchedValue };
			txtCategoryName.Text = matchedValue.CategoryName;

			if (matchedValue.CategoryStatus == true)
			{
				rdCategoryActive.Checked = true;
				rdCategoryPassive.Checked = false;
			}
			else
			{
				rdCategoryPassive.Checked = true;
				rdCategoryActive.Checked = false;
			}

			MessageBox.Show("Category Finded Succesfully");
		}
		#endregion

		#region Update
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var id = int.Parse(txtCategoryId.Text);
			var updatedValue = _categoryService.TGetById(id);

			bool statusValue;
			if (rdCategoryActive.Checked)
			{
				statusValue = true;
			}
			else
			{
				statusValue = false;
			}

			updatedValue.CategoryName = txtCategoryName.Text;
			updatedValue.CategoryStatus = statusValue;
			
			_categoryService.TUpdate(updatedValue);

			MessageBox.Show("Category Updated Succesfully");
		}
		#endregion
	}
}
