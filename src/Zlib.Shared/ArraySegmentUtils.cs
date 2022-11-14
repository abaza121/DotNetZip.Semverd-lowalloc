using System;

namespace Ionic.Zip.Utils
{
    public static class ArraySegmentUtils
    {
        public static void Copy<T>(ArraySegment<T> source, int sourceIndex, ArraySegment<T> destination, int destinationIndex, int length)
        {
            if (sourceIndex + length > source.Count || destinationIndex + length > destination.Count) throw new ArgumentOutOfRangeException();
            Array.Copy(source.Array, source.Offset + sourceIndex, destination.Array, destination.Offset + destinationIndex, length);
        }

        public static void Copy<T>(ArraySegment<T> source, int sourceIndex, T[] destination, int destinationIndex, int length)
        {
            if (sourceIndex + length > source.Count) throw new ArgumentOutOfRangeException(nameof(source));
            Array.Copy(source.Array, source.Offset + sourceIndex, destination, destinationIndex, length);
        }
        public static void Copy<T>(T[] source, int sourceIndex, ArraySegment<T> destination, int destinationIndex, int length)
        {
            if (destinationIndex + length > destination.Count) throw new ArgumentOutOfRangeException(nameof(destination));
            Array.Copy(source, sourceIndex, destination.Array, destinationIndex + destination.Offset, length);
        }

        public static void Clear<T>(ArraySegment<T> target, int index, int length)
        {
            if (index + length > target.Count) throw new ArgumentOutOfRangeException(nameof(length));
            Array.Clear(target.Array, target.Offset + index, length);
        }
    }
}