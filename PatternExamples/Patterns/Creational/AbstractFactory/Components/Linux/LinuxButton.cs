namespace AbstractFactory.Components.Linux
{
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
