using Microsoft.AspNetCore.Mvc;
using PureSound.Data.Entities;
using PureSound.Models.ViewModels;

namespace PureSound.Contracts
{
    public interface IArtistService
    {
        Task<ArtistVM> GetArtistByIdAsync(Guid id);
        Task<List<ArtistVM>> GetAllArtistsAsync();
        Task<List<ArtistVM>> SortArtistsAsync(string sortOption);
        Task AddArtistAsync(AddArtistVM model);
        Task DeleteArtistAsync(Guid id);
        Task<List<Track>> GetArtistsTracksAsync(Guid id);
        Task AddToFavouriteAsync(Guid userId, Guid artistId);
        Task RemoveFromFavouriteAsync(Guid userId, Guid artistId);
    }
}
