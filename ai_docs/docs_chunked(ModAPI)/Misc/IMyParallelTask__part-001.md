---
title: "Interface IMyParallelTask"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyParallelTask.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyParallelTask"
---

# Interface IMyParallelTask | Space Engineers ModAPI

Mod API interface allowing you to run async tasks

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyParallelTask
```

### Properties

#### DefaultOptions

Default WorkOptions. DetachFromParent = false, MaximumThreads = 1

##### Declaration

```
WorkOptions DefaultOptions { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| ParallelTasks.WorkOptions |     |

### Methods

#### Do(IWork, IWork)

Executes the given work items potentially in parallel with each other. This method will block until all work is completed.

##### Declaration

```
void Do(IWork a, IWork b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ParallelTasks.IWork | a   | Work to execute. |
| ParallelTasks.IWork | b   | Work to execute. |

#### Do(IWork\[\])

Executes the given work items potentially in parallel with each other. This method will block until all work is completed.

##### Declaration

```
void Do(params IWork[] work)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ParallelTasks.IWork\[\] | work | The work to execute. |

#### Do(Action, Action)

Executes the given work items potentially in parallel with each other. This method will block until all work is completed.

##### Declaration

```
void Do(Action action1, Action action2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action1 | The work to execute. |
| System.Action | action2 | The work to execute. |

#### Do(Action\[\])

Executes the given work items potentially in parallel with each other. This method will block until all work is completed.

##### Declaration

```
void Do(params Action[] actions)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action\[\] | actions | The work to execute. |

#### For(Int32, Int32, Action<Int32>)

Executes a for loop, where each iteration can potentially occur in parallel with others.

##### Declaration

```
void For(int startInclusive, int endExclusive, Action<int> body)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | startInclusive | The index (inclusive) at which to start iterating. |
| System.Int32 | endExclusive | The index (exclusive) at which to end iterating. |
| System.Action<System.Int32\> | body | The method to execute at each iteration. The current index is supplied as the parameter. |

#### For(Int32, Int32, Action<Int32>, Int32)

Executes a for loop, where each iteration can potentially occur in parallel with others.

##### Declaration

```
void For(int startInclusive, int endExclusive, Action<int> body, int stride)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | startInclusive | The index (inclusive) at which to start iterating. |
| System.Int32 | endExclusive | The index (exclusive) at which to end iterating. |
| System.Action<System.Int32\> | body | The method to execute at each iteration. The current index is supplied as the parameter. |
| System.Int32 | stride | The number of iterations that each processor takes at a time. |

#### ForEach<T>(IEnumerable<T>, Action<T>)

Executes a foreach loop, where each iteration can potentially occur in parallel with others.

##### Declaration

```
void ForEach<T>(IEnumerable<T> collection, Action<T> action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<T> | collection | The enumerable data source. |
| System.Action<T> | action | The method to execute at each iteration. The item to process is supplied as the parameter. |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | The type of item to iterate over. |

#### Sleep(Int32)

Suspends the current thread for the specified number of milliseconds.

##### Declaration

```
void Sleep(int millisecondsTimeout)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | millisecondsTimeout | How much to sleep |

#### Sleep(TimeSpan)

Suspends the current thread for the specified amount of time.

##### Declaration

```
void Sleep(TimeSpan timeout)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.TimeSpan | timeout | How much to sleep |

#### Start(IWork)

Creates and starts a task to execute the given work.

##### Declaration

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ParallelTasks.IWork | work | The work to execute in parallel. |

##### Returns

| Type | Description |
| --- | --- |
| ParallelTasks.Task | A task which represents one execution of the work. |

#### Start(IWork, Action)

Creates and starts a task to execute the given work.

##### Declaration

```
Task Start(IWork work, Action completionCallback)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ParallelTasks.IWork | work | The work to execute in parallel. |
| System.Action | completionCallback | A method which will be called in Parallel.RunCallbacks() once this task has completed. |

##### Returns

| Type | Description |
| --- | --- |
| ParallelTasks.Task | A task which represents one execution of the work. |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.ArgumentNullException | `work` is null. |
| System.ArgumentException | Invalid number of maximum threads set in ParallelTasks.IWork.Options. |

#### Start(Action)

Creates and starts a task to execute the given work.

##### Declaration

```
Task Start(Action action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action | The work to execute in parallel. |
