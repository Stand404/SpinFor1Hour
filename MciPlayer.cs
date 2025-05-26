using System;

namespace Spin_for_1_hour
{
    using System.Runtime.InteropServices;

    public static class MciPlayer
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, IntPtr hwndCallback);

        public static void mciPlay(string strFileName)
        {
            // 打开 MP3 文件并为其分配一个别名
            string openCommand = $"open \"{strFileName}\" type mpegvideo alias MyMp3";
            mciSendString(openCommand, null, 0, IntPtr.Zero);

            // 播放 MP3 文件
            string playCommand = "play MyMp3 repeat";
            mciSendString(playCommand, null, 0, IntPtr.Zero);
        }

        public static void mciStop()
        {
            // 停止播放
            string stopCommand = "stop MyMp3";
            mciSendString(stopCommand, null, 0, IntPtr.Zero);

            // 关闭文件
            string closeCommand = "close MyMp3";
            mciSendString(closeCommand, null, 0, IntPtr.Zero);
        }
    }
}
