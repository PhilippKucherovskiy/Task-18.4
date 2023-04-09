using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

namespace Task_18._4.Command_Types
{
    class DownloadVideoCommand : ICommand
    {
        private readonly Video _video;
        private readonly string _outputFilePath;

        public DownloadVideoCommand(Video video, string outputFilePath)
        {
            _video = video;
            _outputFilePath = outputFilePath;
        }

        public async Task ExecuteAsync()
        {
            var videos = new YoutubeClient();
            var streamInfoSet = await videos.GetAsync(_video.Url);
            var streamInfo = streamInfoSet.Muxed.WithHighestVideoQuality();
            if (streamInfo != null)
            {
                Console.WriteLine($"Загрузка видео {_video.Url}...");
                await videos.DownloadAsync(streamInfo, _outputFilePath);
                Console.WriteLine($"Видео загружено в {_outputFilePath}");
            }
        }
    }

}
