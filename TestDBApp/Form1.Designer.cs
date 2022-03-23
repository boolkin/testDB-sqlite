namespace TestDBApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.showReport = new System.Windows.Forms.Button();
            this.dateEndpicker = new System.Windows.Forms.DateTimePicker();
            this.clearAllFields = new System.Windows.Forms.Button();
            this.ButtonSendValues = new System.Windows.Forms.Button();
            this.prodPriceTB = new System.Windows.Forms.TextBox();
            this.prodQtyTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Suppliers = new System.Windows.Forms.ListBox();
            this.productList = new System.Windows.Forms.ListBox();
            this.prodTypesLB = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbQtyComp = new System.Windows.Forms.ListBox();
            this.lbPriceComp = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateStartPicker = new System.Windows.Forms.DateTimePicker();
            this.useDateCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.summaryReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showReport
            // 
            this.showReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showReport.Location = new System.Drawing.Point(16, 148);
            this.showReport.Name = "showReport";
            this.showReport.Size = new System.Drawing.Size(116, 46);
            this.showReport.TabIndex = 9;
            this.showReport.Text = "Показать выборку";
            this.toolTip1.SetToolTip(this.showReport, "Выберите необходимые поля сверху по которым будет сформирован отчет");
            this.showReport.UseVisualStyleBackColor = true;
            this.showReport.Click += new System.EventHandler(this.showReport_Click);
            // 
            // dateEndpicker
            // 
            this.dateEndpicker.Location = new System.Drawing.Point(450, 178);
            this.dateEndpicker.Name = "dateEndpicker";
            this.dateEndpicker.Size = new System.Drawing.Size(142, 20);
            this.dateEndpicker.TabIndex = 12;
            // 
            // clearAllFields
            // 
            this.clearAllFields.Location = new System.Drawing.Point(58, 96);
            this.clearAllFields.Name = "clearAllFields";
            this.clearAllFields.Size = new System.Drawing.Size(306, 23);
            this.clearAllFields.TabIndex = 9;
            this.clearAllFields.Text = "Очистить все поля";
            this.clearAllFields.UseVisualStyleBackColor = true;
            this.clearAllFields.Click += new System.EventHandler(this.clearAllFields_Click);
            // 
            // ButtonSendValues
            // 
            this.ButtonSendValues.Location = new System.Drawing.Point(437, 56);
            this.ButtonSendValues.Name = "ButtonSendValues";
            this.ButtonSendValues.Size = new System.Drawing.Size(154, 30);
            this.ButtonSendValues.TabIndex = 0;
            this.ButtonSendValues.Text = "Добавить запись";
            this.ButtonSendValues.UseVisualStyleBackColor = true;
            this.ButtonSendValues.Click += new System.EventHandler(this.SendValues_Click);
            // 
            // prodPriceTB
            // 
            this.prodPriceTB.Location = new System.Drawing.Point(437, 28);
            this.prodPriceTB.Name = "prodPriceTB";
            this.prodPriceTB.Size = new System.Drawing.Size(63, 20);
            this.prodPriceTB.TabIndex = 1;
            this.prodPriceTB.TextChanged += new System.EventHandler(this.prodPriceTB_TextChanged);
            // 
            // prodQtyTB
            // 
            this.prodQtyTB.Location = new System.Drawing.Point(528, 28);
            this.prodQtyTB.Name = "prodQtyTB";
            this.prodQtyTB.Size = new System.Drawing.Size(63, 20);
            this.prodQtyTB.TabIndex = 1;
            this.prodQtyTB.TextChanged += new System.EventHandler(this.prodQtyTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество";
            // 
            // Suppliers
            // 
            this.Suppliers.FormattingEnabled = true;
            this.Suppliers.Location = new System.Drawing.Point(14, 28);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(134, 56);
            this.Suppliers.TabIndex = 6;
            this.Suppliers.SelectedIndexChanged += new System.EventHandler(this.Suppliers_SelectedIndexChanged);
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Items.AddRange(new object[] {
            "Яблоки",
            "Груши"});
            this.productList.Location = new System.Drawing.Point(170, 28);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(111, 56);
            this.productList.TabIndex = 7;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // prodTypesLB
            // 
            this.prodTypesLB.FormattingEnabled = true;
            this.prodTypesLB.Items.AddRange(new object[] {
            "Первый сорт",
            "Второй сорт"});
            this.prodTypesLB.Location = new System.Drawing.Point(300, 28);
            this.prodTypesLB.Name = "prodTypesLB";
            this.prodTypesLB.Size = new System.Drawing.Size(112, 56);
            this.prodTypesLB.TabIndex = 8;
            this.prodTypesLB.SelectedIndexChanged += new System.EventHandler(this.prodTypesLB_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbQtyComp);
            this.panel1.Controls.Add(this.lbPriceComp);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.prodTypesLB);
            this.panel1.Controls.Add(this.clearAllFields);
            this.panel1.Controls.Add(this.productList);
            this.panel1.Controls.Add(this.Suppliers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.prodQtyTB);
            this.panel1.Controls.Add(this.prodPriceTB);
            this.panel1.Controls.Add(this.ButtonSendValues);
            this.panel1.Location = new System.Drawing.Point(16, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 131);
            this.panel1.TabIndex = 13;
            // 
            // lbQtyComp
            // 
            this.lbQtyComp.FormattingEnabled = true;
            this.lbQtyComp.Items.AddRange(new object[] {
            " >",
            " <"});
            this.lbQtyComp.Location = new System.Drawing.Point(545, 94);
            this.lbQtyComp.Name = "lbQtyComp";
            this.lbQtyComp.Size = new System.Drawing.Size(31, 30);
            this.lbQtyComp.TabIndex = 11;
            // 
            // lbPriceComp
            // 
            this.lbPriceComp.FormattingEnabled = true;
            this.lbPriceComp.Items.AddRange(new object[] {
            "  >",
            "  <"});
            this.lbPriceComp.Location = new System.Drawing.Point(453, 94);
            this.lbPriceComp.Name = "lbPriceComp";
            this.lbPriceComp.Size = new System.Drawing.Size(31, 30);
            this.lbPriceComp.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Сорт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Товары";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Поставщики";
            // 
            // dateStartPicker
            // 
            this.dateStartPicker.Location = new System.Drawing.Point(450, 152);
            this.dateStartPicker.Name = "dateStartPicker";
            this.dateStartPicker.Size = new System.Drawing.Size(142, 20);
            this.dateStartPicker.TabIndex = 15;
            // 
            // useDateCB
            // 
            this.useDateCB.Location = new System.Drawing.Point(304, 152);
            this.useDateCB.Name = "useDateCB";
            this.useDateCB.Size = new System.Drawing.Size(119, 46);
            this.useDateCB.TabIndex = 16;
            this.useDateCB.Text = "Использовать выборку по датам";
            this.useDateCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "с";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "по";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 275);
            this.dataGridView1.TabIndex = 18;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // summaryReport
            // 
            this.summaryReport.Location = new System.Drawing.Point(156, 148);
            this.summaryReport.Name = "summaryReport";
            this.summaryReport.Size = new System.Drawing.Size(116, 46);
            this.summaryReport.TabIndex = 19;
            this.summaryReport.Text = "Показать отчет";
            this.summaryReport.UseVisualStyleBackColor = true;
            this.summaryReport.Click += new System.EventHandler(this.summaryReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 507);
            this.Controls.Add(this.summaryReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.useDateCB);
            this.Controls.Add(this.dateStartPicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateEndpicker);
            this.Controls.Add(this.showReport);
            this.Name = "Form1";
            this.Text = "TestDBApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showReport;
        private System.Windows.Forms.DateTimePicker dateEndpicker;
        private System.Windows.Forms.Button clearAllFields;
        private System.Windows.Forms.Button ButtonSendValues;
        private System.Windows.Forms.TextBox prodPriceTB;
        private System.Windows.Forms.TextBox prodQtyTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Suppliers;
        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.ListBox prodTypesLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateStartPicker;
        private System.Windows.Forms.CheckBox useDateCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbQtyComp;
        private System.Windows.Forms.ListBox lbPriceComp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button summaryReport;
    }
}

