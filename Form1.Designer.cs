namespace Genetik_Algoritma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.chartConvergence = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtPopulationSize = new System.Windows.Forms.TextBox();
            this.txtCrossoverRate = new System.Windows.Forms.TextBox();
            this.txtMutationRate = new System.Windows.Forms.TextBox();
            this.txtElitismCount = new System.Windows.Forms.TextBox();
            this.txtGenerations = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartConvergence)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 285);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Calistir";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(26, 329);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(73, 16);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Sonuclar = ";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // chartConvergence
            // 
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chartConvergence.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartConvergence.Legends.Add(legend1);
            this.chartConvergence.Location = new System.Drawing.Point(406, 45);
            this.chartConvergence.Name = "chartConvergence";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartConvergence.Series.Add(series1);
            this.chartConvergence.Size = new System.Drawing.Size(616, 300);
            this.chartConvergence.TabIndex = 7;
            this.chartConvergence.Text = "chart1";
            this.chartConvergence.Click += new System.EventHandler(this.chartConvergence_Click);
            // 
            // txtPopulationSize
            // 
            this.txtPopulationSize.Location = new System.Drawing.Point(222, 64);
            this.txtPopulationSize.Name = "txtPopulationSize";
            this.txtPopulationSize.Size = new System.Drawing.Size(100, 22);
            this.txtPopulationSize.TabIndex = 8;
            // 
            // txtCrossoverRate
            // 
            this.txtCrossoverRate.Location = new System.Drawing.Point(222, 115);
            this.txtCrossoverRate.Name = "txtCrossoverRate";
            this.txtCrossoverRate.Size = new System.Drawing.Size(100, 22);
            this.txtCrossoverRate.TabIndex = 9;
            // 
            // txtMutationRate
            // 
            this.txtMutationRate.Location = new System.Drawing.Point(222, 159);
            this.txtMutationRate.Name = "txtMutationRate";
            this.txtMutationRate.Size = new System.Drawing.Size(100, 22);
            this.txtMutationRate.TabIndex = 10;
            // 
            // txtElitismCount
            // 
            this.txtElitismCount.Location = new System.Drawing.Point(222, 199);
            this.txtElitismCount.Name = "txtElitismCount";
            this.txtElitismCount.Size = new System.Drawing.Size(100, 22);
            this.txtElitismCount.TabIndex = 11;
            // 
            // txtGenerations
            // 
            this.txtGenerations.Location = new System.Drawing.Point(222, 239);
            this.txtGenerations.Name = "txtGenerations";
            this.txtGenerations.Size = new System.Drawing.Size(100, 22);
            this.txtGenerations.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Popülasyon boyutu = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Çaprazlama oranı (0-1 arası) =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mutasyon oranı (0-1 arası) =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Seçkinlik adedi =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Jenerasyon sayısı =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenerations);
            this.Controls.Add(this.txtElitismCount);
            this.Controls.Add(this.txtMutationRate);
            this.Controls.Add(this.txtCrossoverRate);
            this.Controls.Add(this.txtPopulationSize);
            this.Controls.Add(this.chartConvergence);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartConvergence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartConvergence;
        private System.Windows.Forms.TextBox txtPopulationSize;
        private System.Windows.Forms.TextBox txtCrossoverRate;
        private System.Windows.Forms.TextBox txtMutationRate;
        private System.Windows.Forms.TextBox txtElitismCount;
        private System.Windows.Forms.TextBox txtGenerations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

