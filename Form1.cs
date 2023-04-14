using System.ComponentModel;
namespace medicamentos
{
    public partial class Form1 : Form
    {
        BindingList<medicamento> listamedicamento;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            medicamento li = new medicamento(int.Parse(textBoxId.Text), textBoxNom.Text, DateTime.Parse(textBoxFeVenc.Text), decimal.Parse(textBoxPrecio.Text), bool.Parse(textBoxDisponible.Text), textBoxMarca.Text, textBoxApli.Text,textBoxPres.Text);
            listamedicamento.Add(li);
            MessageBox.Show("Nro de medicamentos:" + listamedicamento.Count);
            textBoxId.Clear();
            textBoxNom.Clear();
            textBoxFeVenc.Clear();
            textBoxDisponible.Clear();
            textBoxMarca.Clear();
            textBoxPrecio.Clear();
            textBoxApli.Clear();
            textBoxPres.Clear();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listamedicamento = new BindingList<medicamento>();
            dataGridView1.DataSource = listamedicamento;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}