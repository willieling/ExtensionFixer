using System;
using System.IO;

namespace ExtensionFixer
{
    public enum FileExtension
    {
        FileNotFound,
        UnsupportedFormat,
        gif,
        webp,
        webm,
        mpg,
        jpg,
        png,
        heic
    }

    internal static class FileAnalyzer
    {
        private const int EXTENSION_START_INDEX = 2;

        public static FileExtension GetTrueFileExtension(string filepath)
        {
            string? extResult = Path.GetExtension(filepath);
            if(string.IsNullOrEmpty(extResult))
            {
                return FileExtension.FileNotFound;
            }

            //remove dot prefix
            extResult = extResult.Remove(0, 1);

            foreach(FileExtension extension in Enum.GetValues(typeof(FileExtension)))
            {
                if(extension.ToString() == extResult)
                {
                    return extension;
                }
            }

            return FileExtension.UnsupportedFormat;
        }
    }
}
