using System;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    public interface IBullet : ICloneable
    {
        int Power { get; set; }
        string Description { get; }
    }

    public class BasicBullet : IBullet
    {
        public int Power { get; set; }
        public string Description { get { return "standard bullet that doesn't do anything exciting"; } }

        public object Clone()
        {
            return new BasicBullet { Power = Power };
        }
    }

    public class IceBullet : IBullet
    {
        public int Power { get; set; }
        public string Description { get { return "bullet that will freeze enemies"; } }

        public object Clone()
        {
            return new IceBullet { Power = Power };
        }
    }
}