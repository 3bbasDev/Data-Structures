namespace Stack
{
    public class Stack<T>
    {
        private int top;
        private T[] item;
        private int stachSize = 0;
        public Stack(int stachSize)
        {
            this.stachSize = stachSize;
            item = new T[stachSize];
            top = -1;
        }

        public void Puch(T element)
        {
            if (top >= stachSize - 1)
                Console.WriteLine("Stack full on push");
            else
            {
                top++;
                item[top] = element;
            }
        }
        public bool IsEmpty() => top < 0;

        public void Pop()
        {
            if (IsEmpty())
                Console.WriteLine("Stack empty on pup");
            else top--;
        }
        public void Pop(ref T element)
        {
            if (IsEmpty())
                Console.WriteLine("Stack empty on pup");
            else
            {
                element = item[top];
                top--;
            }
        }

        public void GetTop(ref T stackTop)
        {
            if (IsEmpty())
                Console.WriteLine("Stack empty on pup");
            else
            {
                stackTop = item[top];
                Console.WriteLine(stackTop);
            }
        }
        public void Print()
        {
            Console.Write("[");
            for (int i = top; i >= 0; i--)
            {
                Console.Write(item[i] + " ");
            }
            Console.WriteLine("]");
        }
    }
}