using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using OpenCvSharp;
using OpenCvSharp.Internal;

namespace OpenCvSharp
{
    static public class Slim
    {
        /// <summary>
        ///     renders unicode text string in the image,
        ///     full support of Chinese/Japanese character set
        /// </summary>
        /// <param name="img">Image.</param>
        /// <param name="text">Text string to be drawn.</param>
        /// <param name="org">Bottom-left corner of the text string in the image.</param>
        /// <param name="color">Text color.</param>
        /// <param name="fontSize">Font size</param>
        /// <param name="fontName">The name of font,it must be existed in C:\Windows\Fonts</param>
        /// <param name="italic">enable italic type when true</param>
        /// <param name="underline">enable underline when true</param>
        static public void PutTextUnicode(InputOutputArray img, string text, Point org,
            Scalar color,
            int fontSize, string fontName = "微软雅黑", bool italic = false, bool underline = false)
        {
            if (img == null)
                throw new ArgumentNullException(nameof(img));
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException(text);
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException(fontName);
            img.ThrowIfDisposed();

            NativeMethods.HandleException(imgproc_putTextUnicode(img.CvPtr, text, org, color, fontSize, fontName,
                italic, underline));

            img.Fix();
            GC.KeepAlive(img);
        }

        [Pure]
        [DllImport("OpenCvSharpExtern", CallingConvention = CallingConvention.Cdecl, BestFitMapping = false,
            ThrowOnUnmappableChar = true, ExactSpelling = true)]
        private static extern ExceptionStatus imgproc_putTextUnicode(IntPtr img,
            [MarshalAs(UnmanagedType.LPStr)] string text, Point org,
            Scalar color,
            int fontSize, [MarshalAs(UnmanagedType.LPStr)] string fontName, bool italic, bool underline);
    }
}
