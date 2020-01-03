﻿

namespace Netio_Sample.XML
{   

       
        public class Output
        {


        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.netio-products.com/XMLSchema/NETIO.xsd")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.netio-products.com/XMLSchema/NETIO.xsd", IsNullable = false)]
        public partial class Root
        {

            private Agent agentField;

            private OutputsOutput[] outputsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public Agent Agent
            {
                get
                {
                    return this.agentField;
                }
                set
                {
                    this.agentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Output", IsNullable = false)]
            public OutputsOutput[] Outputs
            {
                get
                {
                    return this.outputsField;
                }
                set
                {
                    this.outputsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Agent
        {

            private string modelField;

            private string versionField;

            private decimal xmlVerField;

            private string deviceNameField;

            private byte vendorIDField;

            private byte oemIDField;

            private string serialNumberField;

            private uint uptimeField;

            private System.DateTime timeField;

            private byte numOutputsField;

            /// <remarks/>
            public string Model
            {
                get
                {
                    return this.modelField;
                }
                set
                {
                    this.modelField = value;
                }
            }

            /// <remarks/>
            public string Version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            public decimal XmlVer
            {
                get
                {
                    return this.xmlVerField;
                }
                set
                {
                    this.xmlVerField = value;
                }
            }

            /// <remarks/>
            public string DeviceName
            {
                get
                {
                    return this.deviceNameField;
                }
                set
                {
                    this.deviceNameField = value;
                }
            }

            /// <remarks/>
            public byte VendorID
            {
                get
                {
                    return this.vendorIDField;
                }
                set
                {
                    this.vendorIDField = value;
                }
            }

            /// <remarks/>
            public byte OemID
            {
                get
                {
                    return this.oemIDField;
                }
                set
                {
                    this.oemIDField = value;
                }
            }

            /// <remarks/>
            public string SerialNumber
            {
                get
                {
                    return this.serialNumberField;
                }
                set
                {
                    this.serialNumberField = value;
                }
            }

            /// <remarks/>
            public uint Uptime
            {
                get
                {
                    return this.uptimeField;
                }
                set
                {
                    this.uptimeField = value;
                }
            }

            /// <remarks/>
            public System.DateTime Time
            {
                get
                {
                    return this.timeField;
                }
                set
                {
                    this.timeField = value;
                }
            }

            /// <remarks/>
            public byte NumOutputs
            {
                get
                {
                    return this.numOutputsField;
                }
                set
                {
                    this.numOutputsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class OutputsOutput
        {

            private byte idField;

            private string nameField;

            private byte stateField;

            private byte actionField;

            private ushort delayField;

            /// <remarks/>
            public byte ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public byte State
            {
                get
                {
                    return this.stateField;
                }
                set
                {
                    this.stateField = value;
                }
            }

            /// <remarks/>
            public byte Action
            {
                get
                {
                    return this.actionField;
                }
                set
                {
                    this.actionField = value;
                }
            }

            /// <remarks/>
            public ushort Delay
            {
                get
                {
                    return this.delayField;
                }
                set
                {
                    this.delayField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Outputs
        {

            private OutputsOutput[] outputField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Output")]
            public OutputsOutput[] Output
            {
                get
                {
                    return this.outputField;
                }
                set
                {
                    this.outputField = value;
                }
            }
        }


    }
}