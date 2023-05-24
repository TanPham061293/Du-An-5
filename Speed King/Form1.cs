using System.Media;
using System.Windows.Forms;



namespace Speek_King
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Location_y = 0;
        int Location_y_2 = -300;
        int Location_x_Xeplayer = 12;
        int Locaton_y_xeplayer = 230;
        int Location_x_xethunghiem = 42;
        int Location_y_xethunghiem = 230;
        // int Location_x_Xeplayer_bansao;
        int Locaton_y_xeplayer_bansao = 2;// tạo để có dữ liệu cho new location

        PictureBox ptb_xeplayer = new PictureBox();
        PictureBox ptb_xeplayer_bansao = new PictureBox();
        System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
        string Dia_Chi_File_Xe = "C:\\Users\\PC\\Desktop\\car.png";
        DirectoryInfo dr = new DirectoryInfo("car");
        List<FileInfo> arr_anhxeauto = new List<FileInfo>();
        List<PictureBox> arr_ptb_duongdau1 = new List<PictureBox>();
        List<PictureBox> arr_ptb_duongdua2 = new List<PictureBox>();
        SoundPlayer am_nhac_newgame = new SoundPlayer("nhac\\Nhay_Cung_ZinZin.wav");
        SoundPlayer am_nhac_choigame = new SoundPlayer("nhac\\NhacGameBoomDuaXe1.wav");
        SoundPlayer am_thanh_vacham = new SoundPlayer("nhac\\bum.wav");
        // WMPLib.WindowsMediaPlayer play = new WMPLib.WindowsMediaPlayer();
        int gio = 0;
        int phut = 0;
        int giay = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            pnel_ConDuong.BackgroundImage = Image.FromFile("road\\road2.jpg");
            pnel_ConDuong.BackgroundImageLayout = ImageLayout.Stretch;
            pnel_ConDuong.Size = new Size(150, 300);

            pnel_Conduong2.BackgroundImage = Image.FromFile("road\\road2.jpg");
            pnel_Conduong2.BackgroundImageLayout = ImageLayout.Stretch;
            pnel_Conduong2.Size = new Size(150, 300);

            pnel_Dichuyen.Size = new Size(150, 50);

            ptb_xevacham.BackgroundImage = Image.FromFile("anhvvv\\xevacham.png");
            ptb_xevacham.BackgroundImageLayout = ImageLayout.Stretch;

            label1.BackColor = Color.Red; // nút pause/play
            label1.Location = new Point(155, lb_ThoiGianChoi.Size.Height + 10);

            pnel_ConDuong.Visible = false;
            pnel_Conduong2.Visible = false;
            pnel_Dichuyen.Visible = false;
            lb_ThoiGianChoi.Visible = false;
            button1.Visible = false;
            
            label1.Visible = false;
            ptb_XeThunghiem.Visible = false;
            ptb_xevacham.Visible = false;

            this.BackgroundImage = Image.FromFile("anhvvv\\backgroudgame.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            ptb_vaogame.Location = new Point(300, 350);
            ptb_vaogame.BackgroundImage = Image.FromFile("anhvvv\\3.jpg");
            ptb_vaogame.BackgroundImageLayout = ImageLayout.Stretch;
            ptb_vaogame.BorderStyle = BorderStyle.Fixed3D;
            am_nhac_newgame.Play();
            if (!dr.Exists)
            {
                MessageBox.Show("Địa chỉ File không chính xác.");
            }
            foreach (var item in dr.GetFiles())
            {
                arr_anhxeauto.Add(item);
            }
        }
        private void ptb_vaogame_Click(object sender, EventArgs e)
        {
            pnel_ConDuong.Location = new Point(30, Location_y);
            pnel_Conduong2.Location = new Point(30, Location_y_2);
            pnel_Dichuyen.Location = new Point(30, 300);
            // ptb_xeplayer.Image = new Bitmap("C:\\Users\\PC\\Desktop\\car\\car_player.png");
            ptb_xeplayer.BackgroundImage = Image.FromFile("anhvvv\\car_player.png");
            ptb_xeplayer.Size = new Size(36, 50);
            ptb_xeplayer.BackgroundImageLayout = ImageLayout.Stretch;
            ptb_xeplayer.Location = new Point(Location_x_Xeplayer, Locaton_y_xeplayer);
            ptb_xeplayer.Visible = true;

            //this.pnel_ConDuong.Controls.Add(ptb_xeplayer);

            ptb_xeplayer_bansao.BackgroundImage = Image.FromFile("anhvvv\\car_player.png");
            ptb_xeplayer_bansao.Size = new Size(36, 50);
            ptb_xeplayer_bansao.BackgroundImageLayout = ImageLayout.Stretch;
            ptb_xeplayer_bansao.Location = new(10, Locaton_y_xeplayer_bansao);
            ptb_xeplayer_bansao.Visible = false;

            ptb_XeThunghiem.BackgroundImage = Image.FromFile("anhvvv\\car_player.png");
            ptb_XeThunghiem.BackgroundImageLayout = ImageLayout.Stretch;
            ptb_XeThunghiem.Size = new Size(36, 50);
            ptb_XeThunghiem.Location = new Point(Location_x_xethunghiem, Location_y_xethunghiem);
            ptb_XeThunghiem.Visible = true;
           // this.pnel_Conduong2.Controls.Add(ptb_xeplayer_bansao);
            lb_ThoiGianChoi.Location = new Point(150, 0);
            
            label1.Visible = true;
            pnel_ConDuong.Visible = true;
            pnel_Conduong2.Visible = true;
            pnel_Dichuyen.Visible = true;
            lb_ThoiGianChoi.Visible = true;
            //ptb_vaogame.Visible = false;
            am_nhac_newgame.Stop();

            //ptb_vaogame.Location = new Point(80, 200);
            //ptb_vaogame.Size = new Size(36, 50);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(220, 420);
            this.MaximizeBox = false;
            
            am_nhac_choigame.Play();
            tm.Interval = 100;
            tm.Tick += Tm_Tick;
            tm.Start();
            tm_DemThoiGian.Start();
            tm_randomxeAuto.Start();
        }

        //bool hoandoi = true;
        bool Luachon_xetdk = true;
        int HoanDoiThoiGianThanhDonViGiay;
        DialogResult luachon;
        private void Tm_Tick(object? sender, EventArgs e)
        {
            if (pnel_ConDuong.Location.Y >= 300) // tạo đường đua tranh so sanh bang để tránh trường hợp tọa độ y cộng với đơn vị lớn hơn 1
            {
                Location_y = -300;
                foreach (var item in arr_ptb_duongdau1)
                {
                    this.pnel_ConDuong.Controls.Remove(item);
                }
                arr_ptb_duongdau1.Clear();
                //ptb_xeplayer.Visible = false;
            }
            else if (pnel_Conduong2.Location.Y >= 300) // tạo đường đua
            {
                Location_y_2 = -300;
                foreach (var item2 in arr_ptb_duongdua2)
                {
                    this.pnel_Conduong2.Controls.Remove(item2);
                }
                arr_ptb_duongdua2.Clear();
                //ptb_xeplayer_bansao.Visible = false;
            }

            HoanDoiThoiGianThanhDonViGiay = giay + phut * 60 + gio * 3600;
            if (HoanDoiThoiGianThanhDonViGiay <= 10)
            {
                Location_y++;
                Location_y_2++;
               // Locaton_y_xeplayer--;
               // Locaton_y_xeplayer_bansao--;
            }
            else if (HoanDoiThoiGianThanhDonViGiay <= 30)
            {
                Location_y += 2;
                Location_y_2 += 2;
               // Locaton_y_xeplayer -= 2;
               // Locaton_y_xeplayer_bansao -= 2;
            }
            else if (HoanDoiThoiGianThanhDonViGiay <= 60)
            {
                Location_y += 3;
                Location_y_2 += 3;
                // tm.Interval = 10;
                //Locaton_y_xeplayer -= 3;
               // Locaton_y_xeplayer_bansao -= 3;
            }
            else if (HoanDoiThoiGianThanhDonViGiay <= 90)
            {
                Location_y += 5;
                Location_y_2 += 5;
               // Locaton_y_xeplayer -= 5;
               // Locaton_y_xeplayer_bansao -= 5;
            }
            else if (HoanDoiThoiGianThanhDonViGiay <= 120)
            {
                Location_y += 7;
                Location_y_2 += 7;
               // Locaton_y_xeplayer -= 7;
               // Locaton_y_xeplayer_bansao -= 7;
            }
            else if (HoanDoiThoiGianThanhDonViGiay <= 150)
            {
                Location_y += 10;
                Location_y_2 += 10;
               // Locaton_y_xeplayer -= 10;
                //Locaton_y_xeplayer_bansao -= 10;
            }
            else
            {
                Location_y += 12;
                Location_y_2 += 12;
               // Locaton_y_xeplayer -= 12;
               // Locaton_y_xeplayer_bansao -= 12;
            }

            //ptb_xeplayer.Location = new Point(Location_x_Xeplayer, Locaton_y_xeplayer); // new lại location xe đua
            //ptb_xeplayer_bansao.Location = new Point(Location_x_Xeplayer, Locaton_y_xeplayer_bansao);
            ptb_XeThunghiem.Location = new Point(Location_x_xethunghiem, Location_y_xethunghiem);
            if (pnel_ConDuong.Location.Y >= 0)
            {
                pnel_Conduong2.Location = new Point(30, Location_y_2);
                pnel_ConDuong.Location = new Point(30, Location_y); // new lại location đường đua   
            }
            else
            {
                pnel_ConDuong.Location = new Point(30, Location_y); // new lại location đường đua  
                pnel_Conduong2.Location = new Point(30, Location_y_2);
            }

            //if (ptb_xeplayer.Location.Y <= 0 && hoandoi == true) // xét điều kiện để tạo xe đua phụ cho đường đua phụ không so sánh với 0 để tránh trường hợp giảm tọa độ y của xe lớn hơn 1
            //{
            //    Locaton_y_xeplayer_bansao = 300 + ptb_xeplayer.Location.Y;
            //    ptb_xeplayer_bansao.Visible = true;
            //    hoandoi = false;
            //}
            //else if (ptb_xeplayer_bansao.Location.Y <= 0 && hoandoi == false) // xét đk cho sự trở lại của xe đua chính của đường đua chính
            //{
            //    Locaton_y_xeplayer = 300 + ptb_xeplayer_bansao.Location.Y;
            //    ptb_xeplayer.Visible = true;
            //    hoandoi = true;
            //}
            //if (ptb_xeplayer.Visible == true)
            //{
            //    foreach (var item in arr_ptb_duongdau1)
            //    {
            //        if (item.Location.X == ptb_xeplayer.Location.X)
            //        {
            //            int min = item.Location.Y <= ptb_xeplayer.Location.Y ? item.Location.Y : ptb_xeplayer.Location.Y;
            //            int max = item.Location.Y >= ptb_xeplayer.Location.Y ? item.Location.Y : ptb_xeplayer.Location.Y;
            //            if (max - min <= 50)
            //            {
            //                tm.Stop();
            //                tm_DemThoiGian.Stop();
            //                tm_randomxeAuto.Stop();
            //                ptb_xevacham.Location = new Point(ptb_xeplayer.Location.X - 10, ptb_xeplayer.Location.Y - 80);
            //                am_nhac_choigame.Stop();
            //                am_thanh_vacham.Play();
            //                ptb_xevacham.Visible = true;
            //                Luachon_xetdk = false;
            //                luachon = MessageBox.Show("Game Over.");
            //                am_thanh_vacham.Stop();
            //                break;
            //            }
            //        }
            //    }
            //}
            //if (ptb_xeplayer_bansao.Visible == true)
            //{
            //    foreach (var item2 in arr_ptb_duongdua2)
            //    {
            //        if (item2.Location.X == ptb_xeplayer_bansao.Location.X)
            //        {
            //            int min = item2.Location.Y <= ptb_xeplayer_bansao.Location.Y ? item2.Location.Y : ptb_xeplayer_bansao.Location.Y;
            //            int max = item2.Location.Y >= ptb_xeplayer_bansao.Location.Y ? item2.Location.Y : ptb_xeplayer_bansao.Location.Y;
            //            if (max - min <= 50)
            //            {
            //                tm.Stop();
            //                tm_DemThoiGian.Stop();
            //                tm_randomxeAuto.Stop();
            //                ptb_xevacham.Location = new Point(ptb_xeplayer_bansao.Location.X - 10, ptb_xeplayer_bansao.Location.Y - 80);
            //                am_nhac_choigame.Stop();
            //                am_thanh_vacham.Play();
            //                ptb_xevacham.Visible = true;
            //                Luachon_xetdk = false;
            //                luachon = MessageBox.Show("Game Over2.");
            //                am_thanh_vacham.Stop();
            //                break;
            //            }
            //        }
            //    }
            //}
            foreach (var item in arr_ptb_duongdua2)
            { 
                if (item.Location.X + 30 == ptb_XeThunghiem.Location.X)
                {
                    int toado_item = item.Location.Y + pnel_Conduong2.Location.Y;
                   
                    int min = toado_item <= ptb_XeThunghiem.Location.Y ? toado_item : ptb_XeThunghiem.Location.Y;
                    int max = toado_item <= ptb_XeThunghiem.Location.Y ? ptb_XeThunghiem.Location.Y : toado_item;
                    if (max - min <= 50)
                    {
                        tm.Stop();
                        tm_DemThoiGian.Stop();
                        tm_randomxeAuto.Stop();
                        am_nhac_choigame.Stop();

                        ptb_xevacham.BringToFront();
                        ptb_xevacham.Location = new Point(Location_x_xethunghiem - 20, Location_y_xethunghiem - 10);
                        ptb_xevacham.Visible = true;
                        am_thanh_vacham.Play();
                        Luachon_xetdk = false;
                       luachon = MessageBox.Show("Game over.");
                        am_thanh_vacham.Stop();
                        break;
                    }
                }
            }
            foreach (var item2 in arr_ptb_duongdau1)
            {
                if (item2.Location.X + 30 == ptb_XeThunghiem.Location.X)
                {
                    int toado_Item2 = item2.Location.Y + pnel_ConDuong.Location.Y;
                    
                    int min = toado_Item2 <= ptb_XeThunghiem.Location.Y ? toado_Item2 : ptb_XeThunghiem.Location.Y;
                    int max = toado_Item2 <= ptb_XeThunghiem.Location.Y ? ptb_XeThunghiem.Location.Y : toado_Item2;
                    if (max - min <= 50)
                    {
                        tm.Stop();
                        tm_DemThoiGian.Stop();
                        tm_randomxeAuto.Stop();

                        am_nhac_choigame.Stop();
                        ptb_xevacham.BringToFront();
                        ptb_xevacham.Location = new Point(Location_x_xethunghiem - 20, Location_y_xethunghiem - 10);
                        ptb_xevacham.Visible = true;
                        am_thanh_vacham.Play();
                        Luachon_xetdk = false;
                        luachon = MessageBox.Show("Game over.");
                        am_thanh_vacham.Stop();
                        break;
                    }
                }
            }
            //if (luachon == DialogResult.OK && Luachon_xetdk == false)
            //{
            //    foreach (var item in arr_ptb_duongdau1)
            //    {
            //        this.pnel_ConDuong.Controls.Remove(item);
            //    }
            //    foreach (var item2 in arr_ptb_duongdua2)
            //    {
            //        this.pnel_Conduong2.Controls.Remove(item2);
            //    }
            //    arr_ptb_duongdau1.Clear();
            //    arr_ptb_duongdua2.Clear();

            //    gio = phut = giay = 0;
            //    giay_random = 0;

            //    Location_y = 0;
            //    Location_y_2 = -300;

            //    Location_x_Xeplayer = 12;
            //    Locaton_y_xeplayer = 230;
            //    Locaton_y_xeplayer_bansao = 2;
            //    dem = 0;
            //    hoandoi = true;
            //    label1.Visible = false;
            //    pnel_ConDuong.Visible = false;
            //    pnel_Conduong2.Visible = false;
            //    pnel_Dichuyen.Visible = false;
            //    lb_ThoiGianChoi.Visible = false;
            //    ptb_xevacham.Visible = false;
            //    ptb_vaogame.Visible = true;
            //    am_nhac_newgame.Play();
            //    Luachon_xetdk = true;

            //    this.Size = new Size(900, 500);
            //}
            if (luachon == DialogResult.OK && Luachon_xetdk == false)
            { 
                foreach (var item in arr_ptb_duongdau1)
                {
                    this.pnel_ConDuong.Controls.Remove(item);
                }
                foreach (var item2 in arr_ptb_duongdua2)
                {
                    this.pnel_Conduong2.Controls.Remove(item2);
                }
                arr_ptb_duongdau1.Clear();
                arr_ptb_duongdua2.Clear();
                giay = gio = phut = giay_random = 0;

                Location_y = 0;
                Location_y_2 = -300;
                dem = 0;
                //hoandoi = true;
                label1.Visible = false;
                pnel_ConDuong.Visible = false;
                pnel_Conduong2.Visible = false;
                pnel_Dichuyen.Visible = false;
                lb_ThoiGianChoi.Visible = false;
                ptb_xevacham.Visible = false;
                ptb_XeThunghiem.Visible = false;
                ptb_vaogame.Visible = true;
                am_nhac_newgame.Play();
                Luachon_xetdk = true;

                this.Size = new Size(900, 500);
            }
        }

        private void Bt_Right_Click(object sender, EventArgs e)
        {
            //if (ptb_xeplayer.Location.X > 12 || ptb_xeplayer_bansao.Location.X > 12)
            //{
            //    Location_x_Xeplayer -= 44;
            //}
            if (ptb_XeThunghiem.Location.X > 42)
            {
                Location_x_xethunghiem -= 44;
            }
            
        }

        private void bt_Left_Click(object sender, EventArgs e)
        {
            //if (ptb_xeplayer.Location.X + ptb_xeplayer.Size.Width < 136 || ptb_xeplayer_bansao.Location.X + ptb_xeplayer_bansao.Size.Width < 136)
            //{
            //    Location_x_Xeplayer += 44;
            //}
            if (ptb_XeThunghiem.Location.X < 130)
            {
                Location_x_xethunghiem += 44;
            }
            
        }
        Random rd_toado = new Random();
        Random rd_toado_y = new Random();
        Random mauxe = new Random();
        int Chisomau;
        int i;
        int j;
        private void tm_DemThoiGian_Tick(object sender, EventArgs e)
        {
            giay++;
            if (giay == 60)
            {
                phut++;
                giay = 0;
                if (phut == 60)
                {
                    gio++;
                    phut = 0;
                }
            }
            string giayy = giay < 10 ? "0" + giay.ToString() : giay.ToString();
            string gioo = gio < 10 ? "0" + gio.ToString() : gio.ToString();
            string phutt = phut < 10 ? "0" + phut.ToString() : phut.ToString();
            lb_ThoiGianChoi.Text = gioo + ":" + phutt + ":" + giayy;
        }
        int giay_random = 0;
        private void tm_randomxeAuto_Tick(object sender, EventArgs e)
        {
            giay_random++;
            if (giay_random == 60)
            {
                giay_random = 0;
            }
            if (giay_random % 3 == 0)
            {
                j = rd_toado.Next(0, 3);
                // int i = rd_toado_y.Next(0, 300);

                PictureBox xe_auto = new PictureBox();
                xe_auto.Size = new Size(36, 50);
                Chisomau = mauxe.Next(0, arr_anhxeauto.Count());
                xe_auto.BackgroundImage = Image.FromFile(arr_anhxeauto[Chisomau].FullName);
                xe_auto.BackgroundImageLayout = ImageLayout.Stretch;

                if (pnel_Conduong2.Location.Y < 0)
                {
                    if (arr_ptb_duongdua2.Count == 0)
                    {
                        i = 230;
                    }
                    else
                    {
                        i = arr_ptb_duongdua2[arr_ptb_duongdua2.Count - 1].Location.Y - 230;
                    }
                    if (i >= 0)
                    {
                        xe_auto.Location = new Point(12 + (j * 44), i);
                        arr_ptb_duongdua2.Add(xe_auto);
                        this.pnel_Conduong2.Controls.Add(xe_auto);
                    }
                }
                if (pnel_ConDuong.Location.Y < 0)
                {
                    if (arr_ptb_duongdau1.Count == 0)
                    {
                        i = 150;
                    }
                    else
                    {
                        i = arr_ptb_duongdau1[arr_ptb_duongdau1.Count - 1].Location.Y - 150;

                    }
                    if (i >= 0)
                    {
                        xe_auto.Location = new Point(12 + (j * 44), i);
                        arr_ptb_duongdau1.Add(xe_auto);
                        this.pnel_ConDuong.Controls.Add(xe_auto);
                    }
                }
            }
        }

        private void ptb_vaogame_MouseMove(object sender, MouseEventArgs e)
        {
            ptb_vaogame.Size = new Size(155, 55);
        }

        private void ptb_vaogame_MouseLeave(object sender, EventArgs e)
        {
            ptb_vaogame.Size = new Size(145, 50);
        }
        int dem = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            dem++;
            if (dem == 1)
            {
                label1.Text = "Play";
                tm.Stop();
                tm_DemThoiGian.Stop();
                tm_randomxeAuto.Stop();
            }
            else if (dem == 2)
            {
                label1.Text = "Pause";
                tm.Start();
                tm_DemThoiGian.Start();
                tm_randomxeAuto.Start();
                dem = 0;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (ptb_XeThunghiem.Location.X > 42)
                {
                    Location_x_xethunghiem -= 44;
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                if (ptb_XeThunghiem.Location.X < 130)
                {
                    Location_x_xethunghiem += 44;
                }
            }
        }
    }
}