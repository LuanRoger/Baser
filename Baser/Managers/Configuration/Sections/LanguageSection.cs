using Baser.Enum;

namespace Baser.Managers.Configuration.Sections
{
    public record LanguageSection
    {
        public LanguageCode langCode { get; set; }
    }
}