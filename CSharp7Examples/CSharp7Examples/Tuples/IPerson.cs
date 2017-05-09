namespace CSharp7Examples.Tuples
{
    public interface IPerson
    {
        (string FirstName, string LastName, int Age) GetPersonDetails();
    }
}
