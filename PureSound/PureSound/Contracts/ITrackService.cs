using Microsoft.AspNetCore.Mvc;
using PureSound.Models.ViewModels;

namespace PureSound.Contracts
{
    public interface ITrackService
    {
        Task<List<TrackVM>> GetAllTracksAsync();
        Task<List<ArtistVM>> GetAllTrackArtistsAsync(Guid id);
        Task<List<TrackVM>> SortTracksAsync(string sortOption);
        Task AddTrackAsync(AddTrackVM model);
        Task DeleteTrackAsync(Guid id);
        Task<TrackVM> EachTrackAsync(Guid id);
        Task AddToFavouriteAsync(Guid userId, Guid trackId);
        Task RemoveFromFavouriteAsync(Guid userId, Guid artistId);
    }
}
