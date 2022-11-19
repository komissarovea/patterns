namespace Strategy;

class EmployeeByIdComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        return x != null && y != null ? x.Id.CompareTo(y.Id) : throw new NullReferenceException();
    }
}
