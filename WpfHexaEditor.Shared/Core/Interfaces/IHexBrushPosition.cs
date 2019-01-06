﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace WpfHexaEditor.Core.Interfaces
{
    /// <summary>
    /// This interface indicates brushinfo for HexBrush;
    /// </summary>
    public interface IHexBrushPosition
    {
        /// <summary>
        /// Position relative to the data of the datalayer;
        /// </summary>
        int Position { get; }
        /// <summary>
        /// The first char Foreground or Background etc.
        /// </summary>
        Brush FirstCharBrush { get; }
        /// <summary>
        /// The second char Foreground or Background etc.
        /// </summary>
        Brush SecondCharBrush { get; }
    }
}
