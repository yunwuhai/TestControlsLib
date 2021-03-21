using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoControls
{
    public class TestEventArgs : EventArgs
    {
        public TestEventArgs(object value)
        {
            Value = value;
        }

        public object Value { get; set; }
    }
}
