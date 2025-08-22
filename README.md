# FotZIP

**Version:** 1.0.0
**Supported Platforms:** Linux (x64), Windows (x64), macOS (x64)
**License:** GNU GPL v3

---

## Overview

FotZIP is a lightweight, single-file ZIP utility designed for creating and extracting ZIP archives quickly and securely.
Currently, the application is **command-line only (CLI)**. GUI version will be added in future releases.

---

## Features

* Create and extract ZIP archives.
* Cross-platform support: Linux, Windows, macOS.
* GPG detached signature support for verifying authenticity.
* Easy to use via terminal or command prompt.

---

## Security & Verification

Each release is signed with a **GPG detached signature** to ensure integrity and authenticity.

### Verifying the Build

1. Import the public key:

```bash
gpg --import fotzip_public_key.asc
```

2. Verify the detached signature:

```bash
gpg --verify FotZIP.sig FotZIP
```

* If the output shows `Good signature` and the correct key ID (`4419366131D22C571C21204E23EE58A626C1A820`), the file is authentic.
* Any tampering or mismatched signature will be flagged as `bad signature`.

---

## Installation

### Linux / macOS

```bash
chmod +x FotZIP
./FotZIP [options]
```

### Windows

* Place `FotZIP.exe` in a folder.
* Run via Command Prompt:

```cmd
FotZIP.exe [options]
```

---

## Usage

Basic examples:

* **Create a ZIP archive:**

1. Run the program:

```bash
./FotZIP
```

2. In the menu, select **2. Create ZIP**.
3. Then, the program will ask for:

   * **Folder path to ZIP** → The folder you want to compress
   * **Output ZIP file path** → The path for the new ZIP file

---

* **Extract a ZIP archive:**

1. Run the program:

```bash
./FotZIP
```

2. In the menu, select **1. Extract ZIP**.
3. Then, the program will ask for:

   * **ZIP file path** → The ZIP archive you want to extract
   * **Extraction folder** → The folder where files will be extracted

---

* **Exit the program:**

1. Run the program:

```bash
./FotZIP
```

2. In the menu, select **3. Exit** to quit the program.

---

## Known Issues

* ZIP64 archives may trigger warnings in edge cases.
* GUI version not yet implemented; CLI only.
* Platform-specific issues may occur.

---

## Future Plans

* GUI interface for all platforms.
* Improved ZIP64 support and advanced compression options.
* Automated builds for Windows, Linux, and macOS.

---

## License

FotZIP is released under **GNU GPL v3**. See `LICENSE` file for details.
