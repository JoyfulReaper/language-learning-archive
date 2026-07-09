package abstractClasses;

public class PersonTest {
    public static void main(String[] args)
    {
        var people = new Person[2];

        people[0] = new Employee("Some Dude", 48000, 2015, 5, 16);
        people[1] = new Student("Some Student", "Biology");

        for(Person p : people)
            System.out.println(p.getName() + ", " + p.getDescription());
        
    }
}