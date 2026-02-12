namespace calculadora_oracle
{
    partial class FrmCalculadora
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtA;
        private TextBox txtB;
        private Label lblResultado;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMult;
        private Button btnDiv;
        private Label lblA;
        private Label lblB;
        private Label lblRes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtA = new TextBox();
            txtB = new TextBox();
            lblResultado = new Label();
            btnSuma = new Button();
            btnResta = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            lblA = new Label();
            lblB = new Label();
            lblRes = new Label();
            SuspendLayout();

            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(40, 30);
            lblA.Name = "lblA";
            lblA.Size = new Size(68, 15);
            lblA.Text = "Operando 1";

            // 
            // txtA
            // 
            txtA.Location = new Point(40, 50);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 23);

            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(40, 90);
            lblB.Name = "lblB";
            lblB.Size = new Size(68, 15);
            lblB.Text = "Operando 2";

            // 
            // txtB
            // 
            txtB.Location = new Point(40, 110);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 23);

            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(230, 45);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(50, 30);
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;

            // 
            // btnResta
            // 
            btnResta.Location = new Point(290, 45);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(50, 30);
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;

            // 
            // btnMult
            // 
            btnMult.Location = new Point(230, 90);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(50, 30);
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;

            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(290, 90);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(50, 30);
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;

            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(40, 160);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(59, 15);
            lblRes.Text = "Resultado";

            // 
            // lblResultado
            // 
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Location = new Point(40, 180);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(150, 25);
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 260);
            Controls.Add(lblResultado);
            Controls.Add(lblRes);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(txtB);
            Controls.Add(lblB);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Name = "FrmCalculadora";
            Text = "Calculadora Oracle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}