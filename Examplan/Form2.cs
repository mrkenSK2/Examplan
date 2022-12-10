using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examplan
{
    public partial class Form2 : Form
    {
        public Form1 f1;
        /*public Form2()
        {
            InitializeComponent();
        }*/

        public Form2(Form1 fm, int flag)
        {
            //string dayNumstr = fm.daytextBox1.Text;
            if (flag == 0)
            {
                InitializeComponent();
                this.f1 = fm;
                int days = Convert.ToInt32(fm.daytextBox1.Text);
                string[] daystrs = new string[days];

                DateTime start = fm.dateTimePicker1.Value;
                DateTime dtTmp = DateTime.MinValue;
                this.Plan.ColumnCount = days + 1;
                this.Plan.RowCount = Convert.ToInt32(fm.subtextBox2.Text) + 1;
                //this.Plan.Rows.Add(2, "太郎", fm.dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                this.Plan.Rows[0].Cells[0].Value = "科目/日付";
                for (int i = 0; i < days; i++)
                {
                    dtTmp = start.AddDays(i);
                    daystrs[i] = dtTmp.ToString("yyyy/MM/dd");
                    this.Plan.Rows[0].Cells[i + 1].Value = daystrs[i];
                }
            }
            else
            {
                InitializeComponent();
                this.f1 = fm;
                OpenFileDialog ofDialog = new OpenFileDialog();
                ofDialog.InitialDirectory = @"C:\Users\nm124\source\repos\Examplan\data";
                ofDialog.Title = "開くファイルを選択してください";

                if (ofDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = ofDialog.FileName;
                    string[] lines = File.ReadAllLines(path);
                    StreamReader sr = new StreamReader(path, Encoding.Default);
                    this.Plan.RowCount = lines.Length;

                    int firstFlag = 0;
                    int row = 0;
                    while (!sr.EndOfStream)
                    {
                        // CSVファイルの一行を読み込む
                        string line = sr.ReadLine();
                        string[] values = line.Split(',');
                        if (firstFlag == 0)
                        {
                            this.Plan.ColumnCount = values.Length - 1;
                            firstFlag = 1;
                        }
                        for (int i = 0; i < values.Length-1; i++)
                        {
                            this.Plan.Rows[row].Cells[i].Value = values[i];
                        }
                        row++;
                    }

                    // オブジェクト破棄
                    ofDialog.Dispose();
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //explore
            //System.Diagnostics.Process.Start("C:/"); // 「c直下」を開く
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = ".csv";
            sfd.InitialDirectory = @"C:\Users\nm124\source\repos\Examplan\data";
            //[ファイルの種類]に表示される選択肢
            sfd.Filter = "csvファイル(*.csv)|*.csv";
            sfd.FilterIndex = 0;
            //タイトル設定
            sfd.Title = "保存先のファイルを選択してください";
            sfd.RestoreDirectory = true;
            //ファイル上書き警告
            sfd.OverwritePrompt = true;
            //存在しないパスの警告
            sfd.CheckPathExists = true;

            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string FilenameProperty = "@\"C:\\Users\\nm124\\source\\repos\\Examplan\\data\\" + sfd.FileName;
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.Default))
                {
                    // ワーク文字列
                    string s = "";

                    for (int row = 0; row < Plan.RowCount; row++)
                    {
                        for (int col = 0; col < Plan.ColumnCount; col++)
                        {
                            s += Plan.Rows[row].Cells[col].Value;
                            if (col == Plan.ColumnCount - 1)
                            {
                                s += "\n";
                            }
                            else
                            {
                                s += ",";
                            }
                        }

                    }
                    // ワーク文字列をファイルに出力する
                    sw.Write(s);
                }
            }
        }
        
    }
}
