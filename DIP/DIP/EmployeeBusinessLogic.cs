namespace DIP
{
    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccessLogic _dataAccessLogic;

        public EmployeeBusinessLogic()
        {
            _dataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetails(int id)
        {
            return _dataAccessLogic.GetEmployeeDetails(id);
        }
    }
}
