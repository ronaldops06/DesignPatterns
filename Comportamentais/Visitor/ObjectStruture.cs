using System.Collections.Generic;

namespace Visitor
{
    public class ObjectStruture
    {
        private List<Element> _elementos = new List<Element>();

        public void Anexar(Element element)
        {
            this._elementos.Add(element);
        }

        public void Desanexar(Element element)
        {
            this._elementos.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element element in this._elementos)
            {
                element.Accept(visitor);
            }
        }
    }
}
