﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Schema
{
    /// <summary>
    /// A user has added a bot to their contact list, removed the bot from their contact list, or otherwise changed the relationship between user and bot
    /// </summary>
    public interface IContactRelationUpdateActivity : IActivity
    {
        /// <summary>
        /// add|remove
        /// </summary>
        string Action { get; set; }
    }
}