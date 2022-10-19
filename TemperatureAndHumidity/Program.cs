class program {
    public static bool temperature()
    {
      return true;
    }

     public static bool humidity()
    {
      return true;
    }

    static void Main(string[] args){
        if(temperature() || humidity())
        {
            Console.WriteLine("Torn on conditioner");
        }
        else
        {
            Console.WriteLine("not need");
        }
    }
}
