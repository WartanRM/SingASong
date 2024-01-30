using System;
namespace noti;

public interface INoti
{
		public string To { get; set; };
		public string From { get; set; };
		public string msg { get; set; };
}
