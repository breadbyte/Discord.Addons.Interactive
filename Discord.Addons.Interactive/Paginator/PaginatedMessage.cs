﻿using System.Collections.Generic;

namespace Discord.Addons.Interactive
{
    public class PaginatedMessage
    {
        /// <summary>
        /// Pages contains a collection of elements to page over in the embed. It is expected
        /// that a string-like object is used in this collection, as objects will be converted
        /// to a displayable string only through their generic ToString method, with the
        /// exception of EmbedFieldBuilders.
        /// 
        /// If this collection is of EmbedFieldBuilder, then the pages will be displayed in
        /// batches of <see cref="PaginatedAppearanceOptions.FieldsPerPage"/>, and the
        /// embed's description will be populated with the <see cref="AlternateDescription"/> field.
        /// </summary>
        public IEnumerable<object> EmbedDescriptionOrEmbedFieldBuilder { get; set; }
        
        public IEnumerable<string> ImageUrls { get; set; }

        /// <summary>
        /// Content sets the content of the message, displayed above the embed. This may remain empty.
        /// </summary>
        public string Content { get; set; } = "";

        /// <summary>
        /// Author sets the <see cref="EmbedBuilder.Author"/> property directly.
        /// </summary>
        public EmbedAuthorBuilder Author { get; set; } = null;
        public Color Color { get; set; } = Color.Default;
        public string Title { get; set; } = "";
        /// <summary>
        /// AlternateDescription will be used as the description of the pager only when
        /// <see cref="EmbedDescriptionOrEmbedFieldBuilder"/> is a collection of <see cref="EmbedFieldBuilder"/>.
        /// </summary>
        public string AlternateDescription { get; set; } = "";

        public PaginatedAppearanceOptions Options { get; set; } = PaginatedAppearanceOptions.Default;
    }
}
