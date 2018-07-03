using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public class EventRaiser
    {
        public event EventHandler<Event> RaiseCustomEvent;

        public void RaiseIt()
        {
            EventHandler<Event> handler = RaiseCustomEvent;
            handler(this,new Event("Strawfest"));
        }
    }
}
