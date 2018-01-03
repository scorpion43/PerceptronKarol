namespace WindowsFormsApp1.DataAccess.Interface
{
    public interface IPointsDataAccess
    {
        float GetValueForX();
        float GetValueForY();
        float GetValueForZ();
        float GetValueForH();
        int GetEpochs();
        float GetMaxError();
        int GetDataSetSize();
    }
}