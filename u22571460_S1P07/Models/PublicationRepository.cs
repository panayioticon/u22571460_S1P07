using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u22571460_S1P07.Models
{
    public static class PublicationRepository
    {
        public static List<Publication> GetAllPublications()
        {
            return new List<Publication>
        {
            new Article
            {
                Title = "Improving the foundation of our falling sand simulator",
                Author = new Author { Name = "Koffi Umukoro" },
                Summary = "Addison is a detective from Sale who falls in love with his best friend. The two are separated when the best friend falls for somebody else. However, Addison manages to rescue the situation by buying a magnificent t-shirt.,",
                Link = "https://bait.example.net/bag.aspx",
                Image = "https://cdn.pixabay.com/photo/2018/03/02/20/22/sktop-3194194__340.jpg",
                DatePublished = new DateTime(2018, 07, 24)
            },
            new Book
            {
                Title = "NASA fed some Apollo 11 lunar samples to cockroaches and mice",
                Author = new Author { Name = "Octavia Barret" },
                Summary = "A farmer from Markham is delighted when she gets the chance to take part in the final of X-Factor. However, her chances are scuppered when her son goes missing. Unexpectedly, the farmer is bitten by a zombie and therefore is disqualified from competing.",
                Link = "https://www.example.com/bite.aspx",
                Image = "https://cdn.pixabay.com/photo/2016/08/18/08/31/lemur-1602313__340.jpg",
                DatePublished = new DateTime(2006, 05, 15),
                EditionCount = 2
            },
            new Article
            {
                Title = "When Your Smart ID Card Reader Comes with Malware",
                Author = new Author { Name = "Gunnhild Aric" },
                Summary = "A caretaker from Lehi is delighted when she gets the chance to take part in the final of X-Factor. However, her chances are scuppered by an angyy camel. After the drama, the caretaker realises there is more to life than winning X-Factor and goes on a picninc with her great aunt instead.\"",
                Link = "https://example.com/bone/basin.php?bed=bedroom&boat=amusement#boundary",
                Image = "https://cdn.pixabay.com/photo/2017/06/14/11/34/meadow-2401931__340.jpg",
                DatePublished = new DateTime(2023, 03, 21)
            },
            new Book
            {
                Title = "Jailer: A truly relational database tool",
                Author = new Author { Name = "Jakob Ayanda" },
                Summary = "In a world where robots are wealthy, one golfer has no choice but to assasinate an honorable man by killing his own ex-wife. Eventually, the golfer forms an army and teaches the robots a little respect.\"",
                Link = "https://www.example.com/baseball/basin.php?attraction=anger&bead=amusement",
                Image = "https://cdn.pixabay.com/photo/2016/08/20/05/44/clock-1606919__340.jpg",
                DatePublished = new DateTime(1989, 06, 06),
                EditionCount = 3
            },
            new Article
            {
                Title = "sEverything you ever wanted to know about terminal",
                Author = new Author{Name = "Shyam Benson"},
                Summary = "In a world where robots are miraculously transformed into angels, one pop star has no choice but to bring down the goverment by killing her own step-sister. It turns out all the robots were a manifestations of the pop star's multiple personality disorder and her real fight is one to regain sanity.\"",
                Link = "https://www.example.com/bait/bath.php",
                Image = "https://cdn.pixabay.com/photo/2016/09/01/10/33/witchs-house-1635770_960_720.jpg",
                DatePublished = new DateTime(2020,01,23)
            },
            new Article
            {
                Title = "NaturalSpeech: End-to-end text to speech synthesis with human-level quality",
                Author = new Author{Name = "Lucas Asim"},
                Summary = "When a movie star from West Des Moines learns to sing, not everybody is supportive. However, her fortunes improve when her step-sister buys a deralict castle. Eventually, the movie star realises that she has always been a worthwhile person and does not need to change.\"",
                Link = "http://www.example.com/bear",
                Image = "https://cdn.pixabay.com/photo/2016/04/25/07/15/man-1351317__340.png",
                DatePublished = new DateTime(2022,10,28)
            },
            new Article
            {
                Title = "Husky, Datadog's Third-Generation Event Store",
                Author = new Author{Name = "Harmon Deeann"},
                Summary = "A WW2 veteran Brisbane who recieves an invitation to a modern battle. It turns out the invitations is spam and is from a scammer who is famous for making up stories.",
                Link = "https://www.example.com/bells",
                Image = "https://cdn.pixabay.com/photo/2020/03/13/08/19/ornaments-4927258__340.jpg",
                DatePublished = new DateTime(2022,03,4)
            },
            new Book
            {
                Title = "Singers and Vampires",
                Author = new Author{Name = "Gargi Sudheer"},
                Summary = "In a world where vampires run large corporations, one singer has no choice but to protect mankind using a magic ring. It turns out the vampires are all sheep.",
                Link = "https://example.com/baseball/adjustment.aspx?airplane=border&advertisement=argument",
                Image = "https://cdn.pixabay.com/photo/2016/08/07/18/22/back-to-school-1576791__340.jpg",
                DatePublished = new DateTime(1972,04,24),
                EditionCount = 2
            }



        };
        }
    }
}