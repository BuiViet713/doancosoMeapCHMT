using CuaHangMT.Controller;
using CuaHangMT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	/// Interaction logic for KhachHang.xaml
	/// </summary>
	public partial class KhachHang : UserControl
	{
		public KhachHang()
		{
			InitializeComponent();
			loadKH();

		}
		public void loadKH()
		{
			List<KhachHangModel> danhSachKH = KhachHangController.Instance.GetKhachHang();
			this.dgvKhachHang.ItemsSource = danhSachKH;

		}




	}
}
