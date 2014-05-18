namespace DesignPatterns.CreationalPatterns.Prototype
{
    public class Example
    {
        public void PrototypeExample()
        {
            var gun = new Gun();

            // Shoot a standard bullet that doesn't do anything exciting. Whoopee.
            gun.PrototypicalBullet = new BasicBullet();
            gun.PrototypicalMovement = new SpiralMovements();
            gun.Shoot();

            // Shoot a bullet in a crazy spiral pattern that will freeze enemies where they stand!
            gun.PrototypicalBullet = new IceBullet();
            gun.PrototypicalMovement = new SpiralMovements();

            // Speed up new bullets!
            gun.PrototypicalMovement.Speed += 1;

            // Make new bullets do more damange!
            gun.PrototypicalBullet.Power += 1;
        }
    }
}
