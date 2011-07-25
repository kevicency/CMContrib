$packages = ls -Filter packages.config -recurse
foreach($package in $packages) { ./nuget/nuget.exe i $package.FullName -o packages }