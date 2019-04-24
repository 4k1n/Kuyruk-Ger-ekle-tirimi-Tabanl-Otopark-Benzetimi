using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM_2116_Proje1_Ödev1
{
    public class SimpleQueueOtopark : IQueueOtopark
    {
        public Araba[] _SimpleQueueOtopark;
        public int front = -1;
        public int rear = -1;
        public int size = 0;
        public int sayac = 0;

        public SimpleQueueOtopark(int size)
        {
            this.size = size;
            _SimpleQueueOtopark = new Araba[size];
        }

        public void Insert(Araba a)
        {
            if (front == -1)
                front = 0;

            _SimpleQueueOtopark[++rear] = a;
            sayac++;            
        }

        public object Remove()
        {
            if (IsEmpty())
                return "Otopark boş";

            object temp = _SimpleQueueOtopark[front];

            _SimpleQueueOtopark[front] = null;

            front++;
            sayac--;
            return temp;
        }
        public bool IsEmpty()
        {
            return sayac == 0;
        }

        public object Peek()
        {
            return _SimpleQueueOtopark[front];
        }

        public void Insert(object a)
        {
            throw new NotImplementedException();
        }
    }
}
