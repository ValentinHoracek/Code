# Design Patterns
## Behavioral
### Chain of Responsibility
Modular request processing allowing a request to be passed along a chain of independent, interchangable handlers, each of which can process, transform or forward a request without the sender needing to know which handler will act.
### Command
Turns an action or request into an object that can be passed around and executed later. This way, the part of your program that triggers the action doesn’t need to know the details of how the action is done.
### Interpreter
Defines a way to evaluate language-like expressions (DSL - domain-specific language) by representing grammar rules as class objects. Each expression is an object that knows how to interpret itself, usually in a shared context. When working with real textual languages, you first need to parse the input into an abstract syntax tree composed of these expression objects.
### Iterator
Provides a way to sequentially access elements of a collection without exposing its internal structure.
### Mediator
Defines specific object (the mediator) that encapsulates how a set of objects interact. It promotes loose coupling by preventing objects from referring to each other explicitly, letting them communicate only through the mediator.
### Memento
Lets you save and restore an object's (originator) internal state without violating encapsulation. It provides undo or rollback functionality.
### Observer
Defines a one-to-many relationship between objects, where one object (subject) maintains a list of dependent objects (observers). When the subject's state changes, it autoamtically notifies all observers. Pattern promotes loose coupling, enabling objects to communicate without needing to know each other's internal structure or logic.
### State
Models and object's behaviour as a set of state, each encapsulating specific rules and actions. Transitions between states can also be controlled and prevented if certain conditions, like validity checks, are not met.
### Strategy
Pattern is used when an operation's behaviour need to change dynamically at runtime. Encapsulates a family of alrgorithms or behaviours for single operation and lets the client select the appropriate strategy before executing it. Strategies can be iomplemented with private constructors to control their creationa and enfroce correct usage.
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
### Composite
Compose objects into tree structures and use common interface to access them. Simplifying recursive operations on nodes and leaves.
### Decorator
Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending behavior. Extending object without changing it.
### Facade
Provide a simplified interface to a complex subsystem. Connect several service references into one for easier injection and manipulation. Doesn't contain any logic only passes calls to respective services.
### Flyweight
Share common object data to save memory by storing intrinsic (shared) state externaly, into separate class, and reusing it across many instances.
### Proxy
Provide a substitute or placeholder for another object to control access to it. 