using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz3
{
    public class Student
    {

        public string Saxeli { get; set; }
        public string Gvari { get; set; }
        public char Skesi { get; set; }
        public DateTime DabadebisDge { get; set; }
        public string Universiteti { get; private set; }
        public string Fakulteti { get; private set; }
        public string Specialoba { get; private set; }
        public int Kursi { get; set; }
        private List<int> Nishnebi { get; set; }


        private static Random random = new Random();

        public Student(string saxeli, string gvari, DateTime dabadebisdge, char skesi, string universiteti, string fakulteti
            , string specialoba, int kursi)
        {
            Saxeli = saxeli;
            Gvari = gvari;
            Skesi = skesi;
            DabadebisDge = dabadebisdge;

            Universiteti = universiteti;
            Fakulteti = fakulteti;
            Specialoba = specialoba;
            Kursi = kursi;

            Nishnebi = Enumerable.Range(0, 10).Select(_ => random.Next(51, 101)).ToList();
        }

        public override string ToString()
        {
            return $"Saxeli: {Saxeli}\nGvari: {Gvari}\n" +
                   $"Dabadebis Dge: {DabadebisDge}\nSkesi: {Skesi}\n" +
                   $"Universiteti: {Universiteti}\nFakulteti: {Fakulteti}\n" +
                   $"Specialoba: {Specialoba}\nKursi: {Kursi}\n" +
                   $"Nishnebi: {string.Join(", ", Nishnebi)}";
        }

        public double nishnebisSashualo()
        {

            return Nishnebi.Average();
        }
    }
}