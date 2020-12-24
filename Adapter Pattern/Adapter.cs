class ToAdapt
{
   public int Calculate(int a, int b)
   {
      return a * b;
   }
}

class IAdaptInterface
{
   public void CalculateWithLessParameters(int a);
}

class Adapter : ToAdapt, IAdaptInterface
{
   public int CalculateWithLessParameters(int a)
   {
      return Calculate(a, 10);
   }
}
