using System;

namespace MultipleInheritance
{
    public class TextBox : UiControl, IDraggable, IDroppable   //to write the full block of 
                                                            // interface press Alt+enter
                                                            // and then enter again
    {
        public void Drag()            // here we need all the methods from
                                      // IDraggable and IDroppable
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }

    public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }

        public virtual void Draw()
        {
        }

        public void Focus()
        {
            Console.WriteLine("Received focus.");
        }
    }
}


// Interface got nothing to do with Inheritance 
// Here TextBox cannot have multiuple inheritance 
// but it can connected with multiple interfaces



// In interafces all we ae doing is confirmin to a contract. We are
// making sure that the public interface of our class has the methods or
// members as it is declared in the interface 
// so if we try to remove drag() from the texbox, it wont compile here 


// Interfaces are usedfor building losely coupled extensible and testable 
// applications; not for code reusability
// 



// But intefaces do provide polymorphic behaviour 