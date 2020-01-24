[string[]]$list=@()
$br = "`n"
$lastInstalls = "The last programs you have to install are :"
$endingMessage = "See ya!"

    #Bnchmrk
choco install burp-suite-free-edition cpu-z crystaldiskinfo gpu-z -ry
choco install nmap wiztree -ry
$list+="CheckFlash"
$list+="Everest"
    #Browser
choco install firefox tor-browser -ry
    #DocEdit
choco install atom calibre libreoffice-still notepadplusplus typora -ry
choco install foxitreader -ry --ia '/COMPONENTS="pdfviewer","ffaddin","ffSpeckllCheck" /TASKS="Quicklaunchicon","setDefaultReader","DISABLE_UNINSTALL_SURVEY"'
$list+="TreeSheets"
    #FileMgmt
choco install 7zip deluge doublecmd file-converter fileoptimizer -ry
choco install winscp -ry
choco install everything -ry --params "/quick-launch-shortcut /run-on-system-startup"
    #Gaming
choco install 0ad mumble playnite steam -ry
$list+="LaunchBox"
    #ITwork
choco install github-desktop thunderbird -ry
choco install virtualbox -ry --params "/NoDesktopShortcut "
choco install vscodium -ry --params "/NoQuicklaunchIcon /NoAddContextMenuFiles /NoAddContextMenuFolders /AssociateWithFiles"
$list+="Construct 2"
    #Media
choco install aimp audacity honeyview inkscape paint.net -ry
choco install vlc -ry
    #Prdctvty
choco install activitywatch autohotkey f.lux open-shell ueli -ry
    #Utilities
choco install cmder keepass putty qtox rufus -ry
choco install sharex shutup10 speedcrunch -ry
choco install copyq -ry --params "/NoDesktopIcon /ToggleShortcut:ctrl+q"
$list+="DeepSound"
$list+="HiBit Uninstaller"
$list+="Turtl"

$lastInstalls
foreach($program in $list){"• "+$program}
$endingMessage
