using System;

class Die
{
    private Random random;

    public Die()
    {
        random = new Random();
    }

    public int Roll()
    {
        return random.Next(1, 7);
    }
}