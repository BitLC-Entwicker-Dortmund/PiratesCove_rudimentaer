
namespace PiratesCove_rudimentaer {
    internal class Program {
        static void Main(string[] args) {
            //Console.WriteLine("Hallo, Golfer!");

            //Golfer g1 = new Golfer() { Name="Toni"};
            //Golfer g2 = new Golfer() { Name = "Franz" };

            //Queue<Golfer> q = new Queue<Golfer>();
            //q.Enqueue(g1);
            //q.Enqueue(g2);

            ////Console.WriteLine( q.Peek().Name );
            ////q.Dequeue();
            ////Console.WriteLine(q.Peek().Name);

            //List<Golfer> lG = q.ToList();            

            //for (int i = lG.Count-1; i >= 0; i--) {
            //    Console.WriteLine(lG[i].Name);
            //    //Console.WriteLine(i);
            //}
            Bus bus = new Bus();
            bus.addGolfer(new Golfer() { Name="Toni"});
            bus.addGolfer(new Golfer() { Name="Franz"});

            bus.zeigeGolfer();
            bus.zeigeGolferRueckwaerts();

            Console.Read();
        }
    }

    internal class Golfer {
        public string Name { get; set; }
    }
}