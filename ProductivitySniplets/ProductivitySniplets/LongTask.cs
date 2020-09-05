using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivitySniplets
{
    public class LongTask
    {
        //Create a delegate
        public delegate void CallBack(int i);

        //Pass the delegate and invoke the callback
        public void RunLongTask(CallBack callBack)
        {
            for(var i=0; i<5; i++)
            {
                callBack(i);
            }
        }
    }
}
