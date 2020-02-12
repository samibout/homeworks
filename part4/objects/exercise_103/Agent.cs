
namespace exercise_103 {
  public class Agent {
    private string firstName{get;set;}
    private string lastName{get;set;}

    public Agent(string firstName, string lastName) {
      this.firstName = firstName;
      this.lastName = lastName;
    }

    public override string ToString() {
      // Should return for example "My name is Bond. James Bond."
      return ("My name is " + lastName + ". " +firstName + " " +lastName + ".");
      
    }
  }
}