// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The managed database&apos;s restore details backup set properties. </summary>
    public partial class ManagedDatabaseRestoreDetailBackupSetProperties
    {
        /// <summary> Initializes a new instance of ManagedDatabaseRestoreDetailBackupSetProperties. </summary>
        internal ManagedDatabaseRestoreDetailBackupSetProperties()
        {
        }

        /// <summary> Initializes a new instance of ManagedDatabaseRestoreDetailBackupSetProperties. </summary>
        /// <param name="status"> Backup set status. </param>
        /// <param name="firstStripeName"> First stripe name. </param>
        /// <param name="numberOfStripes"> Number of stripes. </param>
        /// <param name="backupSizeInMB"> Backup size. </param>
        /// <param name="restoreStartedOn"> Last restored file time. </param>
        /// <param name="restoreFinishedOn"> Last restored file time. </param>
        internal ManagedDatabaseRestoreDetailBackupSetProperties(string status, string firstStripeName, int? numberOfStripes, int? backupSizeInMB, DateTimeOffset? restoreStartedOn, DateTimeOffset? restoreFinishedOn)
        {
            Status = status;
            FirstStripeName = firstStripeName;
            NumberOfStripes = numberOfStripes;
            BackupSizeInMB = backupSizeInMB;
            RestoreStartedOn = restoreStartedOn;
            RestoreFinishedOn = restoreFinishedOn;
        }

        /// <summary> Backup set status. </summary>
        public string Status { get; }
        /// <summary> First stripe name. </summary>
        public string FirstStripeName { get; }
        /// <summary> Number of stripes. </summary>
        public int? NumberOfStripes { get; }
        /// <summary> Backup size. </summary>
        public int? BackupSizeInMB { get; }
        /// <summary> Last restored file time. </summary>
        public DateTimeOffset? RestoreStartedOn { get; }
        /// <summary> Last restored file time. </summary>
        public DateTimeOffset? RestoreFinishedOn { get; }
    }
}
