namespace ConsoleApp2;

public class MessageService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Send(e.Video.Title);
    }
    
    private void Send(string name)
    {
        Console.WriteLine("message send: "+ name);
    }
}