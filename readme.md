# WPF External Assembly Resource Lookup Test Project
In this project I'm trying to access resouces from a separate Assembly.

The current version fails to do so.

The following line in `MainWindow.xaml` isn't working, no background color is being displayed:

```xml
<StackPanel Grid.Row="0" Background="{DynamicResource {ComponentResourceKey TypeInTargetAssembly={x:Type res:DummyForSharingResources}, ResourceId=TestBg}}"></StackPanel>
```

I published this repository seeking for help.

<br/>

## What I did so far

* "Themes/generic.xaml" file created in supplemental assembly (`StylesAndResources`), filled with resources.
* `ThemeInfoAttribute` updated in application assembly to reference `ResourceDictionaryLocation.ExternalAssembly`.
* Dummy class created in `StylesAndResources` in order to be able to have a [`ComponentResourceKey`](https://docs.microsoft.com/dotnet/desktop/wpf/advanced/componentresourcekey-markup-extension) be generated.

<br/>

## What am I doing wrong?