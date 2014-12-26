using System;

namespace EPM.Services
{
	public class SPServiceMockup
	{
		private string[,] _options;

		public string[,] Options {get { return _options; }}

		public SPServiceMockup ()
		{
			setOptions ();
		}

		private void setOptions(){
			int x = 4, y = 4;
			_options = new string[x, y];
			for (int c = 0; c < x; c++) {
				_options [c, 0] = "Option" + c;
				for (int s = 1; s < y; s++) {
					_options [c, s] = "Property" + s;
				}
			}
		}
	}
}

