using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Player
    {
        const int MIN_VOLUME = 0;
        const int MAX_VOLUME = 1000;
        private int _volume;
        public int Volume
        {
            get
            {
                return _volume;
            }

            private set
            {
                if (value < MIN_VOLUME)
                {
                    _volume = MIN_VOLUME;
                }
                else if (value > MAX_VOLUME)
                {
                    _volume = MAX_VOLUME;
                }
                else
                {
                    _volume = value;
                }
            }
        }
        public bool Locked;
        private bool _playing;
        public bool Playing
        {
            get { return _playing; }
        }

        //B5-Player-3/10
        public void VolumeUp()
        {
            Volume++;
            Console.WriteLine("Sound was increased");
        }

        public void VolumeDown()
        {
            Volume--;
            Console.WriteLine("Sound was reduced");
        }

        public void VolumeChange(int step)
        {
            Volume += step;
            Console.WriteLine("Sound was changed according to the specific value");
        }
        public void Lock()
        {
            Locked = true;
            Console.WriteLine("Player has been Locked");
        }

        public void Unlock()
        {
            Locked = false;
            Console.WriteLine("Player has been Unlocked");
        }

        public bool Stop()
        {
            Console.WriteLine("Player has stopped");
            if (Locked = false)
            {
                _playing = false;
                return _playing;
            }
            else
            {
                _playing = true;
                return _playing;
            }            
        }

        public bool Start()
        {
            Console.WriteLine("Player has started playing");
            if (Locked = false)
            {
                _playing = true;
                return _playing;
            }
            else
            {
                _playing = false;
                return _playing;
            }
            
        }
        //public void Play()
        //{
        //    Console.WriteLine($"Player is playing: {Songs[0].Name}");
        //}
    }
}
