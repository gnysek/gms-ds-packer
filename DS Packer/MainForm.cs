using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DS_Packer
{
	public enum ImportType
	{
		None,
		List,
		Map
	}

	public enum ExportType
	{
		None,
		Txt,
		Csv,
		GML_List,
		GML_Map
	}

	public partial class MainForm : Form
	{
		//static List<string> ms_wordlist = new List<string>();

		static string g_HexText = "0123456789ABCDEF";

		// #############################################################################################
		/// Function:<summary>
		///          	Convert a string into a HEX string
		///          </summary>
		///
		/// In:		<param name="_pBuffer"></param>
		///			<param name="_pStr"></param>
		/// Out:	<returns>
		///				
		///			</returns>
		// #############################################################################################
		static string StringToHex(string _pStr)
		{
			StringBuilder sb = new StringBuilder(_pStr.Length);
			int i = 0;
			while (i < _pStr.Length)
			{
				byte[] bytes = Encoding.UTF8.GetBytes(_pStr[i].ToString());
				//string s = BitConverter.ToString(bytes).Replace("-", string.Empty);

				//sb.Append(BitConverter.ToString(bytes).Replace("-", string.Empty));

				foreach (byte b in bytes)
				{
					sb.Append(g_HexText[((b >> 4) & 0xf)]);
					sb.Append(g_HexText[(b & 0xf)]);
				}

				//int c = (int)_pStr[i];
				//sb.Append(g_HexText[((c >> 4) & 0xf)]);
				//sb.Append(g_HexText[(c & 0xf)]);
				i++;
			}
			return sb.ToString();
		}

		// #############################################################################################
		/// Function:<summary>
		///          	Convert a string into a HEX string
		///          </summary>
		///
		/// In:		<param name="_pBuffer"></param>
		///			<param name="_pStr"></param>
		/// Out:	<returns>
		///				
		///			</returns>
		// #############################################################################################
		static unsafe string DoubleToHex(double _pDouble)
		{
			UInt64 d64 = *((UInt64*)&_pDouble);
			StringBuilder sb = new StringBuilder(16);

			if (d64 == 0)
			{
				sb.Append("00");
			}
			else
			{
				while (d64 != 0)
				{
					int c = (int)((d64 & 0xff00000000000000L) >> 64 - 8);
					d64 = d64 << 8;

					sb.Append(g_HexText[((c >> 4) & 0xf)]);
					sb.Append(g_HexText[(c & 0xf)]);
				}
			}
			return sb.ToString();
		}

		private void GenerateDSListFile(string filename)
		{
			StringBuilder sb = new StringBuilder();
			int count = listView1.Items.Count;

			sb.Append("2D0100");
			sb.Append(count.ToString("X4"));
			sb.Append("000000");
			foreach (ListViewItem pair in listView1.Items)
			{
				byte[] b = Encoding.UTF8.GetBytes(pair.SubItems[1].Text);
				sb.Append("010000000000000000000000");
				sb.Append(b.Count().ToString("X2"));
				sb.Append("000000");
				sb.Append(StringToHex(pair.SubItems[1].Text));
			}

			System.IO.File.WriteAllText(@filename, "ds_list_read(argument0, \"" + sb.ToString() + "\");");

		}

		public void GenerateDSMapFile(string filename)
		{
			//listView1.Sorting = SortOrder.Ascending;
			//listView1.Sort();

			StringBuilder sb = new StringBuilder();
			int count = 0;

			/* format
			 * 0: int,int
			 * 1: string, int
			 * 2: int, string
			 * 3: string, string
			 * if key == string -> +1
			 * if value == string -> +2
			*/

			foreach (ListViewItem pair in listView1.Items)
			{
				if (count != 0) sb.Append(",");
				count++;
				sb.Append("3:");
				//sb.Append(DoubleToHex((double)count));
				sb.Append(StringToHex(pair.SubItems[0].Text));
				sb.Append(":");
				sb.Append(StringToHex(pair.SubItems[1].Text));
			}
			System.IO.File.WriteAllText(@filename, "ds_map_read(argument0, \"" + sb.ToString() + "\");");
		}

		public void GenerateTXTFile(string filename)
		{
			StringBuilder sb = new StringBuilder();
			//int count = 0;

			foreach (ListViewItem pair in listView1.Items)
			{
				sb.Append(pair.SubItems[1].Text);
				sb.AppendLine();
			}
			System.IO.File.WriteAllText(@filename, sb.ToString());
		}

		public void GenerateCSVFile(string filename)
		{
			StringBuilder sb = new StringBuilder();
			//int count = 0;

			foreach (ListViewItem pair in listView1.Items)
			{
				sb.Append(pair.SubItems[0].Text + "," + pair.SubItems[1].Text);
				sb.AppendLine();
			}
			System.IO.File.WriteAllText(@filename, sb.ToString(), Encoding.Unicode);
		}

		// #############################################################################################
		// #############################################################################################
		/// <summary>
		/// Main class
		/// </summary>

		private ImportType FileType = ImportType.None;
		public ExportType ExportSetting = ExportType.None;

		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			listView1.Columns[0].Width = listView1.Columns[1].Width = (listView1.Width / 2) - 10;
			panelTop.Height = 50;
		}

		private void btnImportCSV_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			fileFilterCSV();
			DialogResult d = openFileDialog1.ShowDialog();

			if (d == DialogResult.OK)
			{
				readCSV(openFileDialog1.FileName);
				statusBarPanel2.Text = openFileDialog1.FileName;
			}
		}

		private void fileFilterCSV()
		{
			openFileDialog1.DefaultExt = "*.csv";
			openFileDialog1.Filter = saveFileDialog1.Filter = "CSV Files|*.csv;*.txt";
		}

		private void fileFilterGDS()
		{
			openFileDialog1.DefaultExt = "*.gml";
			openFileDialog1.Filter = saveFileDialog1.Filter = "GML File|*.gml|GDS Files|*.gds|TXT File|*.txt";
		}

		private void readCSV(string filename)
		{
			bool ANSI = filename.Contains(".txt");
			ASCIIEncoding ASCII = new ASCIIEncoding();
			StreamReader sr = new StreamReader(@filename, ANSI ? Encoding.GetEncoding(1250) : Encoding.UTF8);

			string strline = "";
			string[] _values = null;
			int x = 0;
			bool list = false;

			strline = sr.ReadLine();
			_values = strline.Split(',');

			if (_values.Count() == 1)
			{
				list = true;
			}
			FileType = (list) ? ImportType.List : ImportType.Map;

			if (_values.Count() > 2)
			{
				MessageBox.Show(
					"This file isn't compatible with " + Application.ProductName + " - should have exactly 2 columns in each line!",
					Application.ProductName,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
					);
			}

			while (!sr.EndOfStream)
			{
				if (x > 0)
				{
					strline = sr.ReadLine();
					_values = strline.Split(',');
				}
				x++;

				if (list)
				{
					if (_values[0].Trim().Length > 0)
					{
						ListViewItem l = listView1.Items.Add(x.ToString());
						l.SubItems.Add(_values[0]);
					}
				}
				else
				{

					if (_values.Length >= 1 && _values[0].Trim().Length > 0)
					{
						ListViewItem l = listView1.Items.Add(_values[0]);
						l.SubItems.Add(_values[1]);
					}
				}

				if (x % 200 == 0) listView1.Refresh();
			}
			sr.Close();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (listView1.Items.Count == 0)
			{
				MessageBox.Show("You cannot export empty list!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (ExportSetting == ExportType.None)
			{
				buttonSave.SplitMenu.Show(sender as wyDay.Controls.SplitButton, new Point(0, buttonSave.Height));
				return;
			}

			switch (ExportSetting)
			{
				case ExportType.GML_Map:
				case ExportType.GML_List:
					saveFileDialog1.DefaultExt = "*.gml";
					saveFileDialog1.Filter = "GML File|" + saveFileDialog1.DefaultExt;
					break;
				case ExportType.Txt:
					saveFileDialog1.DefaultExt = "*.txt";
					saveFileDialog1.Filter = "Txt File|" + saveFileDialog1.DefaultExt;
					break;
				case ExportType.Csv:
					saveFileDialog1.DefaultExt = "*.csv";
					saveFileDialog1.Filter = "CSV File|" + saveFileDialog1.DefaultExt;
					break;
				default:
					MessageBox.Show("Not implemented...");
					break;
			}

			//fileFilterGDS();
			DialogResult d = saveFileDialog1.ShowDialog();

			if (d == DialogResult.OK)
			{
				switch (ExportSetting)
				{
					case ExportType.GML_Map:
						GenerateDSMapFile(saveFileDialog1.FileName);
						break;
					case ExportType.GML_List:
						GenerateDSListFile(saveFileDialog1.FileName);
						break;
					case ExportType.Txt:
						GenerateTXTFile(saveFileDialog1.FileName);
						break;
					case ExportType.Csv:
						GenerateCSVFile(saveFileDialog1.FileName);
						break;
					default:
						MessageBox.Show("Not implemented...");
						break;
				}
			}
		}

		private void btnOptions_Click(object sender, EventArgs e)
		{
			panelTop.Height = (panelTop.Height == 250) ? 50 : 250;
		}

		private void uncheckAndCheckItem(MenuItem select)
		{
			foreach (MenuItem item in contextMenu1.MenuItems)
			{
				item.Checked = false;
			}
			select.Checked = true;
			statusBarPanel1.Text = select.Text;

			if (listView1.Items.Count > 0)
			{
				buttonSave_Click(buttonSave, new EventArgs());
			}
		}

		private void menuItemGmlList_Click(object sender, EventArgs e)
		{
			ExportSetting = ExportType.GML_List;
			uncheckAndCheckItem(sender as MenuItem);
		}

		private void menuItemGmlMap_Click(object sender, EventArgs e)
		{
			ExportSetting = ExportType.GML_Map;
			uncheckAndCheckItem(sender as MenuItem);
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
		}

		private void menuItemTxt_Click(object sender, EventArgs e)
		{
			ExportSetting = ExportType.Txt;
			uncheckAndCheckItem(sender as MenuItem);
		}

		private void menuItemCSV_Click(object sender, EventArgs e)
		{
			ExportSetting = ExportType.Csv;
			uncheckAndCheckItem(sender as MenuItem);
		}

	}
}
