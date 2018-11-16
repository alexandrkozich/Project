using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ShoesFactory.BLL
{
    public class ShoesEnumerator : IEnumerator<Shoes>
    {
       
        

            private Shoes _collection;
            private int curIndex;
            private Shoes curShoes;


            public ShoesEnumerator(Shop collection)
            {
                _collection = collection;
                curIndex = -1;
                curShoes = default(Shoes);

            }

            public bool MoveNext()
            {
                //Avoids going beyond the end of the collection.
                if (++ curIndex >= _collection.Count)
                {
                    return false;
                }
                else
                {
                    // Set current Car to next item in collection.
                    curShoes = _collection[curIndex];
                }
                return true;
            }

            public void Reset() { curIndex = -1; }

            void IDisposable.Dispose() { }

            public Shoes Current
            {
                get { return curShoes; }
            }


            object IEnumerator.Current
            {
                get { return Current; }
            }

        object IEnumerator.Current => throw new NotImplementedException();

        public Shoes Collection { get => _collection; set => _collection = value; }

        // }
    }
}
