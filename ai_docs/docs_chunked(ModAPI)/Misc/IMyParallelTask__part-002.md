Creates and starts a task to execute the given work.

##### Declaration

```
Task Start(Action action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action | The work to execute in parallel. |

##### Returns

| Type | Description |
| --- | --- |
| ParallelTasks.Task | A task which represents one execution of the work. |

#### Start(Action, WorkOptions)

Creates and starts a task to execute the given work.

##### Declaration

```
Task Start(Action action, WorkOptions options)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action | The work to execute in parallel. |
| ParallelTasks.WorkOptions | options | The work options to use with this action. |

##### Returns

| Type | Description |
| --- | --- |
| ParallelTasks.Task | A task which represents one execution of the work. |

#### Start(Action, WorkOptions, Action)

Creates and starts a task to execute the given work.

##### Declaration

```
Task Start(Action action, WorkOptions options, Action completionCallback)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action | The work to execute in parallel. |
| ParallelTasks.WorkOptions | options | The work options to use with this action. |
| System.Action | completionCallback | A method which will be called in Parallel.RunCallbacks() once this task has completed. |

##### Returns

| Type | Description |
| --- | --- |
| ParallelTasks.Task | A task which represents one execution of the work. |

#### Start(Action, Action)

Creates and starts a task to execute the given work.

##### Declaration

```
Task Start(Action action, Action completionCallback)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action | The work to execute in parallel. |
| System.Action | completionCallback | A method which will be called in Parallel.RunCallbacks() once this task has completed. |

##### Returns

| Type | Description |
| --- | --- |
| ParallelTasks.Task | A task which represents one execution of the work. |

#### Start(Action<WorkData>, Action<WorkData>, WorkData)

Creates and schedules a task to execute the given work with the given work data.

##### Declaration

```
Task Start(Action<WorkData> action, Action<WorkData> completionCallback, WorkData workData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action<ParallelTasks.WorkData\> | action | The work to execute in parallel. |
| System.Action<ParallelTasks.WorkData\> | completionCallback | A method which will be called in Parallel.RunCallbacks() once this task has completed. |
| ParallelTasks.WorkData | workData | Data to be passed along both the work and the completion callback. |

##### Returns

| Type | Description |
| --- | --- |
| ParallelTasks.Task | A task which represents one execution of the action. |

#### StartBackground(IWork)

Starts a task in a secondary worker thread. Intended for long running, blocking, work such as I/O.

##### Declaration

```
Task StartBackground(IWork work)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ParallelTasks.IWork | work | The work to execute. |

##### Returns

| Type | Description |
| --- | --- |
| ParallelTasks.Task | A task which represents one execution of the work. |

#### StartBackground(IWork, Action)

Starts a task in a secondary worker thread. Intended for long running, blocking, work such as I/O.

##### Declaration

```
Task StartBackground(IWork work, Action completionCallback)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| ParallelTasks.IWork | work | The work to execute. |
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

#### StartBackground(Action)

Starts a task in a secondary worker thread. Intended for long running, blocking, work such as I/O.

##### Declaration

```
Task StartBackground(Action action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action | The work to execute. |

##### Returns

| Type | Description |
| --- | --- |
| ParallelTasks.Task | A task which represents one execution of the action. |

#### StartBackground(Action, Action)

Starts a task in a secondary worker thread. Intended for long running, blocking, work such as I/O.

##### Declaration

```
Task StartBackground(Action action, Action completionCallback)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action | The work to execute. |
| System.Action | completionCallback | A method which will be called in Parallel.RunCallbacks() once this task has completed. |

##### Returns

| Type | Description |
| --- | --- |
| ParallelTasks.Task | A task which represents one execution of the action. |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.ArgumentNullException | `action` is null. |

#### StartBackground(Action<WorkData>, Action<WorkData>, WorkData)

Starts a task in a secondary worker thread. Intended for long running, blocking work such as I/O.

##### Declaration

```
Task StartBackground(Action<WorkData> action, Action<WorkData> completionCallback, WorkData workData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action<ParallelTasks.WorkData\> | action | The work to execute. |
| System.Action<ParallelTasks.WorkData\> | completionCallback | A method which will be called in Parallel.RunCallbacks() once this task has completed. |
| ParallelTasks.WorkData | workData | Data to be passed along both the work and the completion callback. |
