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

namespace HinhHoc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int dem = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Hv_Click(object sender, RoutedEventArgs e)
        {
            lstHv.Items.Add("STT" + "\t\t Cạnh" + "\t Chu vi" + "\t Diện tích");
            hinhvuong[] hv = new hinhvuong[5];
            hv[0] = new hinhvuong(3);
            hv[1] = new hinhvuong(4);
            hv[2] = new hinhvuong(5);
            hv[3] = new hinhvuong(6);
            hv[4] = new hinhvuong(7);
            for (int i = 0; i < 5; i++)
            {
                hv[i].ChuVi();
                hv[i].DienTich();
                dem += 1;
                lstHv.Items.Add("\nHình Vuông: " + dem.ToString() + "\t" + hv[i].Canh + "  \t " + hv[i].chuvi.ToString() + "\t " + hv[i].dientich.ToString() );
            }
        }
        private void Ht_Click(object sender, RoutedEventArgs e)
        {
            List<hinhtron> ht = new List<hinhtron>();
            ht.Add(new hinhtron(3));

            foreach (hinhtron st in ht)
            {
                dem += 1;
                st.ChuVi();
                st.DienTich();
                lstHt.Items.Add("\nHình tròn: " + dem.ToString() + "\t " + (st.BanKinh) + "  \t " + st.chuvi.ToString() + "\t " + st.dientich.ToString());
            }
        }
    }
}
