namespace App_WindowsForm_Suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Sumando_Click(object sender, EventArgs e)
        {

            int n1 = Convert.ToInt32(text_Numero1.Text);
            int n2 = Convert.ToInt32(text_Numero2.Text);
            int n3 = Convert.ToInt32(text_Numero3.Text);

            int suma = n1 + n2 + n3;

            txt_Resultado.Text = Convert.ToString(suma);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //text_Numero1.Text = "";
            //text_Numero2.Text = "";
            //text_Numero3.Text = "";
            //txt_Resultado.Text = "";

            text_Numero1.Clear();
            text_Numero2.Clear();
            text_Numero3.Clear();
            txt_Resultado.Clear();
        }

        private void Salir_Programa_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}