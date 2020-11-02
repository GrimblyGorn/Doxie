# GUI Improvements / Enhancements

#### Added:
 - New button to toggle recursive searching through directories. Default is still to only search the folder given.
 - New buttons to Select All and Clear All assemblies from the list
 - New button to Reset the GUI
 - New field to enter an alternate output filename (default name is now docs.json). Extension is still always .json
 - New field to enter an alternate output Path (does not require "\\" at the end but works with it as well). This defaults to blank and outputs to the path where the assemblies are located. If given an alternate path it will remain and not be reset when the Reset All button is clicked.
 - Drag-n-Drop functionality added to the GUI if you drop a file or folder it will now correctly add that path to the Path textbox and update the list of assemblies accordingly (Recursion should be selected prior to this if you wish to utilize it). This will also trigger an update of the assemblies list if you Drop a new directory in the GUI by overwriting the previous selection, so you can rapidly output multiple .json files to a unified location now without Resetting the App or closing it. Just assign an output path (if you want), then drop a folder, select the assemblies you want, set a name (if you want or if they're going to a unified directory), generate, drop another folder, select assemblies, set a name, generate, etc...
 - Pasting a path into the Path textbox will now correctly update the list of assemblies accordingly (Recursion works with this if selected before as well). However, pasting a path including a file does not cause the list to update, directory paths are the only thing that works.
 - Changed the list of assemblies to only display the filename instead of the full path and filename. This is cleaner and more functional than before but can be somewhat problematic in cases where recursion is used and there are duplicate assemblies involved. However, you can now always see the file you are selecting where before if the path was too long the filename was not visible and there was no way to see it. Ideally this would display the folder the assembly is in and the filename instead of the entire path. This way you could differentiate between folders in cases where recursion is being used across multiple folders.
 - A few aesthetic improvements were made as well (Reset All button is Light Red, Generate button is Light Green, toggling Recursion alternates the red/green true/false text next to it, buttons toggle off and on at logical times, etc...)
 - The text instructions in the GUI have also been updated to reflect these changes as needed.
 - I also added a new Error handler pop-up window that has select-able text, a Copy-to-Clipboard button with a confirmation text, and stores a numbered list of any application errors thrown with a button to clear the list if needed, and a button to exit the error log and return back to the application.
 - I updated the GUI to compile against .NET 4.8 Framework now. Not really sure why :)

#### Known Issues:
 - Allowing for the filename to be changed caused the Console solution to break. This is due to the new field I added to the Generate method in JsonHelpFileGenerator.cs. I simply removed it from the build list so it's no longer in my project and quit throwing errors I didn't plan to fix.
 - Pasting a path into the Path textobox that includes a filename throws an error and does not update the list of files like it should. 
 - Pasting a path into the Path textbox only works the first time. Subsequent pasting will not result in the list updating to reflect the new directory.  Even using the reset button doesn't fix this. The only way to paste again right now is to close and re-open the app. Not sure offhand why but it's likely improperly handled Event related stuff :)
 - Likely a few other bugs or quirks I would guess but that's all I can come up with for now.

#### Unchanged:
 - Sadly I have not yet changed any of the underlying functionality as to how this generates .json files. Ideally it would work to some degree on assemblies with no XML files available, and it should work on assemblies that have XML files that are not correct or incomplete as well. There are other minor issues with this and it's concerns for the XML files that would be nice to have resolved as well, but I'm not sure if I will get around to fixing these issues, or be able to even if I find the time to try my hand at it.

# New Enhanced GUI & Custom Error Window
<img src="https://github.com/GrimblyGorn/Doxie/blob/master/_Misc/new_GUI.png" alt="GUI" />
<img src="https://github.com/GrimblyGorn/Doxie/blob/master/_Misc/New_ErrorWindow.png" alt="GUI" />

