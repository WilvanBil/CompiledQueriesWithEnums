# CompiledQueriesWithEnums

## Intro

When [pre-generating types](https://martendb.io/configuration/prebuilding.html#pre-building-generated-types) a compiled query with an enum, the outputted generated code gives errors. This only happens in Marten 7. In Marten 6 there is no issue.
`dotnet run -- codegen write` is the command to be executed if you want to test it.

## CompiledQueriesWithEnumMarten6
This project contains Marten `6.4.2`. When executing the command the compiledquery types will generate correctly.

## CompiledQueriesWithEnums
This project contains Marten `7.34.1`. When executing the command the compiledquery will generate, however it will have errors.
![image](https://github.com/user-attachments/assets/6877f182-2183-4ce9-b61a-32e4e4a86195)
![image](https://github.com/user-attachments/assets/9ece365b-8465-4aa9-bd18-09e0a6990cee)
