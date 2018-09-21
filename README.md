# CryptoCausationTrackerCLI
### Live data analysis of cryptocurrency markets 

 - [Download .exe](https://github.com/adamdon/CryptoCausationTrackerCLI/releases/download/1.0/CryptoCausationTrackerCLI.exe)
 
![Screenshot of UI](https://adamdon.github.io/img/CryptoCausationTrackerCLI_screenshot01.png)

Rewrote in C# from a command line tool that I developed as part of a Hackathon challenge to utilise the real-time data streams using the Satori SDK. I chose to make a tool that could be used to calculate the interexchange rate for the Ethereum Cryptocurrency. The Application takes in around 1800 trades per minute from the top volume Crypto exchanges with ETH/USD pairing. The JSON messages are deserializatilised with Newtonsoft.Json.Linq then stored in an List of Message Objects to to give out real time statistics.

```markdown
public void handleBtnAppointmentRegister()
public static Message ReadToObject(string json)
{
  Message deserializedMessage = new Message();
  MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
  DataContractJsonSerializer ser = new DataContractJsonSerializer(deserializedMessage.GetType());
  deserializedMessage = ser.ReadObject(ms) as Message;
  ms.Close();
  return deserializedMessage;
}
```
 - [View Full Source (github)](https://github.com/adamdon/CryptoCausationTrackerCLI/tree/master/CryptoCausationTrackerCLI)
