namespace BarChart
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
            panelChart = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnDrawChart = new Button();
            txtDataInput = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelChart
            // 
            panelChart.BackColor = Color.LightGray;
            panelChart.Location = new Point(88, 114);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(700, 350);
            panelChart.TabIndex = 0;
            // 
            // btnDrawChart
            // 
            btnDrawChart.BackColor = Color.LightBlue;
            btnDrawChart.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrawChart.Location = new Point(120, 186);
            btnDrawChart.Name = "btnDrawChart";
            btnDrawChart.Size = new Size(94, 29);
            btnDrawChart.TabIndex = 1;
            btnDrawChart.Text = "Enter";
            btnDrawChart.UseVisualStyleBackColor = false;
            // 
            // txtDataInput
            // 
            txtDataInput.Location = new Point(63, 129);
            txtDataInput.Name = "txtDataInput";
            txtDataInput.Size = new Size(225, 27);
            txtDataInput.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1158, 73);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(487, 10);
            label1.Name = "label1";
            label1.Size = new Size(209, 46);
            label1.TabIndex = 0;
            label1.Text = "BAR CHART";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtDataInput);
            panel2.Controls.Add(btnDrawChart);
            panel2.Location = new Point(825, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 295);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(33, 67);
            label2.Name = "label2";
            label2.Size = new Size(279, 31);
            label2.TabIndex = 3;
            label2.Text = "Please Enter Value Below";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1182, 503);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelChart);
            Name = "Form1";
            Text = "Bar Chart";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnDrawChart;
        private TextBox txtDataInput;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
    }
}
