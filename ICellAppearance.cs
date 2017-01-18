﻿using System.Drawing;

namespace SadConsole
{
    /// <summary>
    /// Describes the appearance of a cell. This includes the foreground and background colors, and the effect.
    /// </summary>
    public interface ICellAppearance
    {
        /// <summary>
        /// The foreground color.
        /// </summary>
        Color Foreground { get; set; }
        /// <summary>
        /// The background color.
        /// </summary>
        Color Background { get; set; }
        /// <summary>
        /// The character index from a font sheet.
        /// </summary>
        int GlyphIndex { get; set; }

        ///// <summary>
        ///// The SpriteBatch sprite mirror effect used when rendering the cell.
        ///// </summary>
        //SpriteEffects SpriteEffect { get; set; }

        /// <summary>
        /// Copy the current appearance to another.
        /// </summary>
        void CopyAppearanceTo(ICellAppearance destination);
    }
}
