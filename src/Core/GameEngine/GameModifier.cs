﻿//-----------------------------------------------------------------------------
// <copyright file="GameModifier.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   Created by: Fastalanasa
//   Date      : 5/18/2009 10:45:23 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Core
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a game/ruleset modifier.
    /// </summary>
    public class GameModifier
    {
        /// <summary>
        /// Initializes a new instance of the GameModifier class.
        /// </summary>
        public GameModifier()
        {
            this.Modifiers = new Dictionary<string, string>();
        } 

        /// <summary>
        /// Gets or sets the map to.
        /// </summary>
        /// <value>The map to.</value>
        public string MapTo { get; set; }

        /// <summary>
        /// Gets or sets the stat level.
        /// </summary>
        /// <value>The stat level.</value>
        public int StatLevel { get; set; }

        /// <summary>
        /// Gets or sets the modifiers.
        /// </summary>
        /// <value>The modifiers.</value>
        public Dictionary<string, string> Modifiers { get; set; }
    }
}