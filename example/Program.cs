using System;
using System.Diagnostics;
using System.IO;
using OpenCvSharp;

namespace OpenCvSharpSlim.PutTextUnicode
{
    class Program
    {
        private static readonly string baseDir = AppContext.BaseDirectory;

        static void Main(string[] args)
        {
            Mat src = new(600, 800, MatType.CV_8UC3, Scalar.Wheat);

            var loops = 32;
            var sw = new Stopwatch();

            sw.Start();
            for (var i = 0; i < loops; i++)
            {
                var pos = new Point(new Random().Next(10, src.Width - 100), new Random().Next(20, src.Height - 20));

                Slim.PutTextUnicode(src, "☆★中華人民共和國★☆γε",
                    pos, Scalar.Red, 36);

                Slim.PutTextUnicode(src, "●中華の台頭のために本を読む●",
                    pos + new Point(0,80), Scalar.Black, 26);
            }
            sw.Stop();

            //drawing two times in one loop
            Console.WriteLine($"time {sw.ElapsedMilliseconds/(loops*2.0):F6} ms.");

            Cv2.ImWrite(Path.Combine(baseDir, "result.jpg"), src);
        }
    }
}
