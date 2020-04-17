using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGUI.EventsLib
{
    public class FilterChangeEventArgs : EventArgs
    {
        public string Param { get; internal set; }
        public string Name { get; internal set; }

        public FilterChangeEventArgs(string paramValue, string name)
        {
            Param = paramValue;
            Name = name;
        }
    }
    public class DeleteChangeEventArgs : EventArgs
    {
        public string Param { get; internal set; }
        public string Name { get; internal set; }

        public DeleteChangeEventArgs(string paramValue, string name)
        {
            Param = paramValue;
            Name = name;
        }
    }
}
