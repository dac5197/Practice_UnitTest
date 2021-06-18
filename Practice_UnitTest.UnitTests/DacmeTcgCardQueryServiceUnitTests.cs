using Microsoft.EntityFrameworkCore;
using Moq;
using Practice_UnitTest.ApplicationCore.Models;
using Practice_UnitTest.Infrastructure.DataAccess;
using Practice_UnitTest.Infrastructure.Services.CommandServices;
using Practice_UnitTest.Infrastructure.Services.QueryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Practice_UnitTest.UnitTests
{
    public class DacmeTcgCardCommandServiceUnitTests
    {
        [Fact]
        public async Task CreateAsync_ShouldReturnAllCards_WhenCardsExist()
        {
            // Arrange
            var mockCard = new DacmeTcgCard()
            {
                Id = Guid.NewGuid(),

            };

            var mockSet = new Mock<DbSet<DacmeTcgCard>>();
            
            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(m => m.DacmeTcgCards).Returns(mockSet.Object);

            var sut = new DacmeTcgCardCommandService(mockContext.Object);

            // Act
            var output = await sut.CreateAsync(mockCard);

            // Assert
        }
    }
}
