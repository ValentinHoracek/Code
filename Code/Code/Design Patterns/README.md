# Design Patterns
## Behavioral
## Creational
### Abstract Factory
Create related instances without specifying their concrete class. Encapsulate object creation without leaking implementation details. Central point of control and creation.
### Builder
Create complex objects by using functional style step-by-step. Builder knows each step. Director puts recipes together.
### Factory Method
Define an interface for creating single object, buit let subclasses decide which class to instantiate.
### Prototype
Create new object without constructor -> copying prototype.
### Singleton
Global access to single instance of a class.
## Structural
### Adapter
Consume the interface of a class into another interface the client expects. Adapter lets classes work together that couldn’t otherwise because of incompatible interfaces. Wraps existing class. One-way Bridge pattern.
### Bridge
Separate an abstraction from its implementation. Allows both sides to evolve indepoendently. Two-way abstraction hierarchy.