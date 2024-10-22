using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BOOPM3_08_05a
{
    public class csPasswordManager
    {
		string _password1 = null;
		public string Password1 => _password1;

		string _password2 = null;
		public string Password2 => _password2;

		static csPasswordManager _singleton = null;
        public csPasswordManager ()
        {
			//Connecting to Azure Key Vault to read the passwords.
			//It takes time, which I simulate with 10sec delay
			Thread.Sleep(5000);
			_password1 = "Bullibompa1";
			_password2 = "MupparnasJulmiddag1";
		}

		public static csPasswordManager Instance { get
        {
			if (_singleton == null)
            {
				_singleton = new csPasswordManager();
            }
			return _singleton;
        }}
	}
}
