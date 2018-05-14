using System;
using System.Collections.Generic;
using System.Linq;

namespace problemsolving.Recursion
{
    public class SubSets
    {
        public List<List<int>> FindSubSets(List<int> sourceList, int index)
        {
            var foundSubSets = new List<List<int>>();

            if (index == sourceList.Count)
            {
                foundSubSets.Add(new List<int>());
            } 
            else
            {
                var returnedSubSets = FindSubSets(sourceList, index + 1);

                foreach(var existingSubSet in returnedSubSets.ToList())
                {
                    var newSubSet = new List<int>();
                    newSubSet.AddRange(existingSubSet);
                    newSubSet.Add(sourceList[index]);

                    returnedSubSets.Add(newSubSet);
                }

                foundSubSets.AddRange(returnedSubSets);
            }

            return foundSubSets;
        }
    }
}
