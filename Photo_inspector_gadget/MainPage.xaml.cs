using Microsoft.Devices;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Info;
using Microsoft.Phone.Tasks;
using System;
using System.Linq;
using System.Windows;
using Windows.Phone.Media.Capture;




namespace Photo_inspector_gadget
{
    public partial class MainPage : PhoneApplicationPage
    {
        private const CameraSensorLocation SENSOR_LOCATION = CameraSensorLocation.Back;
        private PhotoChooserTask _photoChooserTask = new PhotoChooserTask();
        private PhotoResult _photoResult = null;
        private PhotoCaptureDevice _device = null;
        private bool _focusing = false;
        private bool _capturing = false;
        private bool _capture = false;
        private PhotoChooserTask photoChooserTask;
        // Constructeur
        public MainPage()
        {
            InitializeComponent();
            InitializeCamera();

            photoChooserTask = new PhotoChooserTask();
            photoChooserTask.Completed += new EventHandler<PhotoResult>(photoChooserTask_Completed);
            // Exemple de code pour la localisation d'ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void InitializeCamera()
        {
            Windows.Foundation.Size captureResolution;

            var deviceName = DeviceStatus.DeviceName;

            if (deviceName.Contains("RM-875") || deviceName.Contains("RM-876") || deviceName.Contains("RM-877"))
            {
                captureResolution = new Windows.Foundation.Size(7712, 4352); // 16:9
                //captureResolution = new Windows.Foundation.Size(7136, 5360); // 4:3
            }
            else if (deviceName.Contains("RM-937") || deviceName.Contains("RM-938") || deviceName.Contains("RM-939"))
            {
                captureResolution = new Windows.Foundation.Size(5376, 3024); // 16:9
                //captureResolution = new Windows.Foundation.Size(4992, 3744); // 4:3
            }
            else
            {
                captureResolution = PhotoCaptureDevice.GetAvailableCaptureResolutions(SENSOR_LOCATION).First();
            }

            var task = PhotoCaptureDevice.OpenAsync(SENSOR_LOCATION, captureResolution).AsTask();

            task.Wait();

            _device = task.Result;
            _device.SetProperty(KnownCameraGeneralProperties.PlayShutterSoundOnCapture, true);

            //if (_flashButton != null)
            //{
            //    SetFlashState(_flashState);
            //}

            //AdaptToOrientation();

            ViewfinderVideoBrush.SetSource(_device);

            if (PhotoCaptureDevice.IsFocusSupported(SENSOR_LOCATION))
            {
                Microsoft.Devices.CameraButtons.ShutterKeyHalfPressed += CameraButtons_ShutterKeyHalfPressed;
            }

            Microsoft.Devices.CameraButtons.ShutterKeyPressed += CameraButtons_ShutterKeyPressed;
        }

        private async void CameraButtons_ShutterKeyHalfPressed(object sender, EventArgs e)
        {
            if (!_focusing && !_capturing)
            {
                _focusing = true;

                _device.FocusRegion = null;

                await _device.FocusAsync();

                _focusing = false;

                if (_capture)
                {
                    _capture = false;

                    //await CaptureAsync();
                }
            }
        }

        private async void CameraButtons_ShutterKeyPressed(object sender, EventArgs e)
        {
            if (_focusing)
            {
                _capture = true;
            }
            else
            {
                //await CaptureAsync();
            }
        }

        private bool _isSettingsOpen = false;

        private void ApplicationBarIconButton_OnClick(object sender, EventArgs e)
        {

            if (_isSettingsOpen)
            {

                VisualStateManager.GoToState(this, "SettingsClosedState", true);

                _isSettingsOpen = false;

            }
            else
            {
               VisualStateManager.GoToState(this, "SettingsOpenState", true);
            _isSettingsOpen = true;
            }
        }

        void photoChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                MessageBox.Show(e.ChosenPhoto.Length.ToString());

                //Code to display the photo on the page in an image control named myImage.
                //System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                //bmp.SetSource(e.ChosenPhoto);
                //myImage.Source = bmp;
            }
        }

        private void Importer_Click(object sender, EventArgs e)
        {
            photoChooserTask.Show();
        }

        private void Canvas_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

       

        // Exemple de code pour la conception d'une ApplicationBar localisée
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Définit l'ApplicationBar de la page sur une nouvelle instance d'ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crée un bouton et définit la valeur du texte sur la chaîne localisée issue d'AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crée un nouvel élément de menu avec la chaîne localisée d'AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}