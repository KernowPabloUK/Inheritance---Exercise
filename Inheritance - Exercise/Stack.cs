using System.Collections.Generic;
using System;

#region//The Push() method stores the given object on top of the stack.
//We use the “object” type here so we can store any objects inside the stack.
//Remember the “object” class is the base of all classes in the .NET Framework.
//So any types can be automatically upcast to the object.
//Make sure to take into account the scenario that null is passed to this object.
//We should not store null references in the stack. So if null is passed to this method, you should throw an InvalidOperationException.
//Remember, when coding every method, you should think of all possibilities and make sure the method behaves properly in all these edge cases.
//That’s what distinguishes you from an “average” programmer.
#endregion

#region//The Pop() method removes the object on top of the stack and returns it.
//Make sure to take into account the scenario that we call the Pop() method on an empty stack.
//In this case, this method should throw an InvalidOperationException.
//Remember, your classes should always be in a valid state and used properly.
//When they are misused, they should throw exceptions.
//Again, thinking of all these edge cases, separates you from an average programmer.
//The code written this way will be more robust and with less bugs.
#endregion

#region//The Clear() method removes all objects from the stack.

//We should be able to use this stack class as follows:

// var stack = new Stack();
// stack.Push(1);
// stack.Push(2);
// stack.Push(3);

// Console.WriteLine(stack.Pop());
// Console.WriteLine(stack.Pop());
// Console.WriteLine(stack.Pop());
#endregion

#region//The output of this program will be
// 3
// 2
// 1

//Note: The downside of using the object class here is that if we store value types (eg int, char, bool, DateTime) in our Stack, boxing and unboxing occurs, which comes with a small performance penalty.
//In my C# Advanced course, I’ll teach you how to resolve this by using generics, but for now don’t worry about it

//Real-world use case: Stacks are very popular in real-world applications.
//Think of your browser.As you navigate the web, the address of each page you visit is stored in a stack.
//As you click the Back button, the most recent address is popped.This is because of the LIFO behaviour of stacks.
#endregion

namespace Inheritance___Exercise
{
    /// <summary>
    /// A Stack is a data structure for storing a list of elements in a LIFO (last in, first out) fashion.
    /// Design a class called Stack with three methods.
    /// </summary>
    internal class Stack
    {
        private List<object> List;
        
        internal Stack()
        {
            this.List = new List<object>();
        }
        

        /// <summary>
        ///We use the “object” type here so we can store any objects inside the stack.
        ///Remember the “object” class is the base of all classes in the .NET Framework.
        ///So any types can be automatically upcast to the object.
        ///Make sure to take into account the scenario that null is passed to this object.
        ///We should not store null references in the stack. So if null is passed to this method, you should throw an InvalidOperationException.
        ///Remember, when coding every method, you should think of all possibilities and make sure the method behaves properly in all these edge cases.
        ///That’s what distinguishes you from an “average” programmer.
        /// </summary>
        /// <param name="obj">obj represents an object that will be pushed to stack</param>
        internal void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("there must be an object to be passed to the list, you cannot pass a null value");
            }
            this.List.Add(obj);
        }

        internal object Pop()
        {
            if (this.List.Count == 0)
            {
                throw new InvalidOperationException("You cannot return an empty list with null value");
            }
            int LastIndexOfList = this.List.Count - 1;
            object poppedObject = this.List[LastIndexOfList];
            this.List.RemoveAt(LastIndexOfList);
            return poppedObject;
        }

        internal void Clear()
        {
            this.List.Clear();
        }
    }
}
