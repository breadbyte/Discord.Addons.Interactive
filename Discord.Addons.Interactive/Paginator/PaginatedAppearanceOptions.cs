using System;

namespace Discord.Addons.Interactive
{
    public abstract class PaginatedAppearanceOptions
    {
        public virtual IEmote First{ get; set; } =  new Emoji("⏮");
        public virtual IEmote Back { get; set; } = new Emoji("◀");
        public virtual IEmote Next { get; set; } = new Emoji("▶");
        public virtual IEmote Last { get; set; } = new Emoji("⏭");
        public virtual IEmote Stop { get; set; } = new Emoji("⏹");
        public virtual IEmote Jump { get; set; } = new Emoji("🔢");
        public virtual IEmote Info { get; set; } = new Emoji("ℹ");

        public virtual string FooterFormat { get; set; } = "Page {0}/{1}";
        public virtual string InformationText { get; set; }= "This is a paginator. React with the respective icons to change page.";

        public virtual JumpDisplayOptions JumpDisplayOptions { get; set; }= JumpDisplayOptions.WithManageMessages;
        public virtual bool DisplayInformationIcon { get; set; } = true;

        public virtual TimeSpan? Timeout { get; set; }= null;
        public virtual TimeSpan InfoTimeout { get; set; }= TimeSpan.FromSeconds(30);
    }

    public enum JumpDisplayOptions
    {
        Never,
        WithManageMessages,
        Always
    }
}
