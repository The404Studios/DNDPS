using System;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

public class ConfigLoader1
{
    public Config LoadConfig(string filePath)
    {
        var yaml = File.ReadAllText(filePath);
        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(new CamelCaseNamingConvention())
            .Build();

        var config = deserializer.Deserialize<Config>(yaml);

        // Perform validation
        ValidateConfig(config);

        return config;
    }

    private void ValidateConfig(Config config)
    {
        if (config.GameSettings.StartingLevel < 1)
        {
            throw new InvalidOperationException("StartingLevel must be greater than 0.");
        }

        // Add other validation logic as needed
    }
}
