Simple thread-safe queue. Uses spin-lock

#### [MyConcurrentList<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentList-1.html)

#### [MyConcurrentPool<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentPool-1.html)

Simple thread-safe pool. Can store external objects by calling return. Creates new instances when empty.

#### [MyConcurrentQueue<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentQueue-1.html)

Simple thread-safe queue. Uses spin-lock

#### [MyDeque<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyDeque-1.html)

#### [MyDistributedTypeUpdater<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyDistributedTypeUpdater-1.html)

Class distributing updates on large amount of objects in configurable intervals. This updater does updates in linear manner in defined steps. Also takes into account type of the item.

#### [MyDistributedTypeUpdater<T>.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyDistributedTypeUpdater-1.Enumerator.html)

#### [MyDistributedUpdater<TList, TElement>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyDistributedUpdater-2.html)

Class distributing updates on large amount of objects in configurable intervals.

#### [MyDistributedUpdater<TList, TElement>.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyDistributedUpdater-2.Enumerator.html)

#### [MyIntervalList](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyIntervalList.html)

A set of integer numbers optimized for sets with long consecutive runs. Each interval is stored as two values in m\_list: the lower and the upper bound.

For example, the set of numbers 2, 3, 4, 5, 7, 9, 10, 11, 12, 13 (or alternatively in the interval notation <2, 5> U <7, 7> U <9, 13>) is saved as a list { 2, 5, 7, 7, 9, 13 }

#### [MyIntervalList.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyIntervalList.Enumerator.html)

#### [MyQueue<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyQueue-1.html)

Allows access to queue by index Otherwise implementation is similar to regular queue

#### [MyQueue<T>.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyQueue-1.Enumerator.html)

#### [MySinglyLinkedList<V>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MySinglyLinkedList-1.html)

#### [MySinglyLinkedList<V>.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MySinglyLinkedList-1.Enumerator.html)

#### [MySwapQueue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MySwapQueue.html)

#### [MySwapQueue<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MySwapQueue-1.html)

Holds three objects in safe manner, use when Reader requires only last valid data. One object is used for reading, one for writing and third is used as buffer, so reader/writer don't have to wait on the other.

#### [MyUniqueList<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyUniqueList-1.html)

#### [ObservableCollection<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ObservableCollection-1.html)

Observable collection that also fix support to clear all. Don't know if ObservableCollection<T> is allocation free.

#### [ObservableCollection<T>.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ObservableCollection-1.Enumerator.html)

Enumerator which uses index access. Index access on Collection is O(1) operation

#### [QueueReader<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.QueueReader-1.html)

#### [SortedDictionaryReader<K, V>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.SortedDictionaryReader-2.html)

#### [SortedDictionaryValuesReader<K, V>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.SortedDictionaryValuesReader-2.html)

#### [ThreadSafeStore<TKey, TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ThreadSafeStore-2.html)

#### [TypeSortedCachingList<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.TypeSortedCachingList-1.html)

List wrapper that allows for addition and removal even during enumeration. Done by caching changes and allowing explicit application using Apply\* methods.

#### [UniqueListReader<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.UniqueListReader-1.html)

### Interfaces

#### [IMyElementAllocator<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.IMyElementAllocator-1.html)