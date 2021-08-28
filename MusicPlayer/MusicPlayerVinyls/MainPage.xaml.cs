using MusicPlayerVinyls.Controls;
using MusicPlayerVinyls.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MusicPlayerVinyls
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AlbumDetailsView_UserInteracted(PanCardView.CardsView view, PanCardView.EventArgs.UserInteractedEventArgs args)
        {
            switch (args.Status)
            {
                case PanCardView.Enums.UserInteractionStatus.Started:
                    break;
                case PanCardView.Enums.UserInteractionStatus.Running:
                    // make the top view expand or collapse
                    var albumView = ArtCarousel.CurrentView as AlbumArtView;
                    albumView.PanAmount = args.Diff;
                    break;
                case PanCardView.Enums.UserInteractionStatus.Ending:
                    break;
                case PanCardView.Enums.UserInteractionStatus.Ended:
                    break;
            }
        }

       
    }
}