
# OpenCvSharpSlim

- This project provides the slim build of OpenCvSharp native library .

- Currently there're binary packages for OpenCvSharp  **2.4.10**, **3.4.20**  and **4.8.0**.

- The unit tests (339) for the most commonly used functions have all passed.

- Webp, Tiff reading and saving are not included.

<img src="/images/xunit.jpg" />

# Size
|package|size|
|---|---|
|[OpenCvSharpSlim-2.4.10-x86.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-2.4.10-x86.zip)  (x86)| 1.3MB |
|[OpenCvSharpSlim-2.4.10-x64.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-2.4.10-x64.zip)  (x64)| 1.5MB |
|[OpenCvSharpSlim-3.4.20-x86.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-3.4.20-x86.zip)  (x86)| 1.9MB |
|[OpenCvSharpSlim-3.4.20-x64.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-3.4.20-x64.zip)  (x64)| 2.5MB |
|[OpenCvSharpSlim-4.8.0-x86.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-4.8.0-x86.zip)  (x86)| 2.2MB |
|[OpenCvSharpSlim-4.8.0-x64.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-4.8.0-x64.zip)  (x64)| 2.9MB |

# Usage 

Download  **zip** file and replace the original **OpenCvSharpExtern.dll**, that's all !

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