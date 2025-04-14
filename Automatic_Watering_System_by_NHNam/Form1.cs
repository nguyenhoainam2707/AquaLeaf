using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ZedGraph;

namespace Automatic_Watering_System_by_NHNam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] baudrate = { "300", "600", "1200", "2400", "4800", "9600", "14400", "28800", "57600", "115200" };
            cbbbaud.Items.AddRange(baudrate);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbcom.DataSource = SerialPort.GetPortNames();

            //Cài thông số mặc định
            cbbbaud.Text = "9600";
            cbbcom.Text = "COM8";

            //Khởi tạo biểu đồ
            GraphPane myframe = zedGraphControl1.GraphPane;
            myframe.Title.Text = "Moisture Graph";
            myframe.XAxis.Title.Text = "Time";
            myframe.YAxis.Title.Text = "Moisture";

            //Định nghĩa list để vẽ đồ thị
            RollingPointPairList list = new RollingPointPairList(500000);

            //Cấu hình đường line
            LineItem line = myframe.AddCurve("Moisture", list, Color.LightBlue, SymbolType.Circle);

            //Cấu hình 2 trục
            myframe.XAxis.Scale.Min = 0;
            myframe.XAxis.Scale.MinorStep = 1;
            myframe.XAxis.Scale.MajorStep = 5;

            myframe.YAxis.Scale.Min = 0;
            myframe.YAxis.Scale.Max = 100;
            myframe.YAxis.Scale.MinorStep = 1;
            myframe.YAxis.Scale.MajorStep = 5;

            zedGraphControl1.AxisChange();
        }

        int sum = 0;

        public void draw(int line)
        {
            LineItem curve = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            if ( curve == null)
            {
                return;
            }
            IPointListEdit list = curve.Points as IPointListEdit;
            if ( list == null)
            {
                return;
            }
            list.Add(sum, line);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            sum += 1;
        }
        private void scom_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Khai báo biến nhận chuỗi tín hiệu từ ESP32 là tmp1 và đọc dữ liệu
            String tmp1 = scom.ReadLine();
            //Cấu trúc chuỗi dữ liệu gửi lên dạng 'M' + độ ẩm + 'H' + chiều cao cột nước
            if (tmp1[0] == 'M')
            {
                int H_index = tmp1.IndexOf('H');
                //Đọc giá trị độ ẩm gán vào string tmp3
                String tmp3 = tmp1.Substring(1, H_index - 1);
                //Đọc giá trị độ cao cột nước gán vào strign tmp2
                String tmp2 = tmp1.Substring(H_index + 1, tmp1.Length - H_index - 1);
                //Hiển thị độ ẩm và độ cao cột nước lên giao diện
                txtmois.Text = tmp3;
                txtinfo.Text = tmp2;
                //Vẽ điểm độ ẩm lên đồ thị
                Invoke(new MethodInvoker(() => draw(Convert.ToInt32(tmp3))));
            }
            else
            {
                //Nếu chuỗi dữ liệu là ký tự 'T' tức là tín hiệu báo tắt Timer khi đã tưới xong.
                if (tmp1[0] == 'T')
                {
                    //Chuyển DONE về SET báo đã tưới xong
                    btimer.Text = "SET";
                }
            }            
        }

        private void bconnect_Click(object sender, EventArgs e)
            //Nút bấm đóng mở cổng COM kết nối với ESP32
        {
            if(!scom.IsOpen)
            {
                //Mở cổng COM, kết nối ESP32
                scom.PortName = cbbcom.Text;
                scom.BaudRate = Convert.ToInt32(cbbbaud.Text);
                scom.Open();
                bconnect.Text = "CONNECTED";
                string uppertxt = numericUpDown1.Text;
                string lowertxt = numericUpDown2.Text;
                //Gửi thông số Upper, Lower, chiều cao mực mước max mặc định cho ESP32
                scom.Write("U" + uppertxt + '\n' + "L" + lowertxt + '\n' + 'W' + txtsend.Text);
            }
            else
            {
                //Đóng cổng COM
                scom.Close();
                bconnect.Text = "DISCONNECTED";
            }
        }

        private void bsend_Click(object sender, EventArgs e)
            //Gửi giá trị độ cao cột nước tối đa cho ESP32
        {
            if (scom.IsOpen)
            {
                scom.Write('W' + txtsend.Text);
            }
            else
            {
                //Thông báo lên màn hình nếu cổng COM chưa mở
                MessageBox.Show("Cannot connect to COM Port!");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
            //Nếu thay đổi giá trị UPPER thì sẽ gửi giá trị UPPER tới ESP32
        {
            string uppertxt = numericUpDown1.Value.ToString();
            if (scom.IsOpen)
            {
                scom.Write("U" + uppertxt);
            }
            else
            {
                MessageBox.Show("Cannot connect to COM Port!");
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        //Nếu thay đổi giá trị LOWER thì sẽ gửi giá trị LOWER tới ESP32
        {
            string lowertxt = numericUpDown2.Value.ToString();
            
            if (scom.IsOpen)
            {
                scom.Write("L" + lowertxt);
            }
            else
            {
                MessageBox.Show("Cannot connect to COM Port!");
            }
        }

        private void bmode_Click(object sender, EventArgs e)
            //Nút bấm chuyển trạng thái AUTO/MANUAL
        {
            if(bmode.Text == "AUTO")
            {
                if (scom.IsOpen)
                {
                    //Gửi tín hiệu bật chế độ Manual và tắt máy bơm (nếu đang chạy)
                    scom.Write("M" + '\n' + "T");
                    bmode.Text = "MANUAL";
                    brelay.Text = "OFF";
                }
                else
                {
                    MessageBox.Show("Cannot connect to COM Port!");
                }
                
            }
            else
            {
                
                if (scom.IsOpen)
                {
                    //Gửi tín hiệu bật chế độ Auto
                    scom.Write("A");
                    bmode.Text = "AUTO";
                }
                else
                {
                    MessageBox.Show("Cannot connect to COM Port!");
                }
            }
        }

        private void brelay_Click(object sender, EventArgs e)
        {
            
            if (scom.IsOpen)
            {
                if (brelay.Text == "OFF")
                {
                    //Nếu relay đang tắt, thì ấn sẽ đóng relay và bật máy bơm. Chuyển "OFF" thành "ON".
                    brelay.Text = "ON";
                    //Gửi tín hiệu bật
                    scom.Write("B");
                }
                else
                {
                    //Chuyển "ON" về "OFF"
                    brelay.Text = "OFF";
                    //Gửi tín hiệu tắt máy bơm
                    scom.Write("T");
                }
            }
            else
            {
                MessageBox.Show("Cannot connect to COM Port!");
            }
        }

        private void btimer_Click(object sender, EventArgs e)
        {
            
            if (scom.IsOpen)
            {
                if (btimer.Text == "SET")
                {
                    //Chuyển "SET" thành "DONE"
                    btimer.Text = "DONE";
                    //Gửi tín hiệu mở chế độ Timer và gửi thông số số giờ, số phút hẹn giờ.
                    //Đồng thời tắt máy bơm và chuyển về chế độ Manual.
                    scom.Write('H' + numhour.Text + 'M' + numminute.Text + '\n' + "M" + '\n' + "T");
                    bmode.Text = "MANUAL";
                    brelay.Text = "OFF";
                }
                else
                {
                    //Nếu đang chưa qua thời gian hẹn giờ mà muốn thoát chế độ hẹn giờ thì ấn "DONE"
                    //Hệ thống gửi tín hiệu thoát chế độ Timer và về chế độ Manual
                    scom.Write("O"+ '\n' + "M" + '\n' + "T");
                    btimer.Text = "SET";
                    bmode.Text = "MANUAL";
                    brelay.Text = "OFF";
                }
            }
            else
            {
                MessageBox.Show("Cannot connect to COM Port!");
            }
        }
    }
}
