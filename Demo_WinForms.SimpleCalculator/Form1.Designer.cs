namespace Demo_WinForms.SimpleCalculator
{
    partial class MainForm
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txtBox_Length = new System.Windows.Forms.TextBox();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.txtBox_Width = new System.Windows.Forms.TextBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.txtBox_Height = new System.Windows.Forms.TextBox();
            this.grpBox_Inputs = new System.Windows.Forms.GroupBox();
            this.picBox_DumpTruck = new System.Windows.Forms.PictureBox();
            this.cmbBox_Material = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lbl_GrossWeight = new System.Windows.Forms.Label();
            this.txtBox_GrossWeight = new System.Windows.Forms.TextBox();
            this.lbl_PayloadWeight = new System.Windows.Forms.Label();
            this.txtBox_PayloadWeight = new System.Windows.Forms.TextBox();
            this.lbl_Empty = new System.Windows.Forms.Label();
            this.txtBox_EmptyWeight = new System.Windows.Forms.TextBox();
            this.btn_Help = new System.Windows.Forms.Button();
            this.radBtn_Imperial = new System.Windows.Forms.RadioButton();
            this.radBtn_Metric = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_LengthUnits = new System.Windows.Forms.Label();
            this.lbl_WeightUnits = new System.Windows.Forms.Label();
            this.grpBox_Inputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_DumpTruck)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Title.Location = new System.Drawing.Point(331, 20);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(462, 39);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Dump Trailer Load Calculator";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Exit.Location = new System.Drawing.Point(140, 349);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 42);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // txtBox_Length
            // 
            this.txtBox_Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Length.Location = new System.Drawing.Point(97, 52);
            this.txtBox_Length.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_Length.Name = "txtBox_Length";
            this.txtBox_Length.Size = new System.Drawing.Size(132, 30);
            this.txtBox_Length.TabIndex = 2;
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Length.Location = new System.Drawing.Point(11, 56);
            this.lbl_Length.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(72, 25);
            this.lbl_Length.TabIndex = 3;
            this.lbl_Length.Text = "Length";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Width.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Width.Location = new System.Drawing.Point(11, 107);
            this.lbl_Width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(63, 25);
            this.lbl_Width.TabIndex = 5;
            this.lbl_Width.Text = "Width";
            // 
            // txtBox_Width
            // 
            this.txtBox_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Width.Location = new System.Drawing.Point(97, 103);
            this.txtBox_Width.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_Width.Name = "txtBox_Width";
            this.txtBox_Width.Size = new System.Drawing.Size(132, 30);
            this.txtBox_Width.TabIndex = 4;
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Height.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Height.Location = new System.Drawing.Point(11, 158);
            this.lbl_Height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(68, 25);
            this.lbl_Height.TabIndex = 7;
            this.lbl_Height.Text = "Height";
            // 
            // txtBox_Height
            // 
            this.txtBox_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Height.Location = new System.Drawing.Point(97, 155);
            this.txtBox_Height.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_Height.Name = "txtBox_Height";
            this.txtBox_Height.Size = new System.Drawing.Size(132, 30);
            this.txtBox_Height.TabIndex = 6;
            // 
            // grpBox_Inputs
            // 
            this.grpBox_Inputs.Controls.Add(this.lbl_LengthUnits);
            this.grpBox_Inputs.Controls.Add(this.lbl_Height);
            this.grpBox_Inputs.Controls.Add(this.txtBox_Height);
            this.grpBox_Inputs.Controls.Add(this.lbl_Width);
            this.grpBox_Inputs.Controls.Add(this.txtBox_Width);
            this.grpBox_Inputs.Controls.Add(this.lbl_Length);
            this.grpBox_Inputs.Controls.Add(this.txtBox_Length);
            this.grpBox_Inputs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBox_Inputs.Location = new System.Drawing.Point(252, 132);
            this.grpBox_Inputs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBox_Inputs.Name = "grpBox_Inputs";
            this.grpBox_Inputs.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBox_Inputs.Size = new System.Drawing.Size(255, 209);
            this.grpBox_Inputs.TabIndex = 8;
            this.grpBox_Inputs.TabStop = false;
            // 
            // picBox_DumpTruck
            // 
            this.picBox_DumpTruck.Image = global::Demo_WinForms.SimpleCalculator.Properties.Resources.dump_truck;
            this.picBox_DumpTruck.InitialImage = global::Demo_WinForms.SimpleCalculator.Properties.Resources.dump_truck;
            this.picBox_DumpTruck.Location = new System.Drawing.Point(32, 20);
            this.picBox_DumpTruck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBox_DumpTruck.Name = "picBox_DumpTruck";
            this.picBox_DumpTruck.Size = new System.Drawing.Size(231, 94);
            this.picBox_DumpTruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_DumpTruck.TabIndex = 9;
            this.picBox_DumpTruck.TabStop = false;
            // 
            // cmbBox_Material
            // 
            this.cmbBox_Material.FormattingEnabled = true;
            this.cmbBox_Material.Location = new System.Drawing.Point(8, 122);
            this.cmbBox_Material.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBox_Material.Name = "cmbBox_Material";
            this.cmbBox_Material.Size = new System.Drawing.Size(160, 24);
            this.cmbBox_Material.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(45, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Material";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_WeightUnits);
            this.groupBox1.Controls.Add(this.btn_Calculate);
            this.groupBox1.Controls.Add(this.lbl_GrossWeight);
            this.groupBox1.Controls.Add(this.txtBox_GrossWeight);
            this.groupBox1.Controls.Add(this.lbl_PayloadWeight);
            this.groupBox1.Controls.Add(this.lbl_Empty);
            this.groupBox1.Controls.Add(this.txtBox_EmptyWeight);
            this.groupBox1.Controls.Add(this.txtBox_PayloadWeight);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(529, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(325, 259);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Calculate.Location = new System.Drawing.Point(87, 103);
            this.btn_Calculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(215, 38);
            this.btn_Calculate.TabIndex = 8;
            this.btn_Calculate.Text = "Calculate Weight";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // lbl_GrossWeight
            // 
            this.lbl_GrossWeight.AutoSize = true;
            this.lbl_GrossWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GrossWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_GrossWeight.Location = new System.Drawing.Point(72, 205);
            this.lbl_GrossWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GrossWeight.Name = "lbl_GrossWeight";
            this.lbl_GrossWeight.Size = new System.Drawing.Size(64, 25);
            this.lbl_GrossWeight.TabIndex = 7;
            this.lbl_GrossWeight.Text = "Gross";
            // 
            // txtBox_GrossWeight
            // 
            this.txtBox_GrossWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_GrossWeight.Location = new System.Drawing.Point(168, 202);
            this.txtBox_GrossWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_GrossWeight.Name = "txtBox_GrossWeight";
            this.txtBox_GrossWeight.Size = new System.Drawing.Size(132, 30);
            this.txtBox_GrossWeight.TabIndex = 6;
            this.txtBox_GrossWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_PayloadWeight
            // 
            this.lbl_PayloadWeight.AutoSize = true;
            this.lbl_PayloadWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PayloadWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_PayloadWeight.Location = new System.Drawing.Point(72, 154);
            this.lbl_PayloadWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PayloadWeight.Name = "lbl_PayloadWeight";
            this.lbl_PayloadWeight.Size = new System.Drawing.Size(83, 25);
            this.lbl_PayloadWeight.TabIndex = 5;
            this.lbl_PayloadWeight.Text = "Payload";
            // 
            // txtBox_PayloadWeight
            // 
            this.txtBox_PayloadWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_PayloadWeight.Location = new System.Drawing.Point(168, 150);
            this.txtBox_PayloadWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_PayloadWeight.Name = "txtBox_PayloadWeight";
            this.txtBox_PayloadWeight.Size = new System.Drawing.Size(132, 30);
            this.txtBox_PayloadWeight.TabIndex = 4;
            this.txtBox_PayloadWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Empty
            // 
            this.lbl_Empty.AutoSize = true;
            this.lbl_Empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Empty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Empty.Location = new System.Drawing.Point(8, 54);
            this.lbl_Empty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Empty.Name = "lbl_Empty";
            this.lbl_Empty.Size = new System.Drawing.Size(129, 25);
            this.lbl_Empty.TabIndex = 3;
            this.lbl_Empty.Text = "Truck Weight";
            // 
            // txtBox_EmptyWeight
            // 
            this.txtBox_EmptyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_EmptyWeight.Location = new System.Drawing.Point(170, 50);
            this.txtBox_EmptyWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_EmptyWeight.Name = "txtBox_EmptyWeight";
            this.txtBox_EmptyWeight.Size = new System.Drawing.Size(132, 30);
            this.txtBox_EmptyWeight.TabIndex = 2;
            this.txtBox_EmptyWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Help.Location = new System.Drawing.Point(32, 349);
            this.btn_Help.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(100, 42);
            this.btn_Help.TabIndex = 14;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.Btn_Help_Click);
            // 
            // radBtn_Imperial
            // 
            this.radBtn_Imperial.AutoSize = true;
            this.radBtn_Imperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtn_Imperial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radBtn_Imperial.Location = new System.Drawing.Point(33, 20);
            this.radBtn_Imperial.Name = "radBtn_Imperial";
            this.radBtn_Imperial.Size = new System.Drawing.Size(101, 29);
            this.radBtn_Imperial.TabIndex = 15;
            this.radBtn_Imperial.TabStop = true;
            this.radBtn_Imperial.Text = "Imperial";
            this.radBtn_Imperial.UseVisualStyleBackColor = true;
            // 
            // radBtn_Metric
            // 
            this.radBtn_Metric.AutoSize = true;
            this.radBtn_Metric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtn_Metric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radBtn_Metric.Location = new System.Drawing.Point(33, 51);
            this.radBtn_Metric.Name = "radBtn_Metric";
            this.radBtn_Metric.Size = new System.Drawing.Size(86, 29);
            this.radBtn_Metric.TabIndex = 16;
            this.radBtn_Metric.TabStop = true;
            this.radBtn_Metric.Text = "Metric";
            this.radBtn_Metric.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radBtn_Metric);
            this.groupBox2.Controls.Add(this.radBtn_Imperial);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbBox_Material);
            this.groupBox2.Location = new System.Drawing.Point(32, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 159);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // lbl_LengthUnits
            // 
            this.lbl_LengthUnits.AutoSize = true;
            this.lbl_LengthUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LengthUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_LengthUnits.Location = new System.Drawing.Point(164, 19);
            this.lbl_LengthUnits.Name = "lbl_LengthUnits";
            this.lbl_LengthUnits.Size = new System.Drawing.Size(65, 25);
            this.lbl_LengthUnits.TabIndex = 8;
            this.lbl_LengthUnits.Text = "(Feet)";
            this.lbl_LengthUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_WeightUnits
            // 
            this.lbl_WeightUnits.AutoSize = true;
            this.lbl_WeightUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WeightUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_WeightUnits.Location = new System.Drawing.Point(209, 18);
            this.lbl_WeightUnits.Name = "lbl_WeightUnits";
            this.lbl_WeightUnits.Size = new System.Drawing.Size(93, 25);
            this.lbl_WeightUnits.TabIndex = 9;
            this.lbl_WeightUnits.Text = "(Pounds)";
            this.lbl_WeightUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(885, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBox_DumpTruck);
            this.Controls.Add(this.grpBox_Inputs);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "The Simple Calculator";
            this.grpBox_Inputs.ResumeLayout(false);
            this.grpBox_Inputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_DumpTruck)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txtBox_Length;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.TextBox txtBox_Width;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.TextBox txtBox_Height;
        private System.Windows.Forms.GroupBox grpBox_Inputs;
        private System.Windows.Forms.PictureBox picBox_DumpTruck;
        private System.Windows.Forms.ComboBox cmbBox_Material;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lbl_GrossWeight;
        private System.Windows.Forms.TextBox txtBox_GrossWeight;
        private System.Windows.Forms.Label lbl_PayloadWeight;
        private System.Windows.Forms.TextBox txtBox_PayloadWeight;
        private System.Windows.Forms.Label lbl_Empty;
        private System.Windows.Forms.TextBox txtBox_EmptyWeight;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.RadioButton radBtn_Imperial;
        private System.Windows.Forms.RadioButton radBtn_Metric;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_LengthUnits;
        private System.Windows.Forms.Label lbl_WeightUnits;
    }
}

