namespace asigment_calories_and_fat
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCalculationResults = new System.Windows.Forms.Label();
            this.lblCaloriesFromFat = new System.Windows.Forms.Label();
            this.lblFatPercentage = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chkLowFat = new System.Windows.Forms.CheckBox();
            this.lblFoodInformation = new System.Windows.Forms.Label();
            this.txtTotalCalories = new System.Windows.Forms.TextBox();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.txtFatGrams = new System.Windows.Forms.TextBox();
            this.lblFatGrams = new System.Windows.Forms.Label();
            this.txtCaloriesFromFat = new System.Windows.Forms.TextBox();
            this.txtFatPercentage = new System.Windows.Forms.TextBox();
            this.txtExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(294, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(390, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Fat Percentage Calculator";
            // 
            // lblCalculationResults
            // 
            this.lblCalculationResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculationResults.Location = new System.Drawing.Point(138, 272);
            this.lblCalculationResults.Name = "lblCalculationResults";
            this.lblCalculationResults.Size = new System.Drawing.Size(230, 20);
            this.lblCalculationResults.TabIndex = 3;
            this.lblCalculationResults.Text = "Calculation Results";
            // 
            // lblCaloriesFromFat
            // 
            this.lblCaloriesFromFat.Location = new System.Drawing.Point(148, 318);
            this.lblCaloriesFromFat.Name = "lblCaloriesFromFat";
            this.lblCaloriesFromFat.Size = new System.Drawing.Size(147, 20);
            this.lblCaloriesFromFat.TabIndex = 4;
            this.lblCaloriesFromFat.Text = "Calories from Fat:";
            // 
            // lblFatPercentage
            // 
            this.lblFatPercentage.Location = new System.Drawing.Point(148, 353);
            this.lblFatPercentage.Name = "lblFatPercentage";
            this.lblFatPercentage.Size = new System.Drawing.Size(147, 20);
            this.lblFatPercentage.TabIndex = 5;
            this.lblFatPercentage.Text = "Fat Percentage:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(396, 199);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(188, 50);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = " Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // chkLowFat
            // 
            this.chkLowFat.AutoSize = true;
            this.chkLowFat.Location = new System.Drawing.Point(127, 434);
            this.chkLowFat.Name = "chkLowFat";
            this.chkLowFat.Size = new System.Drawing.Size(92, 24);
            this.chkLowFat.TabIndex = 8;
            this.chkLowFat.Text = "Low Fat";
            this.chkLowFat.UseVisualStyleBackColor = true;
            // 
            // lblFoodInformation
            // 
            this.lblFoodInformation.Location = new System.Drawing.Point(167, 83);
            this.lblFoodInformation.Name = "lblFoodInformation";
            this.lblFoodInformation.Size = new System.Drawing.Size(230, 23);
            this.lblFoodInformation.TabIndex = 9;
            this.lblFoodInformation.Text = "Enter Food Information";
            // 
            // txtTotalCalories
            // 
            this.txtTotalCalories.Location = new System.Drawing.Point(384, 116);
            this.txtTotalCalories.Name = "txtTotalCalories";
            this.txtTotalCalories.Size = new System.Drawing.Size(219, 26);
            this.txtTotalCalories.TabIndex = 10;
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.Location = new System.Drawing.Point(148, 116);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(230, 23);
            this.lblTotalCalories.TabIndex = 11;
            this.lblTotalCalories.Text = "Total Calories:";
            // 
            // txtFatGrams
            // 
            this.txtFatGrams.Location = new System.Drawing.Point(384, 148);
            this.txtFatGrams.Name = "txtFatGrams";
            this.txtFatGrams.Size = new System.Drawing.Size(219, 26);
            this.txtFatGrams.TabIndex = 12;
            // 
            // lblFatGrams
            // 
            this.lblFatGrams.Location = new System.Drawing.Point(138, 152);
            this.lblFatGrams.Name = "lblFatGrams";
            this.lblFatGrams.Size = new System.Drawing.Size(230, 23);
            this.lblFatGrams.TabIndex = 13;
            this.lblFatGrams.Text = "Fat Grams:";
            // 
            // txtCaloriesFromFat
            // 
            this.txtCaloriesFromFat.Location = new System.Drawing.Point(365, 318);
            this.txtCaloriesFromFat.Name = "txtCaloriesFromFat";
            this.txtCaloriesFromFat.Size = new System.Drawing.Size(219, 26);
            this.txtCaloriesFromFat.TabIndex = 14;
            // 
            // txtFatPercentage
            // 
            this.txtFatPercentage.Location = new System.Drawing.Point(365, 353);
            this.txtFatPercentage.Name = "txtFatPercentage";
            this.txtFatPercentage.Size = new System.Drawing.Size(219, 26);
            this.txtFatPercentage.TabIndex = 15;
            this.txtFatPercentage.TextChanged += new System.EventHandler(this.txtFatPercentage_TextChanged);
            // 
            // txtExit
            // 
            this.txtExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExit.Location = new System.Drawing.Point(609, 199);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(188, 50);
            this.txtExit.TabIndex = 16;
            this.txtExit.Text = "Exit";
            this.txtExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 597);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.txtFatPercentage);
            this.Controls.Add(this.txtCaloriesFromFat);
            this.Controls.Add(this.lblFatGrams);
            this.Controls.Add(this.txtFatGrams);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.txtTotalCalories);
            this.Controls.Add(this.lblFoodInformation);
            this.Controls.Add(this.chkLowFat);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFatPercentage);
            this.Controls.Add(this.lblCaloriesFromFat);
            this.Controls.Add(this.lblCalculationResults);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCalculationResults;
        private System.Windows.Forms.Label lblCaloriesFromFat;
        private System.Windows.Forms.Label lblFatPercentage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chkLowFat;
        private System.Windows.Forms.Label lblFoodInformation;
        private System.Windows.Forms.TextBox txtTotalCalories;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.TextBox txtFatGrams;
        private System.Windows.Forms.Label lblFatGrams;
        private System.Windows.Forms.TextBox txtCaloriesFromFat;
        private System.Windows.Forms.TextBox txtFatPercentage;
        private System.Windows.Forms.Button txtExit;
    }
}

