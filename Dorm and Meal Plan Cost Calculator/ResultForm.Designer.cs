
namespace Dorm_and_Meal_Plan_Cost_Calculator
{
    partial class ResultForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dormPlanTextbox = new System.Windows.Forms.Label();
            this.dormCostTextbox = new System.Windows.Forms.Label();
            this.mealPlanTextbox = new System.Windows.Forms.Label();
            this.mealCostTextbox = new System.Windows.Forms.Label();
            this.totalCostTextbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(283, 332);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 33);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Items selected:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Dormitory:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Meal Plan:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Total Cost:";
            // 
            // dormPlanTextbox
            // 
            this.dormPlanTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dormPlanTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dormPlanTextbox.Location = new System.Drawing.Point(123, 91);
            this.dormPlanTextbox.Name = "dormPlanTextbox";
            this.dormPlanTextbox.Size = new System.Drawing.Size(206, 28);
            this.dormPlanTextbox.TabIndex = 23;
            this.dormPlanTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dormCostTextbox
            // 
            this.dormCostTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dormCostTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dormCostTextbox.Location = new System.Drawing.Point(361, 91);
            this.dormCostTextbox.Name = "dormCostTextbox";
            this.dormCostTextbox.Size = new System.Drawing.Size(198, 28);
            this.dormCostTextbox.TabIndex = 24;
            this.dormCostTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealPlanTextbox
            // 
            this.mealPlanTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mealPlanTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealPlanTextbox.Location = new System.Drawing.Point(123, 153);
            this.mealPlanTextbox.Name = "mealPlanTextbox";
            this.mealPlanTextbox.Size = new System.Drawing.Size(206, 28);
            this.mealPlanTextbox.TabIndex = 25;
            this.mealPlanTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealCostTextbox
            // 
            this.mealCostTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mealCostTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealCostTextbox.Location = new System.Drawing.Point(361, 153);
            this.mealCostTextbox.Name = "mealCostTextbox";
            this.mealCostTextbox.Size = new System.Drawing.Size(198, 28);
            this.mealCostTextbox.TabIndex = 26;
            this.mealCostTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostTextbox
            // 
            this.totalCostTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostTextbox.Location = new System.Drawing.Point(270, 232);
            this.totalCostTextbox.Name = "totalCostTextbox";
            this.totalCostTextbox.Size = new System.Drawing.Size(145, 28);
            this.totalCostTextbox.TabIndex = 27;
            this.totalCostTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(641, 407);
            this.Controls.Add(this.totalCostTextbox);
            this.Controls.Add(this.mealCostTextbox);
            this.Controls.Add(this.mealPlanTextbox);
            this.Controls.Add(this.dormCostTextbox);
            this.Controls.Add(this.dormPlanTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Name = "ResultForm";
            this.Text = "ResultsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label dormPlanTextbox;
        public System.Windows.Forms.Label dormCostTextbox;
        public System.Windows.Forms.Label mealPlanTextbox;
        public System.Windows.Forms.Label mealCostTextbox;
        public System.Windows.Forms.Label totalCostTextbox;
    }
}