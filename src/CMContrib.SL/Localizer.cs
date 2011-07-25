using System;
using System.Linq;
using System.Resources;
using Caliburn.Micro.Contrib.Properties;

namespace Caliburn.Micro.Contrib
{
    public static class Localizer
    {
        public static Func<Enum, string> LocalizeEnum =
            enumValue =>
            {
                var enumName = enumValue.GetType().Name;

                return GetString(GetEnumKey(enumName, enumValue.ToString())) ?? enumValue.ToString();
            };

        public static Func<Enum, string> LocalizeFlag =
            flag =>
            {
                var enumName = flag.GetType().Name;
                const char seperator = ',';

                var flags = flag.ToString()
                    .Split(seperator)
                    .Select(x => GetString(GetEnumKey(enumName, x.Trim())) ?? x)
                    .ToArray();

                return String.Join(seperator + " ", flags);
            };

        static Localizer()
        {
            UseFallback = true;
        }

        /// <summary>
        ///   When TRUE and the ResourceManager returns null for a given key, the DefaultResourceManager is used
        /// </summary>
        public static bool UseFallback { get; set; }

        /// <summary>
        ///   The default CMContrib Resource Manager
        /// </summary>
        public static ResourceManager DefaultResourceManager
        {
            get { return CMContrib.ResourceManager; }
        }

        /// <summary>
        ///   A custom Resource Manager
        /// </summary>
        public static ResourceManager CustomResourceManager { get; set; }

        public static string GetString(string key)
        {
            if (CustomResourceManager != null)
            {
                var value = CustomResourceManager.GetString(key);
                return value ?? (UseFallback ? DefaultResourceManager.GetString(key) : null);
            }
            else
            {
                return DefaultResourceManager.GetString(key);
            }
        }

        public static object GetObject(string key)
        {
            object value = null;

            if (CustomResourceManager != null)
            {
                value = CustomResourceManager.GetObject(key);
            }

            return value ?? (UseFallback ? DefaultResourceManager.GetObject(key) : null);
        }

        private static string GetEnumKey(string enumName, string enumValue)
        {
            return string.Format("{0}_{1}", enumName, enumValue);
        }
    }
}