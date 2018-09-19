using System;
using System.Configuration;
using System.Media;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;

namespace Project_Arcade
{
    internal class Program
    {
        public static void Music()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\vmadmin\RiderProjects\Project_Arcade\ArcadeMusic.wav";
            player.Play();
        }


        public static void Main(string[] args)
        {
            GameChooser.ShowText();
            Music();
            GameChooser.Select();
        }
    }
}