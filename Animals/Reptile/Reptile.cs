namespace Animals.Reptile
{
    public abstract class Reptile : Animal
    {
        public int Lenght { get; set; }
        public abstract void Crawl();
    }
}
