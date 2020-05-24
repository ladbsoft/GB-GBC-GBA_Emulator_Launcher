# GB/GBC/GBA Emulator Launcher
## Small Launcher for GB/GBC/GBA ROMs

I happen to always have several emulators for my GameBoy, GameBoy Color and GameBoy Advance ROMS, and I use one or another depending on the situation:
- If I use a GB/GBC ROM which needs cable link connection, I use [BGB](https://bgb.bircd.org/).
- For other ROMS I usually use [VisualBoyAdvance](https://sourceforge.net/projects/vba/). This is my favourite, so I use it by default if I do not have any problems.
- For some specific ROMS which I encounter problems, I use [VisualBoyAdvance-M](https://github.com/visualboyadvance-m/visualboyadvance-m).

What is normally my setup in my computer? I associate .GB, .GBC and .GB with VisualBoyAdvance, and keep a copy of BGB in the same folder as the roms which I need cable link connectivity. I do the same with VisualBoyAdvance-M. So, if I want to play a ROM, I just double-click the rom icon, unless I have BGB or VisualBoyAdvance-M in that folder, for what I just drag the rom to the executable.

I had some free time and I said "Why not creating a small launcher, which scans the rom folder to see if there's an emulator inside, and in case it is, launch the ROM using that emulator and launch it with a "default" emulator instead?". So I did 😀

This launcher will scan for the following emulator executables in the same folder as the ROM you're trying to launch:

- VisualBoyAdvance.exe
- wxvba-m.exe
- bgb.exe

If it finds any of those, it will launch them using the rom as argument. If it doesn't, it will launch the default emulator, which you can define launching the program without arguments.
