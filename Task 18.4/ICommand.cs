using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;


namespace Task_18._4
{
    interface ICommand
    {
        Task ExecuteAsync();
    }
}
