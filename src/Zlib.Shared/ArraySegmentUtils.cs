using System;

namespace Ionic.Zip.Utils
{
    public static class ArraySegmentUtils
    {
        public static void Copy<T>(ArraySegment<T> source, int sourceIndex, ArraySegment<T> destination, int destinationIndex, int length) => source.Slice(sourceIndex, length).CopyTo(destination.Slice(destinationIndex, length));
        public static void Copy<T>(ArraySegment<T> source, int sourceIndex, T[] destination, int destinationIndex, int length)             => source.Slice(sourceIndex, length).CopyTo(destination,destinationIndex);
        public static void Copy<T>(T[] source, int sourceIndex, ArraySegment<T> destination, int destinationIndex, int length)             => source.AsSpan(sourceIndex, length).CopyTo(destination.AsSpan(destinationIndex));
        public static void Clear<T>(ArraySegment<T> target, int index, int length)                                                         => target.AsSpan(index,length).Clear();
    }
}