---
title: "Class MyCampaignManager"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyCampaignManager.html"
category: "Misc"
namespace: "Sandbox.Game"
class: "MyCampaignManager"
---

# Class MyCampaignManager | Space Engineers ModAPI

##### Inheritance

System.Object

MyCampaignManager

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyCampaignManager : Object
```

### Constructors

#### MyCampaignManager()

##### Declaration

```
public MyCampaignManager()
```

### Fields

#### AfterCampaignLocalizationsLoaded

##### Declaration

```
public static Action AfterCampaignLocalizationsLoaded
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnCampaignMissionFinished

##### Declaration

```
public Action<string> OnCampaignMissionFinished
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<System.String\> |     |

### Properties

#### ActiveCampaign

##### Declaration

```
public MyObjectBuilder_Campaign ActiveCampaign { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.ObjectBuilders.Campaign.MyObjectBuilder\_Campaign |     |

#### ActiveCampaignLevels

##### Declaration

```
public IEnumerable<string> ActiveCampaignLevels { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<System.String\> |     |

#### ActiveCampaignName

##### Declaration

```
public string ActiveCampaignName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### CampaignNames

##### Declaration

```
public IEnumerable<string> CampaignNames { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<System.String\> |     |

#### Campaigns

##### Declaration

```
public IEnumerable<MyObjectBuilder_Campaign> Campaigns { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<VRage.Game.ObjectBuilders.Campaign.MyObjectBuilder\_Campaign\> |     |

#### CrossPlatform

##### Declaration

```
public bool CrossPlatform { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsCampaignRunning

##### Declaration

```
public bool IsCampaignRunning { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsNewCampaignLevelLoading

##### Declaration

```
public bool IsNewCampaignLevelLoading { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsScenarioRunning

##### Declaration

```
public bool IsScenarioRunning { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LocalizationLanguages

##### Declaration

```
public IEnumerable<string> LocalizationLanguages { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<System.String\> |     |

#### RefreshSubscribedModDataResult

##### Declaration

```
public (MyGameServiceCallResult, string) RefreshSubscribedModDataResult { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.ValueTuple<VRage.GameServices.MyGameServiceCallResult, System.String\> |     |

#### Static

##### Declaration

```
public static MyCampaignManager Static { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCampaignManager](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyCampaignManager.html) |     |

### Methods

#### FindStartingState(MyObjectBuilder\_CampaignSM)

Finds starting state of the campaign SM. For purposes of first load.

##### Declaration

```
public MyObjectBuilder_CampaignSMNode FindStartingState(MyObjectBuilder_CampaignSM stateMachine)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.ObjectBuilders.Campaign.MyObjectBuilder\_CampaignSM | stateMachine |     |

##### Returns

| Type | Description |
| --- | --- |
| VRage.Game.ObjectBuilders.Campaign.MyObjectBuilder\_CampaignSMNode |     |

#### ForceRefreshModData()

##### Declaration

```
public void ForceRefreshModData()
```

#### GetCampaign(String)

##### Declaration

```
public MyObjectBuilder_Campaign GetCampaign(string scfFilePath)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | scfFilePath |     |

##### Returns

| Type | Description |
| --- | --- |
| VRage.Game.ObjectBuilders.Campaign.MyObjectBuilder\_Campaign |     |

#### HasStartedAsCampaign(String)

##### Declaration

```
public bool HasStartedAsCampaign(string campaignName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | campaignName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Init()

Loads campaign data to storage.

##### Declaration

#### IsCampaign(String, Boolean, UInt64)

##### Declaration

```
public bool IsCampaign(string campaignName, bool isVanilla, ulong modPublishedFileId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | campaignName |     |
| System.Boolean | isVanilla |     |
| System.UInt64 | modPublishedFileId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsCampaign(MyObjectBuilder\_CampaignSessionComponent)

##### Declaration

```
public bool IsCampaign(MyObjectBuilder_CampaignSessionComponent ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_CampaignSessionComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_CampaignSessionComponent.html) | ob  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |
