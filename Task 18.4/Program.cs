
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;
using Task_18._4.Command_Types;
using Task_18._4;

class Program
{
    static async Task Main(string[] args)
    {
        var commandInvoker = new CommandInvoker();
        var videoUrl = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        var getVideoInfoCommand = new GetVideoInfoCommand(videoUrl);
        var downloadVideoCommand = new DownloadVideoCommand(getVideoInfoCommand.GetVideo(), "video.mp4");
        commandInvoker.SetCommand(getVideoInfoCommand);
        await commandInvoker.RunAsync();
        commandInvoker.SetCommand(downloadVideoCommand);
        await commandInvoker.RunAsync();
    }
}
