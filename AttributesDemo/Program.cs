using System.Reflection;
using AttributesDemo;
using AutoMapper;
using Contracts;
using Domains;

var configuration = new MapperConfiguration(configure =>
{
    configure.AllowNullCollections = true;
    configure.AllowNullDestinationValues = true;

    Assembly.GetEntryAssembly()
        !.GetCustomAttributes(typeof(MappingDefinitionAttribute), false)
        .Cast<MappingDefinitionAttribute>()
        .ToList()
        .ForEach(attribute =>
        {
            IMappingExpression mappingExpression = configure.CreateMap(attribute.From, attribute.To);

            if (mappingExpression != null && attribute.Reverse)
            {
                mappingExpression.ReverseMap();
            }
        });
});

var mapper = new Mapper(configuration);

var contract = new PaulContract
{
    Name = "Bah... Paul?",
    Age = 22
};

var domain = mapper.Map<PaulDomains>(contract);

Console.WriteLine(domain);
