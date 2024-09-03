using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic
{
    public class Game
    {
        private bool _end
        {
            get { return _end; }
            set { this._end = value; }
        }


        private void InitVariable ()
        {
            this._end = false;
        }

        public Game ()
        {
            this.InitVariable();

        }

        public void Run ()
        {
            while (this._end == false)
            {

            }

            Console.WriteLine("Ending game .... ");
        }
    }
}
