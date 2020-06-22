using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Random random = new Random();

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try {
                lvLotteryNumbers.Clear();

                List<int> lotteryNumbers = GenerateLotteryNumbers(1, 49, 6);

                if(lotteryNumbers != null && lotteryNumbers.Count > 0)
                {
                    lblErrorMsg.Text = string.Empty;

                    foreach(int number in lotteryNumbers)
                    {
                        ListViewItem listViewItem = new ListViewItem
                        {
                            Text = number.ToString()
                        };

                        switch (number)
                        {
                            case int n when (n >= 1 && n <= 9):
                                listViewItem.ForeColor = Color.Gray;
                                break;
                            case int n when (n >= 10 && n <= 19):
                                listViewItem.ForeColor = Color.Black;
                                break;
                            case int n when (n >= 20 && n <= 29):
                                listViewItem.ForeColor = Color.Pink;
                                break;
                            case int n when (n >= 30 && n <= 39):
                                listViewItem.ForeColor = Color.Green;
                                break;
                            case int n when (n >= 40 && n <= 49):
                                listViewItem.ForeColor = Color.Yellow;
                                break;
                        }

                        lvLotteryNumbers.Items.Add(listViewItem);
                    }
                }
                else
                {
                    lblErrorMsg.Text = "Unable to generate numbers, please try again.";
                }
            }
            catch(Exception ex)
            {
                lblErrorMsg.Text = ex.Message;
            }
        }

        private List<int> GenerateLotteryNumbers(int minValue, int maxValue, int count)
        {
            try
            {
                if (maxValue <= minValue || count < 0 || (count > maxValue - minValue && maxValue - minValue > 0))
                {
                    throw new ArgumentOutOfRangeException("Range " + minValue + " to " + maxValue +
                            " (" + (maxValue - minValue) + " values), or count " + count + " is illegal");
                }

                HashSet<int> randomNumbers = new HashSet<int>();

                for(int topValue = maxValue - count; topValue < maxValue; topValue++)
                {
                    if(!randomNumbers.Add(random.Next(minValue, topValue + 1)))
                    {
                        randomNumbers.Add(topValue);
                    }
                }

                List<int> result = randomNumbers.ToList();

                for (int i = result.Count - 1; i > 0; i--)
                {
                    int k = random.Next(i + 1);
                    int tmp = result[k];
                    result[k] = result[i];
                    result[i] = tmp;
                }

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
