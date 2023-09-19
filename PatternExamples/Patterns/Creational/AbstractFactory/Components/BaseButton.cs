namespace AbstractFactory.Components
{
    public abstract class BaseButton
    {
        protected string Content;
        public abstract void OnClick();
    }

    public class WinButton : BaseButton
    {
        public WinButton()
        {
            Content = "WindowsButton";
        }

        public override void OnClick()
        {
            Console.WriteLine(Content);
        }
    }

    public class LinuxButton : BaseButton
    {
        public LinuxButton()
        {
            Content = "LinuxButton";
        }

        public override void OnClick()
        {
            Console.WriteLine(Content);
        }
    }
}
