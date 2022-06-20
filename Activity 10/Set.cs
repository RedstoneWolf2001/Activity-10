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
				//These lines are not valid since it will return false if and only if all the elements have been checked.
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
			//Added an extra set to keep the working set pure
			Set hold = new Set();
			for (int i =0; i < elements.Count; i++)
            {
				hold.elements.Add(elements[i]);
            }
			//

			for (int i = 0; i < rhs.elements.Count; i++)
			{
				hold.addElement(rhs.elements[i]);
			}

			//Removed 'rhs' and added the hold set to 
			//return rhs
			return hold;
		}
	}
}

