using System;

namespace BaseNetCoreFileHelpers
{
	public class DirectoryItem
	{
		public string Name {get; set;}
		public string Location {get; set;}
		public DateTime Modified {get; set;}
		public string[] ItemArray
		{
			get
			{
				return new[] {Location, Name, Modified.ToShortDateString()};
			}
		}
		public override string ToString() => Name;
    }

}