using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

ObservableCollection<int> ints = new ObservableCollection<int>()
{
    1, 2, 3, 4, 5
};
ints.CollectionChanged += IntsChanged;

ints.Add(10);
ints.Add(20);
ints.RemoveAt(3);


static void IntsChanged(object sender, NotifyCollectionChangedEventArgs eventArgs)
{
    Console.WriteLine("Action for this event: {0}", eventArgs.Action);

    switch (eventArgs.Action)
    {
        case NotifyCollectionChangedAction.Remove:
            Console.WriteLine("Here are the OLD items:");
            foreach (var e in eventArgs.OldItems)
            {
                Console.WriteLine(e);
            }

            break;
        case NotifyCollectionChangedAction.Add:
            Console.WriteLine("Here are the NEW itesm:");
            foreach (var e in eventArgs.NewItems)
            {
                Console.WriteLine(e);
            }

            break;
    }
}