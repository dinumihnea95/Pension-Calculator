namespace CompoundInterestCalculatorAdds_In
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;

    
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
            this.name_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_years_retirement = new System.Windows.Forms.NumericUpDown();
            this.interest_rate = new System.Windows.Forms.NumericUpDown();
            this.initial_invest = new System.Windows.Forms.NumericUpDown();
            this.monthly_contrib = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_years_retirement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interest_rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initial_invest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_contrib)).BeginInit();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(309, 105);
            this.name_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(277, 26);
            this.name_txt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculeaza";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calculate_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Investitie initiala (RON)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dobanda (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ani activi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 352);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Investitie lunara (RON)";
            // 
            // num_years_retirement
            // 
            this.num_years_retirement.Location = new System.Drawing.Point(309, 286);
            this.num_years_retirement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_years_retirement.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.num_years_retirement.Name = "num_years_retirement";
            this.num_years_retirement.Size = new System.Drawing.Size(180, 26);
            this.num_years_retirement.TabIndex = 11;
            // 
            // interest_rate
            // 
            this.interest_rate.Location = new System.Drawing.Point(309, 226);
            this.interest_rate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.interest_rate.Name = "interest_rate";
            this.interest_rate.Size = new System.Drawing.Size(180, 26);
            this.interest_rate.TabIndex = 12;
            // 
            // initial_invest
            // 
            this.initial_invest.Location = new System.Drawing.Point(309, 162);
            this.initial_invest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.initial_invest.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.initial_invest.Name = "initial_invest";
            this.initial_invest.Size = new System.Drawing.Size(180, 26);
            this.initial_invest.TabIndex = 13;
            // 
            // monthly_contrib
            // 
            this.monthly_contrib.Location = new System.Drawing.Point(306, 348);
            this.monthly_contrib.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.monthly_contrib.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.monthly_contrib.Name = "monthly_contrib";
            this.monthly_contrib.Size = new System.Drawing.Size(180, 26);
            this.monthly_contrib.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 692);
            this.Controls.Add(this.monthly_contrib);
            this.Controls.Add(this.initial_invest);
            this.Controls.Add(this.interest_rate);
            this.Controls.Add(this.num_years_retirement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_txt);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_years_retirement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interest_rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initial_invest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_contrib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_years_retirement;
        private System.Windows.Forms.NumericUpDown interest_rate;
        private System.Windows.Forms.NumericUpDown initial_invest;
        private System.Windows.Forms.NumericUpDown monthly_contrib;
    }
}