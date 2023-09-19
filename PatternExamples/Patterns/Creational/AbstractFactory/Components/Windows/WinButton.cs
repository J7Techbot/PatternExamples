namespace AbstractFactory.Components.Windows
{
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
}
