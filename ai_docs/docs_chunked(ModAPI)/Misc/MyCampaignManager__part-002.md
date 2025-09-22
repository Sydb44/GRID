```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_CampaignSessionComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_CampaignSessionComponent.html) | ob  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LoadCampaignLocalization()

##### Declaration

```
public void LoadCampaignLocalization()
```

#### NotifyCampaignFinishing()

Called from MyCampaignSessionComponent when campaign finishing. Do not use anywhere else.

##### Declaration

```
public void NotifyCampaignFinishing()
```

#### PublishActive(String\[\], String\[\])

Runs publish process for active campaign.

##### Declaration

```
public void PublishActive(string[] tags, string[] serviceNames)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String\[\] | tags |     |
| System.String\[\] | serviceNames |     |

#### RefreshModData()

##### Declaration

```
public Task RefreshModData()
```

##### Returns

| Type | Description |
| --- | --- |
| ParallelTasks.Task |     |

#### ReloadMenuLocalization()

##### Declaration

```
public void ReloadMenuLocalization()
```

#### RunCampaign(String, Boolean, Boolean)

##### Declaration

```
public bool RunCampaign(string path, bool runAsInstance = true, bool crossPlatform = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path |     |
| System.Boolean | runAsInstance |     |
| System.Boolean | crossPlatform |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RunNewCampaign(String, MyOnlineModeEnum, Int32, Boolean, Boolean)

starts new campaign

##### Declaration

```
public CloudResult RunNewCampaign(string campaignName, MyOnlineModeEnum onlineMode, int maxPlayers, bool crossPlatform, bool runAsInstance = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | campaignName |     |
| [MyOnlineModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOnlineModeEnum.html) | onlineMode |     |
| System.Int32 | maxPlayers |     |
| System.Boolean | crossPlatform |     |
| System.Boolean | runAsInstance |     |

##### Returns

| Type | Description |
| --- | --- |
| VRage.GameServices.CloudResult |     |

#### SetExperimentalCampaign(MyObjectBuilder\_Checkpoint)

##### Declaration

```
public void SetExperimentalCampaign(MyObjectBuilder_Checkpoint checkpoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Checkpoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Checkpoint.html) | checkpoint |     |

#### SwitchCampaign(String, Boolean, UInt64, String, String, Boolean)

Changes the manager state to given campaign.

##### Declaration

```
public bool SwitchCampaign(string name, bool isVanilla = true, ulong publisherFileId = 0UL, string publisherServiceName = null, string localModFolder = null, bool crossPlatform = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| System.Boolean | isVanilla |     |
| System.UInt64 | publisherFileId | 0 is default value or local mod value. |
| System.String | publisherServiceName |     |
| System.String | localModFolder |     |
| System.Boolean | crossPlatform |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Events

#### OnActiveCampaignChanged

##### Declaration

```
public static event Action OnActiveCampaignChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnCampaignFinished

##### Declaration

```
public event Action OnCampaignFinished
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnCampaignFinishing

##### Declaration

```
public event Action OnCampaignFinishing
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |