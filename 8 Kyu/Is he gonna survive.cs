class Kata
{
    public static bool Hero(int bullets, int dragons)
    {
        return dragons != 0 ? bullets / dragons >= 2 : false;
    }
}