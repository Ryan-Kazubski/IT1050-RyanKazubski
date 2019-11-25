using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Fido";

            myDog.Bark();
            myDog.doTrick("Fetch");
        }
    }

    class Dog
    {
        public string Name { get; set; }

        public string trickName;

        public void Bark()
        {
            Console.WriteLine("{0} is barking..", Name);
        }

        public void doTrick(string trickName)
        {
            this.trickName = trickName;
            Console.WriteLine("{0} is so smart! {0} is doing a(n) {1}!", Name, trickName);
        }
    }
    /*
     * 2.) Scope: scope determines where you can use that method or class in your program such as public or private. In our example public would be the scope.
     *      It could also be a private or class instead.
     *     Static vs. Non-Static:  A static class is basically the same as a non-static class, but there is one difference: a static class cannot be instantiated. Non-static is the get area, but there is no static method.
     *     Return Type:The return type is the data type of the value the method returns. THe return type in ours is a double height * width. return types could also be int, string, char and so on.
     *     Method Name: Method name is a unique identifier and it is case sensitive. It cannot be same as any other identifier declared in the class.  getArea is the method name. The name could be anything but capital letters matter.
     *     Parameters: Parameters are used to pass values or variable references to methods. Double heigth Double width is the parameters and it could be anything else such as int or float.
     *     Method Body: method body is everything contained in the brackets after the header. Ours is just the return, but most method bodies can expect to have more code and logic.
     *     
     * 3.)User defined method is written by the user and are hidden from other methods. Methods provided by the framework are able to be reused from several locations in an app. 
     *    When creating user-defined methods we should take into consideration to not “reinvent the wheel.”
     *    
     * 4.)A static class is basically the same as a non-static class, but there is one difference: a static class cannot be instantiated.
     * 
     */
}
