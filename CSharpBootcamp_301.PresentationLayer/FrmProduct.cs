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
	public partial class FrmProduct : Form
	{

		private readonly IProductService _productService;

		public FrmProduct()
		{
			InitializeComponent();
			_productService = new ProductManager(new EfProductDal());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var values = _productService.TGetProductsWithCategoryName();
			dataGridView1.DataSource = values;
		}
	}
}
