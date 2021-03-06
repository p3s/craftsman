﻿namespace Craftsman.Removers
{
    using Craftsman.Helpers;
    using System;
    using System.IO;

    public class EntityRemover
    {
        public static void RemoveDirectory(string solutionDirectory)
        {
            var classPath = ClassPathHelper.EntityClassPath(solutionDirectory, ""); // deleting directory, so I don't need to give a meaningful filename

            if (!Directory.Exists(classPath.ClassDirectory))
                throw new DirectoryNotFoundException($"The `{classPath.ClassDirectory}` directory could not be found.");

            var dir = new DirectoryInfo(classPath.ClassDirectory);
            dir.Delete(true);
        }

        public static void Remove(string solutionDirectory, string filename)
        {
            var classPath = ClassPathHelper.EntityClassPath(solutionDirectory, filename);

            if (!Directory.Exists(classPath.ClassDirectory))
                throw new DirectoryNotFoundException($"The `{classPath.ClassDirectory}` directory could not be found.");

            if (!File.Exists(classPath.FullClassPath))
                throw new FileNotFoundException($"The `{classPath.FullClassPath}` file could not be found.");

            File.Delete(classPath.FullClassPath);
        }
    }
}