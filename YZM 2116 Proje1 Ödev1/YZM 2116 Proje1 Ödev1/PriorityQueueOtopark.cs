using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM_2116_Proje1_Ödev1
{
    public class PriorityQueueOtopark : IQueueOtopark
    {
        public Araba[] _PriorityQueueOtopark;
        private int front = -1;
        private int size = 0;
        private int sayac = 0;

        public PriorityQueueOtopark(int size)
        {
            this.size = size;
            _PriorityQueueOtopark = new Araba[size];
        }
        public void Insert(Araba a)
        {
            if (sayac == size)
            {
                throw new Exception("Otopark Dolu");
            }

            if (IsEmpty())
            {
                front++;
                _PriorityQueueOtopark[front] = a;
                sayac++;
            }
            else
            {
                int i;
                for (i = sayac - 1; i >= 0; i--)
                {
                    if (_PriorityQueueOtopark[i].Zaman > a.Zaman)
                        _PriorityQueueOtopark[i + 1] = _PriorityQueueOtopark[i];
                    else
                        break;
                }
                _PriorityQueueOtopark[i + 1] = a;

                sayac++;
            }
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Otopark boş");
            }
            object temp = _PriorityQueueOtopark[front];
            _PriorityQueueOtopark[front] = null;
            front++;
            sayac--;
            return temp;
        }

        public object Peek()
        {
            return _PriorityQueueOtopark[front];
        }

        public bool IsEmpty()
        {
            return (sayac == 0);
        }

        public void Insert(object a)
        {
            throw new NotImplementedException();
        }
    }
}
