using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed
{
    public abstract class Print
    {
        static int windowHeight = 30;
        static int windowWidth = 80;

        public virtual void PrintOnPosition(int left, int top, string message)
        {
            Console.SetCursorPosition(left, top);

            Console.Write(message);
        }

        public virtual void PrintInCenter(string message, int verticalPosition)
        {
            int horisontalPosition = (windowWidth - message.Length) / 2;

            this.PrintOnPosition(horisontalPosition, verticalPosition, message);
        }

        public virtual void PrintWithAlignment(string message, int verticalPosition, int leftAlignment)
        {
            int horisontalPosition = (windowWidth - leftAlignment) / 2;

            this.PrintOnPosition(horisontalPosition, verticalPosition, message);
        }
    }
}
