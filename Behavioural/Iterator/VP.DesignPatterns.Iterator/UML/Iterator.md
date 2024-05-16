# Iterator Design Pattern

The Iterator pattern is a behavioral design pattern that allows for sequential traversal of elements in a collection without exposing its underlying implementation details.

## Intent

The Iterator pattern aims to:

- **Provide a uniform way to iterate over a collection**: Clients can traverse a collection of objects without knowing its internal structure.
  
- **Decouple client code from collection implementation**: It separates the traversal logic from the collection, promoting flexibility and encapsulation.

## Key Components

- **Iterator**:
  - Defines an interface for accessing and traversing elements of a collection.
  - Typically includes methods like `getCurrent()` to retrieve the current element and `next()` to move to the next element.

- **Concrete Iterator**:
  - Implements the Iterator interface for a specific collection type (e.g., array, list).
  - Manages the traversal state and provides methods for sequential access.

- **Aggregate**:
  - Defines an interface for creating an iterator object.
  - Represents a collection of objects that can be iterated over.

- **Concrete Aggregate**:
  - Implements the Aggregate interface to provide a specific iterator for its collection.
  - Offers methods to add, remove, or retrieve elements within the collection.

The Iterator pattern simplifies traversal of collections by encapsulating the iteration logic, enabling clients to focus on processing elements without being concerned about how they are accessed internally.
