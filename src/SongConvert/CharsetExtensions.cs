using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WindowsApplication1
{
    internal static class CharsetExtensions
    {
        private static readonly Dictionary<char, char> MappingDictionary;

        static CharsetExtensions()
        {
            var conversionTable = File.ReadAllLines("ConversionTable.txt");
            var originalCharacters = conversionTable[0];
            var garbledCharacters = conversionTable[1];

            MappingDictionary = new Dictionary<char, char>();
            for (var j = 0; j < originalCharacters.Length; j++)
            {
                MappingDictionary.Add(garbledCharacters[j], originalCharacters[j]);
            }
        }

        public static string Ungarble(this string garbled)
        {
            var builder = new StringBuilder();
            foreach (var c in garbled)
            {
                builder.Append(MappingDictionary.ContainsKey(c) ? MappingDictionary[c] : c);
            }

            return builder.ToString();
        }
    }
}