using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

namespace TestAplikacija
{
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
            dgvNarudzbe.AutoGenerateColumns = false;
        }

        private List<Klijent> klijenti = null;
        private List<Narudzba> narudzbe = null;

        private void Forma_Load(object sender, EventArgs e)
        {
            using(var conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                klijenti = conn.Query<Klijent>("EXEC proc_klijenti").OrderBy(k => k.Prezime).AsList();
                klijenti.Insert(0, new Klijent { Id = null, Prezime = "(Svi)" });
                cboKlijenti.DataSource = klijenti;
                cboKlijenti.ValueMember = "Id";
                cboKlijenti.DisplayMember = "PunoIme";

            }
        }

        private async void btnSqlKod_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                var formBusy = new Busy();
                formBusy.Show();
                var parameters = new DynamicParameters();
                parameters.Add("@idKlijent", cboKlijenti.SelectedValue, dbType: DbType.Int32);

                narudzbe = (await conn.QueryAsync<Narudzba>(
                    @"SELECT Narudzba.id, Narudzba.DatumNarudzbe,
	                    SUM(NarudzbaDetalj.Kolicina * NarudzbaDetalj.JedinicnaCijena) Ukupno
	                    FROM Narudzba INNER JOIN NarudzbaDetalj ON
	                    Narudzba.id = NarudzbaDetalj.idNarudzba
	                    WHERE Narudzba.idKlijent = @idKlijent OR @idKlijent IS NULL
	                    GROUP BY Narudzba.id, Narudzba.DatumNarudzbe", parameters)).AsList();
                dgvNarudzbe.DataSource = null;
                dgvNarudzbe.DataSource = narudzbe;

                var total = await conn.ExecuteScalarAsync<decimal?>(
                    @"SELECT SUM(NarudzbaDetalj.Kolicina * NarudzbaDetalj.JedinicnaCijena)
	                    FROM Narudzba INNER JOIN NarudzbaDetalj ON
	                    Narudzba.id = NarudzbaDetalj.idNarudzba
	                    WHERE Narudzba.idKlijent = @idKlijent OR @idKlijent IS NULL", parameters);
                txtUkupno.Text = total?.ToString("N2");
                formBusy.Hide();
            }
        }

        private async void btnProcedura_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                var formBusy = new Busy();
                formBusy.Show();
                var parameters = new DynamicParameters();
                parameters.Add("@idKlijent", cboKlijenti.SelectedValue, dbType: DbType.Int32);
                parameters.Add("@ukupno", dbType: DbType.Decimal, direction: ParameterDirection.InputOutput);
                var narudzbe = await conn.QueryAsync<Narudzba>(
                    "EXEC proc_NarudzbeKorisnika3 @idKlijent, @ukupno = @ukupno OUTPUT", parameters);

                dgvNarudzbe.DataSource = null;
                dgvNarudzbe.DataSource = narudzbe;
                txtUkupno.Text = parameters.Get<decimal?>("@ukupno")?.ToString("N2");
                formBusy.Hide();
            }
        }
    }
}
