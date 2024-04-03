using NuGetTry;
using FluentAssertions;
using FluentAssertions.Execution;
namespace NuGetTryTests
{
    public class SampleClassTests
    {
        [Theory]
        [InlineData("Gonzalo Flores")]
        [InlineData("Juan Daniel")]
        [InlineData("Oscar Alberto")]
        public void TestFullNameProperty(string FullName)
        {
            //Arrange
            SampleClass verificador = new SampleClass(FullName);

            //Act
            string res = verificador.FullName;
            //Assert
            Assert.Equal(FullName, res);
        }
        [Theory]
        [InlineData("Juan", "Juan Daniel")]
        [InlineData("Flores", "Gonzalo Flores")]
        public void LastNameRevision(string LastName, string FullName)
        {
            //Arrange
            SampleClass verificador = new SampleClass(FullName);

            //Act
            string res = verificador.LastName;
            //Assert
            Assert.Equal(LastName, res);
        }
        [Theory]
        [InlineData("Eddie", "Van Halen","Eddie Van Halen")]
        public void RevisarNombres(string FirstName, string LastName, string FulllName)
        {
            //arrange
            SampleClass sampleClass = new SampleClass(FulllName);

            using var _ = new AssertionScope();

            //act 
            sampleClass.LastName.Should().Be(LastName);

            //assert
            sampleClass.LastName.Should().StartWith(LastName.Substring(0, 3)).And.EndWith(LastName.Substring(LastName.Length-3)).And.Contain(" ");

        }
    }
}
