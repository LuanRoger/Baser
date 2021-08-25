using Baser.Configuration.Sections;
using SerializedConfig.Types;

namespace Baser
{
    public class ConfigurationModel : IConfigurationModel
    {
        [Section]
        public DatabaseConnection DatabaseConnection { get; set; }
        
        [Section] 
        public LanguageSection LanguageSection { get; set; }
        
        [Section] 
        public UserSection userSection { get; set; }
        
        [Section] 
        public PrintSection printSection { get; set; }
    }
}