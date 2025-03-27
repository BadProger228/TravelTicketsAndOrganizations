using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursovWork_
{
    public partial class TravelTicketInformation : Form
    {
        SqlConnection connection;
        int ticketID, OrganizationID;
        bool status = true;
        int FullPrice = 0;
        int QuantityResult = 0;
        public TravelTicketInformation(string nameOfItem, SqlConnection connecting, bool status)
        {
            InitializeComponent();
            connection = connecting;

            using (SqlCommand TmpCommand = new SqlCommand($"SELECT * FROM Organization", connection))
            {
                using (SqlDataReader tmpReader = TmpCommand.ExecuteReader())
                {
                    
                    while(tmpReader.Read())
                        OrganizationsComboBox.Items.Add(tmpReader["name"].ToString());
                }
            }


            if (!status)
            {
                Random random = new Random();
                ticketID = random.Next(1, 649878);
                this.status = status;
                Save.Text = "Add";
                return;

            }
            using (SqlCommand command = new SqlCommand($"SELECT * FROM TravelTicket WHERE name = '{nameOfItem}'", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return;

                    ticketID = (int)reader["Id"];
                    OrganizationID = (int)reader["IdOfOrganization"];
                    name.Text = reader["name"].ToString();
                    Price.Text = reader["Price"].ToString();
                    FullPrice = (int)reader["Price"];
                    
                    Number.Text = reader["Number"].ToString();
                    NameOfRecipient.Text = reader["NameOfRecipient"].ToString();
                    Adress.Text = reader["Address"].ToString();
                }

                using (SqlCommand TmpCommand = new SqlCommand($"SELECT * FROM AdditionsToTravelTicket WHERE IdOfTravelTicket = {ticketID}", connection))
                {
                    using (SqlDataReader tmpReader = TmpCommand.ExecuteReader())
                    {
                        if (!tmpReader.Read())
                            return;

                        Type.Text = tmpReader["Type"].ToString();
                        Quantity.Text = tmpReader["Quantity"].ToString();
                        QuantityResult = (int)tmpReader["Quantity"];
                        PriceForOne.Text = tmpReader["PriceForOne"].ToString();
                    }
                }
                using (SqlCommand TmpCommand = new SqlCommand($"SELECT * FROM Organization WHERE Id = {OrganizationID}", connection))
                {
                    using (SqlDataReader tmpReader = TmpCommand.ExecuteReader())
                    {
                        if (!tmpReader.Read())
                            return;

                        OrganizationsComboBox.SelectedItem = tmpReader["name"].ToString();
                    }
                }
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameOfRecipient_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Type_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceForOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void TravelTicketInformation_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            
            using (SqlCommand command = new SqlCommand($"SELECT Id FROM Organization WHERE name = '{OrganizationsComboBox.SelectedItem}'", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return;

                    OrganizationID = (int)reader["Id"];
                }
            }
            string Query;
            if (status) {
                Query = $"UPDATE TravelTicket SET idOfOrganization = @idOfOrganization, Price = @Price, Number = @Number, NameOfRecipient = @NameOfRecipient, Address = @Address, name = @name WHERE Id = {ticketID};";
            }
            else
            {
                Query = $"INSERT INTO TravelTicket (Id, IdOfOrganization, Price, Number, NameOfRecipient, Address, name) VALUES (@Id, @IdOfOrganization, @Price, @Number, @NameOfRecipient, @Address, @name)";
            }

            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                if (!status) 
                    command.Parameters.AddWithValue("@Id", ticketID);

                command.Parameters.AddWithValue("@IdOfOrganization", OrganizationID);
                command.Parameters.AddWithValue("@Price", int.Parse(PriceForOne.Text) * int.Parse(Quantity.Text));
                command.Parameters.AddWithValue("@Number", Number.Text);
                command.Parameters.AddWithValue("@NameOfRecipient", NameOfRecipient.Text);
                command.Parameters.AddWithValue("@Address", Address.Text);
                command.Parameters.AddWithValue("@name", name.Text);

                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show($"{rowsAffected} rows updated.");
            }

            if (status)
            {
                Query = $"UPDATE AdditionsToTravelTicket SET Type = @Type, Quantity = @Quantity, PriceForOne = @PriceForOne WHERE IdOfTravelTicket = {ticketID};";
            }
            else
            {
                Query = $"INSERT INTO AdditionsToTravelTicket (Id, IdOfTravelTicket, Type, name, Quantity, PriceForOne) VALUES (@Id, @IdOfTravelTicket, @Type, @name, @Quantity, @PriceForOne)";
            }

            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                if (!status)
                {
                    Random random = new Random();
                    command.Parameters.AddWithValue("@Id", random.Next(1, 6874657));
                }

                command.Parameters.AddWithValue("@IdOfTravelTicket", ticketID);
                command.Parameters.AddWithValue("@Type", Type.Text);
                command.Parameters.AddWithValue("@name", name.Text);
                command.Parameters.AddWithValue("@Quantity", Quantity.Text);
                command.Parameters.AddWithValue("@PriceForOne", PriceForOne.Text);

                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show($"{rowsAffected} rows updated.");
            }

            Query = $"UPDATE RegisterOfTravelTicket SET FullPrice = FullPrice + @FullPrice, Quantity = Quantity + @Quantity WHERE IdOfOrganization = @IdOfOrganization";

            using (SqlCommand command = new SqlCommand(Query, connection)) {
                command.Parameters.AddWithValue("@IdOfOrganization", OrganizationID);
                command.Parameters.AddWithValue("@FullPrice", (int.Parse(PriceForOne.Text)* int.Parse(Quantity.Text) - FullPrice).ToString());
                command.Parameters.AddWithValue("@Quantity", (int.Parse(Quantity.Text) - QuantityResult));

                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show($"{rowsAffected} rows updated.");
            }

            this.Close();
        }
    }
}
