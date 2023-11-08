using CuaHangMT.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMT.Controller
{
	public class ChiTietNhapDAO
	{
		private ChiTietNhapDAO() { }
		private static ChiTietNhapDAO instance;

		public static ChiTietNhapDAO Instance
		{
			get { if (instance == null) instance = new ChiTietNhapDAO(); return ChiTietNhapDAO.instance; }
			private set { ChiTietNhapDAO.instance = value; }
		}

		public List<ChiTietNhapModel> GetByIDNhap(int idNhap)
		{
			DataTable data = new DataTable();
			string query = "select * from CTNhap where idNhap = " + idNhap;

			data = DataProvider.Instance.executeQuery(query);

			List<ChiTietNhapModel> list = new List<ChiTietNhapModel>();

			foreach (DataRow row in data.Rows)
			{
				list.Add(new ChiTietNhapModel(row));
			}

			return list;
		}

		public bool Add(int idNhap, string maMayTinh, int soLuong)
		{
			try
			{
				int result = DataProvider.Instance.executeNonQuery("uspAddChiTietNhap @idNhap , @maMayTinh , @soLuong ", new object[] { idNhap, maMayTinh, soLuong });

				return result > 0;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool Del(int idChiTietNhap)
		{
			try
			{
				int result = DataProvider.Instance.executeNonQuery("uspDelChiTietNhap @id ", new object[] { idChiTietNhap });

				return result > 0;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
