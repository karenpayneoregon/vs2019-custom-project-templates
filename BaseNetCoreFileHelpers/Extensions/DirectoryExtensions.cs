using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BaseNetCoreFileHelpers.Extensions
{
	public static class DirectoryExtensions
	{
		public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo directoryInfo, params string[] extensions)
		{
			if (extensions == null)
			{
				throw new ArgumentNullException("extensions");
			}
			IEnumerable<FileInfo> files = directoryInfo.EnumerateFiles();
			return files.Where((f) => extensions.Contains(f.Extension));
		}

	}

}