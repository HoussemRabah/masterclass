
namespace MasterClassUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pages = new System.Windows.Forms.TabControl();
            this.page_class = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.page_or = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.page_config = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.page_apr = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.pages.SuspendLayout();
            this.page_class.SuspendLayout();
            this.page_or.SuspendLayout();
            this.page_config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.page_apr.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.RoyalBlue;
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.button4);
            this.menu.Controls.Add(this.button3);
            this.menu.Controls.Add(this.button2);
            this.menu.Controls.Add(this.button1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(200, 450);
            this.menu.TabIndex = 0;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 31);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = global::MasterClassUI.Properties.Resources.icons8_info_30;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "a propos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Image = global::MasterClassUI.Properties.Resources.icons8_services_30;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "configuration";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.GhostWhite;
            this.button2.Image = global::MasterClassUI.Properties.Resources.icons8_microsoft_excel_30;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "oreiontation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Image = global::MasterClassUI.Properties.Resources.icons8_numbered_list_30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "calculer classement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(258, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "MasterClassUI";
            // 
            // pages
            // 
            this.pages.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.pages.Controls.Add(this.page_class);
            this.pages.Controls.Add(this.page_or);
            this.pages.Controls.Add(this.page_config);
            this.pages.Controls.Add(this.page_apr);
            this.pages.Location = new System.Drawing.Point(200, 7);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(660, 438);
            this.pages.TabIndex = 1;
            this.pages.SelectedIndexChanged += new System.EventHandler(this.pages_SelectedIndexChanged);
            // 
            // page_class
            // 
            this.page_class.Controls.Add(this.textBox1);
            this.page_class.Controls.Add(this.label2);
            this.page_class.Controls.Add(this.button5);
            this.page_class.Controls.Add(this.textBox2);
            this.page_class.Controls.Add(this.label1);
            this.page_class.Controls.Add(this.button6);
            this.page_class.Location = new System.Drawing.Point(4, 27);
            this.page_class.Name = "page_class";
            this.page_class.Padding = new System.Windows.Forms.Padding(3);
            this.page_class.Size = new System.Drawing.Size(652, 407);
            this.page_class.TabIndex = 0;
            this.page_class.Text = "tabPage1";
            this.page_class.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 23);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "nom du feuil concerné";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(555, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 22);
            this.button5.TabIndex = 6;
            this.button5.Text = "importer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(196, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(353, 23);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "emplacement de liste des etudiants";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(3, 372);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(646, 32);
            this.button6.TabIndex = 3;
            this.button6.Text = "exporter le classement";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // page_or
            // 
            this.page_or.Controls.Add(this.button9);
            this.page_or.Controls.Add(this.textBox7);
            this.page_or.Controls.Add(this.label7);
            this.page_or.Controls.Add(this.textBox5);
            this.page_or.Controls.Add(this.label5);
            this.page_or.Controls.Add(this.button8);
            this.page_or.Controls.Add(this.textBox6);
            this.page_or.Controls.Add(this.label6);
            this.page_or.Controls.Add(this.textBox3);
            this.page_or.Controls.Add(this.label3);
            this.page_or.Controls.Add(this.button7);
            this.page_or.Controls.Add(this.textBox4);
            this.page_or.Controls.Add(this.label4);
            this.page_or.Location = new System.Drawing.Point(4, 27);
            this.page_or.Name = "page_or";
            this.page_or.Padding = new System.Windows.Forms.Padding(3);
            this.page_or.Size = new System.Drawing.Size(652, 407);
            this.page_or.TabIndex = 1;
            this.page_or.Text = "tabPage2";
            this.page_or.UseVisualStyleBackColor = true;
            this.page_or.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.RoyalBlue;
            this.button9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(3, 372);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(646, 32);
            this.button9.TabIndex = 21;
            this.button9.Text = "exporter l\'orientation";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(196, 155);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(353, 23);
            this.textBox7.TabIndex = 20;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "indice de 1er choi";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(196, 126);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(353, 23);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "Feuil1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "nom du feuil concerné";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(555, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "importer";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(196, 99);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(353, 23);
            this.textBox6.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "emplacement des fiches de voeux";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(196, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(353, 23);
            this.textBox3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "nom du feuil concerné";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(555, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 22);
            this.button7.TabIndex = 11;
            this.button7.Text = "importer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(196, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(353, 23);
            this.textBox4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "emplacement de classement";
            // 
            // page_config
            // 
            this.page_config.Controls.Add(this.button10);
            this.page_config.Controls.Add(this.label10);
            this.page_config.Controls.Add(this.label9);
            this.page_config.Controls.Add(this.textBox8);
            this.page_config.Controls.Add(this.label8);
            this.page_config.Controls.Add(this.dataGridView1);
            this.page_config.Location = new System.Drawing.Point(4, 27);
            this.page_config.Name = "page_config";
            this.page_config.Size = new System.Drawing.Size(652, 407);
            this.page_config.TabIndex = 2;
            this.page_config.Text = "tabPage1";
            this.page_config.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.RoyalBlue;
            this.button10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(0, 375);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(652, 32);
            this.button10.TabIndex = 25;
            this.button10.Text = "enregistrer changement";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "S1,S2,S3,S4,S5,S6,a,r,d,s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "variables detecter :";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(291, 23);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(353, 23);
            this.textBox8.TabIndex = 22;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "formule de calculer moyene";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(244, 369);
            this.dataGridView1.TabIndex = 0;
            // 
            // page_apr
            // 
            this.page_apr.Controls.Add(this.panel6);
            this.page_apr.Controls.Add(this.panel4);
            this.page_apr.Controls.Add(this.panel3);
            this.page_apr.Location = new System.Drawing.Point(4, 27);
            this.page_apr.Name = "page_apr";
            this.page_apr.Size = new System.Drawing.Size(652, 407);
            this.page_apr.TabIndex = 3;
            this.page_apr.Text = "tabPage1";
            this.page_apr.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Location = new System.Drawing.Point(13, 121);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(612, 177);
            this.panel6.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(588, 75);
            this.label18.TabIndex = 1;
            this.label18.Text = resources.GetString("label18.Text");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label19.Location = new System.Drawing.Point(9, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 21);
            this.label19.TabIndex = 0;
            this.label19.Text = "description";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(330, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 100);
            this.panel4.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "tarik.benmerar@acigna.com";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label15.Location = new System.Drawing.Point(9, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "contact";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(13, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 100);
            this.panel3.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "V0.1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(9, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Version";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 31);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Right;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Image = global::MasterClassUI.Properties.Resources.icons8_macos_minimize_30__1_;
            this.button12.Location = new System.Drawing.Point(598, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(31, 31);
            this.button12.TabIndex = 1;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Right;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Image = global::MasterClassUI.Properties.Resources.icons8_macos_close_30;
            this.button11.Location = new System.Drawing.Point(629, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(31, 31);
            this.button11.TabIndex = 0;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "MasterClassUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.pages.ResumeLayout(false);
            this.page_class.ResumeLayout(false);
            this.page_class.PerformLayout();
            this.page_or.ResumeLayout(false);
            this.page_or.PerformLayout();
            this.page_config.ResumeLayout(false);
            this.page_config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.page_apr.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.TabPage page_or;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage page_class;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage page_config;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage page_apr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

