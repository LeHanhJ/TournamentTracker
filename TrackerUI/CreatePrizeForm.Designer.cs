
namespace TrackerUI
{
    partial class CreatePrizeForm
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
            CreatePrizeLabel = new Label();
            PleaceNumberValue = new TextBox();
            PlaceNumberLabel = new Label();
            PlaceNameValue = new TextBox();
            PlaceNameLabel = new Label();
            textBox2 = new TextBox();
            PrizeAmountLabel = new Label();
            textBox3 = new TextBox();
            PrizePercentageLabel = new Label();
            OrLabel = new Label();
            CreatePrizeButton = new Button();
            SuspendLayout();
            // 
            // CreatePrizeLabel
            // 
            CreatePrizeLabel.AutoSize = true;
            CreatePrizeLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatePrizeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            CreatePrizeLabel.Location = new Point(52, 36);
            CreatePrizeLabel.Margin = new Padding(5, 0, 5, 0);
            CreatePrizeLabel.Name = "CreatePrizeLabel";
            CreatePrizeLabel.Size = new Size(217, 50);
            CreatePrizeLabel.TabIndex = 17;
            CreatePrizeLabel.Text = "Create Prize:";
            CreatePrizeLabel.Click += CreatePrizeLabel_Click;
            // 
            // PleaceNumberValue
            // 
            PleaceNumberValue.Location = new Point(294, 147);
            PleaceNumberValue.Name = "PleaceNumberValue";
            PleaceNumberValue.Size = new Size(234, 35);
            PleaceNumberValue.TabIndex = 27;
            PleaceNumberValue.TextChanged += teamOneScoreValue_TextChanged;
            // 
            // PlaceNumberLabel
            // 
            PlaceNumberLabel.AutoSize = true;
            PlaceNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlaceNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            PlaceNumberLabel.Location = new Point(86, 147);
            PlaceNumberLabel.Name = "PlaceNumberLabel";
            PlaceNumberLabel.Size = new Size(183, 37);
            PlaceNumberLabel.TabIndex = 26;
            PlaceNumberLabel.Text = "Place Number";
            PlaceNumberLabel.Click += GetFirstNameLabel_Click;
            // 
            // PlaceNameValue
            // 
            PlaceNameValue.Location = new Point(294, 219);
            PlaceNameValue.Name = "PlaceNameValue";
            PlaceNameValue.Size = new Size(234, 35);
            PlaceNameValue.TabIndex = 29;
            PlaceNameValue.TextChanged += textBox1_TextChanged;
            // 
            // PlaceNameLabel
            // 
            PlaceNameLabel.AutoSize = true;
            PlaceNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlaceNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            PlaceNameLabel.Location = new Point(86, 217);
            PlaceNameLabel.Name = "PlaceNameLabel";
            PlaceNameLabel.Size = new Size(157, 37);
            PlaceNameLabel.TabIndex = 28;
            PlaceNameLabel.Text = "Place Name";
            PlaceNameLabel.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(294, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 35);
            textBox2.TabIndex = 31;
            // 
            // PrizeAmountLabel
            // 
            PrizeAmountLabel.AutoSize = true;
            PrizeAmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrizeAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            PrizeAmountLabel.Location = new Point(86, 289);
            PrizeAmountLabel.Name = "PrizeAmountLabel";
            PrizeAmountLabel.Size = new Size(176, 37);
            PrizeAmountLabel.TabIndex = 30;
            PrizeAmountLabel.Text = "Prize Amount";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(294, 436);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 35);
            textBox3.TabIndex = 33;
            // 
            // PrizePercentageLabel
            // 
            PrizePercentageLabel.AutoSize = true;
            PrizePercentageLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrizePercentageLabel.ForeColor = Color.FromArgb(51, 153, 255);
            PrizePercentageLabel.Location = new Point(86, 434);
            PrizePercentageLabel.Name = "PrizePercentageLabel";
            PrizePercentageLabel.Size = new Size(212, 37);
            PrizePercentageLabel.TabIndex = 32;
            PrizePercentageLabel.Text = "Prize Percentage";
            // 
            // OrLabel
            // 
            OrLabel.AutoSize = true;
            OrLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrLabel.ForeColor = Color.FromArgb(51, 153, 255);
            OrLabel.Location = new Point(245, 362);
            OrLabel.Name = "OrLabel";
            OrLabel.Size = new Size(85, 37);
            OrLabel.TabIndex = 34;
            OrLabel.Text = " - or -";
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreatePrizeButton.FlatStyle = FlatStyle.Flat;
            CreatePrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            CreatePrizeButton.Location = new Point(169, 522);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(286, 83);
            CreatePrizeButton.TabIndex = 35;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(647, 658);
            Controls.Add(CreatePrizeButton);
            Controls.Add(OrLabel);
            Controls.Add(textBox3);
            Controls.Add(PrizePercentageLabel);
            Controls.Add(textBox2);
            Controls.Add(PrizeAmountLabel);
            Controls.Add(PlaceNameValue);
            Controls.Add(PlaceNameLabel);
            Controls.Add(PleaceNumberValue);
            Controls.Add(PlaceNumberLabel);
            Controls.Add(CreatePrizeLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreatePrizeForm";
            Text = "Prize Form";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void GetFirstNameLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void teamOneScoreValue_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private EventHandler GetFirstNameLabel_Click()
        {
            return this.FirstNameLabel_Click;
        }

        #endregion
        private Label CreatePrizeLabel;
        private TextBox PleaceNumberValue;
        private Label PlaceNumberLabel;
        private TextBox PlaceNameValue;
        private Label PlaceNameLabel;
        private TextBox textBox2;
        private Label PrizeAmountLabel;
        private TextBox textBox3;
        private Label PrizePercentageLabel;
        private Label OrLabel;
        private Button CreatePrizeButton;

        public EventHandler FirstNameLabel_Click { get; private set; }
    }
}