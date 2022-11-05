﻿// Copyright (c) Avanade. Licensed under the MIT License. See https://github.com/Avanade/Beef

using Microsoft.Extensions.Logging;
using OnRamp.Config;
using OnRamp.Console;
using OnRamp.Utility;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;

namespace Beef.CodeGen
{
    /// <summary>
    /// Provides the console capabilities.
    /// </summary>
    public static class Program
    {
        private static readonly ILogger _logger = new ConsoleLogger(null);

        /// <summary>
        /// The main entry point.
        /// </summary>
        /// <param name="args">The console arguments.</param>
        /// <returns><b>Zero</b> indicates success; otherwise, unsuccessful.</returns>
        public static async Task<int> Main(string[] args)
        {
            // Check for special case / internal use arguments.
            if (args.Length == 1)
            {
                switch (args[0].ToUpperInvariant())
                {
                    case "--GENERATEENTITYJSONSCHEMA": return SpecialActivitiesCenter("Generate Entity JSON Schema", "./Schema/entity.beef.json", fn => JsonSchemaGenerator.Generate<Config.Entity.CodeGenConfig>(fn, "JSON Schema for Beef Entity code-generation (https://github.com/Avanade/Beef)."));
                    case "--GENERATEDATABASEJSONSCHEMA": return SpecialActivitiesCenter("Generate Database JSON Schema", "./Schema/database.beef.json", fn => JsonSchemaGenerator.Generate<Config.Database.CodeGenConfig>(fn, "JSON Schema for Beef Database code-generation (https://github.com/Avanade/Beef)."));
                    case "--GENERATEENTITYMARKDOWN": return SpecialActivitiesCenter("Generate Entity YAML documentation markdown file(s)", "../../docs/", dn => GenerateMarkdown<Config.Entity.CodeGenConfig>(dn, ConfigType.Entity));
                    case "--GENERATEDATABASEMARKDOWN": return SpecialActivitiesCenter("Generate Database YAML documentation markdown file(s)", "../../docs/", dn => GenerateMarkdown<Config.Database.CodeGenConfig>(dn, ConfigType.Database));
                }
            }

            var a = new OnRamp.CodeGeneratorArgs().AddAssembly(typeof(CodeGenConsole).Assembly).AddAssembly(Assembly.GetCallingAssembly());
            return await new CodeGenConsole(a).RunAsync(args).ConfigureAwait(false);
        }

        /// <summary>
        /// Manage/orchestrate the special activities execution.
        /// </summary>
        private static int SpecialActivitiesCenter(string title, string filename, Action<string> action)
        {
            // Method name inspired by: https://en.wikipedia.org/wiki/Special_Activities_Center
            _logger.LogInformation("{Content}", "Business Entity Execution Framework (Beef) Code Generator - ** Special Activities Center **");
            _logger.LogInformation("{Content}", $" Action: {title}");
            _logger.LogInformation("{Content}", $" Filename: {filename}");

            var sw = Stopwatch.StartNew();
            action(filename);
            sw.Stop();
            _logger.LogInformation("{Content}", "");
            _logger.LogInformation("{Content}", $"CodeGen complete [{sw.Elapsed.TotalMilliseconds}ms].");
            _logger.LogInformation("{Content}", "");
            return 0;
        }

        /// <summary>
        /// Invoke the <see cref="MarkdownDocumentationGenerator"/>.
        /// </summary>
        private static void GenerateMarkdown<T>(string directory, ConfigType configType) where T : ConfigBase, IRootConfig
            => MarkdownDocumentationGenerator.Generate<T>(createFileName: (_, cgca) => $"{configType}-{cgca.Name}-Config.md",
                directory: directory, includeExample: true, addBreaksBetweenSections: true, fileCreation: fn => _logger.LogWarning("{Content}", $" > {fn}"));
    }
}