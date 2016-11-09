using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public enum Element
    {
        Fire = 0,
        Lava,
        Earth,
        Grass,
        Water,
        Ice,
        Air,
        Lightning
    }

    class Key
    {
        public Element Sender { get; set; }
        public Element Receiver { get; set; }

    }

    static class DammageMatrix
    {
        public static Dictionary<Key, int> Matrix = new Dictionary<Key, int>();

        public void Construct()
        {
            var k1 = new Key() { Sender = Element.Air, Receiver = Element.Air };
            Matrix.Add(k1, 50);

            var k2 = new Key() { Sender = Element.Air, Receiver = Element.Lava };
            Matrix.Add(k1, 75);
        }


    }

    public class Using
    {
        public Using()
        {
            var sender = Element.Air;
            var receiver = Element.Lava;


            var dammage = new Key() {
                Sender = sender,
                Receiver = receiver
            };

            int allo = DammageMatrix.Matrix.Single(x => x.Key == dammage).Value;
        }
    }
}
