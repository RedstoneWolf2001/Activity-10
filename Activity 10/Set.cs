using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
namespace CST117_IC08_console
{
	class Set
	{
		private List<int> elements;


		public Set()
		{
			elements = new List<int>();
		}

		public bool addElement(int val)
		{
			if (containsElement(val)) return false;
			else
			{
				elements.Add(val);
				return true;
			}
		}

		private bool containsElement(int val)
		{
			for (int i = 0; i < elements.Count; i++)
			{
				if (val == elements[i])
					return true;
				//These lines are not needed because it will return false at the end of the loop.
				//else
					//return false;
			}
			return false;
		}

		public override string ToString()
		{
			string str = "";
			foreach (int i in elements)
			{
				str += i + " ";
			}
			return str;
		}

		public void clearSet()
		{
			elements.Clear();
		}

		public Set union(Set rhs)
		{
			//Swapped 'rhs' and 'this' - This sets the union up properly
			//for (int i = 0; i < rhs.elements.Count; i++)
			for (int i = 0; i < this.elements.Count; i++)
			{
				//this.addElement(rhs.elements[i]);
				rhs.addElement(this.elements[i]);
			}
			return rhs;
		}
	}
}

