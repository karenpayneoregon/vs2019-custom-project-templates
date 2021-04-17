using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BaseNetCoreFileHelpers.Extensions;

namespace BaseNetCoreFileHelpers
{
	public class OperationsListView
	{
		/// <summary>
		/// Container for files containing SearchText
		/// </summary>
		public static List<FoundFile> FoundFileList = new();

		public delegate void OnTraverseFolder(DirectoryItem information);
		/// <summary>
		/// Callback for when a folder is being processed
		/// </summary>
		public static event OnTraverseFolder OnTraverseEvent;

		/// <summary>
		/// For traversing folders, if a cancellation is requested stop processing folders.
		/// </summary>
		public static bool Cancelled = false;

		/// <summary>
		/// Text to search for in files
		/// </summary>
		public static string SearchText;

		public static async Task RecursiveFolders(DirectoryInfo directoryInfo, CancellationToken ct, string fileType = "*.txt")
		{

			if (!directoryInfo.Exists)
			{
				return;
			}

			//
			// Let's say you are traversing folders with Git repositories, we don't
			// want to include their folders.
			//
			if (!directoryInfo.FullName.ContainsAny(".git", "\\obj"))
			{

				var di = new DirectoryItem
				{
					Location = Path.GetDirectoryName(directoryInfo.FullName),
					Name = directoryInfo.Name,
					Modified = directoryInfo.CreationTime
				};

				IterateFilesMultipleExtensions(di.Location);

                OnTraverseEvent?.Invoke(di);

            }

			await Task.Delay(1);

			DirectoryInfo folder = null;

			try
			{

				await Task.Run(async () =>
				{
							   foreach (var dir in directoryInfo.EnumerateDirectories())
							   {

								   folder = dir;

								   if (!Cancelled)
								   {

									   IterateFilesMultipleExtensions(dir.FullName);
									   await Task.Delay(1);
									   await RecursiveFolders(folder, ct);

								   }
								   else
								   {
									   return;
								   }

								   if (ct.IsCancellationRequested)
								   {
									   ct.ThrowIfCancellationRequested();
								   }

							   }
				});

			}
			catch (Exception ex)
			{
				//
				// Operations.RecursiveFolders showed how to recognize
				// folders that access has been denied, here these exceptions
				// are ignored. A developer can integrate those exceptions here
				// if so desired.
				//
				if (ex is OperationCanceledException)
				{

					Cancelled = true;

				}
			}

		}
		public static void IterateFilesMultipleExtensions(string folderName, params string[] extensions)
		{

			if (string.IsNullOrWhiteSpace(SearchText))
			{
				return;
			}


			var dInfo = new DirectoryInfo(folderName);
			var files = dInfo.GetFilesByExtensions(extensions).Select((item) => item.Name).ToArray();

            if (files.Length <= 0) return;
            
            foreach (string fileName in files)
            {
                FoundFileList.Add(new FoundFile() {FileName = fileName});
            }

        }
	}
}