using calculadora_oracle.Data;
using calculadora_oracle.Model;

namespace calculadora_oracle
{
    public partial class FrmCalculadora : Form
    {
        private OperacionDAO dao = new OperacionDAO();

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void Calcular(string tipo)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double r = 0;

            switch (tipo)
            {
                case "+":
                    r = a + b;
                    break;

                case "-":
                    r = a - b;
                    break;

                case "*":
                    r = a * b;
                    break;

                case "/":
                    if (b == 0)
                        throw new Exception("División por cero");
                    r = a / b;
                    break;
            }

            lblResultado.Text = r.ToString();

            Operacion op = new Operacion
            {
                Operando1 = a,
                Operando2 = b,
                Tipo = tipo,
                Resultado = r
            };

            dao.GuardarOperacion(op);
        }

        private void btnSuma_Click(object sender, EventArgs e)
            => Calcular("+");

        private void btnResta_Click(object sender, EventArgs e)
            => Calcular("-");

        private void btnMult_Click(object sender, EventArgs e)
            => Calcular("*");

        private void btnDiv_Click(object sender, EventArgs e)
            => Calcular("/");
    }
}
