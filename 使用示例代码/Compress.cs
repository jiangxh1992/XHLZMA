using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;
public class Compress : MonoBehaviour {
    public Text text = null;
    [DllImport("LZMA")]
    public static extern int LZMAAdd(int x);
    [DllImport("LZMA")]
    public static extern int DefaultLzmaCompress(byte[] src, int srcLen, byte[] dest, ref int destLen);
    [DllImport("LZMA")]
    public static extern int DefaultLzmaUncompress(byte[] src, ref int srcLen, byte[] dest, ref int destLen);
	// Use this for initialization
	void Start () {
        // 压缩
        string input = "122333444455555666666777777788888888999999999";
        byte[] src = System.Text.Encoding.Default.GetBytes(input);
        byte[] dest = new byte[src.Length];
        int srcLen = src.Length;
        int destLen = dest.Length;
        int compressRes = DefaultLzmaCompress(src, srcLen, dest, ref destLen); // 压缩成功compressRes会返回0，destLen的值会变成压缩后的数据长度

        // 解压
        byte[] unsrc = new byte[destLen];
        for (int i = 0; i < destLen; i++) {
            unsrc[i] = dest[i]; // 将压缩后得到的dest数据复制到解压的src数据缓冲中
        }
        srcLen = destLen;
        destLen = src.Length;
        byte[] undest = new byte[destLen];
        int uncompressRes = DefaultLzmaUncompress(unsrc, ref srcLen,undest, ref destLen);
        string output = System.Text.Encoding.Default.GetString(undest); // 解压成功output应该和input值相同
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
