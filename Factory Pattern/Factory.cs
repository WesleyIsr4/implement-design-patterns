interface IShip
{
   string Name();
}

class BigShip : IShip
{
   public string Name()
   {
      return "Big ship";
   }
}

class SmallShip : IShip
{
   public string Name()
   {
      return "Small ship";
   }
}

class Creator
{
   private bool _bigShipAvailable = true;
   public IShip FactoryMethod()
   {
      if (_bigShipAvailable)
      {
         _bigShipAvailable = false;
         return new BigShip();
      }
      else
      {
         return new SmallShip();
      }
   }
}