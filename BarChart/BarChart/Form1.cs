using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BarChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // the button click event
            btnDrawChart.Click += BtnDrawChart_Click;
            // the paint event for the panel
            panelChart.Paint += PanelChart_Paint;
        }

        private void BtnDrawChart_Click(object sender, EventArgs e)
        {
          
            panelChart.Invalidate();
        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {
            int[] data;
            try
            {
                data = txtDataInput.Text.Split(',')
                                        .Select(int.Parse)
                                        .ToArray();
            }
            catch
            {
                MessageBox.Show("Please enter a valid list of numbers separated by commas.");
                return;
            }

            DrawBarChart(e.Graphics, data, panelChart.ClientSize);
        }

        private void DrawBarChart(Graphics graphics, int[] data, Size panelSize)
        {
            int barWidth = 40;
            int spaceBetweenBars = 10;
            int maxDataValue = data.Max();
            int minDataValue = data.Min();

            float scaleFactor = (panelSize.Height - 20) / (float)(maxDataValue - minDataValue);

            // Define colors for each bar 
            Color[] barColors = { Color.Green, Color.Gold, Color.HotPink, Color.RosyBrown, Color.Blue };

            int zeroLineY = panelSize.Height - (int)(-minDataValue * scaleFactor); 

            // Draw each bar with a unique color
            for (int i = 0; i < data.Length; i++)
            {
                int barHeight = (int)(Math.Abs(data[i]) * scaleFactor);
                int x = i * (barWidth + spaceBetweenBars);  

                // Determine the y-position of the bar based on whether the value is positive or negative
                int y = data[i] >= 0 ? zeroLineY - barHeight : zeroLineY;

                Brush brush = new SolidBrush(barColors[i % barColors.Length]);
                graphics.FillRectangle(brush, x, y, barWidth, barHeight); 
            }

            // Draw the Y-axis line
            graphics.DrawLine(Pens.Black, 0, 0, 0, panelSize.Height); 

            // Draw the X-axis line 
            graphics.DrawLine(Pens.Black, 0, zeroLineY, panelSize.Width, zeroLineY);

            // Label each bar
            for (int i = 0; i < data.Length; i++)
            {
                int x = i * (barWidth + spaceBetweenBars) + (barWidth / 2);  
                int labelY = data[i] >= 0 ? zeroLineY - (int)(data[i] * scaleFactor) - 15 : zeroLineY + 5;

                // Draw the label 
                graphics.DrawString(data[i].ToString(), this.Font, Brushes.Black, x - 10, labelY);
            }
        }
    }
}

//I took reference from your classes and previous assignment which I have done. 
