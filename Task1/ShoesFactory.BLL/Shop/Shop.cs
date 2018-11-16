using System;
using System.Collections.Generic;
using System.Collections;

namespace ShoesFactory.BLL
{
    public class Shop : ICollection<Shoes>, IShoesSearchable
    {
      
            // The inner collection to store objects.
            private List<Shoes> innerCol;

            public Shop()
            {
                innerCol = new List<Shoes>();
            }
            // search by speed
          /*  public IEnumerable<Car> Search(SearchCarModel model)
            {
                if (model == null)
                {
                    return innerCol;
                }

                return innerCol.Where(x => x.MaxSpeed >= model.FromSpeed && x.MaxSpeed <= model.ToSpeed);
            }
            //get sum of car parc
            public double Sum { get { return innerCol.Sum(x => x.Price); } }
            //sort by Consumption
            public IEnumerable<Car> Sort(SortType sort = SortType.Asc)
            {
                return sort == SortType.Asc ? innerCol.OrderBy(x => x.Consumption) : innerCol.OrderByDescending(x => x.Consumption);
            }*/

            #region Implementation ICollection

            public IEnumerator<Shoes> GetEnumerator()
            {
                return new ShoesEnumerator(this);
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return new ShoesEnumerator(this);
            }
           // */
            // Adds an index to the collection.
            public Shoes this[int index]
            {
                get { return (Shoes)innerCol[index]; }
                set { innerCol[index] = value; }
            }

            // Determines if an item is in the collection
            // by using the CarSameDimensions equality comparer.
            public bool Contains(Shoes item)
            {
                bool found = false;

                foreach (Shoes bx in innerCol)
                {
                    // Equality defined by the Car
                    // class's implmentation of IEquitable<T>.
                    if (bx.Equals(item))
                    {
                        found = true;
                    }
                }

                return found;
            }

            // Determines if an item is in the 
            // collection by using a specified equality comparer.
            public bool Contains(Shoes item, EqualityComparer<Shoes> comp)
            {
                bool found = false;

                foreach (Shoes bx in innerCol)
                {
                    if (comp.Equals(bx, item))
                    {
                        found = true;
                    }
                }

                return found;
            }

            // Adds an item if it is not already in the collection
            // as determined by calling the Contains method.
          /*  public void Add(Shoes item)
            {

                if (!Contains(item))
                {
                    innerCol.Add(item);
                }
                else
                {
                    Console.WriteLine("A Car with {0}x{1}x{2} dimensions was already added to the collection.",
                        item.Name.ToString(), item.ReleaseYear.ToString(), item.MaxSpeed.ToString());
                }

            }*/

            public void Clear()
            {
                innerCol.Clear();
            }

            public void CopyTo(Shoes[] array, int arrayIndex)
            {
                if (array == null)
                    throw new ArgumentNullException("The array cannot be null.");
                if (arrayIndex < 0)
                    throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
                if (Count > array.Length - arrayIndex + 1)
                    throw new ArgumentException("The destination array has fewer elements than the collection.");

                for (int i = 0; i < innerCol.Count; i++)
                {
                    array[i + arrayIndex] = innerCol[i];
                }
            }

            public int Count
            {
                get
                {
                    return innerCol.Count;
                }
            }

            public bool IsReadOnly
            {
                get { return false; }
            }

            public bool Remove(Shoes item)
            {
                bool result = false;

                // Iterate the inner collection to 
                // find the Car to be removed.
                for (int i = 0; i < innerCol.Count; i++)
                {

                    Shoes curCar = (Shoes)innerCol[i];

                    if (new ShoesComparer().Equals(curCar, item))
                    {
                        innerCol.RemoveAt(i);
                        result = true;
                        break;
                    }
                }
                return result;
            }

        public IEnumerator<Shoes> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(Shoes item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Shoes> Search(SearchShoesModel model)
        {
            throw new NotImplementedException();
        }


}
}
