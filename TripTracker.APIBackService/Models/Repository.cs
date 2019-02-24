using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.APIBackService.Models
{
    public class Repository : System.Collections.IList
    {
        private List<Trip> TripsList = new List<Trip>
        {
            new Trip
            {
                Id = 1,
                Name = "MVP Summit",
                StartDate = new DateTime(2018, 3, 5),
                EndDate = new DateTime(2018, 3, 8)
            },
            new Trip
            {
                Id = 1,
                Name = "Devintersection some place",
                StartDate = new DateTime(2018, 3, 25),
                EndDate = new DateTime(2018, 3, 28)
            },
            new Trip
            {
                Id = 1,
                Name = "Build 2018",
                StartDate = new DateTime(2018, 5, 25),
                EndDate = new DateTime(2018, 5, 28)
            }
        };

        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsFixedSize => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public List<Trip> GetTrips()
        {
            return TripsList;
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            TripsList.Remove(TripsList.First(t => t.Id == id));
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// This is a summary
        /// </summary>
        /// <param name="tripToUpdate">Object of type Trip</param>
        public void Update(Trip tripToUpdate)
        {
            
            TripsList.Remove(TripsList.FirstOrDefault(t => t.Id == tripToUpdate.Id));
            Add(tripToUpdate);
        }
    }
}