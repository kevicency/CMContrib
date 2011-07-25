using System;
using System.Collections.Generic;
using System.Linq;

namespace Caliburn.Micro.Contrib.Helper
{
    public class FileFilterCollection
    {
        private readonly IList<FilterBuilder> _filters = new List<FilterBuilder>();

        public string DefaultExtension { get; private set; }

        /// <summary>
        ///   Adds a filter for the given <paramref name = "extension" />. By default, the first filter will be the default in the dialog
        /// </summary>
        /// <param name = "extension">the file extension</param>
        /// <param name = "isDefault">sets this filter as the default filter in the dialog</param>
        /// <example>
        ///   AddFilter("xml")
        /// </example>
        /// <returns></returns>
        public FilterBuilder AddFilter(string extension, bool isDefault = false)
        {
            var filterBuilder = new FilterBuilder(this, extension);

            if (isDefault) _filters.Insert(0, filterBuilder);
            else _filters.Add(filterBuilder);


            if (String.IsNullOrEmpty(DefaultExtension) || isDefault) DefaultExtension = extension;

            return filterBuilder;
        }

        /// <summary>
        ///   Adds a filter for all files, i.e *.*
        /// </summary>
        /// <returns></returns>
        public FileFilterCollection AddAllFilesFilter(bool isDefault = false)
        {
            FilterBuilder filterBuilder = AddFilter("*", isDefault);
            filterBuilder.WithDescription("All Files");

            return this;
        }

        /// <summary>
        ///   Adds a filter for the list of given <paramref name = "extensions" />
        /// </summary>
        /// <param name = "extensions"></param>
        /// <returns></returns>
        public FilterBuilder AddFilter(params string[] extensions)
        {
            var filterBuilder = new FilterBuilder(this, extensions);
            _filters.Add(filterBuilder);

            return filterBuilder;
        }

        /// <summary>
        ///   Creates the filter expression for the dialog. If no filter was added, a filter expression for alles files will be returned.
        /// </summary>
        /// <returns></returns>
        public string CreateFilterExpression()
        {
            if (!_filters.Any()) return "All Files (*.*)|*.*";

            return string.Join("|",
                               _filters
                                   .Select(x => string.Format("{0}|{1}", x.Description, x.FilterExpression)));
        }

        #region Nested type: FilterBuilder

        public class FilterBuilder
        {
            public FilterBuilder(FileFilterCollection fileFilterCollection, params string[] extensions)
            {
                if (fileFilterCollection == null) throw new ArgumentNullException("FileFilterCollection may not be null");
                if (!extensions.Any() || extensions.All(String.IsNullOrWhiteSpace)) throw new ArgumentException("you must specify at least one extension");

                FileFilterCollection = fileFilterCollection;
                Extensions = extensions;
            }

            internal FileFilterCollection FileFilterCollection { get; private set; }
            internal string[] Extensions { get; private set; }
            internal string Description { get; private set; }

            internal string FilterExpression
            {
                get { return string.Join(";", Extensions.Select(x => string.Format("*.{0}", x))); }
            }

            /// <summary>
            ///   Sets the descripion of the filter. File extensions are automatically added to the description unless <paramref name = "appendExtensions" /> is false.
            /// </summary>
            /// <param name = "description">the description</param>
            /// <param name = "appendExtensions">append the extension(s) to the description?</param>
            /// <returns></returns>
            public FileFilterCollection WithDescription(string description, bool appendExtensions = true)
            {
                Description = description;

                if (appendExtensions) Description = AppendExtensions(Description);

                return FileFilterCollection;
            }

            /// <summary>
            ///   Creates a default description for the filter, i.e. 'Xml-File' for the extension 'xml'
            /// </summary>
            /// <returns></returns>
            public FileFilterCollection WithDefaultDescription()
            {
                string extensionString = string.Join(", ", Extensions.Select(Capitalize));
                Description = string.Format("{0}-Files", extensionString);

                return FileFilterCollection;
            }

            /// <summary>
            ///   Capitalizes a string
            /// </summary>
            /// <param name = "s"></param>
            /// <returns></returns>
            private static string Capitalize(string s)
            {
                if (String.IsNullOrWhiteSpace(s)) return s;
                if (s.Length == 1) return s.ToUpper();

                return s.Substring(0, 1).ToUpper() + s.Substring(1);
            }

            /// <summary>
            ///   Appends the extensions to a string
            /// </summary>
            /// <param name = "s"></param>
            /// <returns></returns>
            private string AppendExtensions(string s)
            {
                return s += string.Format(" ({0})", FilterExpression);
            }
        }

        #endregion
    }
}