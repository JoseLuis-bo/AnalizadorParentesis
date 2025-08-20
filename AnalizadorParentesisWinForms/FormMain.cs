using System;
using System.Drawing;
using System.Windows.Forms;
using AnalizadorParentesisWinForms.Core;

namespace AnalizadorParentesisWinForms.UI
{
    public partial class FormMain : Form
    {
        private readonly ParenthesisAnalyzer _analyzer = new ParenthesisAnalyzer();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            lstPasos.Items.Clear();
            lblResultado.Text = "";

            var input = txtEntrada.Text;
            var res = _analyzer.Analyze(input, chkTrazas.Checked);

            if (chkTrazas.Checked)
                lstPasos.Items.AddRange(res.Steps.ToArray());

            lblResultado.Text = res.Message;
            lblResultado.BackColor = res.IsValid ? Color.LightGreen : Color.LightCoral;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEntrada.Clear();
            lstPasos.Items.Clear();
            lblResultado.Text = "";
        }
    }
}