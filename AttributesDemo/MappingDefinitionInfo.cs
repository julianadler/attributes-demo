using AttributesDemo;
using Contracts;
using Domains;

[assembly: MappingDefinition(typeof(PaulContract), typeof(PaulDomains))]