#### TODO:

 - Fix the Browse option to retain the last location selected.
 - Fix the Path textbox to have better Event handling than it currently does.
 - Fix path pasting errors for the Path textbox.
 - Add a radio button to auto-fill the custom name field with the selected file name (minus the .dll extension) when checked and when there is only one assembly checked. In cases where there are two assemblies it could auto-fill the name field to be the folder name, and in cases where recursion was used it could inherit the primary folder given for the name. This of course would only work in Combined mode, which is another TODO item detailed below,
 - Extend the new error handler to catch errors thrown from the CORE assembly during the parsing and creation of the JSON file as well as the application instead of just the application.
 - Add a Split / Combine toggle button that either outputs a single (Combined) JSON or Splits the selected assemblies by outputting as JSON for each of them. I actually made a fairly time consuming attempt at this already but had to revert back to this current version as I simply could not get it working properly. Perhaps I will try again later. Maybe...
 - Fix the XML dependency so that it will still generate a JSON file for assemblies that have malformed, incomplete, incorrect, or no XML file. Even if that only offers partial coverage over the assembly it is still better than nothing. For example this library does not work despite having XML documentation available [C-Sharp-Algorithms](https://github.com/aalhour/C-Sharp-Algorithms) possibly because it's built on .Net Core 2.0? and this one with no documentation [LunarParser](https://github.com/Relfos/LunarParser) which we know won't work but still should. I feel that both of these should still be an option and any similar libraries as well. So, maybe I'll try to make that happen at some point :)
 - Probably a few other things not mentioned here or up above in the Issues area I laid out previously.

#### Possible Issues (Untested Things):

 - As of now I have not tested the Browse button or any of its functionality in some time so it may or may not work. Though it still should. I think...
 - Adding a list of assemblies long enough to need scroll bars may or may not be handled or cause issues. This is entirely unknown to me as I haven't tested that at all so far.
 - The results generated from using Recursion may or may not be valid as I haven't found the time yet to actually look at them. Though it does seem to be generating things correctly on a surface level that may not be the case upon really inspecting the results.
 - I suspect that this does not work on any of the assemblies compiled against any version of .NET Core, but I'm not certain of that right now. I do think it works on all versions of .NET Framework and .NET Standard though. But I haven't, to my knowledge, tested it against really old versions like Framework 2.0 and below for example, so there is a chance it may not work on older versions of both that I'm not aware of currently. 
 - That's all I can think of for now :)   

___
# Original Description

[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=gordon_matt%40live%2ecom&lc=AU&currency_code=AUD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted)

<img src="https://github.com/gordon-matt/Doxie/blob/master/_Misc/logos/Doxie.png" alt="Logo" width="250" />

# Doxie - Help Generator for .NET Assemblies

Built with:

<img src="https://github.com/gordon-matt/Doxie/blob/master/_Misc/logos/Aurelia.png" alt="Built with Aurelia" width="250" />

![Index Page](https://github.com/gordon-matt/Doxie/blob/master/_Misc/Index.png)

![Assembly Page](https://github.com/gordon-matt/Doxie/blob/master/_Misc/Assembly.png)

## Demo

You can find a working demo I deployed to **gh-pages** for my Extenso project, here: https://gordon-matt.github.io/Extenso/.

## Instructions

1. Install [NodeJS](https://nodejs.org/en/download/)
2. Install JSPM globally: `npm install -g jspm`
3. Clone/download this project
4. Restore JSPM packages: `jspm install`
> **NOTE:** Do this from the root directory of the "Doxie" project (not the solution root)
5. Run one of the help file generators (either WinForms or Console version)
6. Grab the generated **assemblies.json** and place it in **Doxie/js**
7. Run Doxie from a web server (example: IIS)
8. Before deploying, modify the site as you like. Some suggestions:
   1. Change the footer text
   2. Change the URL in the GitHub Ribbon
   3. Use a different Bootstrap theme (see: https://cdnjs.com/libraries/bootswatch)

> **NOTE** Regarding step 5: For .NET Core assemblies you need to ensure that all related assemblies are present in the same location as the ones you want to generate pages from. Otherwise the resulting documentation will contain error messages caused by **FileNotFoundException**s. It can be a pain to figure out what assemblies you need to copy, so there's a simple trick you can use to make this very easy:

1. Add a new project to your solution and call it something like **DoxieDummy** or whatever prefer.
2. Reference all the projects in the solution that you want documentation for.
3. Now the important part: Edit the **.csproj** file for this dummy project and add the following: `<CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>`. This will ensure ALL assemblies are copied locally to the output directory. Below is a screenshot example:

![Dummy Project](https://github.com/gordon-matt/Doxie/blob/master/_Misc/Dummy.PNG)

4. Now all you have to do is pass that directory path to one of the "Help File Generators" and tell it which of those assemblies should be documented.

## Bundling

The default setup can be a bit slow. You can improve this by enabling JSPM bundling. I have added the necessary configuration in **packages.json** and **gulpfile.js**. All you need to do is run `gulp bundle`.
> **NOTE:** Gulp tends to complain about the `baseURL` in the **config.js** being set to `location.pathname`. You can temporarily (or permanently if you wish) change this to the hardcoded path you need. In many cases this can be simply `/` and for GitHub pages it tends to be `/[Your Project Name]/`. The Gulp task should run fine then.

> Further Note: You can also swap out JSPM for webpack if you prefer. See Aurelia's documentation for how to do that. And lastly, I will at some point find time to review all the Aurelia packages and see if there are some that can be removed from **packages.json** to further improve performance. No promises on when.

## License

This project is licensed under the [MIT license](LICENSE.txt).

## Credits

The code and XSD schema for reading the XML comments files comes from an old project named Jolt.NET. The original source code can be found here: https://jolt.codeplex.com and RedGate have created their own fork on GitHub here: https://github.com/red-gate/JoltNet-core, which had an important bug fix in it.

As for the UI and the overall idea, I was inspired by [AutoHelp](https://github.com/RaynaldM/autohelp) but totally reworked it to use Aurelia and I also decided it's better to generate a JSON file to read from instead of relying on MVC controller actions to acquire the data. This way, it's easy to use in GitHub pages.

## Donate
If you find this project helpful, consider buying me a cup of coffee.  :-)

#### PayPal:

[![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=gordon_matt%40live%2ecom&lc=AU&currency_code=AUD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted)

#### Crypto:
- **Bitcoin**: 1EeDfbcqoEaz6bbcWsymwPbYv4uyEaZ3Lp
- **Ethereum**: 0x277552efd6ea9ca9052a249e781abf1719ea9414
- **Litecoin**: LRUP8hukWGXRrcPK6Tm7iUp9vPvnNNt3uz
