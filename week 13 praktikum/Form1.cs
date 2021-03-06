using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace week_13_praktikum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPemain = new DataTable();
        DataTable dtNationality = new DataTable();
        DataTable dtTeam = new DataTable();
        DataTable dtNumber = new DataTable();
        int PosisiSekarang = 0;

        public void IsiDataPemain(int Posisi)
        {
            //MessageBox.Show(Posisi.ToString());
            textBox_playerID.Text = dtPemain.Rows[Posisi][0].ToString();
            textBox_playerName.Text = dtPemain.Rows[Posisi][1].ToString();
            dateTimePicker_birthDate.Text = dtPemain.Rows[Posisi][2].ToString();
            comboBox_nationality.SelectedValue = dtPemain.Rows[Posisi][3].ToString();
            comboBox_team.Text = dtPemain.Rows[Posisi][4].ToString();
            numericUpDown_teamNumber.Text = dtPemain.Rows[Posisi][5].ToString();
            PosisiSekarang = Posisi;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT p.player_id ,p.player_name,p.birthdate,n.nation,t.team_name,p.team_number from player p , team t, nationality n where p.team_id = t.team_id and p.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain);
            IsiDataPemain(0);

            sqlQuery = "select n.nation as Nationality from player p, nationality n where p.nationality_id = n.nationality_id group by p.nationality_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);
            IsiDataPemain(0);
            comboBox_nationality.DataSource = dtNationality;
            comboBox_nationality.DisplayMember = "Nationality";
            comboBox_nationality.ValueMember = "Nationality";

            sqlQuery = "select t.team_name as `Team`, p.team_id as TeamID from player p, team t where p.team_id = t.team_id group by t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            comboBox_team.DataSource = dtTeam;
            comboBox_team.DisplayMember = "Team";
            comboBox_team.ValueMember = "TeamID";
            IsiDataPemain(0);
        }

        private void button_prev2_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtPemain.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void button_next2_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtPemain.Rows.Count - 1);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (label_avail.Text == "Available")
            {
                sqlQuery = $"UPDATE player SET player_name = '" + textBox_playerName.Text + "', team_number = '" + numericUpDown_teamNumber.Value.ToString() + "', nationality_id = '" + comboBox_nationality.SelectedValue.ToString() + "', team_id = '" + comboBox_team.SelectedValue.ToString() + "' where player_id = '" + textBox_playerID.Text + "' ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }

            else if (label_avail.Text == "Not Available")
            {
                MessageBox.Show("Nomor Tim Tidak Tersedia");
            }
            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown_teamNumber_ValueChanged(object sender, EventArgs e)
        {
            dtNumber = new DataTable();
            sqlQuery = $"SELECT * FROM player WHERE team_id='{comboBox_team.SelectedValue}' and team_number={numericUpDown_teamNumber.Value}";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNumber);

            if (dtNumber.Rows.Count > 0)
            {
                label_avail.Text = "Not Available";
            }
            else
            {
                label_avail.Text = "Available";
            }
        }
    }
}
