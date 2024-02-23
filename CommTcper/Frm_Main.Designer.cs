namespace CommTcper
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_startser = new System.Windows.Forms.Button();
            this.tb_serport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_serip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_sermsg = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_ptsermsg = new System.Windows.Forms.TextBox();
            this.btn_connptser = new System.Windows.Forms.Button();
            this.tb_ptserport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ptserip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_prtgamsg = new System.Windows.Forms.TextBox();
            this.ck_dis = new System.Windows.Forms.CheckBox();
            this.btn_thtm = new System.Windows.Forms.Button();
            this.btn_qdgd = new System.Windows.Forms.Button();
            this.btn_qhgd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_gdh = new System.Windows.Forms.TextBox();
            this.bt_dlu = new System.Windows.Forms.Button();
            this.btn_dyjl = new System.Windows.Forms.Button();
            this.lb_sy = new System.Windows.Forms.Label();
            this.lb_yz = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_prtgbmsg = new System.Windows.Forms.TextBox();
            this.contextMenuStrip_rp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon_rp = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_nbstop = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip_rp.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_startser);
            this.groupBox1.Controls.Add(this.tb_serport);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_serip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(47, 239);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(632, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "视觉MES信息接收区";
            // 
            // btn_startser
            // 
            this.btn_startser.Location = new System.Drawing.Point(350, 24);
            this.btn_startser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_startser.Name = "btn_startser";
            this.btn_startser.Size = new System.Drawing.Size(116, 25);
            this.btn_startser.TabIndex = 4;
            this.btn_startser.Text = "连接服务器";
            this.btn_startser.UseVisualStyleBackColor = true;
            this.btn_startser.Click += new System.EventHandler(this.btn_startser_Click);
            // 
            // tb_serport
            // 
            this.tb_serport.Location = new System.Drawing.Point(265, 26);
            this.tb_serport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_serport.Name = "tb_serport";
            this.tb_serport.Size = new System.Drawing.Size(62, 23);
            this.tb_serport.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "端口号:";
            // 
            // tb_serip
            // 
            this.tb_serip.Location = new System.Drawing.Point(52, 26);
            this.tb_serip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_serip.Name = "tb_serip";
            this.tb_serip.Size = new System.Drawing.Size(155, 23);
            this.tb_serip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址:";
            // 
            // tb_sermsg
            // 
            this.tb_sermsg.BackColor = System.Drawing.SystemColors.MenuText;
            this.tb_sermsg.ForeColor = System.Drawing.Color.Lime;
            this.tb_sermsg.Location = new System.Drawing.Point(47, 305);
            this.tb_sermsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_sermsg.Multiline = true;
            this.tb_sermsg.Name = "tb_sermsg";
            this.tb_sermsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_sermsg.Size = new System.Drawing.Size(632, 205);
            this.tb_sermsg.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_ptsermsg);
            this.groupBox2.Controls.Add(this.btn_connptser);
            this.groupBox2.Controls.Add(this.tb_ptserport);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_ptserip);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(47, 514);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(632, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MES条码实时打印显示区";
            // 
            // tb_ptsermsg
            // 
            this.tb_ptsermsg.BackColor = System.Drawing.SystemColors.MenuText;
            this.tb_ptsermsg.ForeColor = System.Drawing.Color.AliceBlue;
            this.tb_ptsermsg.Location = new System.Drawing.Point(0, 54);
            this.tb_ptsermsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ptsermsg.Multiline = true;
            this.tb_ptsermsg.Name = "tb_ptsermsg";
            this.tb_ptsermsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_ptsermsg.Size = new System.Drawing.Size(628, 232);
            this.tb_ptsermsg.TabIndex = 7;
            // 
            // btn_connptser
            // 
            this.btn_connptser.Location = new System.Drawing.Point(350, 26);
            this.btn_connptser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_connptser.Name = "btn_connptser";
            this.btn_connptser.Size = new System.Drawing.Size(116, 25);
            this.btn_connptser.TabIndex = 6;
            this.btn_connptser.Text = "发送";
            this.btn_connptser.UseVisualStyleBackColor = true;
            this.btn_connptser.Click += new System.EventHandler(this.btn_connptser_Click);
            // 
            // tb_ptserport
            // 
            this.tb_ptserport.Location = new System.Drawing.Point(265, 28);
            this.tb_ptserport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ptserport.Name = "tb_ptserport";
            this.tb_ptserport.Size = new System.Drawing.Size(62, 23);
            this.tb_ptserport.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "端口号:";
            // 
            // tb_ptserip
            // 
            this.tb_ptserip.Location = new System.Drawing.Point(52, 28);
            this.tb_ptserip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ptserip.Name = "tb_ptserip";
            this.tb_ptserip.Size = new System.Drawing.Size(155, 23);
            this.tb_ptserip.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP地址:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_prtgamsg);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(684, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 282);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "汇流条打印机状态接收区";
            // 
            // tb_prtgamsg
            // 
            this.tb_prtgamsg.BackColor = System.Drawing.SystemColors.MenuText;
            this.tb_prtgamsg.ForeColor = System.Drawing.Color.Aqua;
            this.tb_prtgamsg.Location = new System.Drawing.Point(0, 63);
            this.tb_prtgamsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_prtgamsg.Multiline = true;
            this.tb_prtgamsg.Name = "tb_prtgamsg";
            this.tb_prtgamsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_prtgamsg.Size = new System.Drawing.Size(603, 205);
            this.tb_prtgamsg.TabIndex = 6;
            // 
            // ck_dis
            // 
            this.ck_dis.AutoSize = true;
            this.ck_dis.Location = new System.Drawing.Point(635, 836);
            this.ck_dis.Name = "ck_dis";
            this.ck_dis.Size = new System.Drawing.Size(54, 16);
            this.ck_dis.TabIndex = 20;
            this.ck_dis.Text = "00:00";
            this.ck_dis.UseVisualStyleBackColor = true;
            // 
            // btn_thtm
            // 
            this.btn_thtm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_thtm.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_thtm.Location = new System.Drawing.Point(574, 81);
            this.btn_thtm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_thtm.Name = "btn_thtm";
            this.btn_thtm.Size = new System.Drawing.Size(118, 52);
            this.btn_thtm.TabIndex = 12;
            this.btn_thtm.Text = "退还";
            this.btn_thtm.UseVisualStyleBackColor = true;
            this.btn_thtm.Click += new System.EventHandler(this.btn_thtm_Click);
            // 
            // btn_qdgd
            // 
            this.btn_qdgd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_qdgd.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_qdgd.Location = new System.Drawing.Point(438, 81);
            this.btn_qdgd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_qdgd.Name = "btn_qdgd";
            this.btn_qdgd.Size = new System.Drawing.Size(118, 52);
            this.btn_qdgd.TabIndex = 11;
            this.btn_qdgd.Text = "确定";
            this.btn_qdgd.UseVisualStyleBackColor = true;
            this.btn_qdgd.Click += new System.EventHandler(this.btn_qdgd_Click);
            // 
            // btn_qhgd
            // 
            this.btn_qhgd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_qhgd.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_qhgd.Location = new System.Drawing.Point(710, 81);
            this.btn_qhgd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_qhgd.Name = "btn_qhgd";
            this.btn_qhgd.Size = new System.Drawing.Size(118, 52);
            this.btn_qhgd.TabIndex = 10;
            this.btn_qhgd.Text = "切换";
            this.btn_qhgd.UseVisualStyleBackColor = true;
            this.btn_qhgd.Click += new System.EventHandler(this.btn_qhgd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(64, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "订单号:";
            // 
            // tb_gdh
            // 
            this.tb_gdh.Location = new System.Drawing.Point(149, 211);
            this.tb_gdh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_gdh.Name = "tb_gdh";
            this.tb_gdh.Size = new System.Drawing.Size(175, 21);
            this.tb_gdh.TabIndex = 8;
            // 
            // bt_dlu
            // 
            this.bt_dlu.BackColor = System.Drawing.Color.White;
            this.bt_dlu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_dlu.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_dlu.Location = new System.Drawing.Point(30, 80);
            this.bt_dlu.Name = "bt_dlu";
            this.bt_dlu.Size = new System.Drawing.Size(118, 52);
            this.bt_dlu.TabIndex = 7;
            this.bt_dlu.Text = "登录";
            this.bt_dlu.UseVisualStyleBackColor = false;
            this.bt_dlu.Click += new System.EventHandler(this.bt_dlu_Click);
            // 
            // btn_dyjl
            // 
            this.btn_dyjl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dyjl.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_dyjl.Location = new System.Drawing.Point(302, 80);
            this.btn_dyjl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_dyjl.Name = "btn_dyjl";
            this.btn_dyjl.Size = new System.Drawing.Size(118, 52);
            this.btn_dyjl.TabIndex = 18;
            this.btn_dyjl.Text = "日志";
            this.btn_dyjl.UseVisualStyleBackColor = true;
            this.btn_dyjl.Click += new System.EventHandler(this.btn_dyjl_Click);
            // 
            // lb_sy
            // 
            this.lb_sy.AutoSize = true;
            this.lb_sy.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_sy.Location = new System.Drawing.Point(1199, 148);
            this.lb_sy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_sy.Name = "lb_sy";
            this.lb_sy.Size = new System.Drawing.Size(24, 28);
            this.lb_sy.TabIndex = 17;
            this.lb_sy.Text = "0";
            // 
            // lb_yz
            // 
            this.lb_yz.AutoSize = true;
            this.lb_yz.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_yz.Location = new System.Drawing.Point(1199, 93);
            this.lb_yz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_yz.Name = "lb_yz";
            this.lb_yz.Size = new System.Drawing.Size(24, 28);
            this.lb_yz.TabIndex = 16;
            this.lb_yz.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(892, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 38);
            this.label8.TabIndex = 15;
            this.label8.Text = "剩余待打印条码数量：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(924, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "实际打印条码数量:";
            // 
            // tb_prtgbmsg
            // 
            this.tb_prtgbmsg.BackColor = System.Drawing.SystemColors.MenuText;
            this.tb_prtgbmsg.ForeColor = System.Drawing.Color.Aqua;
            this.tb_prtgbmsg.Location = new System.Drawing.Point(-1, 53);
            this.tb_prtgbmsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_prtgbmsg.Multiline = true;
            this.tb_prtgbmsg.Name = "tb_prtgbmsg";
            this.tb_prtgbmsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_prtgbmsg.Size = new System.Drawing.Size(604, 232);
            this.tb_prtgbmsg.TabIndex = 7;
            // 
            // contextMenuStrip_rp
            // 
            this.contextMenuStrip_rp.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip_rp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip_rp.Name = "contextMenuStrip_rp";
            this.contextMenuStrip_rp.Size = new System.Drawing.Size(118, 48);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.显示ToolStripMenuItem.Text = "显示(&D)";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.退出ToolStripMenuItem.Text = "退出(&E)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // notifyIcon_rp
            // 
            this.notifyIcon_rp.ContextMenuStrip = this.contextMenuStrip_rp;
            this.notifyIcon_rp.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_rp.Icon")));
            this.notifyIcon_rp.Text = "上位机程序";
            this.notifyIcon_rp.Visible = true;
            this.notifyIcon_rp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_rp_MouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_prtgbmsg);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(684, 515);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(603, 306);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "玻璃面打印机状态接收区";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.bt_save);
            this.groupBox5.Controls.Add(this.btn_qhgd);
            this.groupBox5.Controls.Add(this.btn_thtm);
            this.groupBox5.Controls.Add(this.bt_dlu);
            this.groupBox5.Controls.Add(this.btn_qdgd);
            this.groupBox5.Controls.Add(this.lb_sy);
            this.groupBox5.Controls.Add(this.btn_dyjl);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.lb_yz);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(39, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1255, 181);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1255, 51);
            this.label5.TabIndex = 20;
            this.label5.Text = "                                                      鑫本智能MES系统（正式版本）            " +
    "                                                                   ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // bt_save
            // 
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_save.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_save.Location = new System.Drawing.Point(166, 80);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(118, 52);
            this.bt_save.TabIndex = 19;
            this.bt_save.Text = "保存";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(336, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 30);
            this.label9.TabIndex = 22;
            this.label9.Text = "条码警戒线：";
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(480, 213);
            this.tb_number.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(116, 21);
            this.tb_number.TabIndex = 23;
            this.tb_number.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(608, 207);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 30);
            this.label10.TabIndex = 24;
            this.label10.Text = "条码截止线";
            // 
            // tb_nbstop
            // 
            this.tb_nbstop.Location = new System.Drawing.Point(749, 211);
            this.tb_nbstop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_nbstop.Name = "tb_nbstop";
            this.tb_nbstop.Size = new System.Drawing.Size(119, 21);
            this.tb_nbstop.TabIndex = 25;
            this.tb_nbstop.Text = "999999";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1320, 857);
            this.Controls.Add(this.tb_nbstop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ck_dis);
            this.Controls.Add(this.tb_sermsg);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_gdh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯程序-测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.SizeChanged += new System.EventHandler(this.Frm_Main_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip_rp.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_startser;
        private System.Windows.Forms.TextBox tb_serport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_serip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ptserip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sermsg;
        private System.Windows.Forms.TextBox tb_ptserport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_connptser;
        private System.Windows.Forms.TextBox tb_ptsermsg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_prtgamsg;
        private System.Windows.Forms.TextBox tb_prtgbmsg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_gdh;
        private System.Windows.Forms.Button btn_qhgd;
        private System.Windows.Forms.Button btn_qdgd;
        private System.Windows.Forms.Button btn_thtm;
        private System.Windows.Forms.Label lb_sy;
        private System.Windows.Forms.Label lb_yz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_dyjl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_rp;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon_rp;
        private System.Windows.Forms.CheckBox ck_dis;
        private System.Windows.Forms.Button bt_dlu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_nbstop;
    }
}

