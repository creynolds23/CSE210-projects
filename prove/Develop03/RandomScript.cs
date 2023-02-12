public class RandomScript
{

    private string _randomScript;
    private List<string> _scriptures = new List<string>{"Moses 1:39 /For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.",
                                                        "Proverbs 3:5-6 /Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
                                                        "John 3:5 /Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.",
                                                        "Alma 41:10 /Do not suppose, because it has been spoken concerning restoration, that ye shall be restored from sin to happiness. Behold, I say unto you, wickedness never was happiness."};


    public string GetRandomScript()
    {
        Random random = new Random();
        int randint = random.Next(_scriptures.Count);
        string _randomScript = (_scriptures[randint]);
        return _randomScript;
    }
}


