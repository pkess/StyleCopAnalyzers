﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace StyleCop.Analyzers.Settings.ObjectModel
{
    using Newtonsoft.Json;

    [JsonObject(MemberSerialization.OptIn)]
    internal class ReadabilitySettings
    {
        /// <summary>
        /// This is the backing field for the <see cref="lineLength"/> property.
        /// </summary>
        [JsonProperty("lineLength", DefaultValueHandling = DefaultValueHandling.Include)]
        private int lineLength;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadabilitySettings"/> class during JSON deserialization.
        /// </summary>
        [JsonConstructor]
        protected internal ReadabilitySettings()
        {
            this.lineLength = 0;
        }

        public int LineLength =>
            this.lineLength;
    }
}
