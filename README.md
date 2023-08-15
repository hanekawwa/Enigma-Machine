# Enigma Machine
 Project

This is the initial working version of the project, currently, it has only 3 rotors to choose from, more to be added later, as well as being able to choose which reflector you want to use
(currently, there is only one) and easier access to plugboard settings (will be no need to change it inside the code, for now, you can choose plugboard settings by changing the PLUG dictionary)

The Enigma machine is symmetric so you can both encipher plaintext and decipher ciphertext if both the sender and recipient know the settings of the enigma machine as they should be the same.
To choose which rotors to use, please write their numbers with Roman numerals (i.e I, II, III. For now there are only three such rotors) and for setting the offset and ring settings write with normal numbers (0-26). The machine ignores punctuation and spaces, and outputs the message separated with one space every five letters, which is historically accurate. The rotors are stored in separate files, named I.txt, II.txt, and III.txt respectively. Later on everything else will also be stored in separate files instead of dictionaries in the code to make it cleaner.
