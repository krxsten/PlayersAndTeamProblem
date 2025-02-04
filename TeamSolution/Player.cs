using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TeamSolution
{
    public class Player:IPlayer
    {
		private string name;

		public string Name
		{
			get { return name; }
			set 
            {
                if (value==string.Empty)
                {
                    throw new ArgumentException("Name shouldn't be null");
                }
                name = value;
            }
		}
		private string position;

		public string Position
		{
			get { return position; }
			set 
			{
                if (value == string.Empty)
                {
                    throw new ArgumentException("Position shouldn't be null");
                }
                position = value;
			}
		}
        public Player(string name, string position)
        {
            Name = name;
            Position = position;
        }
    }
}
