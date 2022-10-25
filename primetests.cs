using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrimeFinderLab
{
    public class primetests
    {
      [Theory]
      [InlineData(5, 11)]
      [InlineData(1, 2)]
      [InlineData(7, 17)]
      [InlineData(15, 47)]
      [InlineData(23, 83)]

        public void abc(int hello, int goodbye)
      {
          // ARRANGE
          PrimeFinder pf = new PrimeFinder();

          // ACT
          hello = pf.GetNumbersBack();
          

          // ASSERT
          Assert.Equal(hello, goodbye);

      }
    }
}
