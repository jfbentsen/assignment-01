using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_given_StreamOfSteamInt_returnStreamT()
        {
        //Given
        var expected = new List<int>(){1,2,3,4};
        var list1 = new List<int>(){1,2};
        var list2 = new List<int>(){3,4};

        List<List<int>> input = new List<List<int>>(){list1, list2};

        //When
        var output = Iterators.Flatten(input); 
        //Then
        Assert.Equal(expected, output);
        }

        [Fact]
        public void Filter_given_StreamOfInt_return_evenInts()
        {
            var input = new List<int>(){1,2,3,4,5,6};

            var expected = new List<int>{2,4,6};
            
            Predicate<int> even = Iterators.Even; 

            var output = Iterators.Filter(input, even);

            Assert.Equal(expected,output);
        }
    }
}