# Prototype Pattern

The power of the prototype pattern lies in the ability to create new objects without ever knowing what classes we're creating at runtime.

In this example, we take a look at a simple sample from old skool ["bullet hell"](http://en.wikipedia.org/wiki/Shoot_'em_up) games like 1942 and Gradius.

In these games, you pilot an flying ship against completely overwhelming odds. You're only hope of survival involves finding powerups that increase the power, range, and speed of your guns.

This makes for a great example for the Prototype pattern. You can "power up"

We can abstract away our (loosely termed) bullets and bullet movement patterns and simply clone these items whenever we shoot.

The prototype pattern allows us to change these options out while the game is running without our Gun class knowing about the underlying implementation.


## Why not use a...

Why not use the abstract factory or builder pattern to create the bullets and movement behavior?

There are a couple of workarounds, but typically factories and builder objects need to know about the underlying concrete types that they are creating.

In the prototype pattern, the pertinent objects know how to create themselves. Anyone can implement and pass their own classes without the original authors having any knowledge of them at compile time.

This is a particularly great pattern for gaming applications since it's a great way to enable [mods](http://en.wikipedia.org/wiki/Modding) for third parties.


## About the implementation

In this example we're using .NET's built in ICloneable interface.

By convention, the Clone() method is a deep copy but it's up to the programmers to enforce that convention.

Additionally the return type is an Object, so we lose compile time checking and have to clutter our code up with casts. Doh!

We can work around this problem by using generics, but only if we enforce that the objects are newable. This may be acceptable to your use case.