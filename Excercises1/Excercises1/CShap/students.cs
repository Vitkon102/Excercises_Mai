using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercises1.CShap
{
    class students
    {
        private string _name;
        public string Name
    { get
    { 
        return "Sinh Viên" + this._name;
    }
      set
        { this._name = value; }
      }
    }  
}
