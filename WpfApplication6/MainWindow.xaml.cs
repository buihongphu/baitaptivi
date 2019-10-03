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

namespace WpfApplication6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnhoadon_Click(object sender, RoutedEventArgs e)
        {
            {
                string ten = "Ten: " + txttenkh.Text + "\n";
                string sdt = "So Dien Thoai: " + txtsodt.Text + "\n";
                string soluong = "SoLuong: " + txtsoluong.Text + "\n";
                string SanPham;
                int gia, tong;

                if (rbttivi.IsChecked == true)
                {
                    SanPham = "SanPham: TiVi" + "\n";
                    gia = 200000;
                }
                else
                    if (rbttulanh.IsChecked == true)
                    {
                        SanPham = "SanPham: TuLanh" + "\n";
                        gia = 150000;
                    }
                    else
                    {
                        SanPham = "SanPham: MayTinh" + "\n";
                        gia = 50000;
                    }

                tong = gia * int.Parse(txtsoluong.Text);
                string hienThi = ten + sdt + soluong + SanPham + "Tong Tien : " + tong.ToString() + "\n";
                txbHienThi.Text = hienThi;
            }
        }       
        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        

    
       
        }
       }
}