namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                const string servidor = "localhost";
                const string db = "dbagenda";
                const string usuario = "admin";
                const string senha = "Senha123";

                string conexaoBanco = $"server={servidor}; database={db}; user id={usuario}; password={senha}";

                label1.Text = $"A conexao ao {db} realizada com sucesso!!";

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao Conectar ao Banco" + ex.Message);
            }





        }

    }
}
