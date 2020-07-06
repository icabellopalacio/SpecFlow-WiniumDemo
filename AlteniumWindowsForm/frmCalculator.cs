using System;
using System.Windows.Forms;

namespace AlteniumWindowsForm
{
    public partial class frmCalculator : Form
    {
        int _Operator1 { get; set; }
        int _Operator2 { get; set; }

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            ClearTexts();
            txtResult.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetOperatorsValue();
            txtResult.Text = ((decimal)(_Operator1 + _Operator2)).ToString();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            GetOperatorsValue();
            txtResult.Text = ((decimal)(_Operator1 - _Operator2)).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            GetOperatorsValue();
            txtResult.Text = ((decimal)(_Operator1 * _Operator2)).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e) 
        {
            GetOperatorsValue(1);
            txtResult.Text = ((decimal)(_Operator1 / _Operator2)).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTexts();
        }

        private void txtOperator1_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtOperator2_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void GetOperatorsValue(int defaultValue = 0) {
            _Operator1 = txtOperator1.Text.Length > 0 ? int.Parse(txtOperator1.Text) : 0;
            _Operator2 = txtOperator2.Text.Length > 0 ? int.Parse(txtOperator2.Text) : defaultValue;
        }
        private void ClearTexts() {
            txtOperator1.Text = "";
            txtOperator2.Text = "";
            txtResult.Text = "";
        }

        
    }
}
