using _2._2012.IntroductionAPI.Dtos.BookDto;
using _2._2012.IntroductionAPI.Services;

namespace BookValidatorTests
{
    public class CreateBookValidatorTests
    {
        [Fact]
        public void IsValid_WhenCoverTypeHardcover()
        {
            //Arrange
            var fake = new CreateBookDto
            {
                CoverType = "Hardcover",
                Title = "Title",
                Author = "Author",
                PublishYear = DateTime.Now.AddYears(-10),
            };
            //act
            var sut = new ValidatorBookService();
            var actual = sut.IsValid(fake);
            //assert
            Assert.True(actual);
        }
        [Fact]
        public void IsValid_WhenCoverTypePaperback()
        {
            //Arrange
            var fake = new CreateBookDto
            {
                CoverType = "Paperback",
                Title = "Title",
                Author = "Author",
                PublishYear = DateTime.Now.AddYears(-10),
            };
            //act
            var sut = new ValidatorBookService();
            var actual = sut.IsValid(fake);
            //assert
            Assert.True(actual);
        }
        [Fact]
        public void IsValid_WhenCoverTypeEbook()
        {
            //Arrange
            var fake = new CreateBookDto
            {
                CoverType = "Ebook",
                Title = "Title",
                Author = "Author",
                PublishYear = DateTime.Now.AddYears(-10),
            };
            //act
            var sut = new ValidatorBookService();
            var actual = sut.IsValid(fake);
            //assert
            Assert.True(actual);
        }
        [Fact]
        public void IsValid_WhenCoverTypeDoesNotExist()
        {
            //Arrange
            var fake = new CreateBookDto
            {
                CoverType = "Metal",
                Title = "Title",
                Author = "Author",
                PublishYear = DateTime.Now.AddYears(-10),
            };
            //act
            var sut = new ValidatorBookService();
            var actual = sut.IsValid(fake);
            //assert
            Assert.False(actual);
        }
        [Fact]
        public void IsValid_WhenTitleIsLongerThan200CharLong()
        {
            //Arrange
            var fake = new CreateBookDto
            {
                CoverType = "Ebook",
                Title = "The sera flore CO2 active reactor is integrated into an existing water circuit (e.g. external filter), or it can alternatively be operated with a pump. The rotors ensure strong blending of CO2 with the aquarium water, allowing to dissolve several hundred CO2 bubbles per minute.\r\n\r\nThe holder included with the kit allows attaching the reactor inside or outside the aquarium (e.g. in the cabinet), depending on the existing installation. The material color (smoky gray) is effective against algae settlement. Easy to clean.",
                Author = "Author",
                PublishYear = DateTime.Now.AddYears(-10),
            };
            //act
            var sut = new ValidatorBookService();
            var actual = sut.IsValid(fake);
            //assert
            Assert.False(actual);
        }
        [Fact]
        public void IsValid_WhenPublishYearIsCurrentYear()
        {
            //Arrange
            var fake = new CreateBookDto
            {
                CoverType = "Ebook",
                Title = "Title",
                Author = "Author",
                PublishYear = DateTime.Now,
            };
            //act
            var sut = new ValidatorBookService();
            var actual = sut.IsValid(fake);
            //assert
            Assert.True(actual);
        }
        [Fact]
        public void IsValid_WhenPublishYearIsNextYear()
        {
            //Arrange
            var fake = new CreateBookDto
            {
                CoverType = "Ebook",
                Title = "Title",
                Author = "Author",
                PublishYear = DateTime.Now.AddYears(1),
            };
            //act
            var sut = new ValidatorBookService();
            var actual = sut.IsValid(fake);
            //assert
            Assert.False(actual);
        }
        [Fact]
        public void IsValid_WhenPublishYearIsBeforeThanCurrentYear()
        {
            //Arrange
            var fake = new CreateBookDto
            {
                CoverType = "Ebook",
                Title = "Title",
                Author = "Author",
                PublishYear = DateTime.Now.AddYears(-1),
            };
            //act
            var sut = new ValidatorBookService();
            var actual = sut.IsValid(fake);
            //assert
            Assert.True(actual);
        }
        [Fact]
        public void IsValid_WhenAuthorHasSpecialCharacters()
        {
            //Arrange
            var fake = new CreateBookDto
            {
                CoverType = "Ebook",
                Title = "Title",
                Author = "@&`Author",
                PublishYear = DateTime.Now.AddYears(-1),
            };
            //act
            var sut = new ValidatorBookService();
            var actual = sut.IsValid(fake);
            //assert
            Assert.False(actual);
        }
    }
}