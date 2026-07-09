import java.time.*;

public class CalendarTest
{
    public static void main(String[] args)
    {
        LocalDate date = LocalDate.now(); // The date now
        int month = date.getMonthValue(); // Current month 1 to 12
        int today = date.getDayOfMonth(); // Current day of the month 1 to 31

        date = date.minusDays(today - 1); // First day of the month
        DayOfWeek weekday = date.getDayOfWeek();
        int value = weekday.getValue(); // 1 = Monday, 7 = Sunday

        System.out.println();
        System.out.println("Mon Tue Wed Thu Fri Sat Sun");
        for(int i = 1; i < value; i++)
            System.out.println("    ");
        
        while(date.getMonthValue() == month)
        {
            System.out.printf("%3d", date.getDayOfMonth());
            if(date.getDayOfMonth() == today)
                System.out.print("*");
            else
                System.out.print(" ");
            date = date.plusDays(1);
            if(date.getDayOfWeek().getValue() == 1)
                System.out.println();
        }
        
    }
}