# Enigma Machine Emulator
Welcome to the Enigma Machine Emulator project! This emulator has been designed to offer a historically accurate experience of the renowned Enigma encryption device.

Features:
- Historical Accuracy: Attempts to emulates the exact working of the Enigma machine, complete with its complexities.
- Double Stepping Mechanism: Implemented to ensure the perfect simulation of the machine's rotor movement.
Rotor & Reflector Choices: Choose from:
- 8 different normal rotors (labelled with Roman numerals like I, II, III, IV, etc.)
- 2 thin rotors (Beta or Gamma) (specific to the Kriegsmarine version).
- 2 normal reflectors.
- 2 thin reflectors (specific to the Kriegsmarine version).
How to Use:
 - Plugboard Setting: Enter settings in the format of "A-B". This denotes a swap between letters 'A' and 'B'.
 - Choosing Reflectors: Simply input the desired number (1 or 2).
 - Choosing Rotors: Input the rotor's label, e.g., "III" or "VI". For thin rotors, input either "Beta" or "Gamma".
Text Input:
- Use only the English alphabet.
- All punctuations will be automatically deleted.
  - Whitespaces are ignored, ensuring the output is:
  - Always in capital letters.
  - Grouped in sets of 5 letters, separated by spaces.
    - Note: This might make the output appear challenging to read, but this format ensures historical accuracy.

Decryption: To decrypt, use the exact same settings as were used during encryption. Make sure to note down your configurations!

Reset Mechanism: After receiving an output, the machine resets. Users need to input their settings again for a new operation.

Two Versions Available:
- Army Version:
  - Uses the normal reflectors.
  - Configured with 3 rotors.
- Kriegsmarine Version:
  - Uses the thin reflectors.
  - Configured with 4 rotors. The 4th rotor is thin (either Beta or Gamma).
    - The 4th rotor doesn't auto-rotate and is set manually.
