namespace HospitalCharges
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
            groupBoxCharges = new GroupBox();
            textBoxPhysRehabCharges = new TextBox();
            textBoxLabFees = new TextBox();
            textBoxSurgicalCharges = new TextBox();
            textBoxMedCharges = new TextBox();
            textBoxDaysInHosp = new TextBox();
            label1 = new Label();
            lblLabFees = new Label();
            lblSurgicalCharges = new Label();
            lblMedCharges = new Label();
            lblDaysInHosp = new Label();
            btnClose = new Button();
            btnCalculate = new Button();
            lblTotalText = new Label();
            lblTotalDisplay = new Label();
            textBoxCityName = new TextBox();
            lblWeather = new Label();
            btnGetForecastAPI = new Button();
            textBoxState = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBoxCharges.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCharges
            // 
            groupBoxCharges.Controls.Add(textBoxPhysRehabCharges);
            groupBoxCharges.Controls.Add(textBoxLabFees);
            groupBoxCharges.Controls.Add(textBoxSurgicalCharges);
            groupBoxCharges.Controls.Add(textBoxMedCharges);
            groupBoxCharges.Controls.Add(textBoxDaysInHosp);
            groupBoxCharges.Controls.Add(label1);
            groupBoxCharges.Controls.Add(lblLabFees);
            groupBoxCharges.Controls.Add(lblSurgicalCharges);
            groupBoxCharges.Controls.Add(lblMedCharges);
            groupBoxCharges.Controls.Add(lblDaysInHosp);
            groupBoxCharges.Font = new Font("Segoe UI", 14.15029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxCharges.Location = new Point(40, 54);
            groupBoxCharges.Name = "groupBoxCharges";
            groupBoxCharges.Size = new Size(839, 612);
            groupBoxCharges.TabIndex = 0;
            groupBoxCharges.TabStop = false;
            groupBoxCharges.Text = "Charges";
            // 
            // textBoxPhysRehabCharges
            // 
            textBoxPhysRehabCharges.Location = new Point(437, 454);
            textBoxPhysRehabCharges.Name = "textBoxPhysRehabCharges";
            textBoxPhysRehabCharges.Size = new Size(312, 58);
            textBoxPhysRehabCharges.TabIndex = 13;
            textBoxPhysRehabCharges.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxLabFees
            // 
            textBoxLabFees.Location = new Point(437, 380);
            textBoxLabFees.Name = "textBoxLabFees";
            textBoxLabFees.Size = new Size(312, 58);
            textBoxLabFees.TabIndex = 12;
            textBoxLabFees.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxSurgicalCharges
            // 
            textBoxSurgicalCharges.Location = new Point(437, 310);
            textBoxSurgicalCharges.Name = "textBoxSurgicalCharges";
            textBoxSurgicalCharges.Size = new Size(312, 58);
            textBoxSurgicalCharges.TabIndex = 11;
            textBoxSurgicalCharges.TextAlign = HorizontalAlignment.Right;
            textBoxSurgicalCharges.TextChanged += textBoxSurgicalCharges_TextChanged;
            // 
            // textBoxMedCharges
            // 
            textBoxMedCharges.Location = new Point(437, 231);
            textBoxMedCharges.Name = "textBoxMedCharges";
            textBoxMedCharges.Size = new Size(312, 58);
            textBoxMedCharges.TabIndex = 10;
            textBoxMedCharges.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxDaysInHosp
            // 
            textBoxDaysInHosp.Location = new Point(437, 150);
            textBoxDaysInHosp.Name = "textBoxDaysInHosp";
            textBoxDaysInHosp.Size = new Size(312, 58);
            textBoxDaysInHosp.TabIndex = 9;
            textBoxDaysInHosp.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 458);
            label1.Name = "label1";
            label1.Size = new Size(423, 51);
            label1.TabIndex = 8;
            label1.Text = "Physical Rehab Charges:";
            label1.Click += label1_Click;
            // 
            // lblLabFees
            // 
            lblLabFees.AutoSize = true;
            lblLabFees.Location = new Point(6, 383);
            lblLabFees.Name = "lblLabFees";
            lblLabFees.Size = new Size(174, 51);
            lblLabFees.TabIndex = 6;
            lblLabFees.Text = "Lab Fees:";
            // 
            // lblSurgicalCharges
            // 
            lblSurgicalCharges.AutoSize = true;
            lblSurgicalCharges.Location = new Point(6, 314);
            lblSurgicalCharges.Name = "lblSurgicalCharges";
            lblSurgicalCharges.Size = new Size(308, 51);
            lblSurgicalCharges.TabIndex = 4;
            lblSurgicalCharges.Text = "Surgical Charges:";
            // 
            // lblMedCharges
            // 
            lblMedCharges.AutoSize = true;
            lblMedCharges.Location = new Point(6, 235);
            lblMedCharges.Name = "lblMedCharges";
            lblMedCharges.Size = new Size(364, 51);
            lblMedCharges.TabIndex = 2;
            lblMedCharges.Text = "Medication Charges:";
            lblMedCharges.Click += lblMedCharges_Click;
            // 
            // lblDaysInHosp
            // 
            lblDaysInHosp.AutoSize = true;
            lblDaysInHosp.Location = new Point(9, 158);
            lblDaysInHosp.Name = "lblDaysInHosp";
            lblDaysInHosp.Size = new Size(363, 51);
            lblDaysInHosp.TabIndex = 0;
            lblDaysInHosp.Text = "Days in the Hospital:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightSteelBlue;
            btnClose.Font = new Font("Segoe UI", 14.15029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(1042, 392);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(361, 112);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.LightSteelBlue;
            btnCalculate.Font = new Font("Segoe UI", 14.15029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.Black;
            btnCalculate.Location = new Point(1042, 258);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(361, 112);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Font = new Font("Segoe UI", 14.15029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalText.Location = new Point(1152, 54);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(110, 51);
            lblTotalText.TabIndex = 3;
            lblTotalText.Text = "Total";
            // 
            // lblTotalDisplay
            // 
            lblTotalDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblTotalDisplay.Font = new Font("Segoe UI", 14.15029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalDisplay.Location = new Point(1021, 123);
            lblTotalDisplay.Name = "lblTotalDisplay";
            lblTotalDisplay.Size = new Size(396, 114);
            lblTotalDisplay.TabIndex = 4;
            lblTotalDisplay.Text = "$0.00";
            lblTotalDisplay.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalDisplay.Click += lblTotalDisplay_Click;
            // 
            // textBoxCityName
            // 
            textBoxCityName.ForeColor = SystemColors.InactiveCaption;
            textBoxCityName.Location = new Point(1109, 642);
            textBoxCityName.Name = "textBoxCityName";
            textBoxCityName.Size = new Size(242, 39);
            textBoxCityName.TabIndex = 5;
            textBoxCityName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblWeather
            // 
            lblWeather.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWeather.ForeColor = Color.Firebrick;
            lblWeather.Location = new Point(1064, 570);
            lblWeather.Name = "lblWeather";
            lblWeather.Size = new Size(324, 43);
            lblWeather.TabIndex = 6;
            lblWeather.Text = "Weather Forecast:";
            // 
            // btnGetForecastAPI
            // 
            btnGetForecastAPI.BackColor = Color.Tomato;
            btnGetForecastAPI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetForecastAPI.ForeColor = SystemColors.InfoText;
            btnGetForecastAPI.Location = new Point(1105, 758);
            btnGetForecastAPI.Name = "btnGetForecastAPI";
            btnGetForecastAPI.Size = new Size(246, 80);
            btnGetForecastAPI.TabIndex = 7;
            btnGetForecastAPI.Text = "Get Forecast";
            btnGetForecastAPI.UseVisualStyleBackColor = false;
            btnGetForecastAPI.Click += btnGetForecastAPI_Click;
            // 
            // textBoxState
            // 
            textBoxState.ForeColor = SystemColors.InactiveCaption;
            textBoxState.Location = new Point(1109, 697);
            textBoxState.Name = "textBoxState";
            textBoxState.Size = new Size(242, 39);
            textBoxState.TabIndex = 8;
            textBoxState.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1031, 645);
            label2.Name = "label2";
            label2.Size = new Size(60, 32);
            label2.TabIndex = 9;
            label2.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1031, 704);
            label3.Name = "label3";
            label3.Size = new Size(72, 32);
            label3.TabIndex = 10;
            label3.Text = "State:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1532, 873);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxState);
            Controls.Add(btnGetForecastAPI);
            Controls.Add(lblWeather);
            Controls.Add(textBoxCityName);
            Controls.Add(lblTotalDisplay);
            Controls.Add(lblTotalText);
            Controls.Add(btnCalculate);
            Controls.Add(btnClose);
            Controls.Add(groupBoxCharges);
            Name = "Form1";
            Text = "Hospital Charges";
            groupBoxCharges.ResumeLayout(false);
            groupBoxCharges.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCharges;
        private Label lblDaysInHosp;
        private Label lblLabFees;
        private Label lblSurgicalCharges;
        private Label lblMedCharges;
        private Label label1; //lblP_RehabCharges
        private Button btnClose;
        private Button btnCalculate;
        private Label lblTotalText;
        private Label lblTotalDisplay;
        private TextBox textBoxPhysRehabCharges;
        private TextBox textBoxLabFees;
        private TextBox textBoxSurgicalCharges;
        private TextBox textBoxMedCharges;
        private TextBox textBoxDaysInHosp;
        private TextBox textBoxCityName;
        private Label lblWeather;
        private Button btnGetForecastAPI;
        private TextBox textBoxState;
        private Label label2;
        private Label label3;
    }
}
