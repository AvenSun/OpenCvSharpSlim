

# OpenCvSharpSlim

- This project provides the slim build of OpenCvSharp native library .

- Currently there're binary packages for OpenCvSharp  **2.4.10**, **3.4.20** ,**4.8.0** and **4.8.1**.

- The [unit tests (339)](/images/xunit.jpg) for the most commonly used functions have all passed.

- Webp, Tiff reading and saving are not included.
- **Drawing Chinese/Japanese is supported** . High performance,It's less 1 millisecond.
- Add Nuget package.

<img src="/images/chinese.jpg" />

# Drawing Demo

For details, you can refer to example. If you like this project, you can give it a star.

```c#
Mat src = new(600, 800, MatType.CV_8UC3, Scalar.Wheat);
var pos = new Point(60, 80);
Slim.PutTextUnicode(src, "☆★中華人民共和國★☆γε", pos, Scalar.Red, 36);
Slim.PutTextUnicode(src, "●中華の台頭のために本を読む●",pos + new Point(0,80), Scalar.Black, 26);
Slim.PutTextUnicode(src, "OpenCvSharpSlim", pos + new Point(0, 160), Scalar.Purple, 26, underline:true);
Slim.PutTextUnicode(src, "Runtime For Windows", pos + new Point(0, 240), Scalar.Blue, 26, italic: true);
```



# Nuget Packages

| Package                                | Version                                                                                                                                                 | Description                  |
| -------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------- |
| OpenCvSharp4.slim.runtime.windows-x64                          | [![NuGet](https://img.shields.io/nuget/v/OpenCvSharp4.slim.runtime.windows-x64.svg)](https://nuget.org/packages/OpenCvSharp4.slim.runtime.windows-x64)                                                   | Slim edition of OpenCvSharp4 native bindings for Windows x64       |
| OpenCvSharp4.slim.runtime.windows-x86   | [![NuGet](https://img.shields.io/nuget/v/OpenCvSharp4.slim.runtime.windows-x86.svg)](https://nuget.org/packages/OpenCvSharp4.slim.runtime.windows-x86)   | Slim edition of OpenCvSharp4 native bindings for Windows x86   |
| OpenCvSharp3.slim.runtime.windows-x64     | [![NuGet](https://img.shields.io/nuget/v/OpenCvSharp3.slim.runtime.windows-x64.svg)](https://nuget.org/packages/OpenCvSharp3.slim.runtime.windows-x64)         | Slim edition of OpenCvSharp3 native bindings for Windows x64     |
| OpenCvSharp3.slim.runtime.windows-x86         | [![NuGet](https://img.shields.io/nuget/v/OpenCvSharp3.slim.runtime.windows-x86.svg)](https://nuget.org/packages/OpenCvSharp3.slim.runtime.windows-x86)               | Slim edition of OpenCvSharp3 native bindings for Windows x86    |


# Size
|package|size|
|---|---|
|[OpenCvSharpSlim-2.4.10-x86.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-2.4.10-x86.zip)  (x86)| 1.3MB |
|[OpenCvSharpSlim-2.4.10-x64.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-2.4.10-x64.zip)  (x64)| 1.5MB |
|[OpenCvSharpSlim-3.4.20-x86.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-3.4.20-x86.zip)  (x86)| 1.9MB |
|[OpenCvSharpSlim-3.4.20-x64.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-3.4.20-x64.zip)  (x64)| 2.5MB |
|[OpenCvSharpSlim-4.8.0-x86.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-4.8.0-x86.zip)  (x86)| 2.2MB |
|[OpenCvSharpSlim-4.8.0-x64.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-4.8.0-x64.zip)  (x64)| 2.9MB |
|[OpenCvSharpSlim-4.8.1-x86.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-4.8.1-x86.zip)  (x86)| 2.2MB |
|[OpenCvSharpSlim-4.8.1-x64.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-4.8.1-x64.zip)  (x64)| 2.9MB |

# Usage 

1. Just use Nuget.
2. Download  **zip** file and replace the original **OpenCvSharpExtern.dll**, that's all !


# Modules included

|module|note|
|---|---|
|opencv_core|Mat, matrix operations ...|
|opencv_imgproc|resize, cvtColor, warpAffine, HoughLines, erode ...|
|opencv_highgui|imread, imwrite, imdecode, imencode ...|
|opencv_features2d|keypoint feature and matcher ...|
|opencv_photo|inpaint , fastNlMeansDenoising ...|
|opencv_video|opticalflow, KalmanFilter  ...|

- you can get more details in [OpenCvSlim](https://github.com/AvenSun/OpenCvSlim).


# Build other platform

- You should delete some unused **OpenCv** modeles in  **OpenCvSharpExtern**.
- Download [OpenCvSlim](https://github.com/AvenSun/OpenCvSlim) package and extract, set **OpenCV_INCLUDE_DIR** to **OpenCvSlim** directory. 
- Just build **OpenCvSharpExtern** as usual. 

# Related Projects

- [OpenCvSharp](https://github.com/shimat/opencvsharp)
  - OpenCV wrapper for .NET
-  [OpenCvSlim](https://github.com/AvenSun/OpenCvSlim)
  - Slim Build of OpenCv