using System.Reflection;
using AttributesDemo;

Console.WriteLine("Hello, World!");

Assembly.GetEntryAssembly()!.GetCustomAttributes(typeof(MappingDefinitionAttribute), false)
    .Cast<MappingDefinitionAttribute>()
    .ToList()
    .ForEach(att =>
    {
        // Do the mapping here
        Console.WriteLine(att);
    });
