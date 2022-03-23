using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace TestDBApp
{
    public partial class Form1 : Form
    {
        private SQLiteConnection DB;
        private static int supplierIdx= -1;
        private static int productIdx = -1;
        private static int prodTypesIdx = -1;
        private static string supplierName = "", productName = "", prodType ="";
        private static Single prodPrice, prodQty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Подключение к базе при загрузке формы
            DB = new SQLiteConnection("Data Source = TestDB.db; Version = 3");
            DB.Open();
            DateTime thisDay = DateTime.Now;
            dateEndpicker.Value = thisDay;
            dateStartPicker.Value = thisDay.AddDays(-2);
            // отобразить всех поставщиков из таблицы Suppliers базы данных в listBox
            SQLiteCommand queryShow = DB.CreateCommand();
            queryShow.CommandText = "select Name from 'Suppliers'"; // выбираем столбец Name
            SQLiteDataReader reply = queryShow.ExecuteReader();
            if (reply.HasRows)
            {
                while (reply.Read())
                {
                   //по строкам в виде массива стобцов и т.к. запрошен всего один столбец Name, то нужные нам данные находятся по индексу 0
                    Suppliers.Items.Add(reply[0]);
                }
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //закрыть соединение с базой при закрытии формы
            DB.Close();
        }

        private void SendValues_Click(object sender, EventArgs e)
        {
      
            if (prodPriceTB.Text != "" && prodQtyTB.Text != "" && !(supplierIdx < 0 || productIdx < 0 || prodTypesIdx < 0))
                {
                    if (prodPrice > 0 && prodQty > 0)
                    {
                        // Создаем запрос и выполняем его
                        SQLiteCommand queryAdd = DB.CreateCommand();
                        queryAdd.CommandText = "insert into 'Table' (Supplier, Product, Type, Price, Qty) " +
                                                "values (@Supplier, @Product, @Type, @Price, @Qty)";
                        queryAdd.Parameters.Add("@Supplier", DbType.String).Value = supplierName;
                        queryAdd.Parameters.Add("@Product", DbType.String).Value = productName;
                        queryAdd.Parameters.Add("@Type", DbType.String).Value = prodType;
                        queryAdd.Parameters.Add("@Price", DbType.String).Value = prodPrice.ToString().Replace(',', '.'); ;
                        queryAdd.Parameters.Add("@Qty", DbType.String).Value = prodQty.ToString().Replace(',', '.'); ;
                        queryAdd.ExecuteNonQuery();
                        MessageBox.Show("Добавлено");
                    }
                    else {
                        MessageBox.Show("Количество и цена должны быть больше нуля");
                    }
             }
            else { 
               MessageBox.Show("Не забудьте выбрать поставщика, продукт и его сорт, " +
                        "а также заполните цену и количество перед отправкой данных."); 
             }  
        }

        private void showReport_Click(object sender, EventArgs e)
        {
            
            // Создаем запрос и выполняем его
            SQLiteCommand queryShow = DB.CreateCommand();
            // % в SQLite означает любое количество символов до и после, и если поле не заполнено, то все записи будут подходить под условия
            // || - конкатенация строк. 
            queryShow.CommandText = "select * from 'Table' where Supplier like '%' || @Supplier || '%' " +
                "and Product like '%' || @Product || '%' and Type like '%' || @Type || '%' ";
            queryShow.Parameters.Add("@Supplier", DbType.String).Value = supplierName;
            queryShow.Parameters.Add("@Product", DbType.String).Value = productName;
            queryShow.Parameters.Add("@Type", DbType.String).Value = prodType;
            if (useDateCB.Checked) {
                queryShow.Parameters.Add("@DateStart", DbType.String).Value = dateStartPicker.Value.ToString("yyy-MM-dd");
                queryShow.Parameters.Add("@DateEnd", DbType.String).Value = dateEndpicker.Value.ToString("yyy-MM-dd HH:mm:ss");
                queryShow.CommandText += " and Date > @DateStart and Date<@DateEnd";
            }

            if (prodPriceTB.Text != "") {
                queryShow.Parameters.Add("@Price", DbType.String).Value = prodPrice.ToString().Replace(',', '.');
                if (lbPriceComp.SelectedIndex == 0) queryShow.CommandText += " and Price > @Price";
                else if (lbPriceComp.SelectedIndex == 1) queryShow.CommandText += " and Price < @Price";
                else  queryShow.CommandText += " and Price = @Price";
            }
            if (prodQtyTB.Text != "") {
                queryShow.Parameters.Add("@Qty", DbType.String).Value = prodQty.ToString().Replace(',', '.');
                if (lbQtyComp.SelectedIndex == 0) queryShow.CommandText += " and Qty > @Qty";
                else if (lbQtyComp.SelectedIndex == 1) queryShow.CommandText += " and Qty < @Qty";
                else queryShow.CommandText += " and Qty = @Qty";
            }   
            SQLiteDataReader reply = queryShow.ExecuteReader();
           DataTable dt = new DataTable();
            dt.Load(reply);
            dataGridView1.DataSource = dt;
           

        }



        private void clearAllFields_Click(object sender, EventArgs e)
        {
            prodTypesLB.ClearSelected();            
            Suppliers.ClearSelected();   
            productList.ClearSelected();   
            lbQtyComp.ClearSelected();
            lbPriceComp.ClearSelected();
            prodPriceTB.Text = "";
            prodQtyTB.Text = "";
        }

        private void prodPriceTB_TextChanged(object sender, EventArgs e)
        {
            if (prodPriceTB.Text != "")
            {
                try
                {
                    prodPrice = float.Parse(prodPriceTB.Text);
                }
                catch
                {
                    MessageBox.Show("Не верный формат числа. Используйте запятую для дробных чисел"); // показываем сообщение об ошибке если формат чисел введен неверно
                }
            }
            
        }

        private void prodQtyTB_TextChanged(object sender, EventArgs e)
        {
            if (prodQtyTB.Text != "")
                try
            {
                prodQty = float.Parse(prodQtyTB.Text);
            }
            catch
            {
                MessageBox.Show("Не верный формат числа. Используйте запятую для дробных чисел"); // показываем сообщение об ошибке если формат чисел введен неверно
            }
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void summaryReport_Click(object sender, EventArgs e)
        {
            SQLiteCommand queryShow = DB.CreateCommand();
            queryShow.CommandText = "SELECT s.Name as Поставщик, t.Product as Продукция, t.Type as Тип, " +
                "SUM(t.Cost) as 'Общая стоимость',SUM(t.Qty) as 'Общее кол-во' " +
                "FROM 'Table' t, Suppliers s WHERE s.Name = t.Supplier ";
            if (useDateCB.Checked)
            {
                queryShow.Parameters.Add("@DateStart", DbType.String).Value = dateStartPicker.Value.ToString("yyy-MM-dd");
                queryShow.Parameters.Add("@DateEnd", DbType.String).Value = dateEndpicker.Value.ToString("yyy-MM-dd HH:mm:ss");
                queryShow.CommandText += " and t.Date > @DateStart and t.Date<@DateEnd ";
            }
            queryShow.CommandText += "GROUP BY s.Name,t.Product,t.Type;";
            SQLiteDataReader reply = queryShow.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reply);
            dataGridView1.DataSource = dt;
        }





        // Ниже записываются в переменные индексы и названия выбора из листбоксов
        private void prodTypesLB_SelectedIndexChanged(object sender, EventArgs e)
        {

            prodTypesIdx = prodTypesLB.SelectedIndex;
            if (prodTypesIdx >= 0)
            {
                prodType = prodTypesLB.SelectedItem.ToString();
            } else prodType = "";
        }

        private void Suppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplierIdx = Suppliers.SelectedIndex;
            if (supplierIdx >= 0)
            {
                supplierName = Suppliers.SelectedItem.ToString();
            } else supplierName = "";
        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            productIdx = productList.SelectedIndex;
            if (productIdx>=0)
            {
                productName = productList.SelectedItem.ToString();
            } else productName = "";
        }
    }
}
