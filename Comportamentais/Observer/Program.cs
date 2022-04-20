using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            SubjectConcrete s = new SubjectConcrete();
            s.Anexar(new ObserverConcrete(s, "X"));
            s.Anexar(new ObserverConcrete(s, "Y"));
            s.Anexar(new ObserverConcrete(s, "Z"));

            s.StateSubject = "ABC";
            s.Notificar();

            Console.ReadKey();
        }
    }
}
