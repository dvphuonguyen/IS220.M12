using System;

public class NhanVien
{
	private string name { get; set; }
	private DateTime birthday { get; set; }
	private string gentle { get; set; }
	public NhanVien() { }
	public NhanVien(string hoTen, DateTime ngaySinh, string gioiTinh)
    {
		name = hoTen;
		birthday = ngaySinh;
		gentle = gioiTinh;
    }
	public void Nhap()
    {
		Console.Write("Nhập họ tên nhân viên: ");
		name = Console.ReadLine();
		Console.Write("Nhập ngày sinh nhân viên: ");
		int ngay= int.Parse(Console.ReadLine());
		Console.Write("Nhập tháng sinh nhân viên: ");
		int thang = int.Parse(Console.ReadLine());
		Console.Write("Nhập năm sinh nhân viên: ");
		int nam = int.Parse(Console.ReadLine());
		birthday = new DateTime(nam, thang, ngay);
		Console.Write("Nhập giới tính nhân viên: ");
		gentle = Console.ReadLine();
	}
	public string KiemTraNghiHuu()
    {
		if (gentle == "Nam" )
		{
			return String.Format("Ngày về hưu của nhân viên {0} là: {1}", name, birthday.AddYears(60));
		}
		else
		{
			return String.Format("Ngày về hưu của nhân viên {0} là: {1}", name, birthday.AddYears(55));
		}
	}
}
