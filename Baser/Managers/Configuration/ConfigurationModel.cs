using Baser.Managers.Configuration.Sections;
using SerializedConfig.SectionsAtribute;
using SerializedConfig.Types;

namespace Baser.Managers.Configuration
{
    [SectionClass]
    public class ConfigurationModel : IConfigurationModel
    {
        public DatabaseConnection DatabaseConnection { get; set; }
        public LanguageSection LanguageSection { get; set; }
        public UserSection userSection { get; set; }
        public PrintSection printSection { get; set; }
    }
}