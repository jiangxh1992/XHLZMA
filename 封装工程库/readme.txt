1.LZMA（Xcode）是一个iOS的静态库工程，直接在xcode中run一下即可得到对应的.a静态库，顶层接口封装在LZMALib.c中；

2.LZMA(AndroidStudio)是一个支持runtime C++的安卓工程，顶层接口封装在LZMALib.c中，build一下对应的.so库会装进apk包中，解压apk可以得到里面的LZMA so库（apk路径：..\app\build\outputs\apk\debug）。

3.7zSDK(VS)是LZMA官方完整的SDK和源码工程，编译LZMA动态库的工程是其中的LZMALib工程，路径为：..\C\Util\LzmaLib,顶层接口封装在LZMALib.c中。