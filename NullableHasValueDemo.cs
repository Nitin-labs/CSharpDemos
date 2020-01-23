using System;
namespace CSharp{
    class NullableHasValueDemo{
        public void testNullableHasValue(){
            Console.WriteLine("Using HasValue");
            Nullable<int> noon=null;
            Console.WriteLine("Noon has non-null value: "+noon.HasValue);
            Nullable<int> moon=5;
            Console.WriteLine("Noon has non-null value: "+moon.HasValue);

        }
    }
}