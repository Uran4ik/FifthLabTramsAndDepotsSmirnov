using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zharFirstDataSet1.Tram". При необходимости она может быть перемещена или удалена.
            this.tramTableAdapter1.Fill(this.zharFirstDataSet1.Tram);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zharFirstDataSet.Tram". При необходимости она может быть перемещена или удалена.

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            bindingNavigator1.MoveFirstItem.Enabled = true;
            bindingNavigator1.MovePreviousItem.Enabled = true;
            if (tb_model.Text == "" || tb_year_construct.Text == "")
            {
                MessageBox.Show("Заполните все обязательные поля (модель, год постройки, дата кап ремонта)!");
                return;
            }
            if (tb_tram_length.Text == null) tb_tram_length.Text = "" + 0;
            string connectionString = @"Data Source=localhost;Initial Catalog=ZharFirst;
                                 Persist Security Info=True; Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    

                    string tramLengthText = tb_tram_length.Text.Replace(",", ".");

                    double tramLength;
                    if (!Double.TryParse(tramLengthText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out tramLength))
                    {
                        MessageBox.Show("Некорректное значение для длины трамвая.");
                        return;
                    }
                string dep = tbDepot_number.Text == "" ? null : tbDepot_number.Text;
                string cseats = tb_countseats.Text == "" ? null : tb_countseats.Text;
                string cplaces = tb_count_places.Text == "" ? null : tb_count_places.Text;
                string numtroll = tb_number_trolleys.Text == "" ? null : tb_number_trolleys.Text;
                string seccount = tb_sections_count.Text == "" ? null : tb_sections_count.Text;
                string len = tb_tram_length.Text == "" ? null : tb_tram_length.Text;
                string query = @"UPDATE Tram 
                            SET depot_number = @depot_number, 
                                model = @model, 
                                year_construction = @year_construction, 
                                date_major_repairs = @date_major_repairs, 
                                count_places = @count_places, 
                                count_seats = @count_seats, 
                                tram_length = @tram_length, 
                                trolleys_number = @trolleys_number, 
                                sections_number = @sections_number 
                            WHERE tram_number = @tram_number";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@model", tb_model.Text);
                    cmd.Parameters.AddWithValue("@tram_number",  labb_tram_number.Text);
                    cmd.Parameters.AddWithValue("@year_construction", tb_year_construct.Text);
                    cmd.Parameters.AddWithValue("@date_major_repairs", maskedTB_date.Text);

                    if (dep != null)
                        cmd.Parameters.AddWithValue("@depot_number", tbDepot_number.Text);
                    else
                        cmd.Parameters.AddWithValue("@depot_number", DBNull.Value);
                    if (cseats != null)
                        cmd.Parameters.AddWithValue("@count_seats", tb_countseats.Text);
                    else
                        cmd.Parameters.AddWithValue("@count_seats", DBNull.Value);
                    if (cplaces == null)
                        cmd.Parameters.AddWithValue("@count_places", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@count_places", tb_count_places.Text);
                    if (numtroll == null)
                        cmd.Parameters.AddWithValue("@trolleys_number", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@trolleys_number", tb_number_trolleys.Text);
                    if (seccount == null)
                        cmd.Parameters.AddWithValue("@sections_number", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@sections_number", tb_sections_count.Text);
                    if (len == null)
                        cmd.Parameters.AddWithValue("@tram_length", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@tram_length", tb_tram_length.Text);

                    cmd.ExecuteNonQuery();
                }
                
                }
            bindingNavigator1.MoveFirstItem.Enabled = true;
            bindingNavigator1.MovePreviousItem.Enabled = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (tb_model.Text == "" || tb_year_construct.Text == "")
            {
                MessageBox.Show("Заполните все обязательные поля (модель, год постройки, дата кап ремонта)!");
                return;
            }

            else
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=ZharFirst;
                                        Persist Security Info=True; Integrated Security=True";           
                try
                {
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        string dep = tbDepot_number.Text == "" ? null : tbDepot_number.Text;
                        string cseats = tb_countseats.Text == "" ? null : tb_countseats.Text;
                        string cplaces = tb_count_places.Text == "" ? null : tb_count_places.Text;
                        string numtroll = tb_number_trolleys.Text == "" ? null : tb_number_trolleys.Text;
                        string seccount = tb_sections_count.Text == "" ? null : tb_sections_count.Text;
                        string len = tb_tram_length.Text == "" ? null : tb_tram_length.Text;
                        cnn.Open();
                        string query = @"INSERT INTO Tram (depot_number, model, year_construction, date_major_repairs, count_places, count_seats, tram_length, trolleys_number, sections_number)
                         VALUES (@depot_number, @model, @year_construction, @date_major_repairs, @count_places, @count_seats, @tram_length, @trolleys_number, @sections_number)";
                        using (SqlCommand cmd = new SqlCommand(query, cnn))
                        {
                            cmd.Parameters.AddWithValue("@model", tb_model.Text);
                            cmd.Parameters.AddWithValue("@year_construction", tb_year_construct.Text);
                            cmd.Parameters.AddWithValue("@date_major_repairs", maskedTB_date.Text);

                            if (dep != null)
                                cmd.Parameters.AddWithValue("@depot_number", tbDepot_number.Text);
                            else
                                cmd.Parameters.AddWithValue("@depot_number", DBNull.Value);
                            if (cseats != null)
                                cmd.Parameters.AddWithValue("@count_seats", tb_countseats.Text);
                            else
                                cmd.Parameters.AddWithValue("@count_seats", DBNull.Value);
                            if (cplaces == null)
                                cmd.Parameters.AddWithValue("@count_places", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@count_places", tb_count_places.Text);
                            if (numtroll == null)
                                cmd.Parameters.AddWithValue("@trolleys_number", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@trolleys_number", tb_number_trolleys.Text);
                            if (seccount == null)
                                cmd.Parameters.AddWithValue("@sections_number", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@sections_number", tb_sections_count.Text);
                            if (len == null)
                                cmd.Parameters.AddWithValue("@tram_length", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@tram_length", tb_tram_length.Text);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Добавление прошло успешно");
                        bindingNavigator1.MoveFirstItem.Enabled = true;
                        bindingNavigator1.MovePreviousItem.Enabled = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Во время заполнения записей произошла ошибка: {ex.Message}");
                }
            }
        }

                

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tb_dop_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=ZharFirst;Integrated Security=True;Persist Security Info=True";
            string query2 = "SELECT COUNT(*) FROM Depot WHERE depot_number = @depotNumber";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.Parameters.AddWithValue("@depotNumber", tbDepot_number.Text);
                    int count = (int)command.ExecuteScalar();

                    if (count <= 0)
                    {
                        MessageBox.Show("Номер депо не найден.");
                        return;
                    }
                }
            }
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = @"SELECT COUNT(*) FROM Tram WHERE model = '" + tb_model.Text + "' AND date_major_repairs < DATEADD(YEAR, -2, GETDATE())";
            label_count_model.Text = Convert.ToString(cmd.ExecuteScalar());
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.MoveFirstItem.Enabled = false;
            bindingNavigator1.MovePreviousItem.Enabled = false;
            tb_tram_length.Text = "0";
        }

        private void tb_tram_length_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }
    }
}
