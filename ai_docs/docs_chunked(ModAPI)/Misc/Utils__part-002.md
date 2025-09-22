Nonlinear maximum filtering.

#### [MyMemoryLogs](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMemoryLogs.html)

#### [MyMemoryLogs.MyMemoryEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMemoryLogs.MyMemoryEvent.html)

#### [MyMergeHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMergeHelper.html)

Helper class for merge funcionality. Performs comparison between source and other values and set on self if value is different

#### [MyMessageBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMessageBox.html)

Custom message box

#### [MyMinFiltering](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMinFiltering.html)

Nonlinear minimum filtering.

#### [MyMwcConstants](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMwcConstants.html)

#### [MyPlane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyPlane.html)

#### [MyPolyLine](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyPolyLine.html)

#### [MyPolyLineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyPolyLineD.html)

#### [MyRectangle2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyRectangle2D.html)

#### [MySectorConstants](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MySectorConstants.html)

#### [MySingleCrypto](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MySingleCrypto.html)

#### [MySpherePlaneIntersectionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MySpherePlaneIntersectionEnum.html)

#### [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

Generates string hashes deterministically and crashes on collisions. When used as key for hash tables (Dictionary or HashSet) always pass in MyStringHash.Comparer, otherwise lookups will allocate memory! Can be safely used in network but never serialize to disk!

IDs are computed as hash from string so there is a risk of collisions. Use only when MyStringId is not sufficient (eg. sending over network). Because the odds of collision get higher the more hashes are in use, do not use this for generated strings and make sure hashes are computed deterministically (eg. at startup) and don't require lengthy gameplay. This way we know about any collision early and not from rare and random crash reports.

#### [MyStringHash.HashComparerType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.HashComparerType.html)

#### [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)

Generates unique IDs for strings. When used as key for hash tables (Dictionary or HashSet) always pass in MyStringId.Comparer, otherwise lookups will allocate memory! Never serialize to network or disk!

IDs are created sequentially as they get requested so two IDs might be different between sessions or clients and server. You can safely use ToString() as it will not allocate.

#### [MyStringId.IdComparerType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.IdComparerType.html)

#### [MyStringUtils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringUtils.html)

#### [MyTickTimedItem<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTickTimedItem-1.html)

Item that is accessible only for defined amount of time ticks.

#### [MyTickTimedItemF](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTickTimedItemF.html)

Item that is accessible only for defined amount of time ticks.

#### [MyTimedItem<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTimedItem-1.html)

Item that is accessible only for defined time span.

#### [MyTimedItemCache](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTimedItemCache.html)

Temporaly stores information about item (event/place) existence. This is useful if you want to launch some actions only from time to time. You ask timed cache whether your last event still takes effect.

#### [MyTriangle\_Vertex\_Normal](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTriangle_Vertex_Normal.html)

#### [MyTriangle\_Vertex\_Normals](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTriangle_Vertex_Normals.html)

#### [MyTriangle\_Vertex\_Normals\_Tangents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTriangle_Vertex_Normals_Tangents.html)

#### [MyUtils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.html)

MyFileSystemUtils

#### [MyUtils.ClearCollectionToken<TCollection, TElement>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.ClearCollectionToken-2.html)

#### [MyUtils.ClearRangeToken<T>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.ClearRangeToken-1.html)

#### [MyUtils.ClearRangeToken<T>.OffsetEnumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.ClearRangeToken-1.OffsetEnumerator.html)

#### [MyValidationConstants](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyValidationConstants.html)

#### [MyValueFormatter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyValueFormatter.html)

#### [MyVector3ISet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyVector3ISet.html)

A data structure for a set of Vector3I coordinates optimized for sets with high spatial coherence (hence the name)

#### [MyVector3ISet.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyVector3ISet.Enumerator.html)

#### [MyVersion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyVersion.html)
