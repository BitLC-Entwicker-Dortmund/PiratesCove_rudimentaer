using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratesCove_rudimentaer {
    internal class Bus {
        private Queue<Golfer> q = new Queue<Golfer>();

        public void addGolfer(Golfer g) {
            q.Enqueue(g);
        }

        public void zeigeGolfer() {
            foreach (Golfer g in q) {
                Console.WriteLine(g.Name);
            }
        }

        public void zeigeGolferRueckwaerts() {
            // alternativ Reverse-Methode einsetzen
            List<Golfer> lG = q.ToList();

            for (int i = lG.Count - 1; i >= 0; i--) {
                Console.WriteLine(lG[i].Name);
            }
        }

    }
}
