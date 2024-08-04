namespace ConsoleApp2;

public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Send(e.Video.Title);
    }
    
    public void Send(string name)
    {
        Console.WriteLine("Send mauil after encoding done on: " + name);
    }
}