using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class DecoratorDemo
    {
        static void Main(string[] args)
        {
            Widget demo;

            TextField box = new TextField(50, 50);
            BorderDecorator boxBorder = new BorderDecorator(box);
            ScrollDecorator boxScroll = new ScrollDecorator(boxBorder);
            ButtonDecorator boxButton = new ButtonDecorator(boxScroll);

            boxScroll.draw();

            Console.ReadKey();
        }
    }

    interface Widget
    {
        void draw();
    }

    abstract class Decorator : Widget
    {
        public Decorator(Widget w)
        {
            wid = w;
        }


        abstract public void draw();
      
        private Widget wid;
    }

    class TextField : Widget
    {
        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }

        public void draw()
        {
            Console.WriteLine("I am a Textfield ");
        }

        private int width;
        private int height;
    }

    class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget w) : base(w)
        {

        }

        override public void draw()
        {
            Console.WriteLine("I am a border decorator");
        }
    }

    class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w)
        {

        }

        override public void draw()
        {
            Console.WriteLine("I am a scroll decorator");
        }
    }

    class ButtonDecorator : Decorator
    {
        public ButtonDecorator(Widget w) : base(w)
        {

        }

        override public void draw()
        {
            Console.WriteLine("I am a button decorator");
        }
    }
}
