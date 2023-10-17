namespace AppFinanciamento
{
    public partial class AppFinanciamento : Form
    {
        public AppFinanciamento()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblValorEmprestimo_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblParcela_Click(object sender, EventArgs e)
        {

        }

        private void txtParcelas_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTaxaAnual_Click(object sender, EventArgs e)
        {

        }

        private void txtTaxaJuros_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double.TryParse(txtValor.Text, out double principal);
            double.TryParse(txtTaxaJuros.Text, out double taxaJurosAnual);
            int.TryParse(txtParcelas.Text, out int numeroParcelas);

            double taxaJurosMensal = (taxaJurosAnual / 12) / 100;
            double valorParcela = principal * (taxaJurosMensal / (1 - Math.Pow(1 + taxaJurosMensal, -numeroParcelas)));
            double valorTotalPago = valorParcela * numeroParcelas;
            double valorTotalJuros = valorTotalPago - principal;

            ValorParcelaLbl.Text = $"Valor da Parcela: R$ {valorParcela:N2}";
            ValorTotalPagoLbl.Text = $"Valor Total: R$ {valorTotalPago:N2}";
            ValorTotalJurosLbl.Text = $"Valor Total dos Juros: R$ {valorTotalJuros:N2}";

        }

        private void ValorTotalJurosLbl_Click(object sender, EventArgs e)
        {

        }
    }
}