```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId | Player IdentityId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player is founder of faction |

#### IsFriendly(Int64)

Returns if player with provided playerId is friendly to faction

##### Declaration

```
bool IsFriendly(long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId | Player IdentityId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player is friendly to faction |

#### IsLeader(Int64)

Returns if player with provided playerId is faction leader

##### Declaration

```
bool IsLeader(long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId | Player IdentityId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player is faction leader |

#### IsMember(Int64)

Returns if player with provided playerId is faction member

##### Declaration

```
bool IsMember(long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId | Player IdentityId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player is faction leader |

#### IsNeutral(Int64)

Returns if player with provided playerId is neutral to faction

##### Declaration

```
bool IsNeutral(long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId | Player IdentityId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player is neutral to faction |

#### RequestChangeBalance(Int64)

Changes the balance of the account of this faction by given amount. Sends a message to server with the request.

##### Declaration

```
void RequestChangeBalance(long amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | amount | Amount by which to change te balance. |

#### TryGetBalanceInfo(out Int64)

Gets balance of an account associated with faction.

##### Declaration

```
bool TryGetBalanceInfo(out long balance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | balance | Returns current balance of the account. (If called on client, can return delayed value, as changes to balace have to be synchronized first) |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if account was found. Otherwise false. |