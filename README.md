# 🕋 Terminal Qur'an — `termoquran`

> 📥 **[Support my work](https://paypal.me/jetbl7ck)** – If you benefit from this tool, consider donating to help keep it alive and improving.

A minimalistic command-line Qur’an reader for Linux systems.  
Built with **.NET 9** and designed for **speed**, **privacy**, and **offline use**.  
Perfect for developers, sysadmins, and CLI warriors who want instant access to the Qur’an  
without opening a browser or app.

---

## 📦 Git Clone the Repository

```bash
git clone https://github.com/xMartyr/Terminal-Quran.git
```
```bash
cd Terminal-Quran
```

---

## ⚙️ Install .NET 9 on Linux

> Required to build and run `termoquran`.

### 🧪 Step-by-step:

```bash
sudo apt update -y && sudo apt upgrade -y
sudo apt install -y wget apt-transport-https software-properties-common

# Add Microsoft package signing key
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb

# Install the .NET 9 SDK
sudo apt update -y
sudo apt install -y dotnet-sdk-9.0
```

---

## 🛠️ Build the Project

```bash
dotnet build -c Release
```

This will generate the output in:

```bash
./bin/Release/net9.0/
```

You can now run it manually:

```bash
./bin/Release/net9.0/termoquran
```

---

## 🌍 Optional: Install Globally on Linux

To make `termoquran` available system-wide:

```bash
sudo cp ./bin/Release/net9.0/termoquran /usr/local/bin/termoquran
```

Now just run it from anywhere:

```bash
termoquran
```

---

## ✅ Uninstall (if needed)

```bash
sudo rm /usr/local/bin/termoquran
```

---

## ☕ Contribute

Pull requests are welcome. For major changes, please open an issue first.

---

## 🙏 Bismillah

May this tool be beneficial. Feel free to fork, contribute, and share.
---

### ❤️ Enjoying Terminal Qur'an?

> 🕋 Support future Islamic open-source projects:
> 👉 [paypal.me/jetbl7ck](https://paypal.me/jetbl7ck)
