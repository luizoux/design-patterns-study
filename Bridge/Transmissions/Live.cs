using Bridge.Platforms;

namespace Bridge.Transmissions;

class Live : ITransmisson
{
    protected IPlatform platform;

    public Live(IPlatform platform)
    {
        this.platform = platform;
    }

    public void Broadcasting()
    {
        Console.WriteLine($"Inciando a transmissão na {platform}");
    }

    public void Result()
    {
        Console.WriteLine("**** ON AIR ****");
    }
}
