using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;

//TODO: Add a reference to the IBM.Broker.Plugin.dll assembly which is in the "<MessageBrokerInstallPath>\bin" folder
using IBM.Broker.Plugin;

namespace TestDotNet
{
    /// <summary>
    /// ModifyNode Class
    /// </summary>
    public class ModifyNode : NBComputeNode
    {
        /// <summary>
        /// Evaluate Method
        /// </summary>
        /// <param name="inputAssembly"></param>
        public override void Evaluate(NBMessageAssembly inputAssembly)
        {
            NBOutputTerminal outTerminal = OutputTerminal("Out");

            NBMessage inputMessage = inputAssembly.Message;

            // Create a new message from a copy of the inboundMessage, ensuring it is disposed of after use
            using (NBMessage outputMessage = new NBMessage(inputMessage))
            {
                NBMessageAssembly outAssembly = new NBMessageAssembly(inputAssembly, outputMessage);
                NBElement inputRoot = inputMessage.RootElement;
                NBElement outputRoot = outputMessage.RootElement;

                #region UserCode
                // Add user code in this region to modify the message
                new SpeechSynthesizer().SpeakAsync((String)inputRoot["XMLNSC"]["Message"]);
                // new SpeechSynthesizer().SpeakAsync("Hi Steve");
                outTerminal.Propagate(inputAssembly);
                #endregion UserCode

                // Change the following if not propagating message to the 'Out' terminal
                outTerminal.Propagate(outAssembly);
            }
        }
    }
}