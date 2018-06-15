#include <jni.h>
#include "LzmaLib.h"

JNIEXPORT jint JNICALL Java_com_example_jiangxinhou01_lzmaso_MainActivity_XHTest(JNIEnv *env,jobject obj,jint x) {
    return LZMAAdd(x);
}