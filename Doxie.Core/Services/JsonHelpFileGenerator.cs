﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using Doxie.Core.Models;
using Doxie.Core.XmlComments;
using Extenso;

namespace Doxie.Core.Services
{
    /// <summary>
    /// The json help file generator.
    /// </summary>
    public static class JsonHelpFileGenerator{
        private static DocParser docParser = new DocParser();

        public static void Generate(IEnumerable<string> selectedAssemblyPaths, string outputPath, string file_Name){
                string file = file_Name;
                var assemblies = GetAssemblies(selectedAssemblyPaths);
                string outputFileName = Path.Combine(outputPath, file + ".json");
                assemblies.JsonSerialize().ToFile(outputFileName);
        }

        private static IEnumerable<AssemblyModel> GetAssemblies(IEnumerable<string> selectedAssemblyPaths){
            return selectedAssemblyPaths.Select(filePath => GetAssembly(filePath)).ToArray();
        }

        private static AssemblyModel GetAssembly(string filePath){
            var assembly = docParser.Parse(filePath);
            assembly.FileName = filePath;
            return assembly;
        }
    }
}