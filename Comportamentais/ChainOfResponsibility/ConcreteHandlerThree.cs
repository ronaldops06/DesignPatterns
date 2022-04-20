using System;

namespace ChainOfResponsibility
{
    public class ConcreteHandlerThree : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine($"{this.GetType().Name} handled request {request}");
            }
            else if (sucessor != null)
            {
                sucessor.HandleRequest(request);
            }
        }
    }    
}
