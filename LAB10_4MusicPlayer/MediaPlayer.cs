using System;
using System.Collections.Generic;
using System.Text;

namespace LAB10_4MusicPlayer
{
    class MediaPlayer
    {
        public void PlayMedia(IAudioPlayer media)
        {
            media.Play();
        }
    }
}
