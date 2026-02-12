using calculadora_oracle.Data;
using calculadora_oracle.Model;
using System;
using System.Windows.Forms;

namespace calculadora_oracle
{
    public partial class FrmCalculadora : Form
    {
        private readonly OperacionDAO dao = new OperacionDAO();

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void Calcular(string tipo)
        {
            // 🔒 Validación Operando 1
            if (!double.TryParse(txtA.Text, out double a))
            {
                MessageBox.Show(
                    "Ingrese un valor numérico válido en Operando 1",
                    "Entrada inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtA.Focus();
                return;
            }

            // 🔒 Validación Operando 2
            if (!double.TryParse(txtB.Text, out double b))
            {
                MessageBox.Show(
                    "Ingrese un valor numérico válido en Operando 2",
                    "Entrada inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtB.Focus();
                return;
            }

            double r = 0;

            try
            {
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
                        {
                            MessageBox.Show(
                                "No se puede dividir por cero",
                                "Error matemático",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return;
                        }
                        r = a / b;
                        break;

                    default:
                        MessageBox.Show(
                            "Operación no válida",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                }

                // Mostrar resultado
                lblResultado.Text = r.ToString("0.##");

                // Persistir operación en Oracle
                Operacion op = new Operacion
                {
                    Operando1 = a,
                    Operando2 = b,
                    Tipo = tipo,
                    Resultado = r
                };

                dao.GuardarOperacion(op);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error al procesar la operación:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
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