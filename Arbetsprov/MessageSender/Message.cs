using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSender
{
    class Message

    {

        public string Text
        {
            get;
            set;
        }
        
        
        public DateTime Time
        {
            get;
            set;
        }
        public Message(string text, DateTime time) 
        {
            this.Text = text;
            this.Time = time;
        }
    }
}
