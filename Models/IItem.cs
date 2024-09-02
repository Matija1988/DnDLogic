using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DnDLogic.Models
{
    public interface IItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
