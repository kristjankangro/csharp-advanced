// See https://aka.ms/new-console-template for more information

using ConsoleApp2;

Console.WriteLine("Hello, World!");

var v = new Video { Title = "sdg" };
var ms = new MailService();
var ve = new VideoEncoder();
ve.VideoEncoded += ms.OnVideoEncoded;
ve.Encode(v);


