public class EmployeeTest {
    public static void main(String[] args)
    {
        Employee employee = new Employee("Some Dude", 100000, 2012, 5, 21);
        System.out.println("Name: " + employee.getName() + " Salary: " + employee.getSalary() + " Hire date: " + employee.getHireDate());
        employee.raiseSalary(6);
        System.out.printf("Name: %s Salary: %.2f Hire date: %s ID: %d\n\n", 
            employee.getName(), employee.getSalary(), employee.getHireDate(), employee.getID());

        for(int i = 0; i < 5; i++)
        {
            employee = new Employee("Employee " + i, 25_000, 2020, 6, 23);
            System.out.printf("Name: %s Salary: %.2f Hire date: %s ID: %d\n", 
                employee.getName(), employee.getSalary(), employee.getHireDate(), employee.getID());
        }

        System.out.println();
        System.out.println("Next ID: " + Employee.getNextID());
    }
}