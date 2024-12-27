namespace CSharpEgitimKampi501
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
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.txtProductID = new System.Windows.Forms.TextBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.btnList = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.txtProductName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtProductPrice = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtProductStock = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtProductCategory = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.lblTotalProductCount = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.lblMaxPriceProductName = new System.Windows.Forms.Label();
      this.lblDistinctCategoryCount = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(33, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ürün ID:";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // txtProductID
      // 
      this.txtProductID.Location = new System.Drawing.Point(101, 41);
      this.txtProductID.Name = "txtProductID";
      this.txtProductID.Size = new System.Drawing.Size(148, 22);
      this.txtProductID.TabIndex = 1;
      this.txtProductID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // btnList
      // 
      this.btnList.Location = new System.Drawing.Point(102, 240);
      this.btnList.Name = "btnList";
      this.btnList.Size = new System.Drawing.Size(148, 36);
      this.btnList.TabIndex = 3;
      this.btnList.Text = "Listele";
      this.btnList.UseVisualStyleBackColor = true;
      this.btnList.Click += new System.EventHandler(this.btnList_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(255, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(837, 390);
      this.dataGridView1.TabIndex = 4;
      // 
      // txtProductName
      // 
      this.txtProductName.Location = new System.Drawing.Point(101, 80);
      this.txtProductName.Name = "txtProductName";
      this.txtProductName.Size = new System.Drawing.Size(148, 22);
      this.txtProductName.TabIndex = 6;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.Location = new System.Drawing.Point(26, 83);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(77, 18);
      this.label2.TabIndex = 5;
      this.label2.Text = "Ürün Adı:";
      // 
      // txtProductPrice
      // 
      this.txtProductPrice.Location = new System.Drawing.Point(101, 119);
      this.txtProductPrice.Name = "txtProductPrice";
      this.txtProductPrice.Size = new System.Drawing.Size(148, 22);
      this.txtProductPrice.TabIndex = 8;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.Location = new System.Drawing.Point(48, 122);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(49, 18);
      this.label3.TabIndex = 7;
      this.label3.Text = "Fiyat:";
      // 
      // txtProductStock
      // 
      this.txtProductStock.Location = new System.Drawing.Point(101, 156);
      this.txtProductStock.Name = "txtProductStock";
      this.txtProductStock.Size = new System.Drawing.Size(148, 22);
      this.txtProductStock.TabIndex = 10;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label4.Location = new System.Drawing.Point(50, 159);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 18);
      this.label4.TabIndex = 9;
      this.label4.Text = "Stok:";
      // 
      // txtProductCategory
      // 
      this.txtProductCategory.Location = new System.Drawing.Point(101, 199);
      this.txtProductCategory.Name = "txtProductCategory";
      this.txtProductCategory.Size = new System.Drawing.Size(148, 22);
      this.txtProductCategory.TabIndex = 12;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label5.Location = new System.Drawing.Point(27, 202);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(76, 18);
      this.label5.TabIndex = 11;
      this.label5.Text = "Kategori:";
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(102, 282);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(148, 36);
      this.btnAdd.TabIndex = 13;
      this.btnAdd.Text = "Ekle";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(102, 324);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(148, 36);
      this.btnDelete.TabIndex = 14;
      this.btnDelete.Text = "Sil";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Location = new System.Drawing.Point(102, 366);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(148, 36);
      this.btnUpdate.TabIndex = 15;
      this.btnUpdate.Text = "Güncelle";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label6.Location = new System.Drawing.Point(264, 420);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(194, 22);
      this.label6.TabIndex = 16;
      this.label6.Text = "Toplam Kitap Sayısı:";
      // 
      // lblTotalProductCount
      // 
      this.lblTotalProductCount.AutoSize = true;
      this.lblTotalProductCount.BackColor = System.Drawing.Color.SpringGreen;
      this.lblTotalProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblTotalProductCount.Location = new System.Drawing.Point(481, 422);
      this.lblTotalProductCount.Name = "lblTotalProductCount";
      this.lblTotalProductCount.Size = new System.Drawing.Size(19, 20);
      this.lblTotalProductCount.TabIndex = 17;
      this.lblTotalProductCount.Text = "0";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.BackColor = System.Drawing.Color.SpringGreen;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label7.Location = new System.Drawing.Point(775, 422);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(0, 20);
      this.label7.TabIndex = 19;
      this.label7.Click += new System.EventHandler(this.label7_Click);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label8.Location = new System.Drawing.Point(581, 420);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(154, 22);
      this.label8.TabIndex = 18;
      this.label8.Text = "En Pahalı Kitap:";
      this.label8.Click += new System.EventHandler(this.label8_Click);
      // 
      // lblMaxPriceProductName
      // 
      this.lblMaxPriceProductName.AutoSize = true;
      this.lblMaxPriceProductName.BackColor = System.Drawing.Color.SpringGreen;
      this.lblMaxPriceProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblMaxPriceProductName.Location = new System.Drawing.Point(775, 422);
      this.lblMaxPriceProductName.Name = "lblMaxPriceProductName";
      this.lblMaxPriceProductName.Size = new System.Drawing.Size(19, 20);
      this.lblMaxPriceProductName.TabIndex = 20;
      this.lblMaxPriceProductName.Text = "0";
      // 
      // lblDistinctCategoryCount
      // 
      this.lblDistinctCategoryCount.AutoSize = true;
      this.lblDistinctCategoryCount.BackColor = System.Drawing.Color.SpringGreen;
      this.lblDistinctCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblDistinctCategoryCount.Location = new System.Drawing.Point(481, 458);
      this.lblDistinctCategoryCount.Name = "lblDistinctCategoryCount";
      this.lblDistinctCategoryCount.Size = new System.Drawing.Size(19, 20);
      this.lblDistinctCategoryCount.TabIndex = 23;
      this.lblDistinctCategoryCount.Text = "0";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.BackColor = System.Drawing.Color.SpringGreen;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label10.Location = new System.Drawing.Point(1029, 424);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(0, 20);
      this.label10.TabIndex = 22;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label11.Location = new System.Drawing.Point(264, 456);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(151, 22);
      this.label11.TabIndex = 21;
      this.label11.Text = "Kategori Sayısı:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Teal;
      this.ClientSize = new System.Drawing.Size(1183, 604);
      this.Controls.Add(this.lblDistinctCategoryCount);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.lblMaxPriceProductName);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.lblTotalProductCount);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.txtProductCategory);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtProductStock);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtProductPrice);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtProductName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnList);
      this.Controls.Add(this.txtProductID);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtProductID;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.Button btnList;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.TextBox txtProductName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtProductPrice;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtProductStock;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtProductCategory;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label lblTotalProductCount;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label lblMaxPriceProductName;
    private System.Windows.Forms.Label lblDistinctCategoryCount;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
  }
}

