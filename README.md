Xamarin.Forms.NavFix Demo
===

This is a repro case of what happens when navigating asynchronously using Xamarin.Forms AppCompat backend.

The fixed Build of Xamarin.Forms containing the `AllowStateLoss` flag on `NavigationPage` can be found here:

[https://github.com/monostefan/Xamarin.Forms/releases/tag/2.3.2](https://github.com/monostefan/Xamarin.Forms/releases/tag/2.3.2)

Add the package to local NuGet repository in order to try out.