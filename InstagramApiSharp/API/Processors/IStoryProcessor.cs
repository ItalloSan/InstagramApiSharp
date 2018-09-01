﻿using System;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;

namespace InstagramApiSharp.API.Processors
{
    public interface IStoryProcessor
    {
        /// <summary>
        ///     Get user story feed (stories from users followed by current user).
        /// </summary>
        Task<IResult<InstaStoryFeed>> GetStoryFeedAsync();
        /// <summary>
        ///     Get the story by userId
        /// </summary>
        /// <param name="userId">User Id</param>
        Task<IResult<InstaStory>> GetUserStoryAsync(long userId);
        /// <summary>
        ///     Upload story photo
        /// </summary>
        /// <param name="image">Photo to upload</param>
        /// <param name="caption">Caption</param>
        Task<IResult<InstaStoryMedia>> UploadStoryPhotoAsync(InstaImage image, string caption);
        /// <summary>
        ///     Upload story video (to self story)
        /// </summary>
        /// <param name="video">Video to upload</param>
        /// <param name="caption">Caption</param>
        Task<IResult<InstaStoryMedia>> UploadStoryVideoAsync(InstaVideoUpload video, string caption);
        /// <summary>
        ///     Upload story video [to self story, to direct threads or both(self and direct)]
        /// </summary>
        /// <param name="video">Video to upload</param>
        /// <param name="storyType">Story type</param>
        /// <param name="threadIds">Thread ids</param>
        Task<IResult<bool>> UploadStoryVideoAsync(InstaVideoUpload video,
            StoryProcessor.InstaStoryType storyType = StoryProcessor.InstaStoryType.SelfStory, params string[] threadIds);
        /// <summary>
        ///     Get user story reel feed. Contains user info last story including all story items.
        /// </summary>
        /// <param name="userId">User identifier (PK)</param>
        Task<IResult<InstaReelFeed>> GetUserStoryFeedAsync(long userId);
        /// <summary>
        ///     Get story media viewers
        /// </summary>
        /// <param name="StoryMediaId">Story media id</param>
        /// <param name="paginationParameters">Pagination parameters</param>
        Task<IResult<InstaReelStoryMediaViewers>> GetStoryMediaViewers(string StoryMediaId, PaginationParameters paginationParameters);
        /// <summary>
        ///     Share story to someone
        /// </summary>
        /// <param name="reelId">Reel id</param>
        /// <param name="storyMediaId">Story media id</param>
        /// <param name="threadId">Thread id</param>
        /// <param name="sharingType">Sharing type</param>
        Task<IResult<InstaSharing>> ShareStoryAsync(string reelId, string storyMediaId, string threadId, string text, SharingType sharingType = SharingType.Video);
        /// <summary>
        ///     Delete a media story (photo or video)
        /// </summary>
        /// <param name="mediaId">Story media id</param>
        /// <param name="sharingType">The type of the media</param>
        /// <returns>Return true if the story media is deleted</returns>
        Task<IResult<bool>> DeleteStoryAsync(string storyMediaId, SharingType sharingType = SharingType.Video);
        /// <summary>
        ///     Seen story
        /// </summary>
        /// <param name="storyMediaId">Story media identifier</param>
        /// <param name="takenAtUnix">Taken at unix</param>
        Task<IResult<bool>> SeenStoryAsync(string storyMediaId, long takenAtUnix);
    }
}