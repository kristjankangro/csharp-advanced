namespace ConsoleApp2;

public class VideoEncoder
{
    public event EventHandler<VideoEventArgs> VideoEncoded;
    
    public void Encode(Video video)
    {
        Console.WriteLine("Encoding video");
        Thread.Sleep(3000);
        
        OnVideoEncoded(video);
    }

    protected virtual void OnVideoEncoded(Video video)
    {
        VideoEncoded(this, new VideoEventArgs{ Video = video});
    }
}