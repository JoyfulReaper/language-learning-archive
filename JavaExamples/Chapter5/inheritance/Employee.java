package inheritance;

import java.math.BigDecimal;
import java.time.*;

public class Employee 
{
    private String name;
    private BigDecimal salary;
    private LocalDate hireDay;

    public Employee(String name, double salary, int year, int month, int day)
    {
        this(name, new BigDecimal(salary), year, month, day);
    }

    public Employee(String name, BigDecimal salary, int year, int month, int day)
    {
        this.name = name;
        this.salary = salary;
        hireDay = LocalDate.of(year, month, day);
    }

    public String getName()
    {
        return name;
    }

    public BigDecimal getSalary()
    {
        return salary;
    }

    public LocalDate getHireDay()
    {
        return hireDay;
    }

    public void RaiseSalary(double byPercent)
    {
        salary.add(salary.multiply(new BigDecimal(byPercent / 100)));
    }
}