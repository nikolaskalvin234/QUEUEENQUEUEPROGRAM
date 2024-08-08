using System;
using System.Collections;

namespace Program_latihan_queue_enqueue
{
    class Program
    {
        static void Main(string[] args)
        static int[] Antrian;
        static int Tail, Head, tailidx = -1, headidx = -1;

        void createAntrian()
        {
        Antrian = new int[8];
        Tail = 0; Head = 0;
        }

        void enQUEUE(int elment)
        {
        Antrian[tailidx + 1] = elment;
        tailidx++;
        headidx = 0;
        Tail = element; Head = Antrian[headidx];
        }
    }
}
