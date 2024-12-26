using CompiledQueriesWithEnumMarten6;
using JasperFx.CodeGeneration;
using Marten;
using Microsoft.Extensions.Hosting;
using Oakton;
using Weasel.Core;


var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddMarten(options =>
        {
            options.Connection("host=localhost;database=postgres;password=postgres;username=postgres");
            options.UseDefaultSerialization(enumStorage: EnumStorage.AsString, nonPublicMembersStorage: NonPublicMembersStorage.NonPublicSetters);

            options.Schema.For<Foo>();

            // Query to be generated
            options.RegisterCompiledQueryType(typeof(ActiveFooQuery));
        })
        .OptimizeArtifactWorkflow(TypeLoadMode.Auto);
    })
    .ApplyOaktonExtensions()
    .Build()
    .RunOaktonCommands(args);