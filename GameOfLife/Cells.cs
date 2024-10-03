using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class Cells
    {

        public string Cordinate { get; set; }
        public string State { get; set; }
        public Cells NeighbourTl { get; set; }
        public Cells NeighbourT { get; set; }
        public Cells NeighbourTr { get; set; }
        public Cells NeighbourL { get; set; }
        public Cells NeighbourR { get; set; }
        public Cells NeighbourBl { get; set; }
        public Cells NeighbourB { get; set; }
        public Cells NeighbourBr { get; set; }

        public string getState()
        {
            return State;
        }
    }
}
