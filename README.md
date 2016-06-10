# File Comparer

[![Build status](https://ci.appveyor.com/api/projects/status/eri80x5w22aqu57s?svg=true)](https://ci.appveyor.com/project/akhilmittal/isolated-shell-application)


Download this extension from the [VS Gallery](https://visualstudiogallery.msdn.microsoft.com/6670e475-0ead-49b9-bc45-858a35ee86b6)
or get the [CI build](http://vsixgallery.com/extension/58d83af4-8f4c-48c1-85fb-25bfc5717873/).

---------------------------------------

Visual Studio Extension to compare two files in solution explorer.

See the [changelog](CHANGELOG.md) for changes and roadmap.

## Features

- Compare two files in solution explorer.

### Compare two files
Select two files in solution explorer and right click to get Compare Files... option to compare the selected files.

![File](snaps/file.png)

When Compare Files... option selected, both the files will be opened in left panel and show the difference.

![File Diff](snaps/file_diff.png)

Feature to select second file from disk and compare. Select one file and right click to select "Compare Files..."

![File Dialog](snaps/file_dialog.png)

Get the comparison diff window

![Diff Window](snaps/diff_window.png)



## Contribute
Check out the [contribution guidelines](CONTRIBUTING.md)
if you want to contribute to this project.

For cloning and building this project yourself, make sure
to install the
[Extensibility Tools 2015](https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6)
extension for Visual Studio which enables some features
used by this project.

## License
[Apache 2.0](LICENSE)