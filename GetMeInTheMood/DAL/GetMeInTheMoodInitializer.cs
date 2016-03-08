using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GetMeInTheMood.Models;

namespace GetMeInTheMood.DAL
{
    public class GetMeInTheMoodInitializer : DropCreateDatabaseAlways<GetMeInTheMoodContext>
    {
        protected override void Seed(GetMeInTheMoodContext context)
        {
            var users = new List<User>()
            {
                new User() {
                    /* email = "berislav.sapina@gmail.com", username="bero", password="bero1993"*/
                    email = "1913ec27810b186f6ce6b83a8a2d211e4d167b08c4c4030b0db09a3d24e492cf",
                    username = "bero",
                    password = "7418a4b3814752a06da82d8bf329a5ee7ef92073efd22b112b4d7a03b51726d0"
                           },
                new User() {
                    /*email = "boriskostres92@gmail.com", username="boki", password="boki1991"*/
                    email = "boriskostres92@gmail.com",
                    username = "boki",
                    password = "da6e2fe0d5c605a95e5f2f2d162af47e642960b1ad71fa94e1d8d95311503471"
                           }
            };

            users.ForEach(user => context.Users.Add(user));

            var moods = new List<Mood>()
            {
                new Mood() {imageUrl="~/MoodsImages/happy", name="happy"},
                new Mood() {imageUrl="~/MoodsImages/sad", name="sad"},
                new Mood() {imageUrl="~/MoodsImages/cool", name="cool"}
            };

            moods.ForEach(mood => context.Moods.Add(mood));

            var playlists = new List<Playlist>()
            {
                new Playlist() { mood =moods[0], name="happy", user=users[0]},
                new Playlist() { mood =moods[1], name="sad", user=users[0]},

                new Playlist() { mood =moods[0], name="happy", user=users[1]},
                new Playlist() { mood =moods[1], name="cool", user=users[1]},
            };

            playlists.ForEach(playlist => context.Playlists.Add(playlist));

            users[0].Playlists = new List<Playlist>() { playlists[0], playlists[1] };
            users[1].Playlists = new List<Playlist>() { playlists[2], playlists[3] };
            users.ForEach(user => context.Users.Add(user));

            var songs = new List<Song>()
            {
                new Song()
                {
                    url =new Uri("https://www.youtube.com/watch?v=Us-TVg40ExM"),
                    status ="stop",
                    playlists =new List<Playlist>() {playlists[0],playlists[2]}
                },
                new Song()
                {
                    url =new Uri("https://www.youtube.com/watch?v=hx27NL_iqEM"),
                    status ="stop",
                    playlists =new List<Playlist>() {playlists[3]}
                },
                new Song()
                {
                    url =new Uri("https://www.youtube.com/watch?v=4xjPODksI08"),
                    status ="stop",
                    playlists =new List<Playlist>() {playlists[1]}
                }
            };

            playlists[0].songs = new List<Song>() { songs[0] };
            playlists[1].songs = new List<Song>() { songs[2] };
            playlists[2].songs = new List<Song>() { songs[0] };
            playlists[3].songs = new List<Song>() { songs[1] };
            playlists.ForEach(playlist => context.Playlists.Add(playlist));

            context.SaveChanges();
        }
    }
}