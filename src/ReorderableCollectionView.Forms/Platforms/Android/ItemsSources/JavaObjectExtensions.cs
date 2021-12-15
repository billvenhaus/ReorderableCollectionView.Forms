using System;

// Cloned from the main Xamarin.Forms repository.
// No changes were made.
// https://github.com/xamarin/Xamarin.Forms/tree/5.0.0/Xamarin.Forms.Platform.Android/Extensions/JavaObjectExtensions.cs
namespace ReorderableCollectionView.Forms
{
	internal static class JavaObjectExtensions
	{
		public static bool IsDisposed(this Java.Lang.Object obj)
		{
			return obj.Handle == IntPtr.Zero;
		}

		public static bool IsAlive(this Java.Lang.Object obj)
		{
			if (obj == null)
				return false;

			return !obj.IsDisposed();
		}

		public static bool IsDisposed(this global::Android.Runtime.IJavaObject obj)
		{
			return obj.Handle == IntPtr.Zero;
		}

		public static bool IsAlive(this global::Android.Runtime.IJavaObject obj)
		{
			if (obj == null)
				return false;

			return !obj.IsDisposed();
		}
	}
}