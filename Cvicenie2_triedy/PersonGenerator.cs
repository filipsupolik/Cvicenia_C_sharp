using Cvicenie2_triedy;

public class PersonGenerator
{
    public Person[] Generate(int count)
    {
        string[] maleFirstNames = { "Ján", "Alexander", "Adam", "Juraj", "Štefan" };
        string[] maleLastNames = { "Nový", "Malý", "Veľký", "Chudý", "Vysoký", "Bohatý", "Krásny" };
        string[] femaleFirstNames = { "Silvia", "Františka", "Michaela", "Barbora", "Eva" };
        string[] femaleLastNames = { "Nová", "Malá", "Veľká", "Chudá", "Vysoká", "Bohatá", "Krásna" };

        Random random = new Random();
        Person[] people = new Person[count];

        for (int i = 0; i < count; i++)
        {
            Gender gender = (Gender)random.Next(1, 3); // Randomly select between MALE and FEMALE
            string firstName;
            string lastName;

            if (gender == Gender.MALE)
            {
                firstName = maleFirstNames[random.Next(maleFirstNames.Length)];
                lastName = maleLastNames[random.Next(maleLastNames.Length)];
            }
            else
            {
                firstName = femaleFirstNames[random.Next(femaleFirstNames.Length)];
                lastName = femaleLastNames[random.Next(femaleLastNames.Length)];
            }

            DateTime? birthdate = new DateTime(random.Next(1950, 2010), random.Next(1, 13), random.Next(1, 29));
            Person person = new Person(firstName, lastName, birthdate, gender);
            people[i] = person;
        }

        return people;
    }
}
