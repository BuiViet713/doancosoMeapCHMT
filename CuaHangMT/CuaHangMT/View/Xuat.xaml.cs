using CuaHangMT.Controller;
using CuaHangMT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CuaHangMT.View
{
	/// <summary>
	/// Interaction logic for Xuat.xaml
	/// </summary>
	public partial class Xuat : UserControl
	{
		
		private TaiKhoan acc;
		private int currIDXuat = XuatController.Instance.GetMaxID();
		public Xuat()
		{
			InitializeComponent();
			LoadListView();
		}
		public void thongtinxuat (TaiKhoan acc)
		{
			this.acc = acc;
			txtMaMayTinh.IsReadOnly = true;
			txtSoLuong.IsReadOnly = true;
		}
		public void LoadListView()
		{
			List<ChiTietXuatModel> danhSachXuat = ChiTietXuatController.Instance.GetByIdXuat(currIDXuat);
			this.lstXuat.ItemsSource = danhSachXuat;
		}
	}
}
