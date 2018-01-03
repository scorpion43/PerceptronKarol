using WindowsFormsApp1.DataAccess.Interface;
using WindowsFormsApp1.Service.Implement;
using WindowsFormsApp1.Service.Interface;

namespace WindowsFormsApp1.DataAccess.Implement
{
    public class PointsDataAccess : IPointsDataAccess
    {
        private readonly ValueFormView _valueFormView;

        public PointsDataAccess()
        {
            _valueFormView = new ValueFormView();
            _valueFormView.Show();
        }


        public float GetValueForX()
        {
            return _valueFormView.GetVariables()[0];
        }

        public float GetValueForY()
        {
            return _valueFormView.GetVariables()[1];
        }

        public float GetValueForZ()
        {
            return _valueFormView.GetVariables()[2];
        }

        public float GetValueForH()
        {
            return _valueFormView.GetVariables()[3];
        }

        public int GetEpochs()
        {
            return _valueFormView.GetEpochs();
        }

        public float GetMaxError()
        {
            return _valueFormView.GetMaxError();
        }

        public int GetDataSetSize()
        {
            return _valueFormView.GetDataSetSize();
        }
    }
}