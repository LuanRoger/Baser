using Baser.Enum;

namespace Baser.Configuration.Sections
{
    public record UserSection
    {
        public string userName { get; set; }
        public UserType userType { get; set; }
    }
}