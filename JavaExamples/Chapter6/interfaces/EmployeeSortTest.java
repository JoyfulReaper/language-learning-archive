package interfaces;

import java. util.Arrays;

public class EmployeeSortTest {
    public static void main(String[] args)
    {
        var staff = new Employee[3];

        staff[0] = new Employee("Some Dude", 36000);
        staff[1] = new Employee("The Dude", 75000);
        staff[2] = new Employee("Fun Guss", 45000);

        Arrays.sort(staff);
        for(Employee e : staff)
            System.out.println("name=" + e.getName() + ",salary=" + e.getSalary());
    }
}