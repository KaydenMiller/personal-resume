using System;
using Xunit;
using Bunit;
using SharedBlazorComponents.Carousel;

namespace SharedBlazorComponents.Tests
{
    public class CarouselTests : TestContext
    {
        [Fact]
        public void CarouselArrowButtonPublishesEvent()
        {
            // Arrange
            var cut = RenderComponent<CarouselArrowButton>();
            
            // Act
            
            
            // Assert
            
        }
    }
}