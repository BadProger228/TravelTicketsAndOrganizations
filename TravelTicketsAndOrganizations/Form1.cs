using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursovWork_
{

    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LogicMan\\source\\repos\\CursovWork_\\CursovWork_\\TravelTicketRegister.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();


        }

        private void Refresh_ListBoxes()
        {
            Organization.Items.Clear();
            TravelTicket.Items.Clear();

            connection = new SqlConnection(connectionString);

            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT name FROM Organization", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        Organization.Items.Add(reader["name"].ToString());

                }
            }

            using (SqlCommand command = new SqlCommand("SELECT * FROM TravelTicket", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        TravelTicket.Items.Add($"{reader["name"]}");

                }
            }
        }

        private void Organization_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Organization_DoubleClick(object sender, EventArgs e)
        {
            if (Organization.SelectedItem is null)
                return;
            
            var organization = new OrganizationInformation(Organization.SelectedItem.ToString(), connection, true);
            organization.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh_ListBoxes();
            Organization.ContextMenuStrip = OrganizationListContextMenu;
            TravelTicket.ContextMenuStrip = TravelTicketContextMenu;

        }

        private void TravelTicket_DoubleClick(object sender, EventArgs e)
        {
            if(TravelTicket.SelectedItem is null) 
                return;

            var form = new TravelTicketInformation(TravelTicket.SelectedItem.ToString(), connection, true);
            form.Show();
        }

        private void TravelTicket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var organization = new OrganizationInformation("", connection, false);
            organization.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new TravelTicketInformation("", connection, false);
            form.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int IdOfOrganization, Quantity, Price;

            using (SqlCommand command = new SqlCommand("SELECT Quantity, PriceForOne FROM AdditionsToTravelTicket WHERE name = @name", connection))
            {
                command.Parameters.AddWithValue("@name", TravelTicket.SelectedItem.ToString());
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return;

                    Quantity = reader.GetInt32(0);
                    Price = reader.GetInt32(1) * reader.GetInt32(0);
                }
            }

            using (SqlCommand command = new SqlCommand("SELECT IdOfOrganization FROM TravelTicket WHERE name = @name", connection))
            {
                command.Parameters.AddWithValue("@name", TravelTicket.SelectedItem.ToString());
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return;

                    IdOfOrganization = reader.GetInt32(0);
                }
            }

            string[] Query = { "DELETE FROM AdditionsToTravelTicket WHERE name = @name", "DELETE FROM TravelTicket WHERE name = @name" };
            foreach (string query in Query)
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", TravelTicket.SelectedItem.ToString());

                    int row = command.ExecuteNonQuery();

                    MessageBox.Show($"{row} is delete");
                }
            }

            string newQuery = "UPDATE RegisterOfTravelTicket SET Quantity = Quantity - @Quantity, FullPrice = FullPrice - @FullPrice WHERE IdOfOrganization = @IdOfOrganization";
            using (SqlCommand command = new SqlCommand(newQuery, connection)) {
                command.Parameters.AddWithValue("@Quantity", Quantity);
                command.Parameters.AddWithValue("@FullPrice", Price);
                command.Parameters.AddWithValue("@IdOfOrganization", IdOfOrganization);

                int row = command.ExecuteNonQuery();

                MessageBox.Show($"{row} is delete");

            }

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Refresh_ListBoxes();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
