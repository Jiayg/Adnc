namespace System;

public static class ArrayExtension
{
    /// <summary>
    ///     Copies a specified number of bytes from a source array starting at a particular offset to a destination array
    ///     starting at a particular offset.
    /// </summary>
    /// <param name="src">The source buffer.</param>
    /// <param name="srcOffset">The zero-based byte offset into .</param>
    /// <param name="dst">The destination buffer.</param>
    /// <param name="dstOffset">The zero-based byte offset into .</param>
    /// <param name="count">The number of bytes to copy.</param>
    public static void BlockCopy([NotNull] this Array src, int srcOffset, Array dst, int dstOffset, int count) => Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);

    /// <summary>
    /// sub datas from array 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="arr"></param>
    /// <param name="start"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    public static T[] Sub<T>(this T[] arr, int start, int count)
    {
        var val = new T[count];
        for (var i = 0; i < count; i++)
        {
            val[i] = arr[start + i];
        }
        return val;
    }
}
