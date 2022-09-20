# Xamarin Picker (SfPicker) Overview

The picker control allows you to pick an item among a list of items that can be customized with custom view. This control can be opened as dialog. Its rich feature set includes functionalities such as data binding, multi column, header/footer, custom view on header/footer, and default validation buttons.

For know more details about Picker: https://www.syncfusion.com/xamarin-ui-controls/xamarin-picker

Picker user guide documentation: https://help.syncfusion.com/xamarin/picker/gettingstarted

## Syncfusion Controls

This project uses the following Syncfusion controls:

* [SfPicker](https://www.syncfusion.com/xamarin-ui-controls/xamarin-picker) - To show the sfpicker localization sample

## Screenshots

<img src="Images/Picker.png"  Width="250"/>

## Supported platforms

| Platforms | Supported versions |
| --------- | ------------------ |
| Android   | API level 19 and later versions |
| iOS | iOS 9.0 and later versions |

Refer to the following link for more details: 
[System Requirements](https://help.syncfusion.com/xamarin/installation-and-upgrade/system-requirements)

## Requirements to run the sample

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available in Visual Studio installer)

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#xamarinforms) for more details.

3. Set any one of the platform specific projects (iOS, Android or UWP) as a start-up project.
4. Clean and build the application.
5. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
