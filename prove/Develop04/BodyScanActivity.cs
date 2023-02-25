public  class BodyScanActivity : Activity
{
    List<string> _bodyParts = new List<string>();
    public BodyScanActivity(): base("Body Scan", "This activity will have you scan through your body and release any stress and tension in each part.", 60)
    {
        CompileParts();
    }
    private void CompileParts()
    {
        _bodyParts.Add("toes");
        _bodyParts.Add("feet");
        _bodyParts.Add("calves");
        _bodyParts.Add("thighs");
        _bodyParts.Add("hips");
        _bodyParts.Add("glutes");
        _bodyParts.Add("chest");
        _bodyParts.Add("lower back");
        _bodyParts.Add("upper back");
        _bodyParts.Add("fingers");
        _bodyParts.Add("hands");
        _bodyParts.Add("forearms");
        _bodyParts.Add("biceps");
        _bodyParts.Add("shoulders");
        _bodyParts.Add("neck");
        _bodyParts.Add("face");
    }
    public void RunActivity()
    {
        DisplayBeginningMessage();
        foreach (string part in _bodyParts)
        {
            Console.Clear();
            System.Console.WriteLine($"Relax and relieve your {part}.");
            PauseWithSpinner(_duration/_bodyParts.Count());
        }
        DisplayEndingMessage();
    }

}