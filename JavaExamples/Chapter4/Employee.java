import java.math.BigDecimal;
import java.time.LocalDate;
import java.util.Objects;

public class Employee {
    private final String name;
    private BigDecimal salary;
    private final LocalDate hireDate;
    private int id = getNextID();
    private static int nextID = 1;

    /***
     * Construct an Employee Object
     * @param name Employee's name
     * @param salary Employee's salary
     * @param year Hire year
     * @param month Hire month
     * @param day Hire day
     */
    public Employee(final String name, final double salary, final int year, final int month, final int day) {
        this(name, new BigDecimal(salary), year, month, day);
    }

    public Employee(final String name, final BigDecimal salary, final int year, final int month, final int day) {
        Objects.requireNonNull(name, "name cannot be null");
        Objects.requireNonNull(salary, "salary cannot be null");
        //Object.requireNonNullElse(name, "DefaultName");

        this.name = name;
        this.salary = salary;
        this.hireDate = LocalDate.of(year, month, day);
        this.id = nextID++;
    }

    /***
     * 
     * @return The Employee's name
     */
    public String getName() {
        return name;
    }

    /***
     * 
     * @return The Employee's salary'
     */
    public double getSalary() {
        return salary.doubleValue();
    }

    /***
     * 
     * @return The Employee's hire date
     */
    public LocalDate getHireDate() {
        return hireDate;
    }

    /**
     * 
     * @return The Employee's ID number
     */
    public int getID() {
        return id;
    }


    /**
     * 
     * @return The next unused ID number
     */
    public static int getNextID() {
        return nextID;
    }

    /**
     * Raise the Employee's salary
     * @param byPercent The percentage to increase the salary
     */
    public void raiseSalary(final double byPercent) {
        final double raise = salary.doubleValue() * byPercent / 100;
        salary = salary.add(BigDecimal.valueOf(raise));
    }
}