# F00F
Godot 4 C# Git Template

This [template](https://docs.github.com/en/repositories/creating-and-managing-repositories/creating-a-repository-from-a-template#creating-a-repository-from-a-template) can be used to create a C#-ready repository for Godot projects.

(**VS2026:** Turn off Diagnostic Tools while debugging, otherwise log file will remain locked)

## Features:
 - Configured for 3D by default (but contains preferred 2D pixel-art settings as comments - oops, these got removed when opening in editor!)
 - Contains Launch Settings to run game/editor from Visual Studio IDE (tip: use [symlinks](https://schinagl.priv.at/nt/hardlinkshellext/linkshellextension.html) to manage versions)
 - Contains a GitHub Workflow to export game to a WIP release whenever wip branch is updated (tip: recreate branch to trigger export)
 - Contains a setup script that can be run with Git Bash to download external addons and git repos (see extras)
 - Contains VS editor & filenesting config with corresponding csproj inclusions
 - Contains GD export presets with default project settings
 - Contains basic Assets/Game/addons folder structure
 - Contains shortcut to user data folder
 - Configured for .NET9

## Usage:
1. Set name & description in project.godot, build and run in Visual Studio:
   - Updates README.md with new name and description (and trims template text)
   - Updates VS launch settings to use current Godot version
   - Updates Github Workflow to use current Godot version
   - Updates export presets with new name
   - Renames sln & csproj with new name
2. Exit Visual Studio (without saving) and open renamed sln
3. ***Commit changes***
4. Edit and run ./setup.sh to get Assets and addons
   - There is a template for Assets [here](https://github.com/Cat-Lips/F00F.Assets)
   - setup.sh can be re-run at any time to update addons
5. Uncomment Game/Main.cs and set Main.tscn as main scene

(currently .appdata shortcut must be updated manually)

## Tips:
 - For Visual Studio, a minimal install of the '.NET Desktop Development' workload is all that's required
 - To open Godot Editor from within Visual Studio, right-click project.godot in Solution Explorer (Solution Items) to set the default OpenWith option to symlinked path

## Extras:
 - Contains a setup script that can be run with Git Bash to download external addons and git repos
   - Negates having to store addons or create submodules in your repository (pros & cons)
   - The addons folder contains a default .gitignore file to exclude all externals
     - (unignore `!` to store local addons)
   - The GitHub Workflow is configured to run setup script if present
   - Requires **Developer Mode** or **Admin Privileges** to create symlinks (see setup.sh for alternative)
