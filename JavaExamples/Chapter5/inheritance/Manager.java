package inheritance;

import java.math.BigDecimal;

public class Manager extends Employee 
{
    private BigDecimal bonus;

    public Manager(String name, double salary, int year, int month, int day)
    {
        super(name, salary, year, month, day);
        bonus = new BigDecimal(0);
    }
    
    public Manager(String name, BigDecimal salary, int year, int month, int day)
    {
        super(name, salary, year, month, day);
        bonus = new BigDecimal(0);
    }

    public BigDecimal getSalary()
    {
        BigDecimal baseSalary = super.getSalary();
        return baseSalary.add(bonus);
    }

    public void setBonus(BigDecimal bonus)
    {
        this.bonus = bonus;
    }

    public void setBonus(double bonus)
    {
        this.bonus = new BigDecimal(bonus);
    }
}