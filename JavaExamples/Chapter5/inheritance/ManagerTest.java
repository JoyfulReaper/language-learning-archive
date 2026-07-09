package inheritance;

import java.math.BigDecimal;

public class ManagerTest {
    public static void main(String[] args)
    {
        var boss = new Manager("Bob Burgers", new BigDecimal(75000), 1999, 5, 29);
        boss.setBonus(5000);

        var staff = new Employee[3];
        staff[0] = boss;
        staff[1] = new Employee("Harry Person", 50000, 2001, 6, 30);
        staff[2] = new Employee("Tommy Pinkerton", 45000, 2018, 3, 15);

        for(Employee e : staff) 
        {
            System.out.println("Name: " + e.getName() + " Salary: " + e.getSalary() + " Hire date: " + e.getHireDay());
        }
    }
}