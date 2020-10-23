# GUI Improvements / Enhancements

#### Added:
- New button to toggle recursive searching through directories. Default is still to only search the folder given.
- New buttons to Select All and Clear All assemblies from the list
- New button to Reset the GUI
- New field to enter an alternate output filename (default name is now docs.json). Extension is still always .json
- New field to enter an alternate output Path (does not require "\" at the end but works with it as well). This defaults to blank and outputs to the path where the assemblies are located. If given an alternate path it will remain and not be reset when the Reset All button is clicked.
- Drag-n-Drop functionality added to the GUI if you drop a directory it will now correctly add the path to the Path textbox and update the list of assemblies accordingly (Recursion should be selected prior to this if you wish to utilize it). This will also trigger an update of the assemblies list if you Drop a new directory in the GUI, so you can rapidly output multiple .json files to a unified location now without Resetting the App or closing it. Just assign an output path (if you want), then drop a folder, select the assemblies you want, set a name (if you want or if they're going to a unified directory), generate, drop another folder, select assemblies, set a name, generate, etc...
- Pasting a path into the Path textbox will now correctly update the list of assemblies accordingly (Recursion works with this if selected before as well).
- Changed the list of assemblies to only display the filename instead of the full path and filename. This is cleaner and more functional than before but can be somewhat problematic in cases where recursion is used and there are duplicate assemblies involved. However, you can now always see the file you are selecting where before if the path was too long the filename was not visible and there was no way to see it.
- A few aesthetic improvements were made as well (Reset All button is Light Red, Generate button is Light Green, toggling Recursion alternates the red/green true/false text next to it, etc...)
- The text instructions in the GUI have also been updated to reflect these changes as needed.

#### Issues:
 - Allowing for the filename to be changed caused the Console solution to break. This is due to the new field I added to the Generate method in JsonHelpFileGenerator.cs
I didn't bother fixing the problem since the console app is of no interest to me currently.
 - Pasting a path into the Path textbox only works the first time. Subsequent pasting will not result in the list updating to reflect the new directory. Not sure offhand why but it's likely improperly handled Event related stuff :)
- Dropping a file does not add the files path to the Path textbox. Instead it is simply ignored. Would be nice if it did that but I haven't bothered to figure out why it doesn't as of now.
 - Likely something else I would guess but that's all I can think of for now.

#### Unchanged:
- Sadly I have not yet changed any of the underlying functionality as to how this generates .json files. Ideally it would work to some degree on assemblies with no XML files avaliable, and it should work on assemblies that have XML files that are not correct or incomplete as well. There are other minor issues with this and it's concerns for the XML files that would be nice to have resolved as well, but I'm not sure if I will get around to fixing these issues or be able to if I find the time to try my hand at it.

# New GUI
<img src="https://github.com/GrimblyGorn/Doxie/blob/master/_Misc/new_GUI.png" alt="GUI" />

#### TODO:

 - Fix the Browse option to retain the last location selected.
 - Fix the Recursive toggle button to have better Event handling than it currently does.
 - Fix the Path textbox to have better Event handling than it currently does.
 - Fix the Drag & Drop function to fetch the path of a file dropped in the GUI so it doesn't always have to be a Folder or Directory that's dropped in.
 - Add an error output field to the GUI to give visual feedback on what is happening when dealing with incorrect assemblies or assembly XML files that throw issues within the parser.
 - Fix the XML dependency so that it will still generate a JSON file for assemblies that have malformed, incomplete, incorrect, or no XML file. Even if that only offers partial coverage over the assembly it's still better than nothing.
 - Probably a few other things not mentioned here or up above in the Issues area I laid out previously.  



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
