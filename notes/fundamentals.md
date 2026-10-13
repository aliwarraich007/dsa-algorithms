# C# Reference Types and Nullability

## 1. `Node` vs. `Node?`

**Rule:** `Node` expresses a non-null reference contract. `Node?` expresses that the reference may be null.

```csharp
Node head = new Node(1);
Node? current = null;
```

**Why:** Nullable reference types enable compile-time analysis of potential null-reference errors. They do not enforce non-nullability at runtime.

**Gotcha:** A node's reference and its `next` reference have independent nullability.

```csharp
Node head = new Node(1);
// head is non-null, but head.next may be null.
```

## 2. Definite Assignment

**Rule:** A local variable must be assigned before it is read.

```csharp
Node head;                  // Not yet assigned.
Node? current = null;       // Assigned, and null is allowed.
Node first = new Node(1);   // Assigned a non-null node.
```

**Gotcha:** Definite assignment and nullable reference types are separate compiler checks.

## 3. Method Contracts

**Rule:** A method's parameter and return types should describe whether null is a valid input or output.

```csharp
static void PrintList(Node? head) { /* ... */ }
static Node? CreateList(int[] values) { /* ... */ }
```

`PrintList` can accept an empty list represented by `null`. `CreateList` can return `null` when its input is empty.

**Review question:** If a method guarantees a non-null node or throws otherwise, should its return type be `Node` or `Node?`? Explain why.
