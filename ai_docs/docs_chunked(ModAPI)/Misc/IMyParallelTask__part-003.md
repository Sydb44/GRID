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

##### Returns

| Type | Description |
| --- | --- |
| ParallelTasks.Task | A task which represents one execution of the action. |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.ArgumentNullException | `action` is null. |