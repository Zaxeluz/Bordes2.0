namespace El_Buen_Tamal_Bordeado
{
    partial class SobelParameters
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumericApertureSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NumericYOrder = new System.Windows.Forms.NumericUpDown();
            this.NumericXOrder = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericApertureSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericXOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumericApertureSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.NumericYOrder);
            this.groupBox1.Controls.Add(this.NumericXOrder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sobel Parameters";
            // 
            // NumericApertureSize
            // 
            this.NumericApertureSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericApertureSize.Location = new System.Drawing.Point(82, 105);
            this.NumericApertureSize.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NumericApertureSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericApertureSize.Name = "NumericApertureSize";
            this.NumericApertureSize.Size = new System.Drawing.Size(120, 20);
            this.NumericApertureSize.TabIndex = 7;
            this.NumericApertureSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aperture Size";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumericYOrder
            // 
            this.NumericYOrder.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericYOrder.Location = new System.Drawing.Point(83, 68);
            this.NumericYOrder.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NumericYOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericYOrder.Name = "NumericYOrder";
            this.NumericYOrder.Size = new System.Drawing.Size(120, 20);
            this.NumericYOrder.TabIndex = 3;
            this.NumericYOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericXOrder
            // 
            this.NumericXOrder.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericXOrder.Location = new System.Drawing.Point(83, 32);
            this.NumericXOrder.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NumericXOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericXOrder.Name = "NumericXOrder";
            this.NumericXOrder.Size = new System.Drawing.Size(120, 20);
            this.NumericXOrder.TabIndex = 2;
            this.NumericXOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SobelParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 208);
            this.Controls.Add(this.groupBox1);
            this.Name = "SobelParameters";
            this.Text = "SobelParameters";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericApertureSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericXOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown NumericYOrder;
        private System.Windows.Forms.NumericUpDown NumericXOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericApertureSize;
    }
}