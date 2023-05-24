namespace Speek_King
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnel_ConDuong = new Panel();
            ptb_vaogame = new PictureBox();
            button1 = new Button();
            tm_DemThoiGian = new System.Windows.Forms.Timer(components);
            pnel_Conduong2 = new Panel();
            lb_ThoiGianChoi = new Label();
            bt_Left = new Button();
            Bt_Right = new Button();
            pnel_Dichuyen = new Panel();
            bt_Bottom = new Button();
            bt_Top = new Button();
            tm_randomxeAuto = new System.Windows.Forms.Timer(components);
            ptb_xevacham = new PictureBox();
            label1 = new Label();
            ptb_XeThunghiem = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptb_vaogame).BeginInit();
            pnel_Dichuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_xevacham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_XeThunghiem).BeginInit();
            SuspendLayout();
            // 
            // pnel_ConDuong
            // 
            pnel_ConDuong.BackgroundImageLayout = ImageLayout.None;
            pnel_ConDuong.Location = new Point(1, 0);
            pnel_ConDuong.Name = "pnel_ConDuong";
            pnel_ConDuong.Size = new Size(198, 314);
            pnel_ConDuong.TabIndex = 0;
            pnel_ConDuong.TabStop = true;
            // 
            // ptb_vaogame
            // 
            ptb_vaogame.Location = new Point(643, 12);
            ptb_vaogame.Name = "ptb_vaogame";
            ptb_vaogame.Size = new Size(145, 50);
            ptb_vaogame.TabIndex = 0;
            ptb_vaogame.TabStop = false;
            ptb_vaogame.Click += ptb_vaogame_Click;
            ptb_vaogame.MouseLeave += ptb_vaogame_MouseLeave;
            ptb_vaogame.MouseMove += ptb_vaogame_MouseMove;
            // 
            // button1
            // 
            button1.Location = new Point(295, 362);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Test";
            button1.UseVisualStyleBackColor = true;
            // 
            // tm_DemThoiGian
            // 
            tm_DemThoiGian.Interval = 1000;
            tm_DemThoiGian.Tick += tm_DemThoiGian_Tick;
            // 
            // pnel_Conduong2
            // 
            pnel_Conduong2.BackgroundImageLayout = ImageLayout.None;
            pnel_Conduong2.Location = new Point(231, 0);
            pnel_Conduong2.Name = "pnel_Conduong2";
            pnel_Conduong2.Size = new Size(198, 314);
            pnel_Conduong2.TabIndex = 0;
            pnel_Conduong2.TabStop = true;
            // 
            // lb_ThoiGianChoi
            // 
            lb_ThoiGianChoi.AutoSize = true;
            lb_ThoiGianChoi.BackColor = Color.FromArgb(128, 255, 128);
            lb_ThoiGianChoi.Location = new Point(642, 151);
            lb_ThoiGianChoi.Name = "lb_ThoiGianChoi";
            lb_ThoiGianChoi.Size = new Size(49, 15);
            lb_ThoiGianChoi.TabIndex = 4;
            lb_ThoiGianChoi.Text = "00:00:00";
            // 
            // bt_Left
            // 
            bt_Left.Location = new Point(66, 36);
            bt_Left.Name = "bt_Left";
            bt_Left.Size = new Size(59, 23);
            bt_Left.TabIndex = 6;
            bt_Left.Text = "Left";
            bt_Left.UseVisualStyleBackColor = true;
            bt_Left.Click += bt_Left_Click;
            // 
            // Bt_Right
            // 
            Bt_Right.Location = new Point(0, 36);
            Bt_Right.Name = "Bt_Right";
            Bt_Right.Size = new Size(60, 23);
            Bt_Right.TabIndex = 6;
            Bt_Right.Text = "Right";
            Bt_Right.UseVisualStyleBackColor = true;
            Bt_Right.Click += Bt_Right_Click;
            // 
            // pnel_Dichuyen
            // 
            pnel_Dichuyen.AutoSize = true;
            pnel_Dichuyen.BackColor = Color.FromArgb(255, 255, 128);
            pnel_Dichuyen.Controls.Add(bt_Bottom);
            pnel_Dichuyen.Controls.Add(Bt_Right);
            pnel_Dichuyen.Controls.Add(bt_Top);
            pnel_Dichuyen.Controls.Add(bt_Left);
            pnel_Dichuyen.Location = new Point(435, 0);
            pnel_Dichuyen.Name = "pnel_Dichuyen";
            pnel_Dichuyen.Size = new Size(128, 99);
            pnel_Dichuyen.TabIndex = 7;
            pnel_Dichuyen.TabStop = true;
            // 
            // bt_Bottom
            // 
            bt_Bottom.Location = new Point(36, 65);
            bt_Bottom.Name = "bt_Bottom";
            bt_Bottom.Size = new Size(59, 23);
            bt_Bottom.TabIndex = 8;
            bt_Bottom.Text = "Bottom";
            bt_Bottom.UseVisualStyleBackColor = true;
            // 
            // bt_Top
            // 
            bt_Top.Location = new Point(36, 7);
            bt_Top.Name = "bt_Top";
            bt_Top.Size = new Size(59, 23);
            bt_Top.TabIndex = 8;
            bt_Top.Text = "Top";
            bt_Top.UseVisualStyleBackColor = true;
            // 
            // tm_randomxeAuto
            // 
            tm_randomxeAuto.Tick += tm_randomxeAuto_Tick;
            // 
            // ptb_xevacham
            // 
            ptb_xevacham.Location = new Point(643, 85);
            ptb_xevacham.Name = "ptb_xevacham";
            ptb_xevacham.Size = new Size(74, 50);
            ptb_xevacham.TabIndex = 8;
            ptb_xevacham.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(643, 180);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "Pause";
            label1.Click += label1_Click;
            // 
            // ptb_XeThunghiem
            // 
            ptb_XeThunghiem.Location = new Point(652, 210);
            ptb_XeThunghiem.Name = "ptb_XeThunghiem";
            ptb_XeThunghiem.Size = new Size(65, 50);
            ptb_XeThunghiem.TabIndex = 10;
            ptb_XeThunghiem.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(ptb_XeThunghiem);
            Controls.Add(label1);
            Controls.Add(ptb_xevacham);
            Controls.Add(ptb_vaogame);
            Controls.Add(pnel_Dichuyen);
            Controls.Add(lb_ThoiGianChoi);
            Controls.Add(button1);
            Controls.Add(pnel_Conduong2);
            Controls.Add(pnel_ConDuong);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)ptb_vaogame).EndInit();
            pnel_Dichuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptb_xevacham).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_XeThunghiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnel_ConDuong;
        private Button button1;
        private System.Windows.Forms.Timer tm_DemThoiGian;
        private Panel pnel_Conduong2;
        private PictureBox ptb_vaogame;
        private Label lb_ThoiGianChoi;
        private Button bt_Left;
        private Button Bt_Right;
        private Panel pnel_Dichuyen;
        private Button bt_Bottom;
        private Button bt_Top;
        private System.Windows.Forms.Timer tm_randomxeAuto;
        private PictureBox ptb_xevacham;
        private Label label1;
        private PictureBox ptb_XeThunghiem;
    }
}