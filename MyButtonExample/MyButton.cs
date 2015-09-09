using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyButtonExample
{

    public delegate void EventHandler(object sender, EventArgs args);

    class MyButton
    {

        public event EventHandler ClickEvent;

        public MyButton() { } // Constructor

        private void drawShape()
        {

            // ... Código

        } // drawShape

        public void actionClick()
        {

            Onclick(EventArgs.Empty);

        } // actionClick

        protected virtual void Onclick(EventArgs args)
        {

            if (ClickEvent != null)
            {

                ClickEvent(this, args);

            } // if

        } // OnClick

    } // MyButton

} // MyButtonExample
