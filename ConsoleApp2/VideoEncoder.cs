namespace ConsoleApp2;

public class VideoEncoder
{
    public delegate void VideoEncodedEventHandler(object source, EventArgs args);

    public event VideoEncodedEventHandler VideoEncoded;
    public void Encode(Video video)
    {
        Console.WriteLine("Encoding video");
        Thread.Sleep(3000);
        
        OnVideoEncoded();
    }

    protected virtual void OnVideoEncoded()
    {
        if (VideoEncoded != null)
            VideoEncoded(this, EventArgs.Empty);
    }
}

public class Video
{
    public string Title { get; set; }
}

public class MailService
{
    public void OnVideoEncoded(object source, EventArgs e)
    {
        Send();
    }
    
    public void Send()
    {
        Console.WriteLine("Send mauil after encoding doen");
    }
}