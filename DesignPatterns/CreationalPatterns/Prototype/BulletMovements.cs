using System;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    /// <summary>
    /// How an object moves through space. Could be a fast, slow, zig zag, etc
    /// Use your imagination!
    /// </summary>
    public interface IBulletMovements : ICloneable
    {
        int Speed { get; set; }
        void Apply(IBullet bullet);
    }

    public class BasicMovementBehavior
    {
        public int Speed { get; set; }
        public void Apply(IBullet bullet)
        {
            Console.WriteLine("Shot a {0}. Whoopee.", bullet.Description);
        }

        public object Clone()
        {
            return new BasicMovementBehavior { Speed = Speed };
        }
    }

    public class SpiralMovements : IBulletMovements
    {
        public int Speed { get; set; }
        public void Apply(IBullet bullet)
        {
            Console.WriteLine("Shot a {0} in a crazy spiral pattern!", bullet.Description);
        }

        public object Clone()
        {
            return new SpiralMovements {Speed = Speed};
        }
    }
}