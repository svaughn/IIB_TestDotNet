The YouTube was about:
* WebSphere Message Broker V8 
* Microsoft Visual Studio 2010

I am working with IIB V10

I tried Microsoft Visual Studio 2012 (en_visual_studio_professional_2012_x86_web_installer_2599144).
This is X86 code and doesn't work with IIB V10 on Windows which is x64
Got this error:
```
Warning	1	There was a mismatch between the processor architecture of the project being built "MSIL" and the processor architecture of the reference "IBM.Broker.Plugin, Version=10.0.0.20, Culture=neutral, PublicKeyToken=4acefd357533c9ec, processorArchitecture=AMD64", "AMD64". This mismatch may cause runtime failures. Please consider changing the targeted processor architecture of your project through the Configuration Manager so as to align the processor architectures between your project and references, or take a dependency on references with a processor architecture that matches the targeted processor architecture of your project.	TestDotNet
```

I tried Microsoft Visual Studio 2019 
when I ran IBM Broker DotNet.VSIX (see https://www.ibm.com/support/knowledgecenter/SSMKHH_10.0.0/com.ibm.etools.mft.doc/bc34203_.html),
I received the following error:
```
Install Failed
The install for  'IBM Integration Templates' was not successful for all the selected products
...
```
This error did give a link to the error log which showed which  versions of Visual Studio were supported

I chose Microsoft Visual Studio Professional 2015 (en_visual_studio_professional_2015_with_update_3_x86_x64_web_installer_8922978)

After that decision, everything went very smoothly.
