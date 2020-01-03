using Netio_Sample.XML;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Netio_Sample
{
   

    public enum enAcceso
    {
        On = 0,
        Off = 1
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowXML : Window, INotifyPropertyChanged
    {
        public MainWindowXML()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        #region variabili

        string _UrlNetioXML1 = "http://netio1:81/netio.xml";

        string _UrlNetioXML2 = "http://netio2:82/netio.xml";      

        string _UsernameNetio1 = "UserNetio1";

        string _PasswordNetio1 = "227";

        string _UsernameNetio2 = "UserNetio2";

        string _PasswordNetio2 = "230d4";

        Netio _Netio1;

        Netio _Netio2;

        #endregion

        #region Property Color Output1

        /// <summary>
        /// Color_1_1
        /// </summary>
        public const string FLD_Color_1_1 = "Color_1_1";

        /// <summary>
        /// Color_1_1
        /// </summary>
        private SolidColorBrush mColor_1_1;

        /// <summary>
        /// Color_1_1
        /// </summary>
        public SolidColorBrush Color_1_1
        {
            get
            {
                return mColor_1_1;

            }
            set
            {
                mColor_1_1 = value;
                OnPropertyChanged(FLD_Color_1_1);
            }
        }

        /// <summary>
        /// Color_1_2
        /// </summary>
        public const string FLD_Color_1_2 = "Color_1_2";

        /// <summary>
        /// Color_1_2
        /// </summary>
        private SolidColorBrush mColor_1_2;

        /// <summary>
        /// Color_1_2
        /// </summary>
        public SolidColorBrush Color_1_2
        {
            get
            {
                return mColor_1_2;

            }
            set
            {
                mColor_1_2 = value;
                OnPropertyChanged(FLD_Color_1_2);
            }
        }

        /// <summary>
        /// Color_1_3
        /// </summary>
        public const string FLD_Color_1_3 = "Color_1_3";

        /// <summary>
        /// Color_1_3
        /// </summary>
        private SolidColorBrush mColor_1_3;

        /// <summary>
        /// Color_1_3
        /// </summary>
        public SolidColorBrush Color_1_3
        {
            get
            {
                return mColor_1_3;

            }
            set
            {
                mColor_1_3 = value;
                OnPropertyChanged(FLD_Color_1_3);
            }
        }

        /// <summary>
        /// Color_1_4
        /// </summary>
        public const string FLD_Color_1_4 = "Color_1_4";

        /// <summary>
        /// Color_1_4
        /// </summary>
        private SolidColorBrush mColor_1_4;

        /// <summary>
        /// Color_1_4
        /// </summary>
        public SolidColorBrush Color_1_4
        {
            get
            {
                return mColor_1_4;

            }
            set
            {
                mColor_1_4 = value;
                OnPropertyChanged(FLD_Color_1_4);
            }
        }


        #endregion

        #region Property Color Output2

        /// <summary>
        /// Color_2_1
        /// </summary>
        public const string FLD_Color_2_1 = "Color_2_1";

        /// <summary>
        /// Color_2_1
        /// </summary>
        private SolidColorBrush mColor_2_1;

        /// <summary>
        /// Color_2_1
        /// </summary>
        public SolidColorBrush Color_2_1
        {
            get
            {
                return mColor_2_1;

            }
            set
            {
                mColor_2_1 = value;
                OnPropertyChanged(FLD_Color_2_1);
            }
        }

        /// <summary>
        /// Color_2_2
        /// </summary>
        public const string FLD_Color_2_2 = "Color_2_2";

        /// <summary>
        /// Color_2_2
        /// </summary>
        private SolidColorBrush mColor_2_2;

        /// <summary>
        /// Color_2_2
        /// </summary>
        public SolidColorBrush Color_2_2
        {
            get
            {
                return mColor_2_2;

            }
            set
            {
                mColor_2_2 = value;
                OnPropertyChanged(FLD_Color_2_2);
            }
        }

        /// <summary>
        /// Color_2_3
        /// </summary>
        public const string FLD_Color_2_3 = "Color_2_3";

        /// <summary>
        /// Color_2_3
        /// </summary>
        private SolidColorBrush mColor_2_3;

        /// <summary>
        /// Color_2_3
        /// </summary>
        public SolidColorBrush Color_2_3
        {
            get
            {
                return mColor_2_3;

            }
            set
            {
                mColor_2_3 = value;
                OnPropertyChanged(FLD_Color_2_3);
            }
        }

        /// <summary>
        /// Color_2_4
        /// </summary>
        public const string FLD_Color_2_4 = "Color_2_4";

        /// <summary>
        /// Color_2_4
        /// </summary>
        private SolidColorBrush mColor_2_4;

        /// <summary>
        /// Color_2_4
        /// </summary>
        public SolidColorBrush Color_2_4
        {
            get
            {
                return mColor_2_4;

            }
            set
            {
                mColor_2_4 = value;
                OnPropertyChanged(FLD_Color_2_4);
            }
        }

        #endregion

        #region Property


        /// <summary>
        /// OutPut1_1 On Off
        /// </summary>
        public const string FLD_OutPut1_1 = "OutPut1_1";

        /// <summary>
        /// OutPut1_1 On Off
        /// </summary>
        private enAcceso mOutPut1_1;

        /// <summary>
        /// OutPut1_1 On Off
        /// </summary>
        public enAcceso OutPut1_1
        {
            get
            {
                return mOutPut1_1;
            }
            set
            {
                mOutPut1_1 = value;
                if (OutPut1_1 == enAcceso.Off)
                {
                    Color_1_1 = Brushes.Red;
                }
                else
                {
                    Color_1_1 = Brushes.Green;
                }
                OnPropertyChanged(FLD_OutPut1_1);
                OnPropertyChanged(FLD_Color_1_1);
            }
        }

        /// <summary>
        /// OutPut1_2 On Off
        /// </summary>
        public const string FLD_OutPut1_2 = "OutPut1_2";

        /// <summary>
        /// OutPut1_2 On Off
        /// </summary>
        private enAcceso mOutPut1_2;

        /// <summary>
        /// OutPut1_2 On Off
        /// </summary>
        public enAcceso OutPut1_2
        {
            get
            {
                return mOutPut1_2;
            }
            set
            {
                mOutPut1_2 = value;
                if (OutPut1_2 == enAcceso.Off)
                {
                    Color_1_2 = Brushes.Red;
                }
                else
                {
                    Color_1_2 = Brushes.Green;
                }
                OnPropertyChanged(FLD_OutPut1_2);
                OnPropertyChanged(FLD_Color_1_2);
            }
        }


        /// <summary>
        /// OutPut1_3
        /// </summary>
        public const string FLD_OutPut1_3 = "OutPut1_3";

        /// <summary>
        /// OutPut1_3
        /// </summary>
        private enAcceso mOutPut1_3;

        /// <summary>
        /// OutPut1_3
        /// </summary>
        public enAcceso OutPut1_3
        {
            get
            {
                return mOutPut1_3;
            }
            set
            {
                mOutPut1_3 = value;
                if (OutPut1_3 == enAcceso.Off)
                {
                    Color_1_3 = Brushes.Red;
                }
                else
                {
                    Color_1_3 = Brushes.Green;
                }
                OnPropertyChanged(FLD_OutPut1_3);
                OnPropertyChanged(FLD_Color_1_3);
            }
        }

        /// <summary>
        /// OutPut1_4
        /// </summary>
        public const string FLD_OutPut1_4 = "OutPut1_4";

        /// <summary>
        /// OutPut1_4
        /// </summary>
        private enAcceso mOutPut1_4;

        /// <summary>
        /// OutPut1_4
        /// </summary>
        public enAcceso OutPut1_4
        {
            get
            {
                return mOutPut1_4;
            }
            set
            {
                mOutPut1_4 = value;
                if (OutPut1_4 == enAcceso.Off)
                {
                    Color_1_4 = Brushes.Red;
                }
                else
                {
                    Color_1_4 = Brushes.Green;
                }
                OnPropertyChanged(FLD_OutPut1_4);
                OnPropertyChanged(FLD_Color_1_4);
            }
        }

        /// <summary>
        /// OutPut2_1
        /// </summary>
        public const string FLD_OutPut2_1 = "OutPut2_1";

        /// <summary>
        /// OutPut2_1
        /// </summary>
        private enAcceso mOutPut2_1;

        /// <summary>
        /// OutPut2_1
        /// </summary>
        public enAcceso OutPut2_1
        {
            get
            {
                return mOutPut2_1;
            }
            set
            {
                mOutPut2_1 = value;
                if (OutPut2_1 == enAcceso.Off)
                {
                    Color_2_1 = Brushes.Red;
                }
                else
                {
                    Color_2_1 = Brushes.Green;
                }
                OnPropertyChanged(FLD_OutPut2_1);
                OnPropertyChanged(FLD_Color_2_1);
            }
        }

        /// <summary>
        /// OutPut2_2
        /// </summary>
        public const string FLD_OutPut2_2 = "OutPut2_2";

        /// <summary>
        /// OutPut2_2
        /// </summary>
        private enAcceso mOutPut2_2;

        /// <summary>
        /// OutPut2_2
        /// </summary>
        public enAcceso OutPut2_2
        {
            get
            {
                return mOutPut2_2;
            }
            set
            {
                mOutPut2_2 = value;
                if (OutPut2_2 == enAcceso.Off)
                {
                    Color_2_2 = Brushes.Red;
                }
                else
                {
                    Color_2_2 = Brushes.Green;
                }
                OnPropertyChanged(FLD_Color_2_2);
                OnPropertyChanged(FLD_OutPut2_2);
            }
        }

        /// <summary>
        /// OutPut2_3
        /// </summary>
        public const string FLD_OutPut2_3 = "OutPut2_3";

        /// <summary>
        /// OutPut2_3
        /// </summary>
        private enAcceso mOutPut2_3;

        /// <summary>
        /// OutPut2_3
        /// </summary>
        public enAcceso OutPut2_3
        {
            get
            {
                return mOutPut2_3;
            }
            set
            {
                mOutPut2_3 = value;
                if (OutPut2_3 == enAcceso.Off)
                {
                    Color_2_3 = Brushes.Red;
                }
                else
                {
                    Color_2_3 = Brushes.Green;
                }
                OnPropertyChanged(FLD_Color_2_3);
                OnPropertyChanged(FLD_OutPut2_3);
            }
        }

        /// <summary>
        /// OutPut2_1
        /// </summary>
        public const string FLD_OutPut2_4 = "OutPut2_4";

        /// <summary>
        /// OutPut2_1
        /// </summary>
        private enAcceso mOutPut2_4;

        /// <summary>
        /// OutPut2_1
        /// </summary>
        public enAcceso OutPut2_4
        {
            get
            {
                return mOutPut2_4;
            }
            set
            {
                mOutPut2_4 = value;
                if (OutPut2_4 == enAcceso.Off)
                {
                    Color_2_4 = Brushes.Red;
                }
                else
                {
                    Color_2_4 = Brushes.Green;
                }
                OnPropertyChanged(FLD_Color_2_4);
                OnPropertyChanged(FLD_OutPut2_4);
            }
        }

        #endregion
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetControlli();           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string xmlData;

            switch (((Button)sender).Name)
            {
                case "btnNetio1_1":
                    if(OutPut1_1 == enAcceso.On)
                    {
                        xmlData = Properties.Resources.OutPut_1_OFF;
                    }
                    else
                    {
                        xmlData = Properties.Resources.OutPut_1_ON;
                    }
                    postXMLData(_UrlNetioXML1, xmlData, _UsernameNetio1, _PasswordNetio1);
                    break;
                case "btnNetio1_2":
                    if (OutPut1_2 == enAcceso.On)
                    {
                        xmlData = Properties.Resources.OutPut_2_OFF;
                    }
                    else
                    {
                        xmlData = Properties.Resources.OutPut_2_ON;
                    }
                    postXMLData(_UrlNetioXML1, xmlData, _UsernameNetio1, _PasswordNetio1);
                    break;
                case "btnNetio1_3":
                    if (OutPut1_3 == enAcceso.On)
                    {
                        xmlData = Properties.Resources.OutPut_3_OFF;
                    }
                    else
                    {
                        xmlData = Properties.Resources.OutPut_3_ON;
                    }
                    postXMLData(_UrlNetioXML1, xmlData, _UsernameNetio1, _PasswordNetio1);
                    break;
                case "btnNetio1_4":
                    if (OutPut1_4 == enAcceso.On)
                    {
                        xmlData = Properties.Resources.OutPut_4_OFF;
                    }
                    else
                    {
                        xmlData = Properties.Resources.OutPut_4_ON;
                    }
                    postXMLData(_UrlNetioXML1, xmlData, _UsernameNetio1, _PasswordNetio1);
                    break;
                case "btnNetio2_1":
                    if (OutPut2_1 == enAcceso.On)
                    {
                        xmlData = Properties.Resources.OutPut_1_OFF;
                    }
                    else
                    {
                        xmlData = Properties.Resources.OutPut_1_ON;
                    }
                    postXMLData(_UrlNetioXML2, xmlData, _UsernameNetio2, _PasswordNetio2);
                    break;
                case "btnNetio2_2":
                    if (OutPut2_2 == enAcceso.On)
                    {
                        xmlData = Properties.Resources.OutPut_2_OFF;
                    }
                    else
                    {
                        xmlData = Properties.Resources.OutPut_2_ON;
                    }
                    postXMLData(_UrlNetioXML2, xmlData, _UsernameNetio2, _PasswordNetio2);
                    break;
                case "btnNetio2_3":
                    if (OutPut2_1 == enAcceso.On)
                    {
                        xmlData = Properties.Resources.OutPut_3_OFF;
                    }
                    else
                    {
                        xmlData = Properties.Resources.OutPut_3_ON;
                    }
                    postXMLData(_UrlNetioXML2, xmlData, _UsernameNetio2, _PasswordNetio2);
                    break;
                case "btnNetio2_4":
                    if (OutPut2_1 == enAcceso.On)
                    {
                        xmlData = Properties.Resources.OutPut_4_OFF;
                    }
                    else
                    {
                        xmlData = Properties.Resources.OutPut_4_ON;
                    }
                    postXMLData(_UrlNetioXML2, xmlData, _UsernameNetio2, _PasswordNetio2);
                    break;
                default:
                    MessageBox.Show(string.Format("funzione non implementata: {0}", ((Button)sender).Content));
                    break;
            }
            SetControlli();
        }       

        public string postXMLData(string pDestinationUrl, string pRequestXml, string pUserName, string pPassword)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(pDestinationUrl);
            request.Credentials = new NetworkCredential(pUserName, pPassword);
            byte[] bytes;
            bytes = System.Text.Encoding.ASCII.GetBytes(pRequestXml);
            request.ContentType = "text/xml; encoding='utf-8'";
            request.ContentLength = bytes.Length;
            request.Method = "POST";
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            HttpWebResponse response;
            response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();
                string responseStr = new StreamReader(responseStream).ReadToEnd();
                return responseStr;
            }
            return null;
        }          

        private void SetControlli()
        {
            // Netio 1

            WebRequest request1 = WebRequest.Create(_UrlNetioXML1);
            request1.Credentials = new NetworkCredential(_UsernameNetio1, _PasswordNetio1);
            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
            Stream iDataStream1 = response1.GetResponseStream();
            StreamReader reader1 = new StreamReader(iDataStream1);
            string myXml1 = reader1.ReadToEnd();
            reader1.Close();
            iDataStream1.Close();
            response1.Close();
            _Netio1 = Netio.ReadXml(myXml1);

            lblNameNetio1.Content = _Netio1.Agent.DeviceName + " ( " + _Netio1.Agent.Model + " )";
            btnNetio1_1.Content = _Netio1.Outputs[0].Name;
            if (_Netio1.Outputs[0].State== 0 )
            {
                OutPut1_1 = enAcceso.Off;
            }
            else
            {
                OutPut1_1 = enAcceso.On;
            }

            btnNetio1_2.Content = _Netio1.Outputs[1].Name;
            if (_Netio1.Outputs[1].State == 0)
            {
                OutPut1_2 = enAcceso.Off;
            }
            else
            {
                OutPut1_2 = enAcceso.On;
            }

            btnNetio1_3.Content = _Netio1.Outputs[2].Name;
            if (_Netio1.Outputs[2].State == 0)
            {
                OutPut1_3 = enAcceso.Off;
            }
            else
            {
                OutPut1_3 = enAcceso.On;
            }

            btnNetio1_4.Content = _Netio1.Outputs[3].Name;
            if (_Netio1.Outputs[3].State == 0)
            {
                OutPut1_4 = enAcceso.Off;
            }
            else
            {
                OutPut1_4 = enAcceso.On;
            }

            // Netio 2

            WebRequest request2 = WebRequest.Create(_UrlNetioXML2);
            request2.Credentials = new NetworkCredential(_UsernameNetio2, _PasswordNetio2);
            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();
            Stream iDataStream2 = response2.GetResponseStream();
            StreamReader reader2 = new StreamReader(iDataStream2);
            string myXml2 = reader2.ReadToEnd();
            reader2.Close();
            iDataStream2.Close();
            response2.Close();
            _Netio2 = Netio.ReadXml(myXml2);

            lblNameNetio2.Content = _Netio2.Agent.DeviceName + " ( " + _Netio2.Agent.Model + " )";
            btnNetio2_1.Content = _Netio2.Outputs[0].Name;
            if (_Netio2.Outputs[0].State == 0)
            {
                OutPut2_1 = enAcceso.Off;
            }
            else
            {
                OutPut2_1 = enAcceso.On;
            }

            btnNetio2_2.Content = _Netio2.Outputs[1].Name;
            if (_Netio2.Outputs[1].State == 0)
            {
                OutPut2_2 = enAcceso.Off;
            }
            else
            {
                OutPut2_2 = enAcceso.On;
            }

            btnNetio2_3.Content = _Netio2.Outputs[2].Name;
            if (_Netio2.Outputs[2].State == 0)
            {
                OutPut2_3 = enAcceso.Off;
            }
            else
            {
                OutPut2_3 = enAcceso.On;
            }

            btnNetio2_4.Content = _Netio2.Outputs[3].Name;
            if (_Netio2.Outputs[3].State == 0)
            {
                OutPut2_4 = enAcceso.Off;
            }
            else
            {
                OutPut2_4 = enAcceso.On;
            }           
        }

        /// <summary>
        /// Evento generato alla modifica di una property.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        ///<summary>
        /// Evento che viene generato alla modifica di una property
        ///</summary>
        /// <param name="pPropertyName">nome della property</param>
        protected virtual void OnPropertyChanged(string pPropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(pPropertyName));
        }
    }
}