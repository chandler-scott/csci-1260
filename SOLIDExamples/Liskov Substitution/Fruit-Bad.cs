using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution {
	internal class Apple {
		public virtual string GetColor() {
			return "Red";
		}
	}

	internal class Orange : Apple {
		public override string GetColor() {
			return "Orange";
		}
	}
}
