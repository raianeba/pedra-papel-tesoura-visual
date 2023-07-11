namespace pedra__papel__tesoura_visual
{
    public partial class Form1 : Form
    {
        private string EscolhaDoUser;
        private string EscolhaDoComputer;

        private string[] escolha =
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
            textBox1.Text = EscolhaDoUser;
            EscolhaDoComputador();
        }
        private void EscolhaDoComputador()
        {
            Random rand = new Random();
            int sorteio = rand.Next(escolha.Length);
            EscolhaDoComputer = escolha[sorteio];
            textBox2.Text = EscolhaDoComputer;

            Comparação();
        }
        private void Comparação()
        {
            if (EscolhaDoComputer == EscolhaDoUser)
            {
                textBox3.Text = "Empate";
            }
            else if (EscolhaDoUser == escolha[0] && EscolhaDoComputer == escolha[2])
            {
                textBox3.Text = " Você VENCEU";
            }
            else if (EscolhaDoUser == escolha[1] && EscolhaDoComputer == escolha[0])
            {
                textBox3.Text = "Você VENCEU";
            }
            else if (EscolhaDoUser == escolha[2] && EscolhaDoComputer == escolha[1])
            {
                textBox3.Text = "Você VENCEU";
            } else
            {
                textBox3.Text = "Você Perdeu";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonpedra_Click(object sender, EventArgs e)
        {
            EscolhaDoUsuario(escolha[0]);
        }

        private void buttonpapel_Click(object sender, EventArgs e)
        {
            EscolhaDoUsuario(escolha[1]);
        }

        private void buttontesoura_Click(object sender, EventArgs e)
        {
            EscolhaDoUsuario(escolha[2]);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}