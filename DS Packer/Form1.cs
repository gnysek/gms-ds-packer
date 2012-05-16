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
	public partial class Form1 : Form
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
				int c = (int)_pStr[i];
				sb.Append(g_HexText[((c >> 4) & 0xf)]);
				sb.Append(g_HexText[(c & 0xf)]);
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

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			listView1.Columns[0].Width = listView1.Columns[1].Width = listView1.Width / 2 - 2;
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
			}
		}

		private void fileFilterCSV()
		{
			openFileDialog1.Filter = saveFileDialog1.Filter = "CSV Files|*.csv;*.txt";
		}

		private void fileFilterGDS()
		{
			openFileDialog1.Filter = saveFileDialog1.Filter = "GDS Files|*.gds|TXT File|*.txt";
		}

		private void readCSV(string filename)
		{
			StreamReader sr = new StreamReader(@filename);
			// for set encoding
			// StreamReader sr = new StreamReader(@"file.csv", Encoding.GetEncoding(1250));

			string strline = "";
			string[] _values = null;
			int x = 0;
			while (!sr.EndOfStream)
			{
				x++;
				strline = sr.ReadLine();
				_values = strline.Split(',');

				if (_values.Count() != 2)
				{
					MessageBox.Show(
						"This file isn't compatible with " + Application.ProductName + " - should have exactly 2 columns in each line!",
						Application.ProductName,
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
						);
					break;
				}

				if (_values.Length >= 1 && _values[0].Trim().Length > 0)
				{
					ListViewItem l = listView1.Items.Add(_values[0]);
					l.SubItems.Add(_values[1]);
				}
			}
			sr.Close();
		}

		private void splitButton1_Click(object sender, EventArgs e)
		{
			fileFilterGDS();
			DialogResult d = saveFileDialog1.ShowDialog();

			if (d == DialogResult.OK)
			{
				GenerateDSMapFile(saveFileDialog1.FileName);
				//GenerateDSListFile(saveFileDialog1.FileName);
			}

			d = saveFileDialog1.ShowDialog();

			if (d == DialogResult.OK)
			{
				//GenerateDSMapFile(saveFileDialog1.FileName);
				GenerateDSListFile(saveFileDialog1.FileName);
			}
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
				sb.Append("010000000000000000000000");
				sb.Append(pair.SubItems[0].Text.Length.ToString("X2"));
				sb.Append("000000");
				sb.Append(StringToHex(pair.SubItems[0].Text));
			}

			System.IO.File.WriteAllText(@filename, sb.ToString());

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
				sb.Append(StringToHex(pair.Text));
				sb.Append(":");
				sb.Append(StringToHex(pair.SubItems[0].Text));
			}
			System.IO.File.WriteAllText(@filename, sb.ToString());
		}

		private void btnOptions_Click(object sender, EventArgs e)
		{
			panelTop.Height = 250;
		}

	}
}
