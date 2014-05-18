namespace DesignPatterns.CreationalPatterns.Prototype
{
    /// <summary>
    /// Combines a bullet and a movement behavior with every shot!
    /// </summary>
    public class Gun
    {
        /// <summary>
        /// Creates a copy of it's prototypical bullet, applies a copy of it's own movement pattern, and then fires the bullet.
        /// None of the classes involved know anything the underlying concrete types, so the bullet and movement behavior
        /// can be swapped out at anytime without modifying any of the bullets in flight.
        /// 
        /// This is conceptually like composing a new class at runtime.
        /// </summary>
        public void Shoot()
        {
            var movementBehavior = (IBulletMovements)PrototypicalMovement.Clone();
            var bulletToFire = (IBullet)PrototypicalBullet.Clone();

            movementBehavior.Apply(bulletToFire);
        }

        /// <summary>
        /// Represents how the bullets move through the air
        /// </summary>
        public IBulletMovements PrototypicalMovement { get; set; }

        /// <summary>
        /// Represents the type of bullets that can be shot
        /// </summary>
        public IBullet PrototypicalBullet { set; get; }
    }
}