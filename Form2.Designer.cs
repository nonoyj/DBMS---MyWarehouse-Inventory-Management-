namespace Warehouse_Management
{
    partial class Dashboard
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.product_name = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.product_name_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.quantity_label = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.log_out = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // product_name
            // 
            this.product_name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.product_name.Location = new System.Drawing.Point(232, 122);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(273, 34);
            this.product_name.TabIndex = 12;
            this.product_name.TextChanged += new System.EventHandler(this.product_name_TextChanged);
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.category.Location = new System.Drawing.Point(232, 194);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(273, 34);
            this.category.TabIndex = 11;
            this.category.TextChanged += new System.EventHandler(this.category_TextChanged);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quantity.Location = new System.Drawing.Point(620, 194);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(273, 34);
            this.quantity.TabIndex = 10;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.price.Location = new System.Drawing.Point(620, 122);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(273, 34);
            this.price.TabIndex = 9;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // product_name_label
            // 
            this.product_name_label.AutoSize = true;
            this.product_name_label.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.product_name_label.Location = new System.Drawing.Point(227, 89);
            this.product_name_label.Name = "product_name_label";
            this.product_name_label.Size = new System.Drawing.Size(153, 28);
            this.product_name_label.TabIndex = 8;
            this.product_name_label.Text = "Product name:";
            this.product_name_label.Click += new System.EventHandler(this.product_name_label_Click);
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.category_label.Location = new System.Drawing.Point(227, 162);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(111, 28);
            this.category_label.TabIndex = 7;
            this.category_label.Text = "Category:";
            this.category_label.Click += new System.EventHandler(this.category_label_Click);
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.price_label.Location = new System.Drawing.Point(615, 89);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(67, 28);
            this.price_label.TabIndex = 6;
            this.price_label.Text = "Price:";
            this.price_label.Click += new System.EventHandler(this.price_label_Click);
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.quantity_label.Location = new System.Drawing.Point(615, 162);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(108, 28);
            this.quantity_label.TabIndex = 5;
            this.quantity_label.Text = "Quantity:";
            this.quantity_label.Click += new System.EventHandler(this.quantity_label_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DarkSlateGray;
            this.add.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold);
            this.add.Location = new System.Drawing.Point(232, 243);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(135, 35);
            this.add.TabIndex = 4;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DarkSlateGray;
            this.update.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold);
            this.update.Location = new System.Drawing.Point(415, 243);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(135, 35);
            this.update.TabIndex = 3;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.delete.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold);
            this.delete.Location = new System.Drawing.Point(583, 243);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(135, 35);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.clear.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold);
            this.clear.Location = new System.Drawing.Point(758, 243);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(135, 35);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Location = new System.Drawing.Point(232, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(661, 144);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(805, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "System by Amarante, De la Cruz, Gavilla, Malan, Misajon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // log_out
            // 
            this.log_out.AutoSize = true;
            this.log_out.BackColor = System.Drawing.Color.Teal;
            this.log_out.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold);
            this.log_out.Location = new System.Drawing.Point(1021, 12);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(65, 48);
            this.log_out.TabIndex = 14;
            this.log_out.Text = "➜]";
            this.log_out.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.log_out.UseVisualStyleBackColor = false;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 61);
            this.label2.TabIndex = 15;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(554, 40);
            this.label3.TabIndex = 16;
            this.label3.Text = "MyWarehouse Inventory Management";
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.log_out);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.product_name_label);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.category);
            this.Controls.Add(this.product_name);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Warehouse Inventory Management System";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox product_name;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label product_name_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}