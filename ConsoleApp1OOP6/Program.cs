namespace ConsoleApp1OOP6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // abstraction is the process of hiding the implementation details and showing only the functionality to the user.
            // It allows us to focus on what the object does instead of how it does it.
            // In C#, abstraction can be achieved using abstract classes and interfaces.
            //abstraction hide implementation details and show only functionality to the user.
            //focus on what the object does instead of how it does it.reduce complexity and increase efficiency.
            //encapsulation protect data , focus on how data is accessed,use access modifiers to restrict access to data, increse security.
            //abstraction EX : online shopping website, we only see the products and their details use add to cart pay and checkout 
            //but we don't know how the website works behind the scenes .
            //encapsulation EX : your data is securied can show in login , order system .
            #endregion
            #region Q2 
            //defrence betwwen abstract class and interface in c# is that an abstract class can have both abstract and non-abstract members,
            //while an interface can only have abstract members.
            //abstract class can have constructors, fields, properties, methods and events,
            //while an interface can only have methods and properties.
            //abstract class can have access modifiers for its members,
            //while all members of an interface are public by default.
            //abstract class can provide a default implementation for some of its members,
            //while an interface cannot provide any implementation.
            //abstract class can be inherited by only one class,
            //while an interface can be implemented by multiple classes.
            //Choose an abstract class when you want to provide a common base class for a group of related classes
            //and you want to share code among them.
            //Choose an interface when you want to define a contract that multiple classes can implement
            #endregion
            #region Q3
            //a . can not because i can not make object from abstract class
            //b . PowerConsumption() abstract method 
            //Status() virtual method
            //Label()  concrete method
            //c. standby why? The Toaster class does not override this method
            //,Since Toaster does not provide its own Status() method,
            //it inherits the default implementation from Appliance.
            #endregion
        }
    }
}
