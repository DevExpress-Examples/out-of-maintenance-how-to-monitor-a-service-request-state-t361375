using DevExpress.XtraMap;
using System;
using System.Windows.Forms;


namespace RequestDataLoadingExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            ImageLayer layer = new ImageLayer();
            mapControl1.Layers.Add(layer);
            BingMapDataProvider provider = new BingMapDataProvider();
            provider.BingKey = "YOUR_BING_KEY";
            layer.DataProvider = provider;
            layer.RequestDataLoading += OnRequestDataLoading;
            layer.DataLoaded += OnDataLoaded;
        }
        void OnRequestDataLoading(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            if (!splashScreenManager1.IsSplashFormVisible)
                splashScreenManager1.ShowWaitForm();
        }
        void OnDataLoaded(object sender, DataLoadedEventArgs e) {
            Cursor.Current = Cursors.Default;
            splashScreenManager1.CloseWaitForm();
        }

    }
}
