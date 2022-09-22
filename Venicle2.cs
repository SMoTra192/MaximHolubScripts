using System;
namespace DefaultNamespace
{
    public abstract class Venicle2
    {
        public abstract string autovoice();

        public class car : Venicle
        {
            public override string autovoice() => "Врум-Врум";
        }

        public class ship : Venicle
        {
            public override string autovoice() => "Плыв-Плыв";
        }

        public class plane : Venicle
        {
            public override string autovoice() => "Виу-Виу";
        }




        public static class programm
        {
            public static void Main(string[] args)
            {
                var Machina = new Venicle.car();
                var Korabl = new Venicle.ship();
                var Samolet = new Venicle.plane();
                Venicle[] venicles = new Venicle[] { Machina, Korabl, Samolet };
                foreach (var Venicle_ in venicles)
                {
                    Console.WriteLine(Venicle_.autovoice());
                }
            }
        }


    }
}