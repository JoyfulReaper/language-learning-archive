package abstractClasses;

import java.math.BigDecimal;
import java.time.*;

public class Employee extends Person
{
    private BigDecimal salary;
    private LocalDate hireDay;

    public Employee(String name, double salary, int year, int month, int day)
    {
        this(name, new BigDecimal(salary), year, month, day);
    }

    public Employee(String name, BigDecimal salary, int year, int month, int day)
    {
        super(name);
        this.salary = salary;
        hireDay = LocalDate.of(year, month, day);
    }

    public BigDecimal getSalary()
    {
        return salary;
    }

    public LocalDate getHireDay()
    {
        return hireDay;
    }

    public String getDescription()
    {
        return String.format("an employee with a salary of $%.2f", salary);
    }

    public void RaiseSalary(double byPercent)
    {
        salary.add(salary.multiply(new BigDecimal(byPercent / 100)));
    }
}