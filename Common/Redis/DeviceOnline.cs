﻿using Redis.OM.Modeling;
using Semver;

namespace OpenShock.Common.Redis;

[Document(StorageType = StorageType.Json, IndexName = "device-online")]
public class DeviceOnline
{
    [RedisIdField] [Indexed] public required Guid Id { get; set; }
    [Indexed] public required Guid Owner { get; set; }
    public SemVersion? FirmwareVersion { get; set; }
    public string? Gateway { get; set; }
}