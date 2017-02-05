# ViceAdfDecrypt
Decrypt GTA Vice City ADF files

I wrote this tool in a few minutes when I wanted to listen to the GTA Vice City music without launching the game.
There is already a tool out there called "Vicesimus Alter" but I didn't trust it since it was an Obfuscated Binary for such a simple thing.

The decryption itself is EXTREMELY SIMPLE. It's just the original file XORed with 0x22 per byte.

Usage is very straight forward:
```
ViceAdfDecrypt <input_radio_station.adf>
```
