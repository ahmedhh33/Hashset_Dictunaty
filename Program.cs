namespace Hashset_Distionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();//Set dosnot have doublicate and its umorder
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(1);
            set.Add(2);

            foreach (int i in set)
            {
                System.Console.WriteLine(i);//it will not print the doublicate
            }
            Console.WriteLine(set.Contains(1));

            HashSet<int> set1 = new HashSet<int>();
            set1.Add(1);
            set1.Add(3);
            set1.Add(5);
            set1.Add(9);
            set1.Add(10);
            set1.Add(11);

            set1.UnionWith(set);//save the uniuon in the set1
            foreach (int i in set1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("save the intersect in new hashset"); 
            
            HashSet<int> set3 = new HashSet<int>();
            set3.Add(1);
            set3.Add(7);
            set3.Add(4);
            set3.Add(12);
            set3.Add(6);

            HashSet<int> intsect = set1.Intersect(set3).ToHashSet();

            foreach(int i in intsect)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("###### Dictionary ######");

            Person person1 = new Person(1101,"Ahmed", "Male");
            Person person2 = new Person(1102, "Salmah", "female");
            Person person3 = new Person(1103, "Nasser", "Male");

            Dictionary<long,Person> personMap = new Dictionary<long,Person>();
            //personMap.Add(person1.Id, person1);
            //personMap.Add(person2.Id, person2);
            //personMap.Add(person3.Id, person3);

            personMap[person1.Id] = person1;
            personMap[person2.Id] = person2;
            personMap[person3.Id] = person3;

            person2.Gender = "Male";

            personMap[person1.Id] = person3;

            //personMap.TryAdd(person1.Id, person3);

            Person? reult = null;
            if (personMap.TryGetValue(1101, out reult))
            {
                Console.WriteLine(reult);
            }



        }
    }
}