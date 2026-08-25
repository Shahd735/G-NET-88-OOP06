namespace Assignment_9_OOP_6;

internal class Program
{
    static void Main(string[] args)
    {
        #region Question1
        // a) What happens when you assign one object variable to another object variable?
        // => The reference of the object is copied, not the actual data.

        // b)  Does assigning one object to another create a new object? Explain.
        // => No, it does not create a new object. It only creates a new reference pointer to the existing object.

        // c) What is the difference between copying an object and copying its reference?
        // => Copying an object creates a completely new instance in memory with duplicated data. Copying a reference just creates an additional pointer to the exact same memory location.
        #endregion

        #region Question2
        // a) What is a Shallow Copy?
        // => It creates a new object and copies the non-static fields.

        // b)  What is a Deep Copy?
        // => It creates a new object and recursively copies all fields.

        // c) What happens to reference-type members when a Shallow Copy is created?
        // => The copied object and the original object will share the same nested reference-type objects.

        // d) What happens to reference-type members when a Deep Copy is created?
        // => new independent instances of the nested reference-type objects are created for the new object.

        // e) Give one situation where Deep Copy would be safer than Shallow Copy.
        // => If a Shipment object contains a list of tracking history, a Deep Copy is safer. Modifying the tracking history in the copied shipment won't accidentally corrupt the history of the original shipment.
        #endregion

        #region Question3
        // a) What is a static field, and how is it different from an instance field?
        // => A static field belongs to the class itself and is shared among all instances. An instance field belongs to a specific object

        // b)  What is a static method? Can a static method directly access instance members?
        // => A method that belongs to the class. No, it cannot access instance members directly because it doesn't know which specific object's data to look at

        // c) What is a static constructor, and when is it executed?
        // => It's used to initialize static fields. It runs automatically only once per class, before any instance is created or any static member is accessed.

        // d) What is a static class? Can you create an object from a static class?
        // => A class that contains only static members. No, you cannot create an object from a static class.
        #endregion

        #region Question4
        // a) What is an Extension Method?
        // => A feature that allows you to add new methods to existing types without modifying the original code.

        // b)  What keyword must be used in the first parameter of an extension method?
        // => The (this) keyword

        // c) Where must an extension method be declared?
        // => Inside a top-level static class

        // d) Can an extension method access private members of the class it extends?
        // => No, it can only access public members of the extended class
        #endregion
    }
}