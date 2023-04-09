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
    class CommandInvoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public async Task RunAsync()
        {
            await Task.Run(() => _command.ExecuteAsync());
        }
    }

}
