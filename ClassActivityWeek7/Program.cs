internal class Program
{
    public interface IPlayable
    {
        void Play();
    }


    class Piano : IPlayable
    {


        public void Play()
        {
            Console.WriteLine("PIANO IS NOW PLAYING");
        }
    }
    class Guitor : IPlayable
    {


       public  void Play()
        {

            Console.WriteLine("Guitor IS NOW PLAYING");
        }
        public static void Main(string[] args)
        {
            Piano piano = new Piano();
            Guitor guitor = new Guitor();
            piano.Play();
            guitor.Play();
        }
    }
}

