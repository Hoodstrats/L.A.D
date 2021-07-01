/* https://twitter.com/HoodStrats || https://github.com/Hoodstrats */

using System.Windows.Forms;

namespace Hood.Core
{
    public static class ErrorCatcher
    {
        static ErrorProvider _error = new ErrorProvider();

        public static void Debug(Control c)
        {
            if (c.Name == "_farmNameInput")
            {
                _error.SetIconAlignment(c, ErrorIconAlignment.TopRight);
                _error.SetError(c, "Can't Farm Nothing...Wait.");
            }
            else if (c.Name == "_openLog")
            {
                _error.SetIconAlignment(c, ErrorIconAlignment.TopLeft);
                _error.SetError(c, "No Log currently exists.");
            }
        }

        public static void Clear()
        {
            _error.Clear();
        }
    }
}
