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
            Widget box = new TextField(50, 50);

            Decorator decoBox = new BorderDecorator(new ScrollDecorator(new ButtonDecorator(box)));

            decoBox.draw();

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


        public virtual void draw()
        {
            wid.draw();
        }
      
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
            Console.WriteLine("I am a Textfield, holding a");
        }

        private int width;
        private int height;
    }

    class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget w) : base(w)
        {

        }

        public override void draw()
        {
            base.draw();
            Console.WriteLine("I am a border decorator, holding a");
        }
    }

    class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w)
        {

        }

        public override void draw()
        {
            base.draw();
            Console.WriteLine("I am a scroll decorator, holding a");
        }
    }

    class ButtonDecorator : Decorator
    {
        public ButtonDecorator(Widget w) : base(w)
        {

        }

        public override void draw()
        {
            base.draw();
            Console.WriteLine("I am a button decorator, holding a");
        }
    }
}
