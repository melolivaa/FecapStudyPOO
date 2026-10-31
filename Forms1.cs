namespace FecapStudyPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Disciplina BD = new Disciplina("BD-001", "Banco de Dados", "Programação", 40);

            Disciplina POO = new Disciplina("POO-001", "Programação Orientada a Objetos", "Programação", 40);

            Disciplina Logica = new Disciplina("LOG-001", "Lógica de Programação", "Programação", 40);

            MessageBox.Show(BD.ExibirResumo());
            MessageBox.Show(POO.ExibirResumo());
            MessageBox.Show(Logica.ExibirResumo());
        }
    }
}
