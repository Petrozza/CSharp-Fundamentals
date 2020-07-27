using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> seq = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            int sumRemoved = 0;
            int sumRemovedLeft = 0;
            int sumRemovedRight = 0;

            while (seq.Count > 0)
            {
                if (index < 0)
                {
                    int removedLeft = seq[0];
                    seq.RemoveAt(0);
                    sumRemoved += removedLeft;
                    seq.Insert(0, seq[seq.Count - 1]);

                    CopyElements(seq, removedLeft);

                    index = int.Parse(Console.ReadLine());
                    continue;
                }

                if (index > seq.Count - 1)
                {
                    int removedRight = seq[seq.Count - 1];
                    seq.RemoveAt(seq.Count - 1);
                    sumRemovedRight += removedRight;
                    seq.Add(seq[0]);

                    CopyElements(seq, removedRight);

                    index = int.Parse(Console.ReadLine());
                    continue;
                }


                int removed = seq[index];
                seq.RemoveAt(index);
                sumRemoved += removed;

                CopyElements(seq, removed);

                if (seq.Count <= 0)
                {
                    break;
                }

                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sumRemoved + sumRemovedLeft + sumRemovedRight);
        }

        static void CopyElements(List<int> seq, int removed)
        {
            for (int i = 0; i < seq.Count; i++)
            {
                if (seq[i] <= removed)
                {
                    seq[i] += removed;
                }
                else
                {
                    seq[i] -= removed;
                }
            }
        }
    }
}
