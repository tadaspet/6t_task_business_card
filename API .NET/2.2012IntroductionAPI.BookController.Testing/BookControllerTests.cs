using _2._2012.IntroductionAPI.Controllers;
using _2._2012.IntroductionAPI.DataLayer.Models;
using _2._2012.IntroductionAPI.DataLayer.Repositories;
using _2._2012.IntroductionAPI.Dtos.BookDto;
using _2._2012.IntroductionAPI.Services;
using AutoFixture.Xunit2;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace _2._2012IntroductionAPI.BookController.Testing
{
    public class BookControllerTests
    {
        private readonly Mock<IBookRepository> _mockBooksRespository;
        private readonly Mock<ILogger<BookRepository>> _mocklogger;
        private readonly Mock<IValidatorBookService> _mockvalidator;
        private readonly Mock<IBookMapper> _mockBookMapper;
        private readonly BooksController _sut;

        public BookControllerTests()
        {
            _mockBooksRespository = new Mock<IBookRepository>();
            _mocklogger = new Mock<ILogger<BookRepository>>();
            _mockvalidator = new Mock<IValidatorBookService>();
            _mockBookMapper = new Mock<IBookMapper>();
            _sut = new BooksController(_mockBooksRespository.Object, _mocklogger.Object, _mockvalidator.Object, _mockBookMapper.Object);
        }
        [Theory, AutoData]
        public void WhenCallingGetAllReturnsAllBooksFromRepository(List<Book> books)
        {
            List<CreateBookDto> booksDto = new List<CreateBookDto>();
            _mockBooksRespository.Setup(x => x.GetAll()).Returns(books);
            _mockBookMapper.Setup(x => x.Map(books)).Returns(booksDto);
            //Act
            var result = _sut.GetAll();

            //Assert
            //Assert.Equal(books, result);
            Assert.IsType<OkObjectResult>(result.Result);
            Assert.Equal(booksDto, ((OkObjectResult)result.Result).Value);
        }
        [Fact]
        public void WhenCallingGetByIDReturnsBookWithSameIDFromRepository()
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Title = "Book 1", Author = "Author 1"},
                new Book { Id = 2, Title = "Book 2", Author = "Author 2"},
                new Book { Id = 3, Title = "Book 3", Author = "Author 3"},
            };
            Book singleBook = new Book();
            CreateBookDto booksDto = new CreateBookDto();
            _mockBooksRespository.Setup(x => x.Get(1)).Returns(singleBook);
            _mockBookMapper.Setup(x => x.Map(singleBook)).Returns(booksDto);
            //Act
            var result = _sut.GetByID(1);

            //Assert
            //Assert.Equal(books, result);
            Assert.IsType<OkObjectResult>(result.Result);
            Assert.Equal(booksDto, ((OkObjectResult)result.Result).Value);
        }
    }
}