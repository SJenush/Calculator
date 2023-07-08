namespace Calculator
{
	public partial class Calculator : Form
	{
		public Calculator()
		{
			InitializeComponent();
		}
		//Screen movement
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();



		string FirstNumber, SecondNumber, action;
		string answer = "0";
		bool operation, state, signal;

		private void Close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Calculator_MouseDown(object sender, MouseEventArgs e)
		{

			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void btn_numClick(object sender, EventArgs e)
		{
			Button select = (Button)sender;
			string btn_tmp = select.Text;
			if (op.Text == "")
			{
				if (Screen.Text == "0")
				{
					Screen.Text = btn_tmp;
				}
				else
				{
					Screen.Text = Screen.Text + btn_tmp;
				}
				state = false;
			}
			else if (operation)
			{
				state = true;
				Screen_show.Text = btn_tmp;

				operation = true;
				action = op.Text;
				
			}
			else if (Screen_show.Enabled)
			{
				Screen_show.Text = Screen_show.Text + btn_tmp;
				operation = false;
			}
			else
			{
				Screen.Text = btn_tmp;
				op.Text = "";
				operation = false;
				state = false;
			}


			if (state)
			{
				Screen.Enabled = false;
				Screen_show.Enabled = true;
			}
			else
			{
				Screen.Enabled = true;
				Screen_show.Enabled = false;

			}
			ShowSampleOutput();
			operation = false;
			signal = false;

		}

		private void Calculator_Load(object sender, EventArgs e)
		{
			Screen.BackColor = SystemColors.Control;
			//Screen.BackColor = SystemColors.Control;
			Screen_show.BackColor = SystemColors.Control;
			Result_Preview.BackColor = SystemColors.Control;
			Screen.Text = "0";
			op.Text = "";
			operation = false;
			this.ActiveControl = btn_0;
		}

		private void op_Click(object sender, EventArgs e)
		{
			operation = true;
			Button btn = (Button)sender;
			op.Text = btn.Text;

			action = op.Text;
			if ((Screen_show.Enabled)&& !signal)
			{
				//Screen.Enabled = true;
				//	Screen_show.Enabled = false;
				Screen.Text = Result_Preview.Text;
				Screen_show.Text = "";
				Result_Preview.Text = "";
				state = true;
			}

			FirstNumber = Screen.Text;

			state = true;
			signal = true;
		}

		private void btn_dot_Click(object sender, EventArgs e)
		{
			if (op.Text == "")
			{

				string tmp_data = Screen.Text;
				if (!tmp_data.Contains("."))
				{
					Screen.Text = tmp_data + ".";
				}
			}
			else
			{
				if (state)
				{
					string tmp_data = Screen_show.Text;
					if (Screen_show.Text == "")
					{
						FirstNumber = Screen.Text;
						action = op.Text;
						Screen_show.Text = "0.";
						Screen.Enabled = false;
						Screen_show.Enabled = true;
						operation = false;
					}
					else
					if (!tmp_data.Contains("."))
					{
						Screen_show.Text = tmp_data + ".";
					}

				}
			}


		}
		private void ShowSampleOutput()
		{
			if (!(FirstNumber == "") || !(op.Text == ""))
			{
				Result_Preview.Text = Output();
			}
		}
		private string Output()
		{
			try
			{
				string second = Screen_show.Text;

				double first_num = Convert.ToDouble(FirstNumber);
				double second_num = Convert.ToDouble(second);
				double result;
				switch (action)
				{
					case "+":
						result = first_num + second_num;
						answer = result.ToString();
						return answer;
					case "-":
						result = first_num - second_num;
						answer = result.ToString();
						return answer;
					case "x":
						result = first_num * second_num;
						answer = result.ToString();
						return answer;

					case "/":
						result = first_num / second_num;
						answer = result.ToString();
						return answer;
				}

			}
			catch (Exception ex) { ex.ToString(); };
			return null;
		}
		private void Screen_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_ce_Click(object sender, EventArgs e)
		{
			state = false;
			Screen.Enabled = true;
			Screen_show.Enabled = false;
			Screen.Text = "0";
			operation = false;
			action = "";
			op.Text = "";
			Result_Preview.Text = "";
			Screen_show.Text = "";
			//answer = "0";
		}

		private void btn_equal_Click(object sender, EventArgs e)
		{
			Screen.Text = answer;
			state = false;
			Screen.Enabled = true;
			Screen_show.Enabled = false;
			Result_Preview.Text = "";
			Screen_show.Text = "";
			op.Text = "=";
		}

		private void Result_Preview_TextChanged(object sender, EventArgs e)
		{

		}

		private void Screen_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				btn_equal.PerformClick();
			}
			if(e.KeyCode == Keys.Back)
			{
				BackSpace();
			}
		}
		private void BackSpace()
		{
			if (state)
			{
				string tmp = Screen_show.Text;
				int num=tmp.Length;
				if (num == 1 && !(tmp == "0"))
				{
					Screen_show.Text="0";
				}
				else if(num>1)
				{
					string tmp1=tmp.Remove(tmp.Length-1);
					Screen_show.Text=tmp1;
				}
			}else
			if (!state)
			{
				string tmp = Screen.Text;
				int num = tmp.Length;
				if (num == 1 && !(tmp == "0"))
				{
					Screen.Text = "0";
				}
				else if (num > 1)
				{
					string tmp1 = tmp.Remove(tmp.Length - 1);
					Screen.Text = tmp1;
				}
			}
			ShowSampleOutput();
		}
		private void Screen_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(e.KeyChar == Convert.ToChar(Keys.Enter)))
			{
				string value = e.KeyChar.ToString();
				switch (value)
				{
					case "+":
						btn_add.PerformClick();
						break;
					case "-":
						btn_sub.PerformClick();
						break;
					case "*":
						btn_mul.PerformClick();
						break;
					case "/":
						btn_div.PerformClick();
						break;


					case "1":
						btn_1.PerformClick();
						break;
					case "2":
						btn_2.PerformClick();
						break;
					case "3":
						btn_3.PerformClick();
						break;
					case "4":
						btn_4.PerformClick();
						break;
					case "5":
						btn_5.PerformClick();
						break;
					case "6":
						btn_6.PerformClick();
						break;
					case "7":
						btn_7.PerformClick();
						break;

					case "8":
						btn_8.PerformClick();
						break;
					case "9":
						btn_9.PerformClick();
						break;
					case "0":
						btn_0.PerformClick();
						break;
					case ".":
						btn_dot.PerformClick();
						break;

				}
			}
		}

		private void PlusMinus_Click(object sender, EventArgs e)
		{
			if (state)
			{
				string tmp = Screen_show.Text;
				if (tmp.Contains("-"))
				{
					string tmpp = tmp.Replace("-", "");
					Screen_show.Text = tmpp;
				}
				else
				{
					Screen_show.Text = "-" + tmp;
				}
			}
			else
			{


				string tmp = Screen.Text;
				if (tmp.Contains("-"))
				{
					string tmpp = tmp.Replace("-", "");
					Screen.Text = tmpp;
				}
				else
				{
					Screen.Text = "-" + tmp;
				}
			}
			ShowSampleOutput();
			if (op.Text == "=") { op.Text = ""; }
		}

		private void SquareRoot_Click(object sender, EventArgs e)
		{
			if (state)
			{
				string tmp = Screen_show.Text;
				double num = Convert.ToDouble(tmp);
				double number = Math.Sqrt(num);
				Screen_show.Text = number.ToString();
			}
			else
			{
				string tmp = Screen.Text;
				double num = Convert.ToDouble(tmp);
				double number = Math.Sqrt(num);
				Screen.Text = number.ToString();
				answer = Screen.Text;
			}
			ShowSampleOutput();
		}

		private void M_Click(object sender, EventArgs e)
		{

			if (state)
			{
				SecondNumber = Screen_show.Text;


			}
			else
			{
				SecondNumber = Screen.Text;

			}
		}

		private void M_Add_Click(object sender, EventArgs e)
		{
			if (state)
			{
				if (signal)
				{
					Screen.Enabled = false;
					Screen_show.Enabled = true;
					Screen_show.Text = SecondNumber;
				}
				else
				{
					Screen_show.Text += SecondNumber;
				}

			}
			else
			{

				if (op.Text == "")
					Screen.Text = Screen.Text + SecondNumber;
				else
				{
					FirstNumber = Screen.Text;
					Screen.Text = SecondNumber;
				}
			}
			ShowSampleOutput();
		}

		private void btn_c_Click(object sender, EventArgs e)
		{
			if (state)
			{
				Screen_show.Enabled = true;
				Screen.Enabled = false;
				Screen_show.Text = "0";
				Result_Preview.Text = "";
				answer = Screen.Text;
			}
			else
			{
				Screen.Enabled = true;
				Screen_show.Enabled = false;
				Screen.Text = "0";
				operation = false;
				action = "";
				op.Text = "";
				Result_Preview.Text = "";
				Screen_show.Text = "";
				answer = "0";
			}

		}

		private void btn_r_Click(object sender, EventArgs e)
		{
			if (Screen_show.Enabled)
			{
				string tmp = Result_Preview.Text;
				double num = Convert.ToDouble(tmp);
				double num2 = Math.Round(num, 2);
				Result_Preview.Text = num2.ToString();
			}
			else
			{


				string tmp = Screen.Text;
				double num = Convert.ToDouble(tmp);
				double num2 = Math.Round(num, 2);
				Screen.Text = num2.ToString();
				answer = Screen.Text;
			}

		}
	}
}