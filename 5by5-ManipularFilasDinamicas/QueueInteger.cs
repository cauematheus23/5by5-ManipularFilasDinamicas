using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_ManipularFilasDinamicas
{
    internal class QueueInteger
    {
        int cont_pairs = 0, cont_impairs = 0;
        Integer head;
        Integer tail;

        public QueueInteger()
        {
            this.head = null;
            this.tail = null;
        }
        bool IsEmpty()
        {
            return head== null && tail == null;
        }
        public void Push(Integer aux)
        {
            if (aux.getNumber() % 2 == 0)
            {
                cont_pairs++;

            }
            else
            {
                cont_impairs++;
            }
            if (IsEmpty())
            {
                head = tail = aux;
            }
            else
            {
                this.tail.setNext(aux);
                tail = aux;
            }
        }
        public void Print()
        {
            Integer aux = head;
            if (IsEmpty())
            {
                Console.WriteLine("Empty queue, nothing for print");
            }
            else
            {
                do
                {
                    Console.Write(" " + aux.ToString());
                    aux = aux.getNext();
                    
                } while (aux != null);

                
            }
            Console.WriteLine();
        }
        public void CheckEqualSize(QueueInteger a, QueueInteger b)
        {
            int cont_a = 0, cont_b = 0;
            if (!IsEmpty())
            {
                for (Integer aux = a.head; aux != null; aux = aux.getNext())
                {
                    cont_a++;
                }
                for (Integer aux = b.head; aux != null; aux = aux.getNext())
                {
                    cont_b++;
                }
                Console.WriteLine("Size Queue 1: " + cont_a);
                Console.WriteLine("Size Queue 2: " + cont_b);
                if (cont_a == cont_b)
                {
                    Console.WriteLine("the queues are the same size");
                } else if(cont_a > cont_b)
                {
                    Console.WriteLine("queue 1 is bigger");
                }
                else
                {
                    Console.WriteLine("queue 2 is bigger");

                }
            }
            else
            {
                Console.WriteLine("queues empty, nothing for show!");
            }
        }
        public void BiggestSmallestArithmetic()
        {
            Integer aux = head;
            if (!IsEmpty())
            {
                int biggest = head.getNumber();
                int smallest = head.getNumber();
                double sum = 0, cont_queue = 0, arithmetic;
                for(int i = 0; i < 3; i++)
                {
                    aux = head;
                    int number = 0;
                    if (i == 0)
                    {
                        do
                        {
                            number = aux.getNumber();
                            if (biggest < number)
                            {
                                biggest = number;
                            }
                            aux = aux.getNext();
                        } while (aux != null) ;

                    } else if(i == 1)
                    {
                        smallest = aux.getNumber();
                        do
                        {
                            number = aux.getNumber();
                            if (smallest > number)
                            {
                                smallest = number;
                            }
                            aux = aux.getNext();

                        } while(aux != null) ;
                    }
                    else
                    {
                        for(aux = head; aux != null; aux = aux.getNext())
                        {
                            cont_queue++;
                            sum += aux.getNumber();
                        }
                    }
                }
                arithmetic = sum / cont_queue;
                Console.WriteLine("Biggest: " + biggest);
                Console.WriteLine("Smallest: " + smallest);
                Console.WriteLine("Arithmetic: " + arithmetic);
            }
            else
            {
                Console.WriteLine("Don't exist, because queue is empty!");
            }
        }
        public void TransferQueue(QueueInteger queueaux)
        {
            if (IsEmpty())
            {
                queueaux.head = queueaux.tail = null;
                
            }
            else
            {
                for (Integer aux = head; aux != null; aux = aux.getNext())
                {
                    Integer aux2 = new Integer(aux.getNumber());

                    if (queueaux.IsEmpty())
                    {
                        queueaux.head = queueaux.tail = aux2;
                    }
                    else
                    {
                        queueaux.tail.setNext(aux2);
                        queueaux.tail = aux2;
                    }

                }
            }
            queueaux.Print();

        }
        public void CheckPairsAndImpairs()
        {
            int[] pairs = new int[cont_pairs];
            int[] impairs = new int[cont_impairs];
            int cont_p = 0, cont_i = 0;
            if (!IsEmpty())
            {
                for (Integer aux = head; aux != null; aux = aux.getNext())
                {
                    if (aux.getNumber() % 2 == 0)
                    {
                        pairs[cont_p] = aux.getNumber();
                        cont_p++;
                    }
                    else
                    {
                        impairs[cont_i] = aux.getNumber();
                        cont_i++;
                    }
                }
                Console.WriteLine("Quantity of pairs: " + cont_p);
                Console.Write("Pairs: ");
                for (int i = 0; i < cont_p; i++)
                {
                    Console.Write(" " + pairs[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Quantity of impairs: " + cont_i);
                Console.Write("Impairs: ");
                for (int i = 0; i < cont_i; i++)
                {
                    Console.Write(" " + impairs[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("queue empty, nothing for show!");
            }
            
        }
    }
}
