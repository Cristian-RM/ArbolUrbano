using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using TropicosSyncLib.Models;
using TropicosSyncLib.Services;
using TropicosSyncLib.Data;
using Xunit;

namespace TropicosSyncLib.Tests
{
    public class SpeciesSyncServiceTests
    {
        [Fact]
        public async Task SyncSpeciesAsync_ShouldAddNewSpecies_WhenNotExistInDb()
        {
            // Arrange
            var mockApiClient = new Mock<ITropicosApiClient>();
            var mockRepository = new Mock<ISpeciesRepository>();

            var speciesFromApi = new List<TropicosSpeciesDto>
            {
                new TropicosSpeciesDto { ScientificName = "Species A", CommonName = "Common A", Family = "Family A" }
            };
            mockApiClient.Setup(client => client.GetSpeciesAsync(It.IsAny<string>())).ReturnsAsync(speciesFromApi);
            mockRepository.Setup(repo => repo.GetSpeciesByScientificNameAsync(It.IsAny<string>())).ReturnsAsync((LocalSpecies)null);

            var speciesSyncService = new SpeciesSyncService(mockApiClient.Object, mockRepository.Object);

            // Act
            await speciesSyncService.SyncSpeciesAsync("Species A");

            // Assert
            mockRepository.Verify(repo => repo.AddSpeciesAsync(It.IsAny<LocalSpecies>()), Times.Once);
        }

        [Fact]
        public async Task SyncSpeciesAsync_ShouldUpdateSpecies_WhenExistsInDb()
        {
            // Arrange
            var mockApiClient = new Mock<ITropicosApiClient>();
            var mockRepository = new Mock<ISpeciesRepository>();

            var speciesFromApi = new List<TropicosSpeciesDto>
            {
                new TropicosSpeciesDto { ScientificName = "Species A", CommonName = "Updated Common A", Family = "Updated Family A" }
            };
            mockApiClient.Setup(client => client.GetSpeciesAsync(It.IsAny<string>())).ReturnsAsync(speciesFromApi);

            var existingSpecies = new LocalSpecies { ScientificName = "Species A", CommonName = "Common A", Family = "Family A" };
            mockRepository.Setup(repo => repo.GetSpeciesByScientificNameAsync(It.IsAny<string>())).ReturnsAsync(existingSpecies);

            var speciesSyncService = new SpeciesSyncService(mockApiClient.Object, mockRepository.Object);

            // Act
            await speciesSyncService.SyncSpeciesAsync("Species A");

            // Assert
            mockRepository.Verify(repo => repo.UpdateSpeciesAsync(It.IsAny<LocalSpecies>()), Times.Once);
        }
    }
}
