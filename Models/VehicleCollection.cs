using System.Collections;

namespace TRPO1.Models;

static class VehicleCollection
{
    public class NonGeneric : IEnumerable
    {
        private SortedList Vehicles { get; set; } = new();

        public object this[int key]
        {
            get => Vehicles[key]!;
            set => Vehicles[key] = value;
        }

        public void Add(object key, object value) => Vehicles.Add(key, value);

        public IEnumerator GetEnumerator() => Vehicles.GetEnumerator();
    }

    public class Generic<TKey> : IEnumerable<KeyValuePair<TKey, Vehicle>> where TKey : notnull
    {
        private SortedList<TKey, Vehicle> Vehicles { get; set; } = new();

        public virtual Vehicle this[TKey key]
        {
            get => Vehicles[key];
            set => Vehicles[key] = value;
        }

        public void Add(TKey key, Vehicle value) => Vehicles.Add(key, value);

        IEnumerator<KeyValuePair<TKey, Vehicle>> IEnumerable<KeyValuePair<TKey, Vehicle>>.GetEnumerator() => Vehicles.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Vehicles.GetEnumerator();
    }
}