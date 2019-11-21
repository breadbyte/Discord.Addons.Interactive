using System.Collections.Generic;

namespace Discord.Addons.Interactive
{
    public abstract class PaginatedMessage
    {
        public virtual List<object> Pages { get; set; }

        public virtual string Content { get; set; } = "";

        public virtual EmbedAuthorBuilder Author { get; set; } = null;
        public virtual Color Color { get; set; } = Color.Default;
        public virtual string Title { get; set; } = "";

        public virtual PaginatedAppearanceOptions Options { get; set; } = null;
    }
}
