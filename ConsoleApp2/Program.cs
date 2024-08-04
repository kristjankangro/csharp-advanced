// See https://aka.ms/new-console-template for more information

using ConsoleApp2;

Console.WriteLine("Hello, World!");

var v = new Video { Title = "Nimi sdg" };
var ms = new MailService();
var ms2 = new MessageService();
var ve = new VideoEncoder();
ve.VideoEncoded += ms.OnVideoEncoded;
ve.VideoEncoded += ms2.OnVideoEncoded;
ve.Encode(v);


