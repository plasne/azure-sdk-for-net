// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class ListFilesAndDirectoriesSegmentResponse
    {
        internal static ListFilesAndDirectoriesSegmentResponse DeserializeListFilesAndDirectoriesSegmentResponse(XElement element)
        {
            string serviceEndpoint = default;
            string shareName = default;
            string shareSnapshot = default;
            bool? encoded = default;
            string directoryPath = default;
            StringEncoded prefix = default;
            string marker = default;
            int? maxResults = default;
            FilesAndDirectoriesListSegment segment = default;
            string nextMarker = default;
            string directoryId = default;
            if (element.Attribute("ServiceEndpoint") is XAttribute serviceEndpointAttribute)
            {
                serviceEndpoint = (string)serviceEndpointAttribute;
            }
            if (element.Attribute("ShareName") is XAttribute shareNameAttribute)
            {
                shareName = (string)shareNameAttribute;
            }
            if (element.Attribute("ShareSnapshot") is XAttribute shareSnapshotAttribute)
            {
                shareSnapshot = (string)shareSnapshotAttribute;
            }
            if (element.Attribute("Encoded") is XAttribute encodedAttribute)
            {
                encoded = (bool?)encodedAttribute;
            }
            if (element.Attribute("DirectoryPath") is XAttribute directoryPathAttribute)
            {
                directoryPath = (string)directoryPathAttribute;
            }
            if (element.Element("Prefix") is XElement prefixElement)
            {
                prefix = StringEncoded.DeserializeStringEncoded(prefixElement);
            }
            if (element.Element("Marker") is XElement markerElement)
            {
                marker = (string)markerElement;
            }
            if (element.Element("MaxResults") is XElement maxResultsElement)
            {
                maxResults = (int?)maxResultsElement;
            }
            if (element.Element("Entries") is XElement entriesElement)
            {
                segment = FilesAndDirectoriesListSegment.DeserializeFilesAndDirectoriesListSegment(entriesElement);
            }
            if (element.Element("NextMarker") is XElement nextMarkerElement)
            {
                nextMarker = (string)nextMarkerElement;
            }
            if (element.Element("DirectoryId") is XElement directoryIdElement)
            {
                directoryId = (string)directoryIdElement;
            }
            return new ListFilesAndDirectoriesSegmentResponse(serviceEndpoint, shareName, shareSnapshot, encoded, directoryPath, prefix, marker, maxResults, segment, nextMarker, directoryId);
        }
    }
}
