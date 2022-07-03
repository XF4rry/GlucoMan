﻿namespace GlucoMan.Forms
{
    partial class frmMeals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeals));
            this.btnRemoveMeal = new System.Windows.Forms.Button();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnShowThisMeal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdMeal = new System.Windows.Forms.TextBox();
            this.dtpMealTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveMeal = new System.Windows.Forms.Button();
            this.dtpMealTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAccuracyMeal = new System.Windows.Forms.ComboBox();
            this.txtAccuracyOfChoMeal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTypeOfMeal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChoOfMeal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNowEnd = new System.Windows.Forms.Button();
            this.btnNowBegin = new System.Windows.Forms.Button();
            this.gridMeals = new System.Windows.Forms.DataGridView();
            this.chkNowInAdd = new System.Windows.Forms.CheckBox();
            this.btnDefaults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveMeal
            // 
            this.btnRemoveMeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveMeal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveMeal.Location = new System.Drawing.Point(768, 74);
            this.btnRemoveMeal.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveMeal.Name = "btnRemoveMeal";
            this.btnRemoveMeal.Size = new System.Drawing.Size(46, 46);
            this.btnRemoveMeal.TabIndex = 13;
            this.btnRemoveMeal.Text = "- Food";
            this.btnRemoveMeal.UseVisualStyleBackColor = true;
            this.btnRemoveMeal.Click += new System.EventHandler(this.btnRemoveMeal_Click);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMeal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddMeal.Location = new System.Drawing.Point(718, 74);
            this.btnAddMeal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(46, 46);
            this.btnAddMeal.TabIndex = 12;
            this.btnAddMeal.Text = "+ Food";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // btnShowThisMeal
            // 
            this.btnShowThisMeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowThisMeal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowThisMeal.Location = new System.Drawing.Point(732, 17);
            this.btnShowThisMeal.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowThisMeal.Name = "btnShowThisMeal";
            this.btnShowThisMeal.Size = new System.Drawing.Size(82, 46);
            this.btnShowThisMeal.TabIndex = 14;
            this.btnShowThisMeal.Text = "Details";
            this.btnShowThisMeal.UseVisualStyleBackColor = true;
            this.btnShowThisMeal.Click += new System.EventHandler(this.btnShowThisMeal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "Id Meal";
            // 
            // txtIdMeal
            // 
            this.txtIdMeal.Location = new System.Drawing.Point(7, 26);
            this.txtIdMeal.Name = "txtIdMeal";
            this.txtIdMeal.ReadOnly = true;
            this.txtIdMeal.Size = new System.Drawing.Size(50, 29);
            this.txtIdMeal.TabIndex = 53;
            this.txtIdMeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpMealTimeBegin
            // 
            this.dtpMealTimeBegin.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.dtpMealTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMealTimeBegin.Location = new System.Drawing.Point(91, 87);
            this.dtpMealTimeBegin.Name = "dtpMealTimeBegin";
            this.dtpMealTimeBegin.Size = new System.Drawing.Size(179, 29);
            this.dtpMealTimeBegin.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 52;
            this.label2.Text = "Meal begin";
            // 
            // btnSaveMeal
            // 
            this.btnSaveMeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveMeal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveMeal.Location = new System.Drawing.Point(632, 17);
            this.btnSaveMeal.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveMeal.Name = "btnSaveMeal";
            this.btnSaveMeal.Size = new System.Drawing.Size(82, 46);
            this.btnSaveMeal.TabIndex = 55;
            this.btnSaveMeal.Text = "Save";
            this.btnSaveMeal.UseVisualStyleBackColor = true;
            this.btnSaveMeal.Click += new System.EventHandler(this.btnSaveMeal_Click);
            // 
            // dtpMealTimeEnd
            // 
            this.dtpMealTimeEnd.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.dtpMealTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMealTimeEnd.Location = new System.Drawing.Point(362, 87);
            this.dtpMealTimeEnd.Name = "dtpMealTimeEnd";
            this.dtpMealTimeEnd.Size = new System.Drawing.Size(179, 29);
            this.dtpMealTimeEnd.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 57;
            this.label1.Text = "Meal end";
            // 
            // cmbAccuracyMeal
            // 
            this.cmbAccuracyMeal.FormattingEnabled = true;
            this.cmbAccuracyMeal.Location = new System.Drawing.Point(242, 26);
            this.cmbAccuracyMeal.Name = "cmbAccuracyMeal";
            this.cmbAccuracyMeal.Size = new System.Drawing.Size(145, 29);
            this.cmbAccuracyMeal.TabIndex = 72;
            // 
            // txtAccuracyOfChoMeal
            // 
            this.txtAccuracyOfChoMeal.Location = new System.Drawing.Point(176, 26);
            this.txtAccuracyOfChoMeal.Name = "txtAccuracyOfChoMeal";
            this.txtAccuracyOfChoMeal.Size = new System.Drawing.Size(60, 29);
            this.txtAccuracyOfChoMeal.TabIndex = 71;
            this.txtAccuracyOfChoMeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(176, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 21);
            this.label13.TabIndex = 70;
            this.label13.Text = "Accuracy";
            // 
            // cmbTypeOfMeal
            // 
            this.cmbTypeOfMeal.FormattingEnabled = true;
            this.cmbTypeOfMeal.Location = new System.Drawing.Point(63, 26);
            this.cmbTypeOfMeal.Name = "cmbTypeOfMeal";
            this.cmbTypeOfMeal.Size = new System.Drawing.Size(107, 29);
            this.cmbTypeOfMeal.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 74;
            this.label3.Text = "Type of meal";
            // 
            // txtChoOfMeal
            // 
            this.txtChoOfMeal.BackColor = System.Drawing.Color.Aqua;
            this.txtChoOfMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtChoOfMeal.Location = new System.Drawing.Point(7, 90);
            this.txtChoOfMeal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChoOfMeal.Name = "txtChoOfMeal";
            this.txtChoOfMeal.Size = new System.Drawing.Size(68, 26);
            this.txtChoOfMeal.TabIndex = 75;
            this.txtChoOfMeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 76;
            this.label5.Text = "Meal CHO";
            // 
            // btnNowEnd
            // 
            this.btnNowEnd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNowEnd.Location = new System.Drawing.Point(546, 74);
            this.btnNowEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnNowEnd.Name = "btnNowEnd";
            this.btnNowEnd.Size = new System.Drawing.Size(82, 46);
            this.btnNowEnd.TabIndex = 77;
            this.btnNowEnd.Text = "Now";
            this.btnNowEnd.UseVisualStyleBackColor = true;
            this.btnNowEnd.Click += new System.EventHandler(this.btnNowEnd_Click);
            // 
            // btnNowBegin
            // 
            this.btnNowBegin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNowBegin.Location = new System.Drawing.Point(275, 74);
            this.btnNowBegin.Margin = new System.Windows.Forms.Padding(2);
            this.btnNowBegin.Name = "btnNowBegin";
            this.btnNowBegin.Size = new System.Drawing.Size(82, 46);
            this.btnNowBegin.TabIndex = 78;
            this.btnNowBegin.Text = "Now";
            this.btnNowBegin.UseVisualStyleBackColor = true;
            this.btnNowBegin.Click += new System.EventHandler(this.btnNowStart_Click);
            // 
            // gridMeals
            // 
            this.gridMeals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMeals.Location = new System.Drawing.Point(6, 122);
            this.gridMeals.Name = "gridMeals";
            this.gridMeals.RowTemplate.Height = 25;
            this.gridMeals.Size = new System.Drawing.Size(808, 269);
            this.gridMeals.TabIndex = 79;
            this.gridMeals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMeals_CellContentClick);
            this.gridMeals.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMeals_CellDoubleClick);
            this.gridMeals.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMeals_CellDoubleClick);
            this.gridMeals.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMeals_RowEnter);
            // 
            // chkNowInAdd
            // 
            this.chkNowInAdd.AutoSize = true;
            this.chkNowInAdd.Checked = true;
            this.chkNowInAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNowInAdd.Location = new System.Drawing.Point(393, 28);
            this.chkNowInAdd.Name = "chkNowInAdd";
            this.chkNowInAdd.Size = new System.Drawing.Size(180, 25);
            this.chkNowInAdd.TabIndex = 80;
            this.chkNowInAdd.Text = "New has Now as time";
            this.chkNowInAdd.UseVisualStyleBackColor = true;
            // 
            // btnDefaults
            // 
            this.btnDefaults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDefaults.Location = new System.Drawing.Point(632, 74);
            this.btnDefaults.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(82, 46);
            this.btnDefaults.TabIndex = 81;
            this.btnDefaults.Text = "Defaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            // 
            // frmMeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 395);
            this.Controls.Add(this.btnDefaults);
            this.Controls.Add(this.chkNowInAdd);
            this.Controls.Add(this.gridMeals);
            this.Controls.Add(this.btnNowBegin);
            this.Controls.Add(this.btnNowEnd);
            this.Controls.Add(this.txtChoOfMeal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTypeOfMeal);
            this.Controls.Add(this.cmbAccuracyMeal);
            this.Controls.Add(this.txtAccuracyOfChoMeal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpMealTimeEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveMeal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdMeal);
            this.Controls.Add(this.dtpMealTimeBegin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowThisMeal);
            this.Controls.Add(this.btnRemoveMeal);
            this.Controls.Add(this.btnAddMeal);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMeals";
            this.Text = "Meals management";
            this.Load += new System.EventHandler(this.frmMeals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnRemoveFood;
        private Button btnAddMeal;
        private Button btnShowThisMeal;
        private Label label4;
        private TextBox txtIdMeal;
        private DateTimePicker dtpMealTimeBegin;
        private Label label2;
        private DataGridViewTextBoxColumn IdMeal;
        private DataGridViewTextBoxColumn TypeOfMeal;
        private DataGridViewTextBoxColumn TimeBegin;
        private DataGridViewTextBoxColumn TimeEnd;
        private Button btnSaveMeal;
        private DateTimePicker dtpMealTimeEnd;
        private Label label1;
        private ComboBox cmbAccuracyMeal;
        private TextBox txtAccuracyOfChoMeal;
        private Label label13;
        private ComboBox cmbTypeOfMeal;
        private Label label3;
        private TextBox txtChoOfMeal;
        private Label label5;
        private Button btnRemoveMeal;
        private Button btnNowFinish;
        private Button btnNowStart;
        private DataGridView gridMeals;
        private CheckBox chkNowInAdd;
        private Button btnNowEnd;
        private Button btnNowBegin;
        private Button btnDefaults;
    }
}