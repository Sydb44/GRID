1.  **Static IP:** If you intend to run a game that people from all over the Internet can connect to, you will need a static public IP address. Your internet service provider should tell you whether you have one or not. Without the static IP address, you will be able to host a dedicated server on your LAN, but people from outside the LAN won’t be able to connect to it.
2.  **Port forwarding:** The game uses UDP protocol to communicate. The default listen port is 27016, but this can be changed in the config tool. In order for people to be able to reach your server, you will have to configure your router to forward all incoming UDP traffic on port 27016 (or any other that you have specified) to the computer where your dedicated server is running.
3.  **Firewall settings:** Make sure to set the firewall on your server computer to allow incoming UDP traffic on the listen port.

Note: If you don't know how to open ports go to [http://portforward.com/](http://portforward.com/)

## How to find your group ID

If you want to find your Group ID, this is a way how to do it:

1.  First you have to be a member of the group
2.  On the group's page (e.g. [http://steamcommunity.com/groups/rps](http://steamcommunity.com/groups/rps)), click "Invite Friends"
3.  On the new page that will open, you can find your Group ID (long number in bold) in the page's URL: [http://steamcommunity.com/id/pikacc/friends/?invitegid=](http://steamcommunity.com/id/pikacc/friends/?invitegid=) **103582791429554934**

## SpaceEngineers-Dedicated.cfg

This file is in the server's AppData and contains all the settings you see in the GUI and a few extra that are not in the GUI.

One such hidden configurable is `<NetworkParameters>`.  
It is only used by **EOS** networking mode, and these are the available options and their defaults:

<NetworkParameters>
  <Parameter>globalMaxUpload:600</Parameter>
  <Parameter>peerMaxUpload:600</Parameter>
  <Parameter>statWindow:60</Parameter> <!-- seconds -->
  <Parameter>peakStatWindow:60</Parameter> <!-- seconds -->
</NetworkParameters>

These can also be assigned using startup argument `-np <key:value>`, repeated for every thing you wish to set.  
For example: `SpaceEngineersDedicated.exe -console -np globalMaxUpload:1000 -np peerMaxUpload:1000`  

This was found in game code with a decompiler, for quick reference it's at `MyP2PQoSAdapter`'s constructor.

## Remote API

Remote API is RESTful web API, which you can use to get information about the server and running world. You can use VRage Remote Client to get the data or you can make your own client. These are available resources:

[![](https://spaceengineers.wiki.gg/images/thumb/8/82/VRage_remote_management_resources.png/400px-VRage_remote_management_resources.png?23aa8f)](https://spaceengineers.wiki.gg/wiki/File:VRage_remote_management_resources.png)

VRage remote management resources

You can get information about API by calling GET on api resource (for example http:\\\\localhost:8080\\vrageremote\\api )

**Custom Client**

If you want to make your own client you have to properly create a request. Remote API is using HMAC (HMACSHA1) to compute hash from specific data. HMAC is using private key. Don’t share this key with anyone.

You have to compute hash from string (lines):

*   URL - including query parameters
*   Nonce - random string, can be used only once, can be a number
*   Date - UtcNow, format r, RFC1123 pattern, must be added to header

This is converted to byte buffer from UTF8 string and then used to compute hash. Hash is converted to Base64 string and added to header to Authorization field in format “nonce:hash”.

Example of code in C# (using RestSharp library) :

private readonly string m\_remoteUrl \= "/vrageremote/{0}";

public RestRequest CreateRequest(string resourceLink, Method method, params Tuple<string, string\>\[\] queryParams)
{
    string methodUrl \= string.Format(m\_remoteUrl, resourceLink);
    RestRequest request \= new RestRequest(methodUrl, method); 
    string date \= DateTime.UtcNow.ToString("r", CultureInfo.InvariantCulture);
    request.AddHeader("Date", date); 
    m\_nonce \= random.Next(0, int.MaxValue);
    string nonce \= m\_nonce.ToString();
    StringBuilder message \= new StringBuilder();
    message.Append(methodUrl); 
    if (queryParams.Length \> 0)
    {
        message.Append("?");
    }

    for (int i \= 0; i < queryParams.Length; i++)
    {
        var param \= queryParams\[i\];
        request.AddQueryParameter(param.Item1, param.Item2);
        message.AppendFormat("{0}={1}", param.Item1, param.Item2);
        if (i != queryParams.Length \- 1)
        {
            message.Append("&");
        }
    }

    message.AppendLine();
    message.AppendLine(nonce);
    message.AppendLine(date);
    byte\[\] messageBuffer \= Encoding.UTF8.GetBytes(message.ToString());

    byte\[\] key \= Convert.FromBase64String(m\_securityKey);
    byte\[\] computedHash;
    using (HMACSHA1 hmac \= new HMACSHA1(key))
    {
        computedHash \= hmac.ComputeHash(messageBuffer);
    }

    string hash \= Convert.ToBase64String(computedHash);
    request.AddHeader("Authorization", string.Format("{0}:{1}", nonce, hash));
    return request;
}

## References

1.  [↑](#cite_ref-1 "Jump up") [https://www.spaceengineersgame.com/dedicated-servers.html](https://www.spaceengineersgame.com/dedicated-servers.html)
2.  [↑](#cite_ref-2 "Jump up") [https://www.reddit.com/r/spaceengineers/comments/907wyb/how\_to\_download\_dedicated\_server\_files/](https://www.reddit.com/r/spaceengineers/comments/907wyb/how_to_download_dedicated_server_files/)
3.  [↑](#cite_ref-3 "Jump up") [https://www.reddit.com/r/spaceengineers/comments/907wyb/how\_to\_download\_dedicated\_server\_files/e2oozbs/](https://www.reddit.com/r/spaceengineers/comments/907wyb/how_to_download_dedicated_server_files/e2oozbs/)
4.  [↑](#cite_ref-4 "Jump up") [https://www.spaceengineersgame.com/dedicated-servers.html](https://www.spaceengineersgame.com/dedicated-servers.html)