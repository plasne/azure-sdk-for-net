// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> Expected response schema to embeddings request. </summary>
    public partial class Embeddings
    {
        /// <summary> Initializes a new instance of Embeddings. </summary>
        /// <param name="data"> Embedding values for the prompts submitted in the request. </param>
        /// <param name="usage"> Usage counts for tokens input using the embeddings API. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> or <paramref name="usage"/> is null. </exception>
        internal Embeddings(IEnumerable<EmbeddingItem> data, EmbeddingsUsage usage)
        {
            Argument.AssertNotNull(data, nameof(data));
            Argument.AssertNotNull(usage, nameof(usage));

            Data = data.ToList();
            Usage = usage;
        }

        /// <summary> Initializes a new instance of Embeddings. </summary>
        /// <param name="object"> Type of the data field. </param>
        /// <param name="data"> Embedding values for the prompts submitted in the request. </param>
        /// <param name="model"> ID of the model to use. </param>
        /// <param name="usage"> Usage counts for tokens input using the embeddings API. </param>
        internal Embeddings(EmbeddingsObject @object, IReadOnlyList<EmbeddingItem> data, string model, EmbeddingsUsage usage)
        {
            Object = @object;
            Data = data;
            Model = model;
            Usage = usage;
        }

        /// <summary> Type of the data field. </summary>
        public EmbeddingsObject Object { get; } = EmbeddingsObject.List;

        /// <summary> Embedding values for the prompts submitted in the request. </summary>
        public IReadOnlyList<EmbeddingItem> Data { get; }
        /// <summary> ID of the model to use. </summary>
        public string Model { get; }
        /// <summary> Usage counts for tokens input using the embeddings API. </summary>
        public EmbeddingsUsage Usage { get; }
    }
}
