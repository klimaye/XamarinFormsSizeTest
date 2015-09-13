# XamarinFormsSizeTest 13 Sept 2015
We start with a empty PCL based XamForms app, slowly add essential packages and observe the iOS app store and play store sizes.
# Steps

### base Project created by Xamarin Studio
 * Droid : 9.18 MB (armeabi-v7a)
 * iOS : 38.54 MB (armv7 + armv7s + arm64)
 * iOS : 27.03 MB (armv7 + arm64)

### add NewtonSoft.Json package to PCL
 * iOS : 38.03 MB
 * Droid : 11.76 MB

### add RestSharp.Portable package to PCL
 * iOS : 40.2 MB
 * Droid : 11.91 MB

### add XLabs.Forms package to PCL, iOS and Droid
 * iOS : 43.36 MB
 * Droid : 12.19 MB

### Notes
These were the observed sizes with Xamarin.Forms 1.4.4 on Sept 13th 2015
