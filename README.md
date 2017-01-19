# PublicIPParser

This is a small console program I wrote that reaches out to `whatsmyip.org` and parses out the public v4 ip address and writes it to file.

My ISP does not allow normal customers to have static IP's, I was getting tired of maintaining DDNS accounts. So I worte this program
to keep me updated on what my public IP is. Allowing me to access my home network anytime, anywhere.

##Usage
You must open the source code and edit the `path` and `filename` variables located in `program.cs`to fit your needs.
Compile the program and double click the exe that is generated. 
You should now see your public ip in the file at the path you picked.

##3rd Party Libraries
This project uses [Fizzler](https://fizzlerex.codeplex.com/) to handle all the HTML and parsing.
