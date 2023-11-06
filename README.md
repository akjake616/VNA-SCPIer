# VNA SCPIer



## Getting started

This is a simple GUI tool designed to build connection and send SCPI commands to VNA (Vector Network Analyzer) cards within a PXIe chassis, but the usage may not be retricted to this scenario. The connection utilizes the following usage of the IVI drivers:
- **Ivi.Visa.dll**: automatically check and get the VISA address of the installed VNA card. 
- **Ivi.Visa.Interop.dll**: build IO connections to send SCPI commands to VNA.

The tool is written in C# with .NET Framework 4.6.2. A Keysight controller (model: M9038A) with a 4-port VNA card (model: M9804A) is tested. VNA SCPIer is used for testing and debugging VNA SCPI commands, and it is a side project of my current development of a rapid RFIC testing system. Please feel free to use it.   

## Usage

When the application is launched, the VISA address[^1] should be recognized. If not, one can type it manually in the VNA address textbox. Once the connection is done, one can write SCPI commands in the SCPI command textbox and click the write or write/read button (depending on whether a return is needed) to send it to the VNA. The returned string and execution time are dispalyed in the output textbox.

![image info](/images/img.PNG)

## License

Released under MIT License.

Copyright (c) 2023 Jake W. Liu.


<hr/>

[^1]: Shown in HisLIP form. One can change the default output string format by editting the **tbVisaAddress.Text** propoerty in *Form1.cs*

