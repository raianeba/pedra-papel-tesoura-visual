namespace pedra__papel__tesoura_visual
{
    public partial class Form1 : Form
    {
        string EscolhaDoUser;
        string EscolhaDoComputer;

        string[] escolha = new String[3]
        {
            "Pedra",
            "Papel",
            "Tesoura"
        };
        

        public Form1()
        {
            InitializeComponent();
        }
        private void EscolhaDoUsuario(string escolha)
        {
            EscolhaDoUser = escolha;
            EscolhaDoComputador("");
        }
        private void EscolhaDoComputador(string sorteio)
        {
            Random rand = new Random();
            rand.Next(EscolhaDoComputer.Length);
            EscolhaDoComputer = sorteio;
            Comparação();
        }
        private void Comparação()
        {
            EscolhaDoComputador("");
            EscolhaDoUsuario("");
            if(EscolhaDoComputador == EscolhaDoUsuario)
            {
              
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonpedra_Click(object sender, EventArgs e)
        {
            EscolhaDoUsuario("");
        }

        private void buttonpapel_Click(object sender, EventArgs e)
        {
            EscolhaDoUsuario("");
        }

        private void buttontesoura_Click(object sender, EventArgs e)
        {
            EscolhaDoUsuario("");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}