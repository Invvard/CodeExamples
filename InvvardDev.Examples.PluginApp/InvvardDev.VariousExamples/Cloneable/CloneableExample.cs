using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvvardDev.VariousExamples.Cloneable
{
    internal class CloneableExample
    {
        private readonly CloneableObject _base;
        private readonly List<CloneableObject> _clones;

        public CloneableExample()
        {
            _base = new CloneableObject() {
                                              Id = 42,
                                              Name = "Object"
                                          };
            _clones = new List<CloneableObject>();

            StartProcess();

            Console.WriteLine();
            Console.WriteLine("Press enter to end the process.");
            Console.ReadLine();
        }

        private void StartProcess()
        {
            //BasicClone();

            //NextExample();

            //CloneWithChangeOnClone();

            //NextExample();

            //CloneWithChangeOnCloned();

            //NextExample();

            //CloneWithChangeOnCloneProperty();

            //NextExample();

            //CloneWithChangeOnCloneSubProperties();

            CloneData();
        }

        private void CloneData()
        {
            List<CloneableObject> baseObjects = new List<CloneableObject> {
                                                                                    new CloneableObject() {Id = 0, Name = "K_Zero"},
                                                                                    new CloneableObject() {Id = 1, Name = "K_One"},
                                                                                    new CloneableObject() {Id = 2, Name = "K_Two"},
                                                                                };
            List<List<CloneableObject>> layeredClones = new List<List<CloneableObject>>();

            for (int i = 0 ; i < 3 ; i++)
            {
                var clone = baseObjects.Select(c => (CloneableObject)c.Clone()).ToList();

                for (int j = 0 ; j < clone.Count ; j++)
                {
                    clone[j].Position = new Position(i, j);
                }

                layeredClones.Add(clone);
            }

            Console.WriteLine("Base object :");
            foreach (var clone in baseObjects)
            {
                Console.WriteLine(clone);
            }
            Console.WriteLine();

            Console.WriteLine("Clones :");

            foreach (var layer in layeredClones)
            {
                foreach (var clone in layer)
                {
                    Console.WriteLine(clone);
                }
            }
        }

        private void BasicClone()
        {
            Console.WriteLine("Basic cloning without change :");
            Console.WriteLine();
            _clones.Add((CloneableObject) _base.Clone());

            DisplayData();
        }

        private void CloneWithChangeOnClone()
        {
            _clones.Clear();

            Console.WriteLine("Basic cloning with change in clone :");
            Console.WriteLine();
            var clone = (CloneableObject) _base.Clone();
            clone.Id = 100;
            clone.Name = "Other Name";
            _clones.Add(clone);

            DisplayData();
        }

        private void CloneWithChangeOnCloned()
        {
            _clones.Clear();

            Console.WriteLine("Basic cloning with change in clone :");
            Console.WriteLine();

            var clone = (CloneableObject) _base.Clone();
            _clones.Add(clone);

            _base.Id = 100;

            DisplayData();

            _base.Id = 42;
        }

        private void CloneWithChangeOnCloneProperty()
        {
            _clones.Clear();

            Console.WriteLine("Basic cloning with change in clone property :");
            Console.WriteLine();

            var clone = (CloneableObject) _base.Clone();
            clone.Position = new Position(5, 5);
            _clones.Add(clone);

            DisplayData();
        }

        private void CloneWithChangeOnCloneSubProperties()
        {
            _clones.Clear();

            Console.WriteLine("Basic cloning with change in clone :");
            Console.WriteLine();

            var clone = (CloneableObject) _base.Clone();
            clone.Position.X = 67;
            clone.Position.Y = 34;
            _clones.Add(clone);

            DisplayData();
        }

        private void NextExample()
        {
            Console.WriteLine();
            Console.WriteLine("Press enter for next example");
            Console.ReadLine();
            Console.Clear();
        }

        private void DisplayData()
        {
            Console.WriteLine("Base object :");
            Console.WriteLine(_base);
            Console.WriteLine();

            Console.WriteLine("Clones :");

            foreach (var clone in _clones)
            {
                Console.WriteLine(clone);
            }
        }
    }
}