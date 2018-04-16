using System;

namespace PersonPresentation_DL.Model
{
    public class Person
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
