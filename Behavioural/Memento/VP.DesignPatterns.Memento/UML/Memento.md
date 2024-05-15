# Memento Pattern

The Memento Pattern is a behavioral design pattern that allows capturing and storing the internal state of an object without violating encapsulation. It enables restoring an object to a previous state, effectively providing the ability to undo operations or revert to earlier states.

## Intent

- Capture the internal state of an object without exposing its implementation details.
- Store the state externally in a memento object.
- Restore the object to a previous state when needed.

## Structure

- **Originator**: The object whose state needs to be saved. It creates mementos containing snapshots of its internal state and can restore its state from mementos.
  
- **Memento**: Represents the saved state of the originator. It provides methods to retrieve the saved state.

- **Caretaker**: Responsible for keeping track of and managing mementos. It can store and retrieve mementos but does not modify them.

## Example

Consider a text editor application that allows users to edit and format text. The Memento pattern can be used to implement an undo feature, where the editor can revert to previous versions of the edited text. Each time the user performs an edit operation, the editor creates a memento containing the current state of the text. These mementos are stored in a history list. If the user wants to undo an operation, the editor retrieves the most recent memento from the history and restores the text to its state at that point.

## Implementation

- **Originator**: Represents the object whose state needs to be saved. It provides methods to create mementos and restore its state from mementos.

- **Memento**: Represents the saved state of the originator. It may contain fields to store the state or a reference to the originator.

- **Caretaker**: Manages the collection of mementos. It can save mementos, retrieve mementos, and apply mementos to restore the originator's state.

## When to Use

- When you need to implement an undo feature that allows reverting objects to previous states.
- When you want to capture and store the internal state of an object without exposing its details.
- When you need to support multiple undo levels or a history mechanism for objects.

## Benefits

- Encapsulates the internal state of an object, ensuring data privacy and information hiding.
- Provides a flexible and reusable mechanism for implementing undo functionality.
- Simplifies the implementation of checkpoints or snapshots in applications.

## Drawbacks

- Can consume memory if large or frequent state snapshots are stored.
- May introduce overhead when managing large numbers of mementos or complex state.

## Real-World Examples

- Text editors or word processors that provide undo functionality.
- Graphics editors that allow users to revert changes or undo actions.
- Version control systems that track changes and allow reverting to previous versions of files.

## Related Patterns

- **Command Pattern**: Often used in conjunction with the Memento pattern to implement undoable operations.
- **State Pattern**: The Memento pattern can be seen as an implementation detail of the State pattern, where states are captured and restored using mementos.
- **Iterator Pattern**: Memento can be used to implement snapshots or checkpoints in iterators to revert to a previous iteration state.

![Memento Pattern](memento.png)

