namespace Strategy
{
    internal class Program
    {
        static void Main()
        {

            SortLists();
            Console.WriteLine("Hello, World!");
        }

        public static void SortLists()
        {
            var list = new List<Employee>();
            // Используем "функтор"
            list.Sort(new EmployeeByIdComparer());
            // Используем делегат
            list.Sort((x, y) => x!.Name!.CompareTo(y!.Name));

            var comparer = new EmployeeByIdComparer();
            // Конструктор принимает IComparable
            var set = new SortedSet<Employee>(comparer);
            // Нет конструктора, принимающего делегат Comparison<T>
            // set = new SortedSet<Employee>((x, y) => x!.Name!.CompareTo(y!.Name));

            var comparer2 = ComparerFactory.Create<Employee>((x, y) => x.Id.CompareTo(x.Id));
            var set2 = new SortedSet<Employee>(comparer);
        }
    }
}