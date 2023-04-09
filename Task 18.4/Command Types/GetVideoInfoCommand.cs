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
    class GetVideoInfoCommand : ICommand
    {
        private readonly string _videoUrl;
        private Video _video;

        public GetVideoInfoCommand(string videoUrl)
        {
            _videoUrl = videoUrl;
        }

        public async Task ExecuteAsync()
        {
            var videos = new YoutubeClient();
            ///не работает метод GetAsyn()\GetVideoAsync() объяснений нет////
            /
            
            _video = await videos.GetAsync(_videoUrl);
            Console.WriteLine($"Название видео: {_video.Title}");
            Console.WriteLine($"Описание: {_video.Description}");
        }

        public Video GetVideo()
        {
            return _video;
        }
    }
}
