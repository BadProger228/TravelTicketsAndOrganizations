using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursovWork_
{
    public partial class OrganizationInformation : Form
    {
        SqlConnection Connection;
        int idOfOrganization;
        bool status = true;
        public OrganizationInformation(string nameOfOrganization, SqlConnection connection, bool status)
        {
            InitializeComponent();
            Connection = connection;

            if (!status)
            {
                Random random = new Random();
                idOfOrganization = random.Next(1, 649878);
                SaveInformation.Visible = false;
                this.status = status;
                SaveButton.Text = "Add";
                return;
            }

            
            using (SqlCommand command = new SqlCommand($"SELECT * FROM Organization WHERE name = '{nameOfOrganization}'", Connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return;

                    idOfOrganization = (int)reader["Id"];
                    NameText.Text = reader["name"].ToString();
                    DescriptionText.Text = reader["description"].ToString();
                }

                using (SqlCommand quantityCommand = new SqlCommand($"SELECT * FROM RegisterOfTravelTicket WHERE idOfOrganization = {idOfOrganization}", Connection))
                {
                    using (SqlDataReader quantityReader = quantityCommand.ExecuteReader())
                    {
                        if (quantityReader.Read())
                        {
                            QuantityText.Text = quantityReader["Quantity"].ToString();
                            PriceText.Text = quantityReader["FullPrice"].ToString();
                        }
                    }
                }

                using (SqlCommand dateCommand = new SqlCommand($"SELECT * FROM BalanceOfTravelTicket WHERE idOfOrganization = {idOfOrganization}", Connection))
                {
                    using (SqlDataReader dateReader = dateCommand.ExecuteReader())
                    {
                        if (dateReader.Read())
                        {
                            DateBalance.Text = $"{dateReader["Mounth"]}/{dateReader["Year"]}";
                            BalanceText.Text = dateReader["Balance"].ToString();
                        }
                    }
                }
            }
        }

        private void OrganizationInformation_Load(object sender, EventArgs e)
        {
            
        }

        private void QuantityText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void BalanceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Balance_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string Query;
            if (status)
            {
                Query = $"UPDATE Organization SET name = @name, DESCRIPTION = @DESCRIPTION WHERE Id = @Id";
            }
            else
                Query = $"INSERT INTO Organization (Id, name, DESCRIPTION) VALUES (@Id, @name, @DESCRIPTION)";


            using (SqlCommand command = new SqlCommand(Query, Connection))
            {
                    command.Parameters.AddWithValue("@name", NameText.Text);
                    command.Parameters.AddWithValue("@DESCRIPTION", DescriptionText.Text);
                    command.Parameters.AddWithValue("@Id", idOfOrganization);

                    int rowsAffected = command.ExecuteNonQuery();

                    MessageBox.Show($"{rowsAffected} rows updated.");
            }
            

            if (status)
                return;

            Query = $"INSERT INTO RegisterOfTravelTicket (Id, IdOfOrganization, Quantity, FullPrice) VALUES (@Id, @IdOfOrganization, @Quantity, @FullPrice)";


            using (SqlCommand command = new SqlCommand(Query, Connection))
            {
                Random random = new Random();
                command.Parameters.AddWithValue("@Id", random.Next(1, 364575));
                command.Parameters.AddWithValue("@IdOfOrganization", idOfOrganization);
                command.Parameters.AddWithValue("@Quantity", 0);
                command.Parameters.AddWithValue("@FullPrice", 0);

                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show($"{rowsAffected} rows updated.");
            }

            Query = "INSERT INTO BalanceOfTravelTicket (Id, IdOfOrganization, Year, Mounth, Balance) VALUES (@Id, @IdOfOrganization, @Year, @Mounth, @Balance)";

            using (SqlCommand command = new SqlCommand(Query, Connection))
            {
                Random random = new Random();
                command.Parameters.AddWithValue("@Id", random.Next(1, 364575));
                command.Parameters.AddWithValue("@IdOfOrganization", idOfOrganization);
                command.Parameters.AddWithValue("@Year", 0);
                command.Parameters.AddWithValue("@Mounth", 0);
                command.Parameters.AddWithValue("@Balance", 0);

                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show($"{rowsAffected} rows updated.");

            }

            
            this.Close();
        }
       

        private void SaveInformation_Click(object sender, EventArgs e)
        {
            
            int FullPrice = 0;


            using (SqlCommand command = new SqlCommand($"SELECT SUM(Price) FROM TravelTicket WHERE IdOfOrganization = {idOfOrganization}", Connection)) {
                
                SqlDataReader reader = command.ExecuteReader();
                if (!reader.Read())
                    return;

                FullPrice = reader.GetInt32(0);

            }

            Connection.Close();
            Connection.Open();

            string Query = "UPDATE BalanceOfTravelTicket SET IdOfOrganization = @IdOfOrganization, Year = @Year, Mounth = @Mounth, Balance = @Balance WHERE IdOfOrganization = @IdOfOrganization";

            using (SqlCommand command = new SqlCommand(Query, Connection))
            {
                command.Parameters.AddWithValue("@IdOfOrganization", idOfOrganization);
                command.Parameters.AddWithValue("@Year", DateTime.Now.Year);
                command.Parameters.AddWithValue("@Mounth", DateTime.Now.Month);
                command.Parameters.AddWithValue("@Balance", FullPrice);
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} rows updated.");
            }

        }
    }
}
