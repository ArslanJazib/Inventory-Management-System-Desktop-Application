namespace VPLabMidTask2
{
    partial class mobileShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mobileShop));
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.mainlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.options = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sellStock = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cName = new System.Windows.Forms.RadioButton();
            this.priceTag = new System.Windows.Forms.RadioButton();
            this.mNumber = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.input_tbox = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.mobileData = new System.Windows.Forms.DataGridView();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileData)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLogo
            // 
            this.mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainLogo.Image")));
            this.mainLogo.Location = new System.Drawing.Point(1047, 15);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(64, 68);
            this.mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainLogo.TabIndex = 0;
            this.mainLogo.TabStop = false;
            // 
            // mainlbl
            // 
            this.mainlbl.AutoSize = true;
            this.mainlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlbl.Location = new System.Drawing.Point(897, 34);
            this.mainlbl.Name = "mainlbl";
            this.mainlbl.Size = new System.Drawing.Size(144, 26);
            this.mainlbl.TabIndex = 1;
            this.mainlbl.Text = "Mobile Shop";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.options);
            this.panel1.Controls.Add(this.input_tbox);
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Controls.Add(this.update_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.mainLogo);
            this.panel1.Controls.Add(this.mainlbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 106);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // options
            // 
            this.options.Controls.Add(this.pictureBox3);
            this.options.Controls.Add(this.sellStock);
            this.options.Controls.Add(this.pictureBox4);
            this.options.Controls.Add(this.pictureBox1);
            this.options.Controls.Add(this.cName);
            this.options.Controls.Add(this.priceTag);
            this.options.Controls.Add(this.mNumber);
            this.options.Controls.Add(this.pictureBox2);
            this.options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.options.Location = new System.Drawing.Point(331, 15);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(235, 68);
            this.options.TabIndex = 7;
            this.options.TabStop = false;
            this.options.Text = "Options";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(171, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // sellStock
            // 
            this.sellStock.AutoSize = true;
            this.sellStock.Location = new System.Drawing.Point(201, 31);
            this.sellStock.Name = "sellStock";
            this.sellStock.Size = new System.Drawing.Size(21, 20);
            this.sellStock.TabIndex = 22;
            this.sellStock.TabStop = true;
            this.sellStock.UseVisualStyleBackColor = true;
            this.sellStock.CheckedChanged += new System.EventHandler(this.sellStock_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // cName
            // 
            this.cName.AutoSize = true;
            this.cName.Location = new System.Drawing.Point(36, 31);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(21, 20);
            this.cName.TabIndex = 16;
            this.cName.TabStop = true;
            this.cName.UseVisualStyleBackColor = true;
            this.cName.CheckedChanged += new System.EventHandler(this.cName_CheckedChanged);
            // 
            // priceTag
            // 
            this.priceTag.AutoSize = true;
            this.priceTag.Location = new System.Drawing.Point(144, 31);
            this.priceTag.Name = "priceTag";
            this.priceTag.Size = new System.Drawing.Size(21, 20);
            this.priceTag.TabIndex = 18;
            this.priceTag.TabStop = true;
            this.priceTag.UseVisualStyleBackColor = true;
            this.priceTag.CheckedChanged += new System.EventHandler(this.priceTag_CheckedChanged);
            // 
            // mNumber
            // 
            this.mNumber.AutoSize = true;
            this.mNumber.Location = new System.Drawing.Point(90, 31);
            this.mNumber.Name = "mNumber";
            this.mNumber.Size = new System.Drawing.Size(21, 20);
            this.mNumber.TabIndex = 17;
            this.mNumber.TabStop = true;
            this.mNumber.UseVisualStyleBackColor = true;
            this.mNumber.CheckedChanged += new System.EventHandler(this.mNumber_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(60, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // input_tbox
            // 
            this.input_tbox.Enabled = false;
            this.input_tbox.Location = new System.Drawing.Point(572, 46);
            this.input_tbox.Name = "input_tbox";
            this.input_tbox.Size = new System.Drawing.Size(160, 26);
            this.input_tbox.TabIndex = 6;
            // 
            // search_btn
            // 
            this.search_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_btn.BackgroundImage")));
            this.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Location = new System.Drawing.Point(175, 15);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(64, 68);
            this.search_btn.TabIndex = 5;
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_btn.BackgroundImage")));
            this.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.delete_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.delete_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Location = new System.Drawing.Point(261, 15);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(64, 68);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_btn.BackgroundImage")));
            this.update_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_btn.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.update_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.update_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Location = new System.Drawing.Point(89, 15);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(64, 68);
            this.update_btn.TabIndex = 3;
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_btn.BackgroundImage")));
            this.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Location = new System.Drawing.Point(3, 15);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(64, 68);
            this.add_btn.TabIndex = 2;
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // mobileData
            // 
            this.mobileData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mobileData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.mobileData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mobileData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyName,
            this.modelNumber,
            this.price,
            this.stock});
            this.mobileData.Location = new System.Drawing.Point(12, 124);
            this.mobileData.Name = "mobileData";
            this.mobileData.ReadOnly = true;
            this.mobileData.RowTemplate.Height = 28;
            this.mobileData.Size = new System.Drawing.Size(1114, 529);
            this.mobileData.TabIndex = 3;
            this.mobileData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mobileData_CellContentDoubleClick);
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Company Name";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            // 
            // modelNumber
            // 
            this.modelNumber.HeaderText = "Model Number";
            this.modelNumber.Name = "modelNumber";
            this.modelNumber.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // mobileShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 665);
            this.Controls.Add(this.mobileData);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mobileShop";
            this.Text = "Mobile Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mobileShop_FormClosing);
            this.Load += new System.EventHandler(this.mobileShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainLogo;
        private System.Windows.Forms.Label mainlbl;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView mobileData;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox input_tbox;
        private System.Windows.Forms.GroupBox options;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.RadioButton sellStock;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RadioButton cName;
        public System.Windows.Forms.RadioButton priceTag;
        public System.Windows.Forms.RadioButton mNumber;
        public System.Windows.Forms.PictureBox pictureBox2;
    }
}

