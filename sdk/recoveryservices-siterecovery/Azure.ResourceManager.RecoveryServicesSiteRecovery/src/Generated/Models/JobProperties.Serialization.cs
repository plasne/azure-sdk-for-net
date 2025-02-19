// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class JobProperties
    {
        internal static JobProperties DeserializeJobProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> activityId = default;
            Optional<string> scenarioName = default;
            Optional<string> friendlyName = default;
            Optional<string> state = default;
            Optional<string> stateDescription = default;
            Optional<IReadOnlyList<ASRTask>> tasks = default;
            Optional<IReadOnlyList<JobErrorDetails>> errors = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<IReadOnlyList<string>> allowedActions = default;
            Optional<string> targetObjectId = default;
            Optional<string> targetObjectName = default;
            Optional<string> targetInstanceType = default;
            Optional<JobDetails> customDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activityId"u8))
                {
                    activityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scenarioName"u8))
                {
                    scenarioName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stateDescription"u8))
                {
                    stateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ASRTask> array = new List<ASRTask>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ASRTask.DeserializeASRTask(item));
                    }
                    tasks = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JobErrorDetails> array = new List<JobErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobErrorDetails.DeserializeJobErrorDetails(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("allowedActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedActions = array;
                    continue;
                }
                if (property.NameEquals("targetObjectId"u8))
                {
                    targetObjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetObjectName"u8))
                {
                    targetObjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetInstanceType"u8))
                {
                    targetInstanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customDetails = JobDetails.DeserializeJobDetails(property.Value);
                    continue;
                }
            }
            return new JobProperties(activityId.Value, scenarioName.Value, friendlyName.Value, state.Value, stateDescription.Value, Optional.ToList(tasks), Optional.ToList(errors), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToList(allowedActions), targetObjectId.Value, targetObjectName.Value, targetInstanceType.Value, customDetails.Value);
        }
    }
}
