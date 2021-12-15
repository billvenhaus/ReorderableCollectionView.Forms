using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using ReorderableCollectionViewDemos.UWP;

[assembly: ExportImageSourceHandler(typeof(UriImageSource), typeof(CustomUriImageSourceHandler))]
namespace ReorderableCollectionViewDemos.UWP
{
	// The default UriImageSource handler is not working 100% consistantly. Often returning errors like=>
	// HTTP Request: Could not retrieve https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg/100px-Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg, status code Forbidden
	public class CustomUriImageSourceHandler : IImageSourceHandler
    {
		public Task<Windows.UI.Xaml.Media.ImageSource> LoadImageAsync(Xamarin.Forms.ImageSource imagesource, CancellationToken cancellationToken = new CancellationToken())
		{
			var imageLoader = imagesource as UriImageSource;

			if (imageLoader?.Uri == null)
				return null;

			var image = new BitmapImage();
			image.UriSource = imageLoader.Uri;
			return Task.FromResult((Windows.UI.Xaml.Media.ImageSource)image);
		}
	}
}