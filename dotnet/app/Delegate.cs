namespace app
{
    public class Delegate
    {
        public delegate void Delgo(string str);

        public void FooBar(string message)
        {

        }

        public void BarFoo(Delgo f)
        {
            f("blah");
        }

        ///////////////
        void Do()
        {

        }
    }
}