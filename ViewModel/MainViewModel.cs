using GalaSoft.MvvmLight.Command;
using Launcher.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Launcher.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        private Page Wow = new WoWPAge();
        private Page HS = new HsPage();
        private Page OW = new OwerwatchPage();
        private Page W3 = new W3();
        private Page D3 = new D3();
        private Page HOTS = new HOTS();
        private Page SC2 = new SC2();
        private Page SC = new SC();
        private Page _CurPage = new WoWPAge();

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }

        public ICommand OpenHsPage
        {
            get
            {
                return new RelayCommand(() => CurPage = HS);
            }
        }
        public ICommand OpenOWPage
        {
            get
            {
                return new RelayCommand(() => CurPage = OW);
            }
        }
        public ICommand OpenW3Page
        {
            get
            {
                return new RelayCommand(() => CurPage = W3);
            }
        }
        public ICommand OpenD3Page
        {
            get
            {
                return new RelayCommand(() => CurPage = D3);
            }
        }
        public ICommand OpenHOTSPage
        {
            get
            {
                return new RelayCommand(() => CurPage = HOTS);
            }
        }
        public ICommand OpenSC2Page
        {
            get
            {
                return new RelayCommand(() => CurPage = SC2);
            }
        }
        public ICommand OpenSCPage
        {
            get
            {
                return new RelayCommand(() => CurPage = SC);
            }
        }
        public ICommand OpenWowPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Wow);
            }
        }
        
    }
}
