using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    public class Collections
    {
        //[Fact]
        //public void UsingAGenericList()
        //{
        //    //generics change there form based on a type parameter
        //    // "Parametric Polymorphism"
        //    var favoriteNumbers = new List<int>();
        //    favoriteNumbers.Add(9);
        //    favoriteNumbers.Add(20);
        //    favoriteNumbers.Add(108); Assert.Equal(9, favoriteNumbers[0]);
        //    Assert.Equal(108, favoriteNumbers[2]);         //Assert.Equal(999, favoriteNumbers[32]);
        //    Assert.Equal(3, favoriteNumbers.Count());
        //    Assert.Contains(108, favoriteNumbers);
        //    // - "Roslyn" - "Compiler as a Service"         Assert.Equal(9, favoriteNumbers[0]);
        //}


        //////// same as bove 
        ///
        [Fact]
        public void ListInitializers()
        {
            //generics change there form based on a type parameter
            // "Parametric Polymorphism"
            var favoriteNumbers = new List<int>
                 {
                 9,
                 20,
                 108
                 }; 
            Assert.Equal(3, favoriteNumbers.Count());
        }
    }
}
