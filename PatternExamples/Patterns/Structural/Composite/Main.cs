using Composite.Models;
using System;

namespace Composite
{
    internal class Main
    {
        Unit unit1;
        Unit unit2;
        public Main()
        {
            unit1 = new Unit();
            unit2 = new Unit();
            Group group1 = new Group();
            Group group2 = new Group();
            Group group3 = new Group();
            Group group4 = new Group();
            Data data1 = new Data();
            Data data2 = new Data();
            Data data3 = new Data();
            Data data4 = new Data();
            Models.Attribute attribute1 = new Models.Attribute();
            Models.Attribute attribute2 = new Models.Attribute();
            Models.Attribute attribute3 = new Models.Attribute();
            Models.Attribute attribute4 = new Models.Attribute();

            unit1.Add(group1);
            unit1.Add(group2);
            unit1.Add(group3);
            unit2.Add(group4);

            group1.Add(data1);
            group1.Add(data2);
            group1.Add(data3);
            group2.Add(data4);

            group1.Add(attribute1);
            group1.Add(attribute2);
            group1.Add(attribute3);
            group4.Add(attribute4);
        }

        public void MainMethod()
        {
            Console.WriteLine("Unit1 composite operate.");
            unit1.Operate();
            Console.WriteLine("\nUnit2 composite operate.");
            unit2.Operate();
        }
    }
}
