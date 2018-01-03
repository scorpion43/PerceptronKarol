
using System.Windows.Forms;

namespace WindowsFormsApp1.Service.Implement
{
    public partial class ValueFormView : Form
    {
        public ValueFormView()
        {
            InitializeComponent();
        }

        public float[] GetVariables()
        {
            return new[]
            {
                float.Parse(variableX.Text),
                float.Parse(variableY.Text),
                float.Parse(variableZ.Text),
                float.Parse(variableH.Text),
            };
        }

        public int GetEpochs()
        {
            return int.Parse(EpochsText.Text);
        }

        public float GetMaxError()
        {
            return float.Parse(MaxErrorText.Text);
        }

        public int GetDataSetSize()
        {
            return int.Parse(DataSetSize.Text);
        }

        private void variableH_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
