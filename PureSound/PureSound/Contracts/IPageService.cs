﻿using PureSound.Data.Account;
using PureSound.Models.ViewModels;

namespace PureSound.Contracts
{
    public interface IPageService
    {
        Task<List<TrackVM>> GetAllTracksAsync();
        Task<List<ArtistVM>> GetAllArtistsAsync();
        Task<List<UserVM>> GetAllUsersAsync();
        Task<List<TrackVM>> FavouriteTracksAsync(Guid id);
        Task<List<ArtistVM>> FavouriteArtistsAsync(Guid id);
    }
}
