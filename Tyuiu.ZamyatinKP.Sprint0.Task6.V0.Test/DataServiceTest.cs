using Tyuiu.ZamyatinKP.Sprint0.Task6.V0.Lib;
namespace Tyuiu.ZamyatinKP.Sprint0.Task6.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] {1, 2, 3, 4, 5};
            var res = DataService.AdditionArray(numbers);
            Assert.Equal(15, res);
        }

        [Fact]
        public void CheckSubstractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubstractionArray(numbers);
            Assert.Equal(-15, res);
        }

        [Fact]
        public void CheckMultnArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.Equal(120, res);
        }
    }
}