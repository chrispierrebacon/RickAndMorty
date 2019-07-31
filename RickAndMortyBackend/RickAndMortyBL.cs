using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyBackend
{
    public class RickAndMortyBL
    {
        // Just do this statically for now
        public List<Episode> episodes;

        // We'll get into DI later
        public RickAndMortyBL()
        {
            episodes = new List<Episode>();
            episodes.Add(new Episode
            {
                name = "Pilot",
                season = 1,
                number = 1,
                coverImage = "https://m.media-amazon.com/images/M/MV5BNzlhNGI0MTUtOWZlNS00ZmQ2LTk2NTYtMGMwMzRmOGViZWIyXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SX1777_CR0,0,1777,999_AL_.jpg",
                nicksFavoriteLine = "I'm gonna need you to put these seeds way up inside your butthole Morty.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Lawnmower Dog",
                season = 1,
                number = 2,
                coverImage = "https://m.media-amazon.com/images/M/MV5BNzUyNmIxYzYtMTM2My00ZTZjLWFmODYtNmFmMDgyZDY4OWU4XkEyXkFqcGdeQXVyNjg0Nzk2Nzc@._V1_.jpg",
                nicksFavoriteLine = "Do not call me that. Snuffles was my slave name. You will call me Snowball because my fur is snowy and white.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Anatomy Park",
                season = 1,
                number = 3,
                coverImage = "https://m.media-amazon.com/images/M/MV5BM2I0Nzg0YTktYTc2Zi00NTk4LWI5ZDQtMmVhYjBjZmRmNGM0XkEyXkFqcGdeQXVyNjg4ODczODM@._V1_SX1777_CR0,0,1777,999_AL_.jpg",
                nicksFavoriteLine = "Jacob is your mother's lover. I watch them, sometimes from a chair, sometimes from a closet. Almost always dressed as Superman.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "M. Night Shaym-Aliens!",
                season = 1,
                number = 4,
                coverImage = "https://m.media-amazon.com/images/M/MV5BZWZmZDBjYTEtZTQyNy00NDc5LTgxMjEtZmQyNmU1N2Y1NThkXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY1000_CR0,0,1764,1000_AL_.jpg",
                nicksFavoriteLine = "How does a guy like that go home and have sex with his wife?",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Meeseeks and Destroy",
                season = 1,
                number = 5,
                coverImage = "https://m.media-amazon.com/images/M/MV5BNGQyOWNhYzQtNTJhNy00NzFhLTkyYTgtYTM4MGI0NmYxMWJiXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY1000_CR0,0,1764,1000_AL_.jpg",
                nicksFavoriteLine = "I'm a bit of a stickler Meeseeks. What about your short game?",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Rick Potion #9",
                season = 1,
                number = 6,
                coverImage = "https://m.media-amazon.com/images/M/MV5BYTRhMjhjMTEtZTY0MC00NjAyLWJkNDQtZmYzN2FjNDM1NTI0XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY1000_CR0,0,1764,1000_AL_.jpg",
                nicksFavoriteLine = "I love Morty and I hope Morty loves me. I want to wrap my arms around him and feel him inside me.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Raising Gazorpazorp",
                season = 1,
                number = 7,
                coverImage = "https://m.media-amazon.com/images/M/MV5BYmRlZTdmNTEtNmY5Ny00MTlmLTk5M2UtNGQwYzFkYzU2YWRlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY1000_CR0,0,1764,1000_AL_.jpg",
                nicksFavoriteLine = "Marc? Jacobs? These are names of the penis.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Rixty Minutes",
                season = 1,
                number = 8,
                coverImage = "https://m.media-amazon.com/images/M/MV5BNzM4MmM3MjctYjE0Yy00NzVhLThkNmQtNjBhNWU2MDc1ZjNhXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY1000_CR0,0,1764,1000_AL_.jpg",
                nicksFavoriteLine = "Nobody exists on purpose. Nobody belongs anywhere. Everybody's gonna die. Come watch TV.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Something Ricked This Way Comes",
                season = 1,
                number = 9,
                coverImage = "https://m.media-amazon.com/images/M/MV5BNDIzNDEwOGQtNTE5Mi00ZWM0LWJmYTQtZTk0ZTAzM2Q2ZWZkXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY1000_CR0,0,1764,1000_AL_.jpg",
                nicksFavoriteLine = "What is my purpose? You pass butter. *Looks at hands* Oh my god.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Close Rick-counters of the Rick Kind",
                season = 1,
                number = 10,
                coverImage = "https://m.media-amazon.com/images/M/MV5BZWRhYzZhZjMtMjQxMi00OWVkLWEzNjItMjE3ZmZjM2QwZWU2L2ltYWdlXkEyXkFqcGdeQXVyNDk3OTIwNTU@._V1_.jpg",
                nicksFavoriteLine = "Yeah I'd like to order one large phones with extra phones please. Cell phone, no no no no, rotary and pay phone on half.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Ricksy Business",
                season = 1,
                number = 11,
                coverImage = "https://m.media-amazon.com/images/M/MV5BOGU0ODA0ZDYtNWJiYy00MGM0LThhZDAtMDkxNjZhMGRhZWEyXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY1000_CR0,0,1761,1000_AL_.jpg",
                nicksFavoriteLine = "Why do you party? To get riggity *burp* riggity WRECKED SON!",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "A Rickle in Time",
                season = 2,
                number = 1,
                coverImage = "https://m.media-amazon.com/images/M/MV5BOGMxMzM4MTEtNzViZS00YTRlLThjOGYtOGEzZWU3MTkxMGM0XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY1000_CR0,0,1761,1000_AL_.jpg",
                nicksFavoriteLine = "You're both pieces of shit. Yeah, I can prove it mathematically. Actually, let me grab my whiteboard. This has been a long time coming anyway.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Mortynight Run",
                season = 2,
                number = 2,
                coverImage = "https://m.media-amazon.com/images/M/MV5BZGJiYzFlMjMtZjIyYi00YzhkLWIwMjUtZmUyNWUyMDMxMjZhXkEyXkFqcGdeQXVyMjQyODEzMjc@._V1_.jpg",
                nicksFavoriteLine = "Oh boy here I go killing again.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Auto Erotic Assimilation",
                season = 2,
                number = 3,
                coverImage = "https://m.media-amazon.com/images/M/MV5BOTExYzYxODYtOGRiMi00MzBmLTkwNzMtY2Q5ZDU2ZjdmOGZmXkEyXkFqcGdeQXVyNTkyMjE3NDU@._V1_.jpg",
                nicksFavoriteLine = "No, no. If I wanted to be sober, I wouldn't have gotten drunk.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Total Rickall",
                season = 2,
                number = 4,
                coverImage = "https://m.media-amazon.com/images/M/MV5BOWFjNzJhMjYtNTFlMi00MThlLWE4MDItYjg0ODYxZWZkNzZjXkEyXkFqcGdeQXVyNTkyMjE3NDU@._V1_.jpg",
                nicksFavoriteLine = "Lick lick lick my balls! Yeah! Say that all the time.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Get Schwifty",
                season = 2,
                number = 5,
                coverImage = "https://m.media-amazon.com/images/M/MV5BYjc5N2ZhZjEtNmY2Ny00YjU4LTg5MTMtYzIyOGNiNjc0YTE1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY1000_CR0,0,1761,1000_AL_.jpg",
                nicksFavoriteLine = "You know what this human eats...Bird Dick.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "The Ricks Must Be Crazy",
                season = 2,
                number = 6,
                coverImage = "https://m.media-amazon.com/images/M/MV5BZjMwZmM5N2EtMDUyYi00NmM0LTlkYTItYWExOTY3NTUxYTY2XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SX1777_CR0,0,1777,999_AL_.jpg",
                nicksFavoriteLine = "My function is to keep Summer safe. Not keep Summer being, like, totally stoked about, like, the general vibe and stuff. That's you, that's how you talk.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Big Trouble in Little Sanchez",
                season = 2,
                number = 7,
                coverImage = "https://m.media-amazon.com/images/M/MV5BNTAyMjg5MTAtODRjNi00MGYxLWJjZWItYTU5MGQ2NmY4Yjc1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY1000_CR0,0,1761,1000_AL_.jpg",
                nicksFavoriteLine = "Well then, get your shit together. Get it all together. And put it in a backpack. All your shit. So it’s together...And if you gotta take it somewhere, take it somewhere, you know, take it to the shit store and sell it… Or put it in a shit museum, I don’t care what you do, you just gotta get it together.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Interdimensional Cable 2: Tempting Fate",
                season = 2,
                number = 8,
                coverImage = "https://m.media-amazon.com/images/M/MV5BZGFlNTlkYjctYTYxNS00YWE4LTk1ZTYtNTcyNWY0ZTQ1MzhhXkEyXkFqcGdeQXVyNjgyOTUyNDc@._V1_.jpg",
                nicksFavoriteLine = "Yes I will! That's right, assholes, take my penis, TAKE IT ALL! And tell Shrimply Pimples that when the galaxy came calling Jerry Smith from Earth didn't flinch!",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Look Who's Purging Now",
                season = 2,
                number = 9,
                coverImage = "https://m.media-amazon.com/images/M/MV5BNWZlMmQ0ZjEtZGQ4Yi00YTcxLWJjOGQtZmJmYmRkYmE3NTc3XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY1000_CR0,0,1761,1000_AL_.jpg",
                nicksFavoriteLine = "You like that? You want me to cut to three weeks earlier, when you were alive?",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "The Wedding Squanchers",
                season = 2,
                number = 10,
                coverImage = "https://m.media-amazon.com/images/M/MV5BNmVjM2IzOTQtNzZmNi00MzFjLTg3MGUtYTIwNzk3MDBhMWEwXkEyXkFqcGdeQXVyNTkyMjE3NDU@._V1_.jpg",
                nicksFavoriteLine = "My name is Jerry Smith and I love sucking big, sweaty dick and licking disgusting furry testicle sacks.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "The Rickshank Rickdemption",
                season = 3,
                number = 1,
                coverImage = "https://m.media-amazon.com/images/M/MV5BMTRmYzZmZjAtOTBlMy00ODJiLTgwMzEtMTVjN2Y2NzBjYzU3XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                nicksFavoriteLine = "I can answer that, for money.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Rickmancing the Stone",
                season = 3,
                number = 2,
                coverImage = "https://m.media-amazon.com/images/M/MV5BMGE2ODY0M2ItYWRhZC00ZjEzLTkyNWUtYWQ1MDUzZGE3NTQ5XkEyXkFqcGdeQXVyNjk2NTI2MDI@._V1_SX1777_CR0,0,1777,964_AL_.jpg",
                nicksFavoriteLine = "Remote override engaged. NOOOO I'M ALIIIIVE. Hello",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Pickle Rick",
                season = 3,
                number = 3,
                coverImage = "https://m.media-amazon.com/images/M/MV5BMGIyYjNhOTUtM2UxNC00MjFlLTkwZGYtNDQ0MDhmNGNkYWNlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SX1777_CR0,0,1777,999_AL_.jpg",
                nicksFavoriteLine = "I turned myself into a pickle Morty! I'm pickle Rick!",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Vindicators 3: The Return of Worldender",
                season = 3,
                number = 4,
                coverImage = "https://m.media-amazon.com/images/M/MV5BMGRlMGQ3MDMtNDgzNi00MWI1LTk0ZTgtNzRiMWYyYWRhNGEyXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SX1777_CR0,0,1777,999_AL_.jpg",
                nicksFavoriteLine = "Get it right or the whole planet will blow up and possibly the solar system cuz I kinda fucking eyeballed the neutrino bombs on this one.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "The Whirly Dirly Conspiracy",
                season = 3,
                number = 5,
                coverImage = "https://m.media-amazon.com/images/M/MV5BNTIyYWY4Y2UtYTNiOS00NDMzLWE1ZmEtNjJjYTRlYzIwMWY2XkEyXkFqcGdeQXVyODA0MTgwMTY@._V1_.jpg",
                nicksFavoriteLine = "I want cookies and a 90-minute cut of 'Avatar.'",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Rest and Ricklaxation",
                season = 3,
                number = 6,
                coverImage = "https://m.media-amazon.com/images/M/MV5BMDA0OGI2OTktMjEwOS00Yjc2LWFmMGMtZjViMTBkZmRhN2NlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SX1777_CR0,0,1777,937_AL_.jpg",
                nicksFavoriteLine = "You can't have the droids, they turn into a little voltron robot they're awesome.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "The Ricklantis Mixup",
                season = 3,
                number = 7,
                coverImage = "https://m.media-amazon.com/images/M/MV5BMDc5ZmQ0NTAtMTJjNy00NzA0LWIyMWQtZDVmMzgwNGExMzcxXkEyXkFqcGdeQXVyODAzMDI5NDI@._V1_.jpg",
                nicksFavoriteLine = "You look like you need a good time. One dance for ten. Two for 25. No, thank you, and bad math.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "Morty's Mind Blowers",
                season = 3,
                number = 8,
                coverImage = "https://m.media-amazon.com/images/M/MV5BM2UwY2MzOTYtYWY3ZS00NzM4LWE1YzQtZWE1MjYxNTQxODU2XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                nicksFavoriteLine = "You fucked with squirrels Morty! We have to move to another reality Morty! Because of these damn squirrels!",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "The ABC's of Beth",
                season = 3,
                number = 9,
                coverImage = "https://m.media-amazon.com/images/M/MV5BMTJlMjcwMGYtOWJhNi00MzdmLWE4NGYtNzE0Y2U1MWIzZTZjXkEyXkFqcGdeQXVyODEwNTIzOTM@._V1_.jpg",
                nicksFavoriteLine = "You're supposed to put elbow grease into your daughter. Gross.",
                comments = null
            });
            episodes.Add(new Episode
            {
                name = "The Rickchurian Mortydate",
                season = 3,
                number = 10,
                coverImage = "https://m.media-amazon.com/images/M/MV5BYjJkMDViZDItOGY5NS00ZjkxLTk0ZjMtYjc3MmY2YjQ0ZWNjXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SX1777_CR0,0,1777,999_AL_.jpg",
                nicksFavoriteLine = "I am presidentress of the mega gargantuans. We named ourselves before learning we were small.",
                comments = null
            });
        }

        public List<Episode> getEpisodes()
        {
            return episodes;
        }
    }
}
