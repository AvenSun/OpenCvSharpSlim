
# OpenCvSharpSlim

- This project provides the slim build of OpenCvSharp native library .

- Currently there're binary packages for OpenCvSharp  **2.4.10**.

- Webp, Tiff reading and saving are not included.


# Size
|package|size|
|---|---|
|[OpenCvSharpSlim-2.4.10-x86.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-2.4.10-x86.zip)  (x86)| 1.3MB |
|[OpenCvSharpSlim-2.4.10-x64.zip](https://github.com/AvenSun/OpenCvSlim/raw/master/OpenCvSharpSlim-2.4.10-x64.zip)  (x64)| 1.5MB |

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