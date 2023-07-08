
namespace Calculator
{
	partial class Calculator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			minimize = new Button();
			Close = new Button();
			Screen_Out = new RichTextBox();
			btn_ce = new Button();
			btn_c = new Button();
			btn_r = new Button();
			btn_7 = new Button();
			btn_8 = new Button();
			btn_9 = new Button();
			btn_1 = new Button();
			btn_2 = new Button();
			btn_3 = new Button();
			btn_10 = new Button();
			btn_0 = new Button();
			btn_dot = new Button();
			btn_equal = new Button();
			btn_add = new Button();
			btn_mul = new Button();
			btn_div = new Button();
			btn_4 = new Button();
			btn_5 = new Button();
			btn_6 = new Button();
			btn_sub = new Button();
			op = new Label();
			Result_Preview = new TextBox();
			Memory = new Button();
			M_Add = new Button();
			PlusMinus = new Button();
			SquareRoot = new Button();
			Screen = new TextBox();
			Screen_show = new TextBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.LightGray;
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(minimize);
			panel1.Controls.Add(Close);
			panel1.Dock = DockStyle.Top;
			panel1.ForeColor = Color.White;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(355, 30);
			panel1.TabIndex = 0;
			panel1.MouseDown += Calculator_MouseDown;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.Calculator;
			pictureBox1.Location = new Point(7, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(27, 23);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			pictureBox1.MouseDown += Calculator_MouseDown;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.Blue;
			label1.Location = new Point(33, 5);
			label1.Name = "label1";
			label1.Size = new Size(80, 21);
			label1.TabIndex = 3;
			label1.Text = "Calculator";
			label1.MouseDown += Calculator_MouseDown;
			// 
			// minimize
			// 
			minimize.BackColor = Color.LightGray;
			minimize.FlatAppearance.BorderSize = 0;
			minimize.FlatStyle = FlatStyle.Flat;
			minimize.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold, GraphicsUnit.Point);
			minimize.ForeColor = Color.White;
			minimize.Location = new Point(273, -17);
			minimize.Margin = new Padding(0);
			minimize.Name = "minimize";
			minimize.Size = new Size(41, 47);
			minimize.TabIndex = 2;
			minimize.Text = "__";
			minimize.UseVisualStyleBackColor = false;
			minimize.Click += minimize_Click;
			// 
			// Close
			// 
			Close.BackColor = Color.LightGray;
			Close.FlatAppearance.BorderSize = 0;
			Close.FlatAppearance.MouseOverBackColor = Color.Red;
			Close.FlatStyle = FlatStyle.Flat;
			Close.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			Close.ForeColor = Color.White;
			Close.Location = new Point(314, 0);
			Close.Margin = new Padding(0);
			Close.Name = "Close";
			Close.Size = new Size(41, 30);
			Close.TabIndex = 1;
			Close.Text = "X";
			Close.UseVisualStyleBackColor = false;
			Close.Click += Close_Click;
			// 
			// Screen_Out
			// 
			Screen_Out.BorderStyle = BorderStyle.None;
			Screen_Out.DetectUrls = false;
			Screen_Out.Enabled = false;
			Screen_Out.Font = new Font("Segoe UI", 20.5F, FontStyle.Regular, GraphicsUnit.Point);
			Screen_Out.Location = new Point(10, 41);
			Screen_Out.Margin = new Padding(0);
			Screen_Out.MaxLength = 20;
			Screen_Out.Multiline = false;
			Screen_Out.Name = "Screen_Out";
			Screen_Out.ReadOnly = true;
			Screen_Out.RightToLeft = RightToLeft.No;
			Screen_Out.ScrollBars = RichTextBoxScrollBars.None;
			Screen_Out.Size = new Size(333, 137);
			Screen_Out.TabIndex = 1;
			Screen_Out.Text = "";
			Screen_Out.TextChanged += Screen_TextChanged;
			Screen_Out.KeyPress += Screen_KeyPress;
			Screen_Out.KeyUp += Screen_KeyUp;
			// 
			// btn_ce
			// 
			btn_ce.BackColor = Color.Red;
			btn_ce.FlatAppearance.BorderSize = 0;
			btn_ce.FlatStyle = FlatStyle.Flat;
			btn_ce.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_ce.ForeColor = Color.White;
			btn_ce.Location = new Point(13, 191);
			btn_ce.Name = "btn_ce";
			btn_ce.Size = new Size(62, 50);
			btn_ce.TabIndex = 2;
			btn_ce.Text = "CE";
			btn_ce.UseVisualStyleBackColor = false;
			btn_ce.Click += btn_ce_Click;
			btn_ce.KeyPress += Screen_KeyPress;
			btn_ce.KeyUp += Screen_KeyUp;
			// 
			// btn_c
			// 
			btn_c.BackColor = Color.Red;
			btn_c.FlatAppearance.BorderSize = 0;
			btn_c.FlatStyle = FlatStyle.Flat;
			btn_c.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_c.ForeColor = Color.White;
			btn_c.Location = new Point(101, 191);
			btn_c.Name = "btn_c";
			btn_c.Size = new Size(61, 50);
			btn_c.TabIndex = 3;
			btn_c.Text = "C";
			btn_c.UseVisualStyleBackColor = false;
			btn_c.Click += btn_c_Click;
			btn_c.KeyPress += Screen_KeyPress;
			btn_c.KeyUp += Screen_KeyUp;
			// 
			// btn_r
			// 
			btn_r.BackColor = Color.Red;
			btn_r.FlatAppearance.BorderSize = 0;
			btn_r.FlatStyle = FlatStyle.Flat;
			btn_r.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_r.ForeColor = Color.White;
			btn_r.Location = new Point(186, 191);
			btn_r.Name = "btn_r";
			btn_r.Size = new Size(61, 50);
			btn_r.TabIndex = 4;
			btn_r.Text = "R";
			btn_r.UseVisualStyleBackColor = false;
			btn_r.Click += btn_r_Click;
			btn_r.KeyPress += Screen_KeyPress;
			btn_r.KeyUp += Screen_KeyUp;
			// 
			// btn_7
			// 
			btn_7.BackColor = Color.Blue;
			btn_7.FlatAppearance.BorderSize = 0;
			btn_7.FlatStyle = FlatStyle.Flat;
			btn_7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_7.ForeColor = Color.White;
			btn_7.Location = new Point(15, 317);
			btn_7.Name = "btn_7";
			btn_7.Size = new Size(62, 50);
			btn_7.TabIndex = 5;
			btn_7.Text = "7";
			btn_7.UseVisualStyleBackColor = false;
			btn_7.Click += btn_numClick;
			btn_7.KeyPress += Screen_KeyPress;
			btn_7.KeyUp += Screen_KeyUp;
			// 
			// btn_8
			// 
			btn_8.BackColor = Color.Blue;
			btn_8.FlatAppearance.BorderSize = 0;
			btn_8.FlatStyle = FlatStyle.Flat;
			btn_8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_8.ForeColor = Color.White;
			btn_8.Location = new Point(101, 317);
			btn_8.Name = "btn_8";
			btn_8.Size = new Size(61, 50);
			btn_8.TabIndex = 6;
			btn_8.TabStop = false;
			btn_8.Text = "8";
			btn_8.UseVisualStyleBackColor = false;
			btn_8.Click += btn_numClick;
			btn_8.KeyPress += Screen_KeyPress;
			btn_8.KeyUp += Screen_KeyUp;
			// 
			// btn_9
			// 
			btn_9.BackColor = Color.Blue;
			btn_9.FlatAppearance.BorderSize = 0;
			btn_9.FlatStyle = FlatStyle.Flat;
			btn_9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_9.ForeColor = Color.White;
			btn_9.Location = new Point(186, 317);
			btn_9.Name = "btn_9";
			btn_9.Size = new Size(61, 50);
			btn_9.TabIndex = 7;
			btn_9.Text = "9";
			btn_9.UseVisualStyleBackColor = false;
			btn_9.Click += btn_numClick;
			btn_9.KeyPress += Screen_KeyPress;
			btn_9.KeyUp += Screen_KeyUp;
			// 
			// btn_1
			// 
			btn_1.BackColor = Color.Blue;
			btn_1.FlatAppearance.BorderSize = 0;
			btn_1.FlatStyle = FlatStyle.Flat;
			btn_1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_1.ForeColor = Color.White;
			btn_1.Location = new Point(15, 457);
			btn_1.Name = "btn_1";
			btn_1.Size = new Size(62, 50);
			btn_1.TabIndex = 8;
			btn_1.Text = "1";
			btn_1.UseVisualStyleBackColor = false;
			btn_1.Click += btn_numClick;
			btn_1.KeyPress += Screen_KeyPress;
			btn_1.KeyUp += Screen_KeyUp;
			// 
			// btn_2
			// 
			btn_2.BackColor = Color.Blue;
			btn_2.FlatAppearance.BorderSize = 0;
			btn_2.FlatStyle = FlatStyle.Flat;
			btn_2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_2.ForeColor = Color.White;
			btn_2.Location = new Point(101, 457);
			btn_2.Name = "btn_2";
			btn_2.Size = new Size(61, 50);
			btn_2.TabIndex = 9;
			btn_2.Text = "2";
			btn_2.UseVisualStyleBackColor = false;
			btn_2.Click += btn_numClick;
			btn_2.KeyPress += Screen_KeyPress;
			btn_2.KeyUp += Screen_KeyUp;
			// 
			// btn_3
			// 
			btn_3.BackColor = Color.Blue;
			btn_3.FlatAppearance.BorderSize = 0;
			btn_3.FlatStyle = FlatStyle.Flat;
			btn_3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_3.ForeColor = Color.White;
			btn_3.Location = new Point(186, 457);
			btn_3.Name = "btn_3";
			btn_3.Size = new Size(61, 50);
			btn_3.TabIndex = 10;
			btn_3.Text = "3";
			btn_3.UseVisualStyleBackColor = false;
			btn_3.Click += btn_numClick;
			btn_3.KeyPress += Screen_KeyPress;
			btn_3.KeyUp += Screen_KeyUp;
			// 
			// btn_10
			// 
			btn_10.BackColor = Color.Blue;
			btn_10.FlatAppearance.BorderSize = 0;
			btn_10.FlatStyle = FlatStyle.Flat;
			btn_10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_10.ForeColor = Color.White;
			btn_10.Location = new Point(15, 529);
			btn_10.Name = "btn_10";
			btn_10.Size = new Size(62, 50);
			btn_10.TabIndex = 11;
			btn_10.Text = "00";
			btn_10.UseVisualStyleBackColor = false;
			btn_10.Click += btn_numClick;
			btn_10.KeyPress += Screen_KeyPress;
			btn_10.KeyUp += Screen_KeyUp;
			// 
			// btn_0
			// 
			btn_0.BackColor = Color.Blue;
			btn_0.FlatAppearance.BorderSize = 0;
			btn_0.FlatStyle = FlatStyle.Flat;
			btn_0.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_0.ForeColor = Color.White;
			btn_0.Location = new Point(101, 529);
			btn_0.Name = "btn_0";
			btn_0.Size = new Size(61, 50);
			btn_0.TabIndex = 12;
			btn_0.Text = "0";
			btn_0.UseVisualStyleBackColor = false;
			btn_0.Click += btn_numClick;
			btn_0.KeyPress += Screen_KeyPress;
			btn_0.KeyUp += Screen_KeyUp;
			// 
			// btn_dot
			// 
			btn_dot.BackColor = Color.FromArgb(255, 128, 0);
			btn_dot.FlatAppearance.BorderSize = 0;
			btn_dot.FlatStyle = FlatStyle.Flat;
			btn_dot.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_dot.ForeColor = Color.White;
			btn_dot.Location = new Point(186, 529);
			btn_dot.Name = "btn_dot";
			btn_dot.Size = new Size(61, 50);
			btn_dot.TabIndex = 13;
			btn_dot.Text = ".";
			btn_dot.UseVisualStyleBackColor = false;
			btn_dot.Click += btn_dot_Click;
			btn_dot.KeyPress += Screen_KeyPress;
			btn_dot.KeyUp += Screen_KeyUp;
			// 
			// btn_equal
			// 
			btn_equal.BackColor = Color.FromArgb(255, 128, 0);
			btn_equal.FlatAppearance.BorderSize = 0;
			btn_equal.FlatStyle = FlatStyle.Flat;
			btn_equal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_equal.ForeColor = Color.White;
			btn_equal.Location = new Point(276, 529);
			btn_equal.Name = "btn_equal";
			btn_equal.Size = new Size(61, 50);
			btn_equal.TabIndex = 17;
			btn_equal.Text = "=";
			btn_equal.UseVisualStyleBackColor = false;
			btn_equal.Click += btn_equal_Click;
			btn_equal.KeyPress += Screen_KeyPress;
			btn_equal.KeyUp += Screen_KeyUp;
			// 
			// btn_add
			// 
			btn_add.BackColor = Color.LimeGreen;
			btn_add.FlatAppearance.BorderSize = 0;
			btn_add.FlatStyle = FlatStyle.Flat;
			btn_add.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_add.ForeColor = Color.White;
			btn_add.Location = new Point(276, 457);
			btn_add.Name = "btn_add";
			btn_add.Size = new Size(61, 50);
			btn_add.TabIndex = 16;
			btn_add.Text = "+";
			btn_add.UseVisualStyleBackColor = false;
			btn_add.Click += op_Click;
			btn_add.KeyPress += Screen_KeyPress;
			btn_add.KeyUp += Screen_KeyUp;
			// 
			// btn_mul
			// 
			btn_mul.BackColor = Color.LimeGreen;
			btn_mul.FlatAppearance.BorderSize = 0;
			btn_mul.FlatStyle = FlatStyle.Flat;
			btn_mul.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_mul.ForeColor = Color.White;
			btn_mul.Location = new Point(276, 317);
			btn_mul.Name = "btn_mul";
			btn_mul.Size = new Size(61, 50);
			btn_mul.TabIndex = 15;
			btn_mul.Text = "x";
			btn_mul.UseVisualStyleBackColor = false;
			btn_mul.Click += op_Click;
			btn_mul.KeyPress += Screen_KeyPress;
			btn_mul.KeyUp += Screen_KeyUp;
			// 
			// btn_div
			// 
			btn_div.BackColor = Color.LimeGreen;
			btn_div.FlatAppearance.BorderSize = 0;
			btn_div.FlatStyle = FlatStyle.Flat;
			btn_div.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_div.ForeColor = Color.White;
			btn_div.Location = new Point(276, 251);
			btn_div.Name = "btn_div";
			btn_div.Size = new Size(61, 50);
			btn_div.TabIndex = 14;
			btn_div.Text = "/";
			btn_div.UseVisualStyleBackColor = false;
			btn_div.Click += op_Click;
			btn_div.KeyPress += Screen_KeyPress;
			btn_div.KeyUp += Screen_KeyUp;
			// 
			// btn_4
			// 
			btn_4.BackColor = Color.Blue;
			btn_4.FlatAppearance.BorderSize = 0;
			btn_4.FlatStyle = FlatStyle.Flat;
			btn_4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_4.ForeColor = Color.White;
			btn_4.Location = new Point(15, 388);
			btn_4.Name = "btn_4";
			btn_4.Size = new Size(62, 50);
			btn_4.TabIndex = 5;
			btn_4.Text = "4";
			btn_4.UseVisualStyleBackColor = false;
			btn_4.Click += btn_numClick;
			btn_4.KeyPress += Screen_KeyPress;
			btn_4.KeyUp += Screen_KeyUp;
			// 
			// btn_5
			// 
			btn_5.BackColor = Color.Blue;
			btn_5.FlatAppearance.BorderSize = 0;
			btn_5.FlatStyle = FlatStyle.Flat;
			btn_5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_5.ForeColor = Color.White;
			btn_5.Location = new Point(101, 388);
			btn_5.Name = "btn_5";
			btn_5.Size = new Size(61, 50);
			btn_5.TabIndex = 6;
			btn_5.Text = "5";
			btn_5.UseVisualStyleBackColor = false;
			btn_5.Click += btn_numClick;
			btn_5.KeyPress += Screen_KeyPress;
			btn_5.KeyUp += Screen_KeyUp;
			// 
			// btn_6
			// 
			btn_6.BackColor = Color.Blue;
			btn_6.FlatAppearance.BorderSize = 0;
			btn_6.FlatStyle = FlatStyle.Flat;
			btn_6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_6.ForeColor = Color.White;
			btn_6.Location = new Point(186, 388);
			btn_6.Name = "btn_6";
			btn_6.Size = new Size(61, 50);
			btn_6.TabIndex = 7;
			btn_6.Text = "6";
			btn_6.UseVisualStyleBackColor = false;
			btn_6.Click += btn_numClick;
			btn_6.KeyPress += Screen_KeyPress;
			btn_6.KeyUp += Screen_KeyUp;
			// 
			// btn_sub
			// 
			btn_sub.BackColor = Color.LimeGreen;
			btn_sub.FlatAppearance.BorderSize = 0;
			btn_sub.FlatStyle = FlatStyle.Flat;
			btn_sub.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			btn_sub.ForeColor = Color.White;
			btn_sub.Location = new Point(276, 388);
			btn_sub.Name = "btn_sub";
			btn_sub.Size = new Size(61, 50);
			btn_sub.TabIndex = 15;
			btn_sub.Text = "-";
			btn_sub.UseVisualStyleBackColor = false;
			btn_sub.Click += op_Click;
			btn_sub.KeyPress += Screen_KeyPress;
			btn_sub.KeyUp += Screen_KeyUp;
			// 
			// op
			// 
			op.AutoSize = true;
			op.BackColor = Color.White;
			op.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
			op.ForeColor = Color.Black;
			op.Location = new Point(14, 97);
			op.Name = "op";
			op.Size = new Size(28, 31);
			op.TabIndex = 4;
			op.Text = "X";
			// 
			// Result_Preview
			// 
			Result_Preview.BackColor = SystemColors.ActiveCaption;
			Result_Preview.BorderStyle = BorderStyle.None;
			Result_Preview.Enabled = false;
			Result_Preview.Font = new Font("Segoe UI", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
			Result_Preview.ForeColor = Color.Gray;
			Result_Preview.Location = new Point(23, 140);
			Result_Preview.MaxLength = 20;
			Result_Preview.Name = "Result_Preview";
			Result_Preview.ReadOnly = true;
			Result_Preview.RightToLeft = RightToLeft.No;
			Result_Preview.Size = new Size(314, 30);
			Result_Preview.TabIndex = 18;
			Result_Preview.TextAlign = HorizontalAlignment.Right;
			Result_Preview.TextChanged += Result_Preview_TextChanged;
			// 
			// Memory
			// 
			Memory.BackColor = Color.FromArgb(192, 0, 192);
			Memory.FlatAppearance.BorderSize = 0;
			Memory.FlatStyle = FlatStyle.Flat;
			Memory.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			Memory.ForeColor = Color.White;
			Memory.Location = new Point(13, 251);
			Memory.Name = "Memory";
			Memory.Size = new Size(62, 50);
			Memory.TabIndex = 2;
			Memory.Text = "M";
			Memory.UseVisualStyleBackColor = false;
			Memory.Click += M_Click;
			Memory.KeyPress += Screen_KeyPress;
			Memory.KeyUp += Screen_KeyUp;
			// 
			// M_Add
			// 
			M_Add.BackColor = Color.FromArgb(192, 0, 192);
			M_Add.FlatAppearance.BorderSize = 0;
			M_Add.FlatStyle = FlatStyle.Flat;
			M_Add.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			M_Add.ForeColor = Color.White;
			M_Add.Location = new Point(101, 251);
			M_Add.Name = "M_Add";
			M_Add.Size = new Size(61, 50);
			M_Add.TabIndex = 3;
			M_Add.Text = "M+";
			M_Add.UseVisualStyleBackColor = false;
			M_Add.Click += M_Add_Click;
			M_Add.KeyPress += Screen_KeyPress;
			M_Add.KeyUp += Screen_KeyUp;
			// 
			// PlusMinus
			// 
			PlusMinus.BackColor = Color.LimeGreen;
			PlusMinus.FlatAppearance.BorderSize = 0;
			PlusMinus.FlatStyle = FlatStyle.Flat;
			PlusMinus.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			PlusMinus.ForeColor = Color.White;
			PlusMinus.Location = new Point(186, 251);
			PlusMinus.Name = "PlusMinus";
			PlusMinus.Size = new Size(61, 50);
			PlusMinus.TabIndex = 4;
			PlusMinus.Text = "±";
			PlusMinus.UseVisualStyleBackColor = false;
			PlusMinus.Click += PlusMinus_Click;
			PlusMinus.KeyPress += Screen_KeyPress;
			PlusMinus.KeyUp += Screen_KeyUp;
			// 
			// SquareRoot
			// 
			SquareRoot.BackColor = Color.LimeGreen;
			SquareRoot.FlatAppearance.BorderSize = 0;
			SquareRoot.FlatStyle = FlatStyle.Flat;
			SquareRoot.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			SquareRoot.ForeColor = Color.White;
			SquareRoot.Location = new Point(276, 191);
			SquareRoot.Name = "SquareRoot";
			SquareRoot.Size = new Size(61, 50);
			SquareRoot.TabIndex = 4;
			SquareRoot.Text = "√";
			SquareRoot.UseVisualStyleBackColor = false;
			SquareRoot.Click += SquareRoot_Click;
			SquareRoot.KeyPress += Screen_KeyPress;
			SquareRoot.KeyUp += Screen_KeyUp;
			// 
			// Screen
			// 
			Screen.BackColor = SystemColors.ActiveCaption;
			Screen.BorderStyle = BorderStyle.None;
			Screen.Font = new Font("Segoe UI", 19.5F, FontStyle.Regular, GraphicsUnit.Point);
			Screen.ForeColor = Color.Black;
			Screen.Location = new Point(23, 53);
			Screen.MaxLength = 20;
			Screen.Name = "Screen";
			Screen.ReadOnly = true;
			Screen.RightToLeft = RightToLeft.No;
			Screen.Size = new Size(314, 35);
			Screen.TabIndex = 18;
			Screen.TextAlign = HorizontalAlignment.Right;
			Screen.TextChanged += Screen_TextChanged;
			Screen.KeyPress += Screen_KeyPress;
			Screen.KeyUp += Screen_KeyUp;
			// 
			// Screen_show
			// 
			Screen_show.BackColor = SystemColors.ActiveCaption;
			Screen_show.BorderStyle = BorderStyle.None;
			Screen_show.Enabled = false;
			Screen_show.Font = new Font("Segoe UI", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
			Screen_show.ForeColor = Color.Black;
			Screen_show.Location = new Point(41, 97);
			Screen_show.MaxLength = 20;
			Screen_show.Name = "Screen_show";
			Screen_show.ReadOnly = true;
			Screen_show.RightToLeft = RightToLeft.No;
			Screen_show.Size = new Size(296, 30);
			Screen_show.TabIndex = 18;
			Screen_show.TextAlign = HorizontalAlignment.Right;
			Screen_show.TextChanged += Screen_TextChanged;
			Screen_show.KeyPress += Screen_KeyPress;
			Screen_show.KeyUp += Screen_KeyUp;
			// 
			// Calculator
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Gainsboro;
			ClientSize = new Size(355, 597);
			Controls.Add(Screen_show);
			Controls.Add(Screen);
			Controls.Add(Result_Preview);
			Controls.Add(op);
			Controls.Add(btn_equal);
			Controls.Add(btn_add);
			Controls.Add(btn_sub);
			Controls.Add(btn_mul);
			Controls.Add(btn_div);
			Controls.Add(btn_dot);
			Controls.Add(btn_0);
			Controls.Add(btn_10);
			Controls.Add(btn_3);
			Controls.Add(btn_2);
			Controls.Add(btn_1);
			Controls.Add(btn_6);
			Controls.Add(btn_9);
			Controls.Add(btn_5);
			Controls.Add(btn_4);
			Controls.Add(btn_8);
			Controls.Add(btn_7);
			Controls.Add(SquareRoot);
			Controls.Add(PlusMinus);
			Controls.Add(btn_r);
			Controls.Add(M_Add);
			Controls.Add(btn_c);
			Controls.Add(Memory);
			Controls.Add(btn_ce);
			Controls.Add(Screen_Out);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "Calculator";
			Text = "Calculator";
			Load += Calculator_Load;
			KeyPress += Screen_KeyPress;
			KeyUp += Screen_KeyUp;
			MouseDown += Calculator_MouseDown;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Button minimize;
		private Button Close;
		private RichTextBox Screen_Out;
		private Button btn_ce;
		private Button btn_c;
		private Button btn_r;
		private Button btn_7;
		private Button btn_8;
		private Button btn_9;
		private Button btn_1;
		private Button btn_2;
		private Button btn_3;
		private Button btn_10;
		private Button btn_0;
		private Button btn_dot;
		private Button btn_equal;
		private Button btn_add;
		private Button btn_mul;
		private Button btn_div;
		private Button btn_4;
		private Button btn_5;
		private Button btn_6;
		private Button btn_sub;
		private Label op;
		private TextBox Result_Preview;
		private Button Memory;
		private Button M_Add;
		private Button PlusMinus;
		private Button SquareRoot;
		private TextBox Screen;
		private TextBox Screen_show;
		private PictureBox pictureBox1;
	}
}