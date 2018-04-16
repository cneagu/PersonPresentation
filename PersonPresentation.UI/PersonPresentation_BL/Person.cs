using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPresentation_BL
{
    public struct PersonS
    {
        #region Properties
        public string CNP { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        #endregion
    }
}
