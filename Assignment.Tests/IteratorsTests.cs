using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void FlattenGivenStreamOfSteamIntReturnStreamT()
        {
        //Given
        var expected = new List<int>(){2,4,6,8};
        var list1 = new List<int>(){2,4};
        var list2 = new List<int>(){6,8};

        List<List<int>> input = new List<List<int>>(){list1, list2};

        //When
        var output = Iterators.Flatten(input); 
        //Then
        Assert.Equal(expected, output);
        }

        [Fact]
        public void FilterGivenStreamOfIntReturnEvenInts()
        {
            var input = new List<int>(){1,2,3,4,5,6};

            var expected = new List<int>{2,4,6};
            
            Predicate<int> even = Iterators.Even; 

            var output = Iterators.Filter(input, even);

            Assert.Equal(expected,output);
        }
    }
}