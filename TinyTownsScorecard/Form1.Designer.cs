namespace TinyTownsScorecard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.builderNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearCardBtn = new System.Windows.Forms.Button();
            this.calculateTotalBtn = new System.Windows.Forms.Button();
            this.addImageBtn = new System.Windows.Forms.Button();
            this.finalGameImage = new System.Windows.Forms.PictureBox();
            this.warehouseValue = new System.Windows.Forms.NumericUpDown();
            this.cottageValue = new System.Windows.Forms.NumericUpDown();
            this.chapelValue = new System.Windows.Forms.NumericUpDown();
            this.tavernValue = new System.Windows.Forms.NumericUpDown();
            this.bakeryValue = new System.Windows.Forms.NumericUpDown();
            this.wellValue = new System.Windows.Forms.NumericUpDown();
            this.monumentValue = new System.Windows.Forms.NumericUpDown();
            this.negativeValue = new System.Windows.Forms.NumericUpDown();
            this.totalValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalGameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cottageValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapelValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavernValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wellValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monumentValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negativeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-24, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(958, 803);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // builderNameTxt
            // 
            this.builderNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.builderNameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.builderNameTxt.Location = new System.Drawing.Point(130, 8);
            this.builderNameTxt.Multiline = true;
            this.builderNameTxt.Name = "builderNameTxt";
            this.builderNameTxt.Size = new System.Drawing.Size(119, 34);
            this.builderNameTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkOrchid;
            this.groupBox1.Controls.Add(this.clearCardBtn);
            this.groupBox1.Controls.Add(this.calculateTotalBtn);
            this.groupBox1.Controls.Add(this.addImageBtn);
            this.groupBox1.Controls.Add(this.finalGameImage);
            this.groupBox1.Location = new System.Drawing.Point(251, -17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 805);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Final Game Image";
            // 
            // clearCardBtn
            // 
            this.clearCardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearCardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearCardBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearCardBtn.Location = new System.Drawing.Point(474, 740);
            this.clearCardBtn.Name = "clearCardBtn";
            this.clearCardBtn.Size = new System.Drawing.Size(184, 59);
            this.clearCardBtn.TabIndex = 3;
            this.clearCardBtn.Text = "Clear Card";
            this.clearCardBtn.UseVisualStyleBackColor = false;
            this.clearCardBtn.Click += new System.EventHandler(this.clearCardBtn_Click);
            // 
            // calculateTotalBtn
            // 
            this.calculateTotalBtn.BackColor = System.Drawing.Color.Green;
            this.calculateTotalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateTotalBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateTotalBtn.Location = new System.Drawing.Point(5, 741);
            this.calculateTotalBtn.Name = "calculateTotalBtn";
            this.calculateTotalBtn.Size = new System.Drawing.Size(184, 59);
            this.calculateTotalBtn.TabIndex = 2;
            this.calculateTotalBtn.Text = "Calculate Total";
            this.calculateTotalBtn.UseVisualStyleBackColor = false;
            this.calculateTotalBtn.Click += new System.EventHandler(this.calculateTotalBtn_Click);
            // 
            // addImageBtn
            // 
            this.addImageBtn.BackColor = System.Drawing.Color.DarkGray;
            this.addImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImageBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addImageBtn.Location = new System.Drawing.Point(246, 666);
            this.addImageBtn.Name = "addImageBtn";
            this.addImageBtn.Size = new System.Drawing.Size(142, 59);
            this.addImageBtn.TabIndex = 1;
            this.addImageBtn.Text = "Add Image";
            this.addImageBtn.UseVisualStyleBackColor = false;
            this.addImageBtn.Click += new System.EventHandler(this.addImageBtn_Click);
            // 
            // finalGameImage
            // 
            this.finalGameImage.Location = new System.Drawing.Point(27, 54);
            this.finalGameImage.Name = "finalGameImage";
            this.finalGameImage.Size = new System.Drawing.Size(601, 589);
            this.finalGameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finalGameImage.TabIndex = 0;
            this.finalGameImage.TabStop = false;
            // 
            // warehouseValue
            // 
            this.warehouseValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warehouseValue.Location = new System.Drawing.Point(131, 70);
            this.warehouseValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.warehouseValue.Name = "warehouseValue";
            this.warehouseValue.Size = new System.Drawing.Size(120, 39);
            this.warehouseValue.TabIndex = 12;
            // 
            // cottageValue
            // 
            this.cottageValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cottageValue.Location = new System.Drawing.Point(129, 153);
            this.cottageValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.cottageValue.Name = "cottageValue";
            this.cottageValue.Size = new System.Drawing.Size(120, 39);
            this.cottageValue.TabIndex = 13;
            // 
            // chapelValue
            // 
            this.chapelValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chapelValue.Location = new System.Drawing.Point(128, 234);
            this.chapelValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.chapelValue.Name = "chapelValue";
            this.chapelValue.Size = new System.Drawing.Size(120, 39);
            this.chapelValue.TabIndex = 14;
            // 
            // tavernValue
            // 
            this.tavernValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tavernValue.Location = new System.Drawing.Point(127, 318);
            this.tavernValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.tavernValue.Name = "tavernValue";
            this.tavernValue.Size = new System.Drawing.Size(120, 39);
            this.tavernValue.TabIndex = 15;
            // 
            // bakeryValue
            // 
            this.bakeryValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bakeryValue.Location = new System.Drawing.Point(126, 405);
            this.bakeryValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.bakeryValue.Name = "bakeryValue";
            this.bakeryValue.Size = new System.Drawing.Size(120, 39);
            this.bakeryValue.TabIndex = 16;
            // 
            // wellValue
            // 
            this.wellValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wellValue.Location = new System.Drawing.Point(125, 491);
            this.wellValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.wellValue.Name = "wellValue";
            this.wellValue.Size = new System.Drawing.Size(120, 39);
            this.wellValue.TabIndex = 17;
            // 
            // monumentValue
            // 
            this.monumentValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monumentValue.Location = new System.Drawing.Point(125, 575);
            this.monumentValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.monumentValue.Name = "monumentValue";
            this.monumentValue.Size = new System.Drawing.Size(120, 39);
            this.monumentValue.TabIndex = 18;
            // 
            // negativeValue
            // 
            this.negativeValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.negativeValue.Location = new System.Drawing.Point(124, 664);
            this.negativeValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.negativeValue.Name = "negativeValue";
            this.negativeValue.Size = new System.Drawing.Size(120, 39);
            this.negativeValue.TabIndex = 19;
            // 
            // totalValue
            // 
            this.totalValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalValue.Location = new System.Drawing.Point(124, 737);
            this.totalValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(120, 39);
            this.totalValue.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 788);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.negativeValue);
            this.Controls.Add(this.monumentValue);
            this.Controls.Add(this.wellValue);
            this.Controls.Add(this.bakeryValue);
            this.Controls.Add(this.tavernValue);
            this.Controls.Add(this.chapelValue);
            this.Controls.Add(this.cottageValue);
            this.Controls.Add(this.warehouseValue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.builderNameTxt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tiny Towns Scorecard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.finalGameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cottageValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapelValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavernValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wellValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monumentValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negativeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox builderNameTxt;
        private GroupBox groupBox1;
        private Button addImageBtn;
        private PictureBox finalGameImage;
        private Button calculateTotalBtn;
        private NumericUpDown warehouseValue;
        private NumericUpDown cottageValue;
        private NumericUpDown chapelValue;
        private NumericUpDown tavernValue;
        private NumericUpDown bakeryValue;
        private NumericUpDown wellValue;
        private NumericUpDown monumentValue;
        private NumericUpDown negativeValue;
        private NumericUpDown totalValue;
        private Button clearCardBtn;
    }
}