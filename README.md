# PGPS

PGPS is a small utility for generating C# properties from simple text input.

## Status

This repository contains a legacy Windows Forms application originally created in 2006 and last updated in 2009.

It has not had an official public release yet.

The current goal of this repository is to preserve the original application while modernizing it toward a future release on a newer .NET platform.

## What It Does

Each line in the input becomes a property definition.

The original utility was designed to reduce the amount of repetitive code needed when creating C# properties, including support for:

- Choosing a default data type
- Carrying comments into generated code
- Setting default values
- Generating `get` / `set`
- Raising `PropertyChanged`

## Input Conventions

The generator uses the following conventions:

- If a line contains one word, that word becomes the property name and the default data type is `string`.
- If a line contains two words, the first word is treated as the data type and the second as the property name.
- If a line starts with XML documentation comments (`///`), that documentation is carried to the public property.
- If a line starts with a C# comment (`//`), that comment is carried to the private field.
- If a default value is provided, it is assigned to the private field.
- Private fields use the `_` prefix.

## When To Use It

If you only need to write one property, Visual Studio snippets are probably enough.

If you need to generate many properties at once, this utility was built to make that easier.

## Project History

- `2006-05-29`: Initial version created
- `2009-11-17`: Added `INotifyPropertyChanged` support

## Modernization Notes

The current repository includes newer root-level repository files and documentation as part of an ongoing cleanup and modernization effort.

That repository modernization does not yet reflect the application’s original runtime or project format, which is still legacy .NET / Windows Forms code.

## Future Direction

Possible future work includes:

- Migrating the application to a modern .NET version
- Exploring a newer UI stack such as WPF
- Considering broader platform support if the app evolves well
- Revisiting output styles and generation options
