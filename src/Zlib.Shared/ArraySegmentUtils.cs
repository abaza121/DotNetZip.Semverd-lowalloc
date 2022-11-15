using System;

namespace Ionic.Zip.Utils
{
    public static class ArraySegmentUtils
    {
        public static void Copy<T>(ArraySegment<T> source, int sourceIndex, ArraySegment<T> destination, int destinationIndex, int length)
        {
            if (sourceIndex + length > source.Count || destinationIndex + length > destination.Count) throw new ArgumentOutOfRangeException();
            source.Slice(sourceIndex, length).CopyTo(destination.Slice(destinationIndex, length));
        }

        public static void Copy<T>(ArraySegment<T> source, int sourceIndex, T[] destination, int destinationIndex, int length)
        {
            if (sourceIndex + length > source.Count) throw new ArgumentOutOfRangeException(nameof(source));
            var destinationSegment = new ArraySegment<T>(destination, destinationIndex,length);
            source.Slice(sourceIndex, length).CopyTo(destinationSegment);
        }
        public static void Copy<T>(T[] source, int sourceIndex, ArraySegment<T> destination, int destinationIndex, int length)
        {
            if (destinationIndex + length > destination.Count) throw new ArgumentOutOfRangeException(nameof(destination));
            var sourceSegment = new ArraySegment<T>(source, sourceIndex, length);
            sourceSegment.CopyTo(destination.Slice(destinationIndex, length));
        }

        public static void Clear<T>(ArraySegment<T> target, int index, int length)
        {
            if (index + length > target.Count) throw new ArgumentOutOfRangeException(nameof(length));
            Array.Clear(target.Array, target.Offset + index, length);
        }
    }
}